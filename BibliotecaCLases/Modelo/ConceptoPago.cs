using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Clase que representa un concepto de pago.
/// </summary>
namespace BibliotecaCLases.Modelo
{

    /// /// <summary>
    /// Constructor de la clase ConceptoPago.
    /// </summary>
    /// <param name="nombre">Nombre del concepto de pago.</param>
    /// <param name="monto">Monto a pagar asociado al concepto.</param>
    public class ConceptoPago
    {
        private string _nombre;
        private decimal _monto;
        private decimal _montoIngresado;

        /// <summary>
        /// Constructor de la clase ConceptoPago.
        /// </summary>
        /// <param name="nombre">Nombre del concepto de pago.</param>
        /// <param name="monto">Monto a pagar asociado al concepto.</param>
        public ConceptoPago(string nombre, decimal monto)
        {
            _nombre = nombre;
            _monto = monto;
        }

        /// <summary>
        /// Propiedad para obtener o establecer el nombre del concepto de pago.
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer el monto a pagar asociado al concepto.
        /// </summary>
        public decimal MontoPagar
        { 
            get { return _monto; } 
            set { _monto = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer el monto ingresado para el concepto de pago.
        /// </summary>
        public decimal MontoIngresado
        { 
            get { return _montoIngresado; }
            set { _montoIngresado = value; } 
        }  

    }
}
