using BibliotecaCLases.Controlador;
using BibliotecaCLases.Modelo;

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
            bool verificado = false;


            ControlLogin controlLogin = new();
            bool existeUsuarios = controlLogin.ExisteUsuario;

            if (existeUsuarios)
            {

                verificado = controlLogin.AutenticarUsuario(dni, contraseña);
                if (verificado)
                {
                    Usuario usuarioActual = controlLogin.GetUsuario;
                    FrmPanelUsuario frmPanelUsuario = new(usuarioActual);

                    frmPanelUsuario.FormClosed += (sender, args) =>
                    {
                        this.Close();
                    };
                    frmPanelUsuario.Show();

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

        private void btnAutoCompleAdm_Click(object sender, EventArgs e)
        {
            textUsuario.Text = "011";
            textContraseña.Text = "11";
        }

        private void btnAutoCompleAlumno_Click(object sender, EventArgs e)
        {
            textUsuario.Text = "123";
            textContraseña.Text = "i43Ia%Jjv";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", $"/c start https://extensionfra.com.ar");
        }
    }
}