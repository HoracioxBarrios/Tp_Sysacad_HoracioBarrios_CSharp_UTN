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
        private Usuario _usuario;
        private int _totalAPagar = 0;
        private List<ConceptoPago> conceptoPagos = new List<ConceptoPago>();

        MetodoPago metodoPagoCredito = new("Tarjeta de crédito");
        MetodoPago metodoPagoDebito = new("Tarjeta de débito");
        MetodoPago metodoPagoBancaria = new("Transferencia bancaria");

        public FrmPago(Usuario usuario)
        {
            InitializeComponent();
            _gestorPago = new GestorPagoLogic();
            _usuario = usuario;

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
                dtgvConceptoPago.Rows.Add(concepto.Nombre, concepto.MontoPagar, "");
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
                DataGridViewCell cell = dtgvConceptoPago.Rows[e.RowIndex].Cells[e.ColumnIndex];

                string valorIngresado = cell.EditedFormattedValue.ToString();

                if (!string.IsNullOrWhiteSpace(valorIngresado))
                {
                    if (decimal.TryParse(valorIngresado, out decimal valorCelda))
                    {
                        conceptoPagos[e.RowIndex].MontoIngresado = valorCelda;

                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un valor numérico válido en esta celda.");
                        dtgvConceptoPago.CancelEdit();
                        dtgvConceptoPago.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = conceptoPagos[e.RowIndex].MontoIngresado;
                    }
                }
            }
        }

        private void CmboxMetodoPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string metodoSeleccionado = CmboxMetodoPago.SelectedItem?.ToString(); // El operador ? evita una excepción si es nulo

            if (string.IsNullOrEmpty(metodoSeleccionado))
            {
                MessageBox.Show("Por favor, seleccione un método de pago válido antes de continuar.");
                return;
            }

            List<MetodoPago> metodosDePago = new List<MetodoPago>
            {
                metodoPagoCredito,
                metodoPagoDebito,
                metodoPagoBancaria
            };
            MetodoPago metodoPagoSeleccionado = metodosDePago.FirstOrDefault(mp => mp.Nombre == metodoSeleccionado);

            if (metodoPagoSeleccionado != null)
            {
                if (metodoSeleccionado == "Tarjeta de crédito" || metodoSeleccionado == "Tarjeta de débito")
                {
                    string numeroTarjeta = TbxNumeroTarjeta.Text;
                    string fechaVencimiento = TbxFechaVencimiento.Text;
                    string cvv = TbxCvv.Text;

                    if (_gestorPago.ValidarDatosTarjeta(numeroTarjeta, fechaVencimiento, cvv))
                    {
                        _gestorPago.RegistrarPago(_usuario, conceptoPagos, metodoPagoSeleccionado);
                        MessageBox.Show(_gestorPago.GenerarComprobanteDePago());
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese datos de tarjeta válidos.");
                    }
                }
                else if (metodoSeleccionado == "Transferencia bancaria")
                {
                    _gestorPago.RegistrarPago(_usuario, conceptoPagos, metodoPagoSeleccionado);
                    MessageBox.Show(_gestorPago.GenerarDatosTransferenciaBancaria());
                }
            }
            else
            {
                MessageBox.Show("Método de pago no válido");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPanelUsuario formPanelUsuario = new FormPanelUsuario(_usuario);

            formPanelUsuario.FormClosed += (s, args) =>
            {
                this.Close();
            };

            formPanelUsuario.Show();
            this.Hide();
        }
    }
}
