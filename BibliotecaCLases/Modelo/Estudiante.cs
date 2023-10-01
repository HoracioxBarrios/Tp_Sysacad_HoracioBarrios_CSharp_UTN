using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Modelo
{
    public class Estudiante : Usuario
    {
       
        private static int contadorLegajos = 1;
        private string _direccion;
        private string _telefono;
        private string _clave;
        private int _legajo;
        private bool _debecambiar;


        public Estudiante(string nombre, string apellido, string dni, string correo, string direccion, string telefono, string claveProvisional, bool debeCambiar)
            : base(nombre, apellido, dni, correo, claveProvisional)
        {

            _debecambiar = debeCambiar;
            _legajo = contadorLegajos;
            contadorLegajos++;
            _direccion = direccion;
            _telefono = telefono;
            _clave = claveProvisional;
        }


        public bool Debecambiar
        {
            get { return _debecambiar; }
            set { _debecambiar = value; }
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
