using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;
using System.Collections.Generic;

namespace BibliotecaCLases.Controlador
{
    public class ControlLogin
    {
        List<Administrador> usuarios = new List<Administrador>();

        public ControlLogin()
        {
            // Le paso un folder y nombre de archivo y armo la ruta
            string path = PathManager.ObtenerRuta("Data", "dataUsuarios.json");
            VerificadorFolder verificarFolder = new VerificadorFolder(path);

            if (verificarFolder.Exists())
            {
                // Leer el archivo JSON si existe
                usuarios = Serializador.LeerJson<Administrador>(path);

                // Hacer algo con la lista de usuarios (por ejemplo, guardarla en una propiedad)
            }
            else
            {
                // Si el archivo no existe, crear una lista de usuarios y guardarlo en JSON
               
                Administrador administrador = new Administrador("matias", "cantero", "correo@nuevo.com", "111", "111");
                Administrador administradorDos = new Administrador("Dian", "Iry", "correo@nuevo.com", "222", "222");
                usuarios.Add(administrador);
                usuarios.Add(administradorDos);
                Serializador.GuardarAJson(usuarios, path);
            }

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

    }
}
