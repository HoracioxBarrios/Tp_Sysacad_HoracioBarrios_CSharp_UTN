using BibliotecaCLases.Controlador;
using BibliotecaCLases.Modelo;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmEditarCurso : Form
    {
        private string _cursoSeleccionado;
        private CrudCurso crudCurso;

        public FrmEditarCurso(string cursoSeleccionado)
        {
            InitializeComponent();
            _cursoSeleccionado = cursoSeleccionado;
            crudCurso = new CrudCurso();
            CargarDetallesCurso();
        }

        private void CargarDetallesCurso()
        {
            // Obtener el curso seleccionado por su código
            Curso curso = crudCurso.ObtenerCursoPorCodigo(_cursoSeleccionado);

            if (curso != null)
            {
                // Llenar los campos de entrada de texto con los detalles del curso
                textBoxNombre.Text = curso.Nombre;
                textBoxCodigo.Text = curso.Codigo;
                textBoxDescripcion.Text = curso.Descripcion;
                textBoxCupoMax.Text = curso.CupoMaximo;
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

            // Validar los valores editados utilizando tu GestorCursos
            GestorCursos gestorCursos = new GestorCursos(nuevoNombre, nuevoCodigo, nuevaDescripcion, nuevoCupoMaximo);

            if (gestorCursos.Validado)
            {
                if (gestorCursos.verificarDatosExistentes())
                {
                    // Aplicar las modificaciones utilizando tu GestorCursos o CrudCurso
                    string resultadoEdicion = gestorCursos.EditarCurso(_cursoSeleccionado, nuevoNombre, nuevaDescripcion, nuevoCupoMaximo);

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
    }
}
