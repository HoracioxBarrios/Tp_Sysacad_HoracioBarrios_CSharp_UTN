namespace pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el usuario");
            string dni = Console.ReadLine();
            Console.WriteLine("Dni");
            string contraseña =Console.ReadLine();

            BibliotecaCLases.AutenticacionSession autenticacion = new();

            bool verificado = autenticacion.AutenticarUsuario(dni, contraseña);

            if (verificado)
            {
                Console.WriteLine("Usuario encontrado");
            }
            else
            {

            }
        }
    }
}