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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistroEstudiante frmRegistroEstudiante = new();
            frmRegistroEstudiante.Show();
            this.Hide();    
        }
    }
}
