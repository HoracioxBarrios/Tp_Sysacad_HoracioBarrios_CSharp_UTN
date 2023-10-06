using BibliotecaCLases.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    public class GestorPago
    {
        private List<Pago> _pagos;

        public GestorPago()
        {
            _pagos = new List<Pago>();
        }

        public void RegistrarPago(Estudiante estudiante, List<ConceptoPago> conceptosPago, MetodoPago metodoPago)
        {
            decimal montoTotal = CalcularMontoTotal(conceptosPago);
            Pago nuevoPago = new Pago(estudiante, conceptosPago, metodoPago, montoTotal);
            _pagos.Add(nuevoPago);
        }

        public List<Pago> ObtenerHistorialPagos()
        {
            return _pagos;
        }

        private decimal CalcularMontoTotal(List<ConceptoPago> conceptosPago)
        {
            decimal total = 0;
            foreach (var concepto in conceptosPago)
            {
                total += concepto.Monto;
            }
            return total;
        }
    }
}
