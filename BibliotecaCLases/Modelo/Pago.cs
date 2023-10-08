using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Modelo
{
    /// <summary>
    /// Clase que representa un pago realizado por un estudiante.
    /// </summary>
    public class Pago
    {
        private DateTime _fecha;
        private Usuario _estudiante;
        private List<ConceptoPago> _conceptosPago;
        private MetodoPago _metodoPago;
        private decimal _montoTotal;

        /// <summary>
        /// Constructor de la clase Pago.
        /// </summary>
        /// <param name="estudiante">El estudiante que realiza el pago.</param>
        /// <param name="conceptosPago">Lista de conceptos de pago asociados al pago.</param>
        /// <param name="metodoPago">El método de pago utilizado para el pago.</param>
        /// <param name="montoTotal">El monto total del pago.</param>
        public Pago(Usuario estudiante, List<ConceptoPago> conceptosPago, MetodoPago metodoPago, decimal montoTotal)
        {
            _fecha = DateTime.Now;
            _estudiante = estudiante;
            _conceptosPago = conceptosPago;
            _metodoPago = metodoPago;
            _montoTotal = montoTotal;
        }

        /// <summary>
        /// Propiedad para obtener o establecer la fecha en que se realizó el pago.
        /// </summary>
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer el estudiante que realizó el pago.
        /// </summary>
        public Usuario Estudiante 
        {
            get { return _estudiante; } 
            set { _estudiante = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer la lista de conceptos de pago asociados al pago.
        /// </summary>
        public List<ConceptoPago> ConceptosPago
        {
            get { return _conceptosPago; }
            set { _conceptosPago = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer el método de pago utilizado para el pago.
        /// </summary>
        public MetodoPago MetodoPago
        {
            get { return _metodoPago; }
            set { _metodoPago = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer el monto total del pago.
        /// </summary>
        public decimal MontoTotal
        {
            get { return _montoTotal; }
            set { _montoTotal = value; }
        }
    }
}
