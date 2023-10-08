using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Modelo
{
    /// <summary>
    /// Clase que representa un método de pago.
    /// </summary>
    public class MetodoPago
    {
        /// <summary>
        /// Constructor de la clase MetodoPago.
        /// </summary>
        /// <param name="nombre">Nombre del método de pago.</param>
        private string _nombre;
        public MetodoPago(string nombre)
        {
            _nombre = nombre;
        }

        /// <summary>
        /// Propiedad para obtener o establecer el nombre del método de pago.
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

    }
}
