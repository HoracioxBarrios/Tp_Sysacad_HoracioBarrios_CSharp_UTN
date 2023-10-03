using BibliotecaCLases.Controlador;

namespace Formularios

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
            bool verificado= false;


            ControlLogin controlLogin = new();
            bool existeUsuarios = controlLogin.ExisteUsuario;

            if (existeUsuarios)
            {

               verificado = controlLogin.AutenticarUsuario(dni, contraseña);
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
            else
            {
                MessageBox.Show("No se puede acceder en estos momentos");
            }

        }




    }
}