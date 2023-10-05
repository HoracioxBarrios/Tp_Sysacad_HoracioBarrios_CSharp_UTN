using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Modelo
{
    public class MetodoPago
    {
        private string _nombre;
        public MetodoPago(string nombre)
        {
            _nombre = nombre;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

    }
}
