using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Modelo
{
    public class Pago
    {
        private DateTime _fecha;
        private Estudiante _estudiante;
        private List<ConceptoPago> _conceptosPago;
        private MetodoPago _metodoPago;
        private decimal _montoTotal;

        public Pago(Estudiante estudiante, List<ConceptoPago> conceptosPago, MetodoPago metodoPago, decimal montoTotal)
        {
            _fecha = DateTime.Now;
            _estudiante = estudiante;
            _conceptosPago = conceptosPago;
            _metodoPago = metodoPago;
            _montoTotal = montoTotal;
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public Estudiante Estudiante 
        {
            get { return _estudiante; } 
            set { _estudiante = value; }
        }

        public List<ConceptoPago> ConceptosPago
        {
            get { return _conceptosPago; }
            set { _conceptosPago = value; }
        }

        public MetodoPago MetodoPago
        {
            get { return _metodoPago; }
            set { _metodoPago = value; }
        }

        public decimal MontoTotal
        {
            get { return _montoTotal; }
            set { _montoTotal = value; }
        }
    }
}
