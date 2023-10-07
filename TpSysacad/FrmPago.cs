using BibliotecaCLases.Controlador;
using BibliotecaCLases.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formularios
{
    public partial class FrmPago : Form
    {

        private GestorPagoLogic _gestorPago;
        private Usuario _estudiante;
        private int _totalAPagar = 0;
        private List<ConceptoPago> conceptoPagos = new List<ConceptoPago>();

        MetodoPago metodoPagoCredito = new("Tarjeta de crédito");
        MetodoPago metodoPagoDebito = new("Tarjeta de débito");
        MetodoPago metodoPagoBancaria = new("Transferencia bancaria");

        public FrmPago(Usuario estudiante)
        {
            InitializeComponent();
            _gestorPago = new GestorPagoLogic();
            _estudiante = estudiante;

            CmboxCuota.Visible = false;
            TbxNumeroTarjeta.Visible = false;
            TbxNombreTitular.Visible = false;
            TbxFechaVencimiento.Visible = false;
            TbxCvv.Visible = false;

        }

        private void FrmPago_Load(object sender, EventArgs e)
        {
            MostrarConceptosPagoPendientes();
            MostrarMetodosPAgo();

        }

        /// <summary>
        /// Muestra los conceptos de pago pendientes en el control ListBox.
        /// </summary>
        private void MostrarConceptosPagoPendientes()
        {
            conceptoPagos.Add(new ConceptoPago("Matrícula", 500));
            conceptoPagos.Add(new ConceptoPago("Cargos Administrativos", 600));
            conceptoPagos.Add(new ConceptoPago("Libros de Texto", 200));


            dtgvConceptoPago.Rows.Clear();
            foreach (var concepto in conceptoPagos)
            {
                dtgvConceptoPago.Rows.Add(concepto.Nombre, concepto.Monto, "");
            }

        }
        private void MostrarMetodosPAgo()
        {
            CmboxMetodoPago.Items.Add(metodoPagoCredito.Nombre);
            CmboxMetodoPago.Items.Add(metodoPagoDebito.Nombre);
            CmboxMetodoPago.Items.Add(metodoPagoBancaria.Nombre);

            CmboxMetodoPago.SelectedIndexChanged += CmboxMetodoPago_SelectedIndexChanged;
        }

        private void CmboxMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

            string metodoSeleccionado = CmboxMetodoPago.SelectedItem.ToString();
            CmboxCuota.Visible = false;

            if (metodoSeleccionado == "Tarjeta de crédito" || metodoSeleccionado == "Tarjeta de débito")
            {

                TbxNumeroTarjeta.Visible = true;
                TbxNombreTitular.Visible = true;
                TbxFechaVencimiento.Visible = true;
                TbxCvv.Visible = true;

                if (metodoSeleccionado == "Tarjeta de crédito")
                {

                    CmboxCuota.Items.Clear();
                    CmboxCuota.Visible = true;
                    CmboxCuota.Items.Add("3 cuotas");
                    CmboxCuota.Items.Add("6 cuotas");
                    CmboxCuota.Items.Add("12 cuotas");

                }

            }

            else if (metodoSeleccionado == "Transferencia bancaria")
            {

                TbxNumeroTarjeta.Visible = false;
                TbxNombreTitular.Visible = false;
                TbxFechaVencimiento.Visible = false;
                TbxCvv.Visible = false;

            }

        }

        private void dtgvConceptoPago_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0 && e.RowIndex < conceptoPagos.Count)
            {
                string valorIngresado = dtgvConceptoPago.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                if (decimal.TryParse(valorIngresado, out decimal valorCelda))
                {
                    conceptoPagos[e.RowIndex].MontoPagar = valorCelda;

                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido.");
                }
            }
        }

        private void CmboxMetodoPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string metodoSeleccionado = CmboxMetodoPago.SelectedItem.ToString();

            List<MetodoPago> metodosDePago = new List<MetodoPago>
            {
                metodoPagoCredito,
                metodoPagoDebito,
                metodoPagoBancaria
            };
            MetodoPago metodoPagoSeleccionado = metodosDePago.FirstOrDefault(mp => mp.Nombre == metodoSeleccionado);

            if (metodoPagoSeleccionado != null)
            {
                _gestorPago.RegistrarPago(_estudiante, conceptoPagos, metodoPagoSeleccionado);
                if (metodoSeleccionado != "Transferencia bancaria")
                {
                    MessageBox.Show(_gestorPago.Mostarcomprobante());

                }
                else
                {

                    MessageBox.Show(_gestorPago.MostrarDatosTransferencia());
                }


            }
            else
            {
                MessageBox.Show("Método de pago no válido");
            }
        }


    }
}