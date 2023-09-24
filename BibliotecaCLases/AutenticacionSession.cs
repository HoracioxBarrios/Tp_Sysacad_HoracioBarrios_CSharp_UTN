using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases
{
    public class AutenticacionSession
    {
        private readonly List<Usuario> usuarios;

        public AutenticacionSession()
        {
            // Inicializar la lista de administradores (puedes cargarla desde una base de datos u otra fuente de datos)
            usuarios = new List<Usuario>


        {
            new Administrador("Alexis", "Aranda", "alexisaranda", "111", "111"),
            new Administrador("Hora", "Barrios",  "horabarrios","222", "222")

            // Agregar más administradores según sea necesario
        };
            //administradores.Add(new Administrador("Nuevo", "Administrador", "3333", "nuevoadmin", "333"));

        }

        public bool AutenticarUsuario(string dni, string contrasena)
        {
            // Buscar un administrador con el DNI proporcionado en la lista
            Usuario? admin = usuarios.FirstOrDefault(a => a.Dni == dni);

            // Si no se encuentra un administrador con ese DNI, la autenticación falla
            if (admin == null)
            {
                return false;
            }

            // Verificar si la contraseña proporcionada coincide con la contraseña almacenada
            if (admin.Clave == contrasena)
            {
                // Autenticación exitosa
                return true;
            }

            // Si la contraseña no coincide, la autenticación falla
            return false;
        }



        // Otros métodos relacionados con la autenticación y la gestión de sesiones

        // Por ejemplo, puedes tener un método para cerrar la sesión de un administrador
        public static void CerrarSesion()
        {
            // Lógica para cerrar la sesión del administrador
        }
    }
}
