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
    public partial class FrmRegistroEstudiante : Form
    {
        public FrmRegistroEstudiante()
        {
            InitializeComponent();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            if (textContraseñaProvisional.Text == "123") 
            {
                MessageBox.Show("Se Registro el estudiante{0}",textNombre.Text);
            }
            else
            {
                MessageBox.Show("No Se puede regisatrar el Estudiante");
            }
        }
    }
}
