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

            BibliotecaCLases.AutenticacionSession autenticacion = new();

            bool verificado = autenticacion.AutenticarUsuario(dni, contraseña);

            if (verificado)
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