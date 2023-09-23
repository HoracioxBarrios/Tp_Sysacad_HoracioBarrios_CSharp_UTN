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
            if (textUsuario.Text == "root" && textContraseña.Text == "root")
            {
                FrmPanelAdmin frmPanelAdmin = new();
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