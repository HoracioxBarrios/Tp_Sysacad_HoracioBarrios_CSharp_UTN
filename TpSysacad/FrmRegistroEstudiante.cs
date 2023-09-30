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
            GestorRegistroEstudiantes gestorEstudiantes = new GestorRegistroEstudiantes(textNombre.Text, textApellido.Text, textDni.Text, textEmail.Text, textDireccion.Text,
                textTelefono.Text, textContraseñaProvisional.Text);

            // Validar los datos y obtener un mensaje de error si falla la validación
            if (gestorEstudiantes.Validado)
            {
                if (gestorEstudiantes.verificardatosExistentes())
                {
                    DialogResult resultado = MessageBox.Show("¿Desea confirmar el registro del estudiante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        // Llama al método RegistrarEstudiante de CrudEstudiante para registrar al estudiante
                        gestorEstudiantes.RegistrarEstudiante(textNombre.Text, textApellido.Text, textDni.Text, textEmail.Text, textDireccion.Text,
                        textTelefono.Text, textContraseñaProvisional.Text);

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
                    MessageBox.Show("Error de validación: " + gestorEstudiantes.MensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


        
            }
            else
            {
                // Muestra el mensaje de error al usuario
                MessageBox.Show("Error de validación: " + gestorEstudiantes.MensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
