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
    public partial class FormPanelUsuario : Form
    {
        private string _usuario;
        public FormPanelUsuario(string usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            MostrarBtn(_usuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistroEstudiante frmRegistroEstudiante = new();

            frmRegistroEstudiante.FormClosed += (sender, args) =>
            {
                this.Close();
            };

            frmRegistroEstudiante.Show();
            this.Hide();
        }

        private void BtnGestionarCursos_Click(object sender, EventArgs e)
        {
            FrmGestionarCursos frmGestionarCursos = new(_usuario);

            frmGestionarCursos.FormClosed += (sender, args) =>
            {
                this.Close();
            };

            frmGestionarCursos.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BtnGestionarCursos_Click(sender, e);
        }
        private void MostrarBtn(string usuario)
        {
            button2.Visible = false;
            BtnGestionarCursos.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            if (usuario == "Estudiante")
            {
                button2.Visible = true;
                button3.Visible = true;
            }
            else if (usuario == "Administrador")
            {
                button1.Visible = true;
                BtnGestionarCursos.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
