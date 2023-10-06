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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formularios
{
    public partial class FrmAgregarCurso : Form
    {
        private FrmGestionarCursos _ownerForm;
        public FrmAgregarCurso(FrmGestionarCursos ownerForm)
        {
            InitializeComponent();
            _ownerForm = ownerForm;
        }

        private void FrmAgregarCurso_Load(object sender, EventArgs e)
        {
            MostrarAulas();
            MostrarHorarios();
            MostrarDias();
        }
        private void MostrarEnumEnComboBox<T>(System.Windows.Forms.ComboBox comboBox)
        {
            T[] enumValues = (T[])Enum.GetValues(typeof(T));
            foreach (T value in enumValues)
            {
                comboBox.Items.Add(value.ToString());
            }
        }

        private void MostrarAulas()
        {
            MostrarEnumEnComboBox<Curso.aulas>(cBAula);
        }

        private void MostrarHorarios()
        {
            MostrarEnumEnComboBox<Curso.horarios>(cBHorarios);
        }

        private void MostrarDias()
        {
            MostrarEnumEnComboBox<Curso.dias>(cBDias);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hora = cBHorarios.SelectedItem.ToString();
            GestorCursos gestorCursos = new GestorCursos(textNombre.Text, textCodigo.Text, textDescripcion.Text, textCupoMax.Text,cBDias.SelectedItem.ToString(),cBHorarios.SelectedItem.ToString(),cBAula.SelectedItem.ToString());
            if (gestorCursos.Validado)
            {
                if (gestorCursos.verificarDatosExistentes())
                {
                    gestorCursos.AgregarCurso(textNombre.Text, textCodigo.Text, textDescripcion.Text, textCupoMax.Text,cBDias.SelectedItem.ToString(), cBHorarios.SelectedItem.ToString(), cBAula.SelectedItem.ToString());
                    MessageBox.Show("Curso agregado con éxito.");
                    if (_ownerForm != null)
                    {
                        _ownerForm.ActualizarListaCursos();
                    }
                    this.Hide();
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

        private void cBAula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cBHorarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cBDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
