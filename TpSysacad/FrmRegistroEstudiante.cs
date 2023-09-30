using BibliotecaCLases.Controlador;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;
using System;
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
                DialogResult resultado = MessageBox.Show("¿Desea confirmar el registro del estudiante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    // Realizar el registro
                    string nombre = textNombre.Text;
                    string apellido = textApellido.Text;
                    string correo = textEmail.Text;
                    string dni = textDni.Text;
                    string direccion = textDireccion.Text;
                    string telefono = textTelefono.Text;
                    string claveProvisional = textContraseñaProvisional.Text;


                    // Llama al método RegistrarEstudiante de CrudEstudiante para registrar al estudiante
                    crudEstudiante.RegistrarEstudiante(nombre, apellido, correo, dni, direccion, telefono, claveProvisional, path);

                    MessageBox.Show("Estudiante registrado con éxito. Se ha enviado una notificación al estudiante.");
                }
                else
                {
                    // El administrador eligió cancelar el registro
                    MessageBox.Show("Registro cancelado.");
                }
            }
            else
            {
                // Muestra el mensaje de error al usuario
                MessageBox.Show("Error de validación: " + mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
