namespace BibliotecaCLases.Modelo
{
    /// <summary>
    /// Clase que representa un Administrador, que hereda de la clase Usuario.
    /// </summary>
    public class Administrador : Usuario
    {
        /// <summary>
        /// Constructor de la clase Administrador.
        /// </summary>
        /// <param name="nombre">Nombre del administrador.</param>
        /// <param name="apellido">Apellido del administrador.</param>
        /// <param name="dni">DNI del administrador.</param>
        /// <param name="correo">Correo electrónico del administrador.</param>
        /// <param name="clave">Clave de acceso del administrador.</param>
        public Administrador(string nombre, string apellido, string dni, string correo, string clave)
            : base(nombre, apellido, dni,correo ,clave, 0)
        {
        }

    }
}