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
        private string _cursoSeleccionado;
        public FrmGestionarCursos(Usuario usuario)
        {
            crudEstudiante = new CrudEstudiante();
            _usuario = usuario;
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
            if (!string.IsNullOrEmpty(_cursoSeleccionado))
            {
                // Crear una instancia del formulario de edición y pasar el curso seleccionado
                FrmEditarCurso frmEditarCurso = new FrmEditarCurso(_cursoSeleccionado);
                frmEditarCurso.ShowDialog();

                // Actualizar la lista de cursos en ListBox después de la edición (si es necesario)
                // ...

                // También puedes mostrar un mensaje de éxito o error después de la edición
                // ...
            }
            else
            {
                MessageBox.Show("Debe seleccionar un curso para editar.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminarCursos_Click(object sender, EventArgs e)
        {

        }

        private void FrmGestionarCursos_Load(object sender, EventArgs e)
        {
            List<Curso> listaCursos = new List<Curso>();
            Dictionary<int, Curso> dictCursos;

            dictCursos = new Dictionary<int, Curso>();
            string path = PathManager.ObtenerRuta("Data", "DictCurso.json");

            dictCursos = Serializador.LeerJson<Dictionary<int, Curso>>(path);


            listBoxCursos.Items.Add("CODIGO        CURSO          DESCRIPCION                        CUPO MAXIMO   CUPOS DISPONIBLES");

            foreach (KeyValuePair<int, Curso> kvp in dictCursos)
            {
                listBoxCursos.Items.Add(kvp.Value);
            }


        }

        private void listBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCursos.SelectedIndex != -1)
            {
                string elementoSeleccionado = listBoxCursos.SelectedItem.ToString();
                //Curso cursoSeleccionado = listBoxCursos.SelectedItem;
                labelResultado.Text = "Seleccionaste: " + elementoSeleccionado;
                string[] partes = elementoSeleccionado.Split(' ');

                if (partes.Length >= 2)
                {
                    _cursoSeleccionado = partes[0];
                }
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
            if (string.IsNullOrEmpty(_cursoSeleccionado))
            {
                MessageBox.Show("Debe seleccionar un curso", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int.TryParse(_usuario.Legajo.ToString(), out int legajo);
                Estudiante estudiante = crudEstudiante.ObtenerEstudiantePorLegajo(legajo);

                if (estudiante != null)
                {
                    estudiante.CursosInscriptos.Add(_cursoSeleccionado);
                    string path = PathManager.ObtenerRuta("Data", "DataUsuarios.json");
                    Serializador.ActualizarJson(estudiante, estudiante.Legajo, path);

                    MessageBox.Show($"Inscripción exitosa al curso: {_cursoSeleccionado}");
                }
                else
                {
                    MessageBox.Show("Error: No se encontró al estudiante.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
