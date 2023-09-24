using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases
{
    public class Usuario
    {
        private string _nombre;
        private string _apellido;
        private string _correo;
        private string _dni;
        private string _clave;
        public Usuario(string nombre, string apellido, string dni, string correoElectronico, string clave)
        {
            // constructor
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _correo = correoElectronico;
            _clave = clave;
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

    }
}
