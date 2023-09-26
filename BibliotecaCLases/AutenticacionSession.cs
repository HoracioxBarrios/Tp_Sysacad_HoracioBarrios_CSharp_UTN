using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases
{
    public class AutenticacionSession
    {
        private readonly List<Administrador> usuarios;

        public AutenticacionSession()
        {
            string path = "C:\\Users\\Axex Shop\\source\\repos\\Tp_Sysacad_grupal\\Data\\DatosUsuarios.json";
            usuarios = DataManager.LeerJson<Administrador>(path);

        }
        public bool AutenticarUsuario(string dni, string contrasena)
        {
            // Buscar un administrador con el DNI proporcionado en la lista
            Usuario? admin = usuarios.FirstOrDefault(a => a.Dni == dni);

            // Verificar si la contraseña proporcionada coincide con la contraseña almacenada
            if (admin != null && admin.Clave == contrasena)
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
