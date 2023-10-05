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
                FrmEditarCurso frmEditarCurso = new FrmEditarCurso(_cursoSeleccionado);
                frmEditarCurso.Show();
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
            Dictionary<int, Curso> dictCursos = null; // Inicializa el diccionario como nulo

            string path = PathManager.ObtenerRuta("Data", "DictCurso.json");

            try
            {
                dictCursos = Serializador.LeerJson<Dictionary<int, Curso>>(path);
            }
            catch (FileNotFoundException ex)
            {
                // Maneja la excepción si el archivo JSON no se encuentra
                MessageBox.Show($"No se encontró el archivo JSON en la ruta: {path}");
            }

            if (dictCursos != null)
            {
                listBoxCursos.Items.Add("CODIGO        CURSO         DESCRIPCION        CUPO MAXIMO      CUPOS DISPONIBLES");

                foreach (KeyValuePair<int, Curso> kvp in dictCursos)
                {
                    listBoxCursos.Items.Add(kvp.Value);
                }
            }
        }



        private void listBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCursos.SelectedIndex != -1)
            {
                string elementoSeleccionado = listBoxCursos.SelectedItem.ToString();

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
                string mensajeError;
                bool inscripcionExitosa = crudEstudiante.AgregarCursoAEstudiante(legajo, _cursoSeleccionado, out mensajeError);

                if (inscripcionExitosa)
                {
                    MessageBox.Show($"Inscripción exitosa al curso: {_cursoSeleccionado}");
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
    }
}
