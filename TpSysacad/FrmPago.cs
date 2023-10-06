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

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgvConceptoPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        /// <summary>
        /// Obtiene el concepto de pago que ha sido seleccionado en el control ListBox.
        /// </summary>
        /// <returns>El concepto de pago seleccionado.</returns>




    }
}