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
    public partial class FrmPanelAdmin : Form
    {
        public FrmPanelAdmin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            FrmRegistroEstudiante frmRegistroEstudiante = new();
            frmRegistroEstudiante.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
