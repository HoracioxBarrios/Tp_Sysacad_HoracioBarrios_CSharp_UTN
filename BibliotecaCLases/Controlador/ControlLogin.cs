using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;
using System.Collections.Generic;

namespace BibliotecaCLases.Controlador
{
    public class ControlLogin
    {
        private readonly List<Administrador> usuarios;
        /// <summary>
        /// Inicializa una nueva instancia de la clase ControlLogin.
        /// </summary>
        /// <remarks>
        /// Este constructor se utiliza para gestionar la carga de usuarios desde un archivo JSON.
        /// Si el archivo no existe o está vacío, se crea una lista de usuarios predeterminada
        /// y se guarda en el archivo JSON especificado.
        /// </remarks>
        public ControlLogin()
        {
            // Obtener la ruta del archivo JSON de usuarios
            string path = PathManager.ObtenerRuta("Data", "dataUsuarios.json");

            // Intentar cargar la lista de usuarios desde el archivo JSON
            usuarios = Serializador.LeerJson<Administrador>(path);

            // Verificar si la lista está vacía o si el archivo no existe
            if (usuarios == null || usuarios.Count == 0)
            {
                // Inicializar una nueva lista de usuarios
                usuarios = new List<Administrador>();

                // Crear usuarios predeterminados
                Administrador administrador = new Administrador("matias", "cantero", "correo@nuevo.com", "011", "11");
                Administrador administradorDos = new Administrador("Dian", "Iry", "correo@nuevo.com", "022", "22");

                // Agregar usuarios a la lista
                usuarios.Add(administrador);
                usuarios.Add(administradorDos);

                // Guardar la lista de usuarios en el archivo JSON
                Serializador.GuardarAJson(usuarios, path);
            }
        }

        /// <summary>
        /// verifica si en la lista usuarios uno que coincide con la contraseña y el dni
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="contrasena"></param>
        /// <returns></returns>
        public bool AutenticarUsuario(string dni, string contrasena)
        {
            Usuario? admin = usuarios.FirstOrDefault(a => a.Dni == dni);

            if (admin != null && admin.Clave == contrasena)
            {

                return true;
            }

            return false;
        }

    }
}
