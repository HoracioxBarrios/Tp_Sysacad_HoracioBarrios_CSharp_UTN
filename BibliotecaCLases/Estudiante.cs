using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases
{
    public class Estudiante
    {
        private static int contadorLegajos = 1;
        private string _nombre;
        private string _apellido;
        private string _correo;
        private string _dni;
        private string _clave;
        private string _direccion;
        private string _telefono;
        private string _claveProvisional;
        private int _legajo;


        public Estudiante(string nombre, string apellido, string correo, string dni, string clave, string direccion, string telefono, string claveProvisional)
        {
            _legajo = contadorLegajos;
            contadorLegajos++;
            _nombre = nombre;
            _apellido = apellido;
            _correo = correo;
            _dni = dni;
            _clave = clave;
            _direccion = direccion;
            _telefono = telefono;
            _claveProvisional = claveProvisional;
        }
        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
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

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string ClaveProvisional
        {
            get { return _claveProvisional; }
            set { _claveProvisional = value; }
        }


    }
}
