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
        private string _clave;
        private int _legajo;
        public Estudiante(string nombre, string apellido, string correo, string dni, string direccion, string telefono, string claveProvisional)
            : base(nombre, apellido, correo, dni, claveProvisional)
        {
            _legajo = contadorLegajos;
            contadorLegajos++;
            _direccion = direccion;
            _telefono = telefono;
            _clave = claveProvisional;
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
        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }
    }
}
