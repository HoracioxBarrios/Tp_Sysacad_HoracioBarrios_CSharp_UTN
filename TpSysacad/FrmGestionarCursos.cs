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
        public FrmGestionarCursos()
        {
            InitializeComponent();
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
            // Crear una lista para almacenar los cursos
            List<Curso> listaCursos = new List<Curso>();

            // Crear las instancias de Curso y agregarlas a la lista
            Curso curso1 = new Curso("Curso 1", "001", "Descripción del Curso 1", "30");
            Curso curso2 = new Curso("Curso 2", "002", "Descripción del Curso 2", "25");
            Curso curso3 = new Curso("Curso 3", "003", "Descripción del Curso 3", "20");

            listaCursos.Add(curso1);
            listaCursos.Add(curso2);
            listaCursos.Add(curso3);
            // Agregar elementos al ListBox cuando se carga el formulario

            // Agregar el encabezado como primer elemento
            listBoxCursos.Items.Add("CODIGO        CURSO          DESCRIPCION                        CUPO MAXIMO   CUPOS DISPONIBLES");

            foreach (Curso curso in listaCursos)
            {
                listBoxCursos.Items.Add(curso);
            }


        }

        private void listBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un elemento
            if (listBoxCursos.SelectedIndex != -1)
            {
                // Obtener el elemento seleccionado
                string elementoSeleccionado = listBoxCursos.SelectedItem.ToString();

                // Puedes hacer lo que quieras con el elemento seleccionado, como mostrarlo en una etiqueta
                labelResultado.Text = "Seleccionaste: " + elementoSeleccionado;
            }
        }
    }
}
