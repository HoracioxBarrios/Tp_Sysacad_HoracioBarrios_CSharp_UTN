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

            // Captura la información del estudiante desde la interfaz de usuario
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            string dni = textDni.Text;
            string correo = textEmail.Text;
            string direccion = textDireccion.Text;
            string telefono = textTelefono.Text;
            string claveProvisional = textContraseñaProvisional.Text;

            // Crea una instancia de la clase Estudiante

            // validar datos necesarios 

            // Estudiante nuevoEstudiante = new Estudiante(nombre, apellido, correo, dni, direccion, telefono, claveProvisional);

            // Asigna un número de estudiante

            // Guarda el estudiante en archivos o en una lista

            // Notifica al estudiante (envía un correo electrónico, muestra un mensaje, etc.)


            MessageBox.Show("Estudiante registrado con éxito. Se ha enviado una notificación al estudiante.");
        }
    }
}
