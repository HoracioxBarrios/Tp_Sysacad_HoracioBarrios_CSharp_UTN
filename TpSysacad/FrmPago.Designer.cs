namespace Formularios
{
    partial class FrmPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dtgvConceptoPago = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            IngresarMonton = new DataGridViewTextBoxColumn();
            CmboxMetodoPago = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgvConceptoPago).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 22);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Vista Realizar Pago";
            label1.Click += label1_Click;
            // 
            // dtgvConceptoPago
            // 
            dtgvConceptoPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvConceptoPago.Columns.AddRange(new DataGridViewColumn[] { Nombre, Monto, IngresarMonton });
            dtgvConceptoPago.Location = new Point(141, 57);
            dtgvConceptoPago.Name = "dtgvConceptoPago";
            dtgvConceptoPago.RowTemplate.Height = 25;
            dtgvConceptoPago.Size = new Size(344, 150);
            dtgvConceptoPago.TabIndex = 1;
            dtgvConceptoPago.CellContentClick += dtgvConceptoPago_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // IngresarMonton
            // 
            IngresarMonton.HeaderText = "Ingresar monton";
            IngresarMonton.Name = "IngresarMonton";
            // 
            // CmboxMetodoPago
            // 
            CmboxMetodoPago.Location = new Point(150, 236);
            CmboxMetodoPago.Name = "CmboxMetodoPago";
            CmboxMetodoPago.Size = new Size(184, 23);
            CmboxMetodoPago.TabIndex = 0;
            CmboxMetodoPago.Text = "Seleccionar método de pago";
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(CmboxMetodoPago);
            Controls.Add(dtgvConceptoPago);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmPago";
            Text = "FrmPago";
            Load += FrmPago_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvConceptoPago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgvConceptoPago;
        private ComboBox CmboxMetodoPago;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn IngresarMonton;
    }
}