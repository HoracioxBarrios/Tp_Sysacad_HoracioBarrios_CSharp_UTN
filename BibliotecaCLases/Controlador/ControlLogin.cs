using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;
using System.Collections.Generic;

namespace BibliotecaCLases.Controlador
{
    public class ControlLogin
    {
        private readonly Dictionary<int, Administrador> dictUsuarios;
        private string _path;
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
            int nivelesARetroceder = 4;
       
            _path = PathManager.ObtenerRuta("Data", "dataUsuarios.json", nivelesARetroceder);
            dictUsuarios = Serializador.LeerJson<Dictionary<int, Administrador>>(_path);

            if (dictUsuarios == null || dictUsuarios.Count == 0)
            {
                dictUsuarios = new Dictionary<int, Administrador>();
               
                Administrador administrador = new Administrador("matias", "cantero", "011", "correo@nuevo.com", "11");
                Administrador administradorDos = new Administrador("Dian", "Iry", "022", "correo@nuevo.com", "22");

                int dniAdmin1 = int.Parse(administrador.Dni);
                int dniAdmin2 = int.Parse(administradorDos.Dni);
                dictUsuarios.Add(dniAdmin1,administrador);
                dictUsuarios.Add(dniAdmin2,administradorDos);

                Serializador.GuardarAJson(dictUsuarios, _path);
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
            Usuario? admin = dictUsuarios.FirstOrDefault(pair => pair.Value.Dni == dni).Value;

            if (admin != null && admin.Clave == contrasena)
            {
                return true;
            }

            return false;
        }

    }
}
