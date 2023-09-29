using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;

namespace BibliotecaCLases.Controlador
{


    public class AutenticacionSession
    {
        private readonly List<Administrador> usuarios;
        public AutenticacionSession()
        {



        //public AutenticacionSession()
        //{
        //    string path = "C:\\Users\\Orfhen2022\\Desktop\\utn 2023\\programacion 2 cuatri\\Tp_Sysacad_grupal\\Data\\Data.json";

        //    if (usuarios == null)
        //    {
        //        usuarios = new List<Administrador>(); // Inicializa la lista aquí
        //        usuarios = DataManager.LeerJson<Administrador>(path);


        //        // Inicializar la lista de administradores (puedes cargarla desde una base de datos u otra fuente de datos)
        //        Administrador administrador = new Administrador("matias", "cantero", "correo@nuevo.com", "111", "111");
        //        Administrador administradorDos = new Administrador("Dian", "Iry", "correo@nuevo.com", "222", "222");
        //        usuarios.Add(administrador);
        //        usuarios.Add(administradorDos);

        //        DataManager.GuardarAJson(usuarios, path);

        //    }

        //}

        public bool AutenticarUsuario(string dni, string contrasena)
        {
            // Buscar un administrador con el DNI proporcionado en la lista
            Administrador? admin = usuarios.FirstOrDefault(a => a.Dni == dni);

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
