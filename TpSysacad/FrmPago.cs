using BibliotecaCLases.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formularios
{
    public partial class FrmPago : Form
    {

        private ConceptoPago[] _conceptosPendientes; 
        public FrmPago()
        {
            InitializeComponent();

            CmboxCuota.Visible = false;
            TbxNumeroTarjeta.Visible = false;
            TbxNombreTitular.Visible = false;
            TbxFechaVencimiento.Visible = false;
            TbxCvv.Visible = false;

            TbxNombreBanco.Visible = false;
            TbxNumeroBancaria.Visible = false;
            TbxTitularCuenta.Visible = false;
            TbxNumeroReferencia.Visible = false;

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

            _conceptosPendientes = new[]
            {
            new ConceptoPago("Matrícula", 500),
            new ConceptoPago("Cargos Administrativos", 600),
            new ConceptoPago("Libros de Texto", 200),
            };


            dtgvConceptoPago.Rows.Clear();
            foreach (var concepto in _conceptosPendientes)
            {
                dtgvConceptoPago.Rows.Add(concepto.Nombre, concepto.Monto, ""); // La tercera columna está en blanco
            }

        }
        private void MostrarMetodosPAgo()
        {

            CmboxMetodoPago.Items.Add("Tarjeta de crédito");
            CmboxMetodoPago.Items.Add("Tarjeta de débito");
            CmboxMetodoPago.Items.Add("Transferencia bancaria");

            CmboxMetodoPago.SelectedIndexChanged += CmboxMetodoPago_SelectedIndexChanged;
        }

        private void CmboxMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

            string metodoSeleccionado = CmboxMetodoPago.SelectedItem.ToString();
            CmboxCuota.Visible = false;

            if (metodoSeleccionado == "Tarjeta de crédito" || metodoSeleccionado == "Tarjeta de débito")
            {

                TbxNombreBanco.Visible = false;
                TbxNumeroBancaria.Visible = false;
                TbxTitularCuenta.Visible = false;
                TbxNumeroReferencia.Visible = false;

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

                TbxNombreBanco.Visible = true;
                TbxNumeroBancaria.Visible = true;
                TbxTitularCuenta.Visible = true;
                TbxNumeroReferencia.Visible = true;



            }

        }
        private void dtgvConceptoPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmboxMetodoPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TbxNombreBanco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}