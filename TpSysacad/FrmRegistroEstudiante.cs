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
    public partial class FrmRegistroEstudiante : Form
    {
        public FrmRegistroEstudiante()
        {
            InitializeComponent();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            // Crear una instancia del ValidadorDatosRegistro y pasar los valores del formulario
            ValidadorDatosRegistro validadorDatosRegist = new ValidadorDatosRegistro(
                textNombre.Text, textApellido.Text, textDni.Text, textEmail.Text, textDireccion.Text,
                textTelefono.Text, textContraseñaProvisional.Text);

            // Validar los datos y obtener un mensaje de error si falla la validación
            if (validadorDatosRegist.Validar(out string mensajeError))
            {
                // Realiza el registro
                // Aquí puedes agregar la lógica para guardar los datos si la validación es exitosa
                // Por ejemplo, podrías llamar a un método de registro de estudiante aquí.

                MessageBox.Show("Estudiante registrado con éxito. Se ha enviado una notificación al estudiante.");
            }
            else
            {
                // Muestra el mensaje de error al usuario
                MessageBox.Show("Error de validación: " + mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
