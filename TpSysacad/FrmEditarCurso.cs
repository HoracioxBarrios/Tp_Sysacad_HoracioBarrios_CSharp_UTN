using BibliotecaCLases.Controlador;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;
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

            // Obtener la ID del curso que se está editando
            int idCurso = _cursoSeleccionado.ID;

            // Buscar el curso en el JSON por su ID
            Curso cursoEnJson = crudCurso.ObtenerCursoPorCodigo(idCurso.ToString());

            if (cursoEnJson != null)
            {
                // Modificar los atributos del curso en el JSON con los nuevos valores
                cursoEnJson.Nombre = nuevoNombre;
                cursoEnJson.Codigo = nuevoCodigo;
                cursoEnJson.Descripcion = nuevaDescripcion;
                if (int.TryParse(nuevoCupoMaximo, out int cupoMaximo))
                {
                    cursoEnJson.CupoMaximo = cupoMaximo;
                }
                else
                {
                    MessageBox.Show("Error: El nuevo cupo máximo no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizar el archivo JSON con el diccionario completo
                Serializador.ActualizarJson(cursoEnJson, idCurso.ToString(), crudCurso.Path);
                MessageBox.Show("Cambios guardados con éxito.");

                // Cerrar el formulario de edición después de guardar los cambios
                this.Close();
            }
            else
            {
                MessageBox.Show("El curso no se encontró en el JSON.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
