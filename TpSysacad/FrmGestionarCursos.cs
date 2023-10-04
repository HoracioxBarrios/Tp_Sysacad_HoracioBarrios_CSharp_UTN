using BibliotecaCLases.Controlador;
using BibliotecaCLases.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmGestionarCursos : Form
    {
        private string _usuario;
        private string _cursoSeleccionado;
        public FrmGestionarCursos(string usuario)
        {
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

        }

        private void BtnEliminarCursos_Click(object sender, EventArgs e)
        {

        }

        private void FrmGestionarCursos_Load(object sender, EventArgs e)
        {
            List<Curso> listaCursos = new List<Curso>();

            Curso curso1 = new Curso("Curso 1", "001", "Descripción del Curso 1", "30");
            Curso curso2 = new Curso("Curso 2", "002", "Descripción del Curso 2", "25");
            Curso curso3 = new Curso("Curso 3", "003", "Descripción del Curso 3", "20");

            listaCursos.Add(curso1);
            listaCursos.Add(curso2);
            listaCursos.Add(curso3);

            listBoxCursos.Items.Add("CODIGO        CURSO          DESCRIPCION                        CUPO MAXIMO   CUPOS DISPONIBLES");

            foreach (Curso curso in listaCursos)
            {
                listBoxCursos.Items.Add(curso);
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
        private void MostrarBtn(string usuario)
        {
            BtnAgregarCurso.Visible = false;
            BtnEditarCursos.Visible = false;
            BtnEliminarCursos.Visible = false;
            btnInscripcion.Visible = false;
            if (usuario == "Estudiante")
            {
                btnInscripcion.Visible = true;
            }
            else if (usuario == "Administrador")
            {
                BtnAgregarCurso.Visible = true;
                BtnEditarCursos.Visible = true;
                BtnEliminarCursos.Visible = true;
            }
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Curso agregado con éxito: " + _cursoSeleccionado);
        }
    }
}
