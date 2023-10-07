using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Modelo
{
    public class ConceptoPago
    {
        private string _nombre;
        private decimal _monto;
        private decimal _montoIngresado;

        public ConceptoPago(string nombre, decimal monto)
        {
            _nombre = nombre;
            _monto = monto;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public decimal MontoPagar
        { 
            get { return _monto; } 
            set { _monto = value; }
        }
        public decimal MontoIngresado
        { 
            get { return _montoIngresado; }
            set { _montoIngresado = value; } 
        }  

    }
}
