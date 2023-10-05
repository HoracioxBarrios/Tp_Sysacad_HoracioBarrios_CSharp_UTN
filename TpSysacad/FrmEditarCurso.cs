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
        private FrmGestionarCursos _ownerForm;
        public FrmEditarCurso(Curso cursoSeleccionado, FrmGestionarCursos ownerForm)
        {
            InitializeComponent();
            _cursoSeleccionado = cursoSeleccionado;
            crudCurso = new CrudCurso();
            _ownerForm = ownerForm;
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

            int idCurso = _cursoSeleccionado.ID;

            Curso cursoEnJson = crudCurso.ObtenerCursoPorCodigo(idCurso.ToString());

            if (cursoEnJson != null)
            {
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

                Serializador.ActualizarJson(cursoEnJson, idCurso.ToString(), crudCurso.Path);
                MessageBox.Show("Cambios guardados con éxito.");

                if (_ownerForm != null)
                {
                    _ownerForm.ActualizarListaCursos();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("El curso no se encontró en el JSON.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
