namespace Formularios
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            FrmLogin formLogin = new FrmLogin();
            /*
            Se instancia el form login, con using le decimos que administre la memoria,
            luego corre la app y le pasamos este form login.
            cuando using entienda que se paso a otro form, ejemplo:
            desde form login a form panel adm o desde form login a form alumno si es alumno.
            using cierra este form y libera memoria.
             */
            using (formLogin)
            {
                Application.Run(formLogin);

                formLogin.Close();

            }

        }
    }
}