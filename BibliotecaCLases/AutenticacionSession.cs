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
            usuarios = new List<Administrador>(); // Inicializa la lista aquí
            // Inicializar la lista de administradores (puedes cargarla desde una base de datos u otra fuente de datos)
            Administrador administrador = new Administrador("matias", "cantero", "correo@nuevo.com", "111", "111");
            usuarios.Add(administrador);

            string path = "C:\\Users\\User\\Desktop\\clonan\\Tp_Sysacad_grupal\\Data\\DatosUsuarios1.json";
            DataManager.GuardarAJson(usuarios, path);
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
