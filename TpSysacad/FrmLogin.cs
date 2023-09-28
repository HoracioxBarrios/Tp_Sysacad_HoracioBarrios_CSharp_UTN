using BibliotecaCLases.Controlador;

namespace TpSysacad

{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string dni = textUsuario.Text; // de momento se usa el dni de usuario
            string contraseña = textContraseña.Text;

            AutenticacionSession autenticacion = new();

            bool verificado = autenticacion.AutenticarUsuario(dni, contraseña);

            if (verificado)
            {
                FrmPanelAdmin frmPanelAdmin = new();
                frmPanelAdmin.FormClosed += (sender, args) =>
                {
                    this.Close();
                };
                frmPanelAdmin.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña Incorrecta");
                textUsuario.Text = string.Empty;
                textContraseña.Text = string.Empty;

            }
        }




    }
}