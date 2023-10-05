using BibliotecaCLases.Controlador;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmGestionarCursos : Form
    {
        private Usuario _usuario;
        private CrudEstudiante crudEstudiante;
        private Curso _cursoSeleccionado;
        private CrudCurso crudCurso;
        public FrmGestionarCursos(Usuario usuario)
        {
            crudEstudiante = new CrudEstudiante();
            _usuario = usuario;
            crudCurso = new CrudCurso();
            InitializeComponent();
            MostrarBtn(_usuario);
        }

        private void BtnAgregarCurso_Click(object sender, EventArgs e)
        {
            FrmAgregarCurso frmAgregarCurso = new FrmAgregarCurso();
            frmAgregarCurso.Show();
        }

        private void BtnEditarCursos_Click(object sender, EventArgs e)
        {
            if (_cursoSeleccionado != null)
            {
                FrmEditarCurso frmEditarCurso = new FrmEditarCurso(_cursoSeleccionado, this);
                frmEditarCurso.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un curso para editar.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnEliminarCursos_Click(object sender, EventArgs e)
        {
            if (_cursoSeleccionado != null)
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar este curso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    string resultadoEliminacion = crudCurso.EliminarCurso(_cursoSeleccionado);

                    if (resultadoEliminacion.StartsWith("Se realizó la eliminación lógica"))
                    {
                        MessageBox.Show(resultadoEliminacion, "Resultado:", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Debes actualizar la interfaz de usuario para reflejar los cambios
                        // por ejemplo, eliminar el curso de la lista o actualizar la vista.
                        //ActualizarInterfazUsuario();
                    }
                    else
                    {
                        MessageBox.Show(resultadoEliminacion, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un curso para eliminar.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGestionarCursos_Load(object sender, EventArgs e)
        {
            Dictionary<int, Curso> dictCursos = null;

            string path = PathManager.ObtenerRuta("Data", "DictCurso.json");

            try
            {
                dictCursos = Serializador.LeerJson<Dictionary<int, Curso>>(path);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"No se encontró el archivo JSON en la ruta: {path}");
            }

            if (dictCursos != null)
            {
                listBoxCursos.Items.Add("CODIGO        CURSO         DESCRIPCION        CUPO MAXIMO      CUPOS DISPONIBLES");

                foreach (KeyValuePair<int, Curso> kvp in dictCursos)
                {
                    if (kvp.Value.Activo)
                    {
                        listBoxCursos.Items.Add(kvp.Value);
                    }
                }
            }
        }

        private void listBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCursos.SelectedIndex != -1)
            {
                // Obtén el objeto Curso seleccionado en lugar de la cadena
                _cursoSeleccionado = (Curso)listBoxCursos.SelectedItem;

                // Actualiza la etiqueta de resultado para mostrar información del curso
                labelResultado.Text = "Seleccionaste: Código " + _cursoSeleccionado.Codigo + ", Curso " + _cursoSeleccionado.Nombre;
            }
        }
        private void MostrarBtn(Usuario usuario)
        {
            BtnAgregarCurso.Visible = false;
            BtnEditarCursos.Visible = false;
            BtnEliminarCursos.Visible = false;
            btnInscripcion.Visible = false;
            if (usuario.TipoUsuario.ToString() == "Estudiante")
            {
                btnInscripcion.Visible = true;
            }
            else if (usuario.TipoUsuario.ToString() == "Administrador")
            {
                BtnAgregarCurso.Visible = true;
                BtnEditarCursos.Visible = true;
                BtnEliminarCursos.Visible = true;
            }
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            if (_cursoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un curso", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int.TryParse(_usuario.Legajo.ToString(), out int legajo);
                string mensajeError;
                bool inscripcionExitosa = crudEstudiante.AgregarCursoAEstudiante(legajo, _cursoSeleccionado.Codigo, out mensajeError);

                if (inscripcionExitosa)
                {
                    MessageBox.Show($"Inscripción exitosa al curso: {_cursoSeleccionado.Nombre}");
                }
                else
                {
                    if (!string.IsNullOrEmpty(mensajeError))
                    {
                        MessageBox.Show($"Error: {mensajeError}", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error: No se encontró al estudiante.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void ActualizarListaCursos()
        {
            listBoxCursos.Items.Clear();

            /*Dictionary<int, Curso> dictCursos = null;

            string path = PathManager.ObtenerRuta("Data", "DictCurso.json");

            try
            {
                dictCursos = Serializador.LeerJson<Dictionary<int, Curso>>(path);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"No se encontró el archivo JSON en la ruta: {path}");
            }*/

            List<Curso> listaCursosActualizada = new List<Curso>();

            foreach (KeyValuePair<int, Curso> kvp in crudCurso.ObtenerDictCursos())
            {
                if (kvp.Value.Activo)
                {
                    listaCursosActualizada.Add(kvp.Value);
                    //listBoxCursos.Items.Add(kvp.Value);
                }
            }

            listBoxCursos.Items.Add("CODIGO        CURSO         DESCRIPCION        CUPO MAXIMO      CUPOS DISPONIBLES");
            listBoxCursos.Items.AddRange(listaCursosActualizada.ToArray());
        }

    }
}
