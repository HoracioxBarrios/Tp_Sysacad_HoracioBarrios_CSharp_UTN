using BibliotecaCLases.Controlador;
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
    public partial class FrmAgregarCurso : Form
    {
        public FrmAgregarCurso()
        {
            InitializeComponent();
        }

        private void FrmAgregarCurso_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestorCursos gestorCursos = new GestorCursos(textNombre.Text, textCodigo.Text, textDescripcion.Text, textCupoMax.Text);
            if (gestorCursos.Validado)
            {
                if (gestorCursos.verificarDatosExistentes())
                {
                    gestorCursos.AgregarCurso(textNombre.Text, textCodigo.Text, textDescripcion.Text, textCupoMax.Text);
                    MessageBox.Show("Curso agregado con éxito.");
                }
                else
                {
                    MessageBox.Show("Error de validación: " + gestorCursos.MensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error de validación: " + gestorCursos.MensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
