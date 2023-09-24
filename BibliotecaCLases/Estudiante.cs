using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases
{
    public class Estudiante : Usuario
    {
        private static int contadorLegajos = 1;
        private string _direccion;
        private string _telefono;
        private string _claveProvisional;
        private int _legajo;
        public Estudiante(string nombre, string apellido, string correo, string dni, string clave, string direccion, string telefono, string claveProvisional)
            : base(nombre, apellido, correo, dni, clave)
        {
            _legajo = contadorLegajos;
            contadorLegajos++;
            _direccion = direccion;
            _telefono = telefono;
            _claveProvisional = claveProvisional;
        }

        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
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
