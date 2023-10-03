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
    }
}
