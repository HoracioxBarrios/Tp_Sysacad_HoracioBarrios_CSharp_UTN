using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Modelo
{
    public class Usuario
    {
        /// <summary>
        /// Clase que representa un usuario en el sistema.
        /// </summary>
        private string _nombre;
        private string _apellido;
        private string _correo;
        private string _dni;
        private string _clave;
        private int _legajo;

        /// <summary>
        /// Enumeración que define los tipos de usuario.
        /// </summary>
        public enum tipoUsuario
        {
            Administrador=0,
            Estudiante=1
        }
        private tipoUsuario _tipoUsuario;

        /// <summary>
        /// Constructor de la clase Usuario.
        /// </summary>
        /// <param name="nombre">El nombre del usuario.</param>
        /// <param name="apellido">El apellido del usuario.</param>
        /// <param name="dni">El número de documento del usuario.</param>
        /// <param name="correo">La dirección de correo electrónico del usuario.</param>
        /// <param name="clave">La contraseña del usuario.</param>
        /// <param name="indiceTipoUsuario">El índice del tipo de usuario (0 para Administrador, 1 para Estudiante).</param>
        public Usuario(string nombre, string apellido, string dni, string correo, string clave, int indiceTipoUsuario)
        {
           
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _correo = correo;
            _clave = clave;
            _tipoUsuario = (tipoUsuario)indiceTipoUsuario;
        }

        /// <summary>
        /// Propiedad para obtener o establecer el nombre del usuario.
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer el apellido del usuario.
        /// </summary>
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer la dirección de correo electrónico del usuario.
        /// </summary>
        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer el número de documento del usuario.
        /// </summary>
        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer la contraseña del usuario.
        /// </summary>
        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer el tipo de usuario (Administrador o Estudiante).
        /// </summary>
        public tipoUsuario TipoUsuario
        {
            get { return _tipoUsuario; }
            set { _tipoUsuario = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer el legajo del usuario.
        /// </summary>
        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

    }
}
