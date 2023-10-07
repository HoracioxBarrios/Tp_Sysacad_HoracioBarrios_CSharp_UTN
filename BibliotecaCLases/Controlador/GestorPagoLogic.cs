using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    public class GestorPagoLogic
    {
        private List<Pago> _pagos;
        private Pago _pago;
        private Usuario _estudiante;
        private string _path;
        public GestorPagoLogic()
        {
            _pagos = new List<Pago>();  
            _path = PathManager.ObtenerRuta("Data", "ComprobantesPago.json");
          
        }

        public void RegistrarPago(Usuario estudiante, List<ConceptoPago> conceptosPago, MetodoPago metodoPago)
        {
            _estudiante = estudiante;
            decimal montoTotal = CalcularMontoTotal(conceptosPago);
            _pago = new Pago(estudiante, conceptosPago, metodoPago, montoTotal);
            _pagos.Add(_pago);
           
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
                total += concepto.MontoPagar;
            }
            return total;
        }


        public string Mostarcomprobante()
        {

            if (_pago != null) 
            { 
                StringBuilder comprobante = new StringBuilder();

                comprobante.AppendLine("Comprobante de Pago");
                comprobante.AppendLine("===================");
                comprobante.AppendLine($"Fecha: {_pago.Fecha}");
                comprobante.AppendLine($"Estudiante: {_estudiante.Nombre}, {_estudiante.Apellido}");
                comprobante.AppendLine("Conceptos de Pago:");

                foreach (var concepto in _pago.ConceptosPago)
                {
                    comprobante.AppendLine($"- {concepto.Nombre}: ${concepto.MontoPagar}");
                }

                comprobante.AppendLine($"Monto Total: ${_pago.MontoTotal}");
                comprobante.AppendLine($"Método de Pago: {_pago.MetodoPago.Nombre}");
 
                return comprobante.ToString();
       
            }
            else
            {
                return "No se realizo el pago";
            }
        }
        public string MostrarDatosTransferencia()
        {

            StringBuilder mensajeTransferencia = new StringBuilder("Por favor, realice la transferencia bancaria con los siguientes datos:\n\n");
            mensajeTransferencia.AppendLine("Nombre del Banco: Ciudad");
            mensajeTransferencia.AppendLine("Número de CBU: 0110599540000001234567");
            mensajeTransferencia.AppendLine("Titular de la Cuenta: UTN-fra");
            mensajeTransferencia.AppendLine("Referencia:");

            foreach (var concepto in _pago.ConceptosPago)
            {
                mensajeTransferencia.AppendLine($"- {concepto.Nombre}: ${concepto.MontoPagar}");
            }

            mensajeTransferencia.AppendLine($"Monto a Transferir: {_pago.MontoTotal}");

           return mensajeTransferencia.ToString();

        }



    }
}
