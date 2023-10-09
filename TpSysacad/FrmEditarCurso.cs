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
        private string _codigoOriginal;
        private FrmGestionarCursos _ownerForm;
        public FrmEditarCurso(Curso cursoSeleccionado, FrmGestionarCursos ownerForm)
        {
            InitializeComponent();
            _cursoSeleccionado = cursoSeleccionado;
            _ownerForm = ownerForm;
            _codigoOriginal = cursoSeleccionado.Codigo.ToString();
            CargarDetallesCurso();
        }

        private void CargarDetallesCurso()
        {
            if (_cursoSeleccionado != null)
            {
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
            string nuevoNombre = textBoxNombre.Text;
            string nuevoCodigo = textBoxCodigo.Text;
            string nuevaDescripcion = textBoxDescripcion.Text;
            string nuevoCupoMaximo = textBoxCupoMax.Text;

            GestorCursos gestorCursos = new GestorCursos(nuevoNombre, nuevoCodigo, nuevaDescripcion, nuevoCupoMaximo);

            if (!gestorCursos.Validado)
            {
                MessageBox.Show(gestorCursos.MensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nuevoCodigo != _codigoOriginal)
            {
                if (!gestorCursos.verificarDatosExistentes(nuevoCodigo))
                {
                    MessageBox.Show("Error de validación: " + gestorCursos.MensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string resultadoEdicion = gestorCursos.EditarCurso(_codigoOriginal, nuevoCodigo, nuevoNombre, nuevaDescripcion, nuevoCupoMaximo);

            if (resultadoEdicion.StartsWith("Se modificó correctamente"))
            {
                MessageBox.Show(resultadoEdicion, "Cambios guardados con éxito.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_ownerForm != null)
                {
                    _ownerForm.ActualizarListaCursos();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show(resultadoEdicion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
