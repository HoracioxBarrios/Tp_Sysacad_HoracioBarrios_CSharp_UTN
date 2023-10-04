using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Modelo
{
    public class Estudiante : Usuario
    {
        private string _direccion;
        private string _telefono;
        private string _clave;
        private bool _debecambiar;

        public Estudiante(string nombre, string apellido, string dni, string correo, string direccion, string telefono, string claveProvisional, bool debeCambiar)
            : base(nombre, apellido, dni, correo, claveProvisional, 1)
        {
            _debecambiar = debeCambiar;
            _direccion = direccion;
            _telefono = telefono;
            _clave = claveProvisional;
        }

        public bool Debecambiar
        {
            get { return _debecambiar; }
            set { _debecambiar = value; }
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

    }
}
