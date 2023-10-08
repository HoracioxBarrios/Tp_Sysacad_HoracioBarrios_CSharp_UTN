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

    /// <summary>
    /// Clase que gestiona los pagos de los estudiantes.
    /// </summary>
    public class GestorPagoLogic
    {
        private List<Pago> _pagos;
        private Pago _pago;
        private Estudiante _estudiante;
        private string _path;   
        private CrudEstudiante _crudEstudiante;
        private decimal _totalIngresado = 0;
        private decimal _totalAPagar = 0;

        /// <summary>
        /// Constructor de la clase GestorPagoLogic.
        /// </summary>
        public GestorPagoLogic()
        {
            _crudEstudiante = new CrudEstudiante();
            _pagos = new List<Pago>();
            _path = PathManager.ObtenerRuta("Data", "DataUsuarios.json");

        }

        /// <summary>
        /// Valida los datos de una tarjeta de crédito.
        /// </summary>
        /// <param name="numeroTarjeta">Número de tarjeta de crédito.</param>
        /// <param name="fechaVencimiento">Fecha de vencimiento de la tarjeta.</param>
        /// <param name="cvv">CVV de la tarjeta.</param>
        /// <returns>True si los datos son válidos, False en caso contrario.</returns>
        public bool ValidarDatosTarjeta(string numeroTarjeta, string fechaVencimiento, string cvv)
        {
            bool esTarjetaValida = Validacion.EsTarjetaValida(numeroTarjeta);
            bool esFechaValida = Validacion.EsFechaValida(fechaVencimiento);
            bool esCVVValido = Validacion.EsCVValido(cvv);

            if (esTarjetaValida && esFechaValida && esCVVValido)
            {
                return true;
            }
            else
            {
                return false;
                
            }
        }

        /// <summary>
        /// Registra un pago realizado por un usuario.
        /// </summary>
        /// <param name="usuario">Usuario que realiza el pago.</param>
        /// <param name="conceptosPago">Lista de conceptos de pago.</param>
        /// <param name="metodoPago">Método de pago utilizado.</param>
        public void RegistrarPago(Usuario usuario, List<ConceptoPago> conceptosPago, MetodoPago metodoPago)
        {
            _estudiante = _crudEstudiante.ObtenerEstudiantePorLegajo(usuario.Legajo);

           CalcularMontoTotal(conceptosPago);
            _pago = new Pago(_estudiante, conceptosPago, metodoPago, _totalIngresado);

            if (_totalIngresado == _totalAPagar)
            {
                _estudiante.EstadoDePago = "pagado";
            }
          
            Serializador.ActualizarJson(_estudiante, _estudiante.Legajo, _path);
            _pagos.Add(_pago);

        }

        /// <summary>
        /// Obtiene el historial de pagos realizados.
        /// </summary>
        /// <returns>Lista de pagos.</returns>
        public List<Pago> ObtenerHistorialPagos()
        {
            return _pagos;
        }

        /// <summary>
        /// Calcula el monto total ingresado y el monto total a pagar sumando los montos de los conceptos de pago proporcionados.
        /// </summary>
        /// <param name="conceptosPago">Lista de conceptos de pago para los cuales se calcularán los montos.</param>
        private void CalcularMontoTotal(List<ConceptoPago> conceptosPago)
        {
            foreach (var concepto in conceptosPago)
            {
                _totalIngresado += concepto.MontoIngresado;
                _totalAPagar += concepto.MontoPagar;
            }
           
        }

        /// <summary>
        /// Genera un comprobante de pago en formato de texto.
        /// </summary>
        /// <returns>Texto del comprobante de pago o un mensaje si no se realizó el pago.</returns>
        public string GenerarComprobanteDePago()
        {

            if (_pago.MontoTotal != 0)
            { 
                StringBuilder comprobante = new StringBuilder();

                comprobante.AppendLine("Comprobante de Pago");
                comprobante.AppendLine("===================");
                comprobante.AppendLine($"Fecha: {_pago.Fecha}");
                comprobante.AppendLine($"Estudiante: {_estudiante.Nombre}, {_estudiante.Apellido}");
                comprobante.AppendLine("Conceptos de Pago:");

                foreach (var concepto in _pago.ConceptosPago)
                {
                    comprobante.AppendLine($"- {concepto.Nombre}: ${concepto.MontoIngresado}");
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

        /// <summary>
        /// Genera los datos de transferencia bancaria en formato de texto.
        /// </summary>
        /// <returns>Texto con los datos de la transferencia bancaria o un mensaje si no se ingresó el monto.</returns>
        public string GenerarDatosTransferenciaBancaria()
        {
            if (_pago.MontoTotal != 0)
            {
                StringBuilder mensajeTransferencia = new StringBuilder("Por favor, realice la transferencia bancaria con los siguientes datos:\n\n");
                mensajeTransferencia.AppendLine("Nombre del Banco: Ciudad");
                mensajeTransferencia.AppendLine("Número de CBU: 0110599540000001234567");
                mensajeTransferencia.AppendLine("Alias: Utn.fra.2023");
                mensajeTransferencia.AppendLine("Titular de la Cuenta: UTN-fra");
                mensajeTransferencia.AppendLine("Referencia:");

                foreach (var concepto in _pago.ConceptosPago)
                {
                    mensajeTransferencia.AppendLine($"- {concepto.Nombre}: ${concepto.MontoIngresado}");
                }

                mensajeTransferencia.AppendLine($"Monto a Transferir: {_pago.MontoTotal}");

                return mensajeTransferencia.ToString();
            }else
            {
                return "Ingrese el monto a tranferir";
            }
        }
    }
}
