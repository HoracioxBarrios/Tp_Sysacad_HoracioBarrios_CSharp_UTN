using BibliotecaCLases.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    internal class ControlPago
    {
        private List<Pago> _pagos;

        public ControlPago()
        {
            _pagos = new List<Pago>();
        }

        public void RegistrarPago(Estudiante estudiante, List<ConceptoPago> conceptosPago, MetodoPago metodoPago)
        {
            decimal montoTotal = CalcularMontoTotal(conceptosPago);
            Pago nuevoPago = new Pago(estudiante, conceptosPago, metodoPago, montoTotal);
            _pagos.Add(nuevoPago);
        }

        public void ProcesarReembolso(Pago pago, decimal montoReembolso)
        {
            if (montoReembolso <= pago.MontoTotal)
            {
                // Lógica para procesar el reembolso aquí
                // Esto podría incluir la creación de un nuevo registro de pago negativo.
            }
            else
            {
                Console.WriteLine("El monto de reembolso excede el monto total del pago.");
            }
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
