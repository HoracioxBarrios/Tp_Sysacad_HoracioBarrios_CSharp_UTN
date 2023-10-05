using BibliotecaCLases.Controlador;
using BibliotecaCLases.Modelo;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmEditarCurso : Form
    {
        private Curso _cursoSeleccionado;
        private CrudCurso crudCurso;

        public FrmEditarCurso(Curso cursoSeleccionado)
        {
            InitializeComponent();
            _cursoSeleccionado = cursoSeleccionado;
            crudCurso = new CrudCurso();
            CargarDetallesCurso();
        }

        private void CargarDetallesCurso()
        {
            if (_cursoSeleccionado != null)
            {
                // Llenar los campos de entrada de texto con los detalles del curso para mostrar
                textBoxNombre.Text = _cursoSeleccionado.Nombre;
                textBoxCodigo.Text = _cursoSeleccionado.Codigo;
                textBoxDescripcion.Text = _cursoSeleccionado.Descripcion;
                textBoxCupoMax.Text = _cursoSeleccionado.CupoMaximo.ToString();
            }
            else
            {
                MessageBox.Show("El curso seleccionado no se encontró en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Obtener los valores editados desde los campos de entrada de texto
            string nuevoNombre = textBoxNombre.Text;
            string nuevoCodigo = textBoxCodigo.Text;
            string nuevaDescripcion = textBoxDescripcion.Text;
            string nuevoCupoMaximo = textBoxCupoMax.Text;

            // Crear una instancia de GestorCursos
            GestorCursos gestorCursos = new GestorCursos(nuevoNombre, nuevoCodigo, nuevaDescripcion, nuevoCupoMaximo);

            // Verificar si los nuevos datos son válidos
            if (!gestorCursos.Validado)
            {
                MessageBox.Show("Error: " + gestorCursos.MensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar al método para editar el curso existente
            string resultadoEdicion = gestorCursos.EditarCurso(_cursoSeleccionado.Codigo, nuevoNombre, nuevaDescripcion, nuevoCupoMaximo);

            if (resultadoEdicion == "Se modificó correctamente")
            {
                // Mostrar un mensaje de éxito después de la edición
                MessageBox.Show("Cambios guardados con éxito.");

                // Cerrar el formulario de edición después de guardar los cambios
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar los cambios: " + resultadoEdicion, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
