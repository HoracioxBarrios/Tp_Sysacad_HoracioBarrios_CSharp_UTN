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
    public partial class FrmConsultarHorario : Form
    {
        private Usuario _usuario;
        private CrudEstudiante _crudEstudiante;
        private CrudCurso _crudCurso;

        public FrmConsultarHorario(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            _crudEstudiante = new CrudEstudiante();
            _crudCurso = new CrudCurso();
        }

        private void FormConsultarHorario_Load(object sender, EventArgs e)
        {
            Estudiante estudiante = _crudEstudiante.ObtenerEstudiantePorLegajo(_usuario.Legajo);

            if (estudiante != null && estudiante.CursosInscriptos.Count > 0)
            {
                labelHorarioVacio.Visible = false;
                MostrarHorario(estudiante.CursosInscriptos);
            }
            else
            {
                labelHorario.Visible = false;
                dataGridViewHorario.Visible = false;
                labelHorarioVacio.Visible = true;
            }
        }

        private void MostrarHorario(List<string> cursosInscriptos)
        {
            foreach (var codigoCurso in cursosInscriptos)
            {
                Curso curso = _crudCurso.ObtenerCursoPorCodigo(codigoCurso);
                if (curso != null && curso.Activo)
                {
                    dataGridViewHorario.Rows.Add(curso.Nombre, curso.Horario, curso.Dia, curso.Aula);
                }
            }
        }

        private void dataGridViewHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelHorarioVacio_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPanelUsuario formPanelUsuario = new FrmPanelUsuario(_usuario);

            formPanelUsuario.FormClosed += (s, args) =>
            {
                this.Close();
            };

            formPanelUsuario.Show();
            this.Hide();
        }
    }
}
