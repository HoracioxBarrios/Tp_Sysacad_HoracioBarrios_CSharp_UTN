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
        private CrudCurso crudCurso;
        private FrmGestionarCursos _ownerForm;
        private GestorCursos _gestorCursos;
        private string _resultadoEdicion;
        public FrmEditarCurso(Curso cursoSeleccionado, FrmGestionarCursos ownerForm)
        {
            InitializeComponent();
            _cursoSeleccionado = cursoSeleccionado;
            crudCurso = new CrudCurso();
            _ownerForm = ownerForm;
            _gestorCursos = new GestorCursos(cursoSeleccionado.Nombre, cursoSeleccionado.Codigo, cursoSeleccionado.Descripcion, cursoSeleccionado.CupoMaximo.ToString());
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

            if (_gestorCursos.Validado)
            {
                if (nuevoCodigo != _codigoOriginal)
                {
                    bool codigoNoExiste = _gestorCursos.verificarDatosExistentes(nuevoCodigo);

                    if (codigoNoExiste)
                    {
                        _resultadoEdicion = _gestorCursos.EditarCurso(_codigoOriginal, nuevoCodigo, nuevoNombre, nuevaDescripcion, nuevoCupoMaximo);
                    }
                    else
                    {
                        MessageBox.Show("Error de validación: " + _gestorCursos.MensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    _resultadoEdicion = _gestorCursos.EditarCurso(_codigoOriginal, nuevoCodigo, nuevoNombre, nuevaDescripcion, nuevoCupoMaximo);
                }

                if (_resultadoEdicion != null)
                { 
                    if (_resultadoEdicion.StartsWith("Se modificó correctamente"))
                    {
                        MessageBox.Show(_resultadoEdicion, "Cambios guardados con éxito.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (_ownerForm != null)
                        {
                            _ownerForm.ActualizarListaCursos();
                        }

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(_resultadoEdicion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(_gestorCursos.MensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
