using BibliotecaCLases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpSysacad
{
    public partial class FrmRegistroEstudiante : Form
    {
        public FrmRegistroEstudiante()
        {
            InitializeComponent();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textNombre.Text;
                string apellido = textApellido.Text;
                string dni = textDni.Text;
                string correo = textEmail.Text;
                string direccion = textDireccion.Text;
                string telefono = textTelefono.Text;
                string claveProvisional = textContraseñaProvisional.Text;

                // Realiza las validaciones llamando al método RegistrarEstudiante de la clase CrudEstudiante
                CrudEstudiante scrumEstudiante = new CrudEstudiante();
                Estudiante nuevoEstudiante = scrumEstudiante.RegistrarEstudiante(nombre, apellido, correo, dni, direccion, telefono, claveProvisional);

                // Notifica al usuario que el estudiante se ha registrado con éxito
                MessageBox.Show("Estudiante registrado con éxito. Se ha enviado una notificación al estudiante.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Captura otras excepciones no controladas
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
