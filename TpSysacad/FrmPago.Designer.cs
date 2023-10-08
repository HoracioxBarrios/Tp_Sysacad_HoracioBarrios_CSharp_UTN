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
            TbxNumeroTarjeta = new TextBox();
            TbxNombreTitular = new TextBox();
            TbxFechaVencimiento = new TextBox();
            TbxCvv = new TextBox();
            CmboxCuota = new ComboBox();
            btnPagar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvConceptoPago).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 27);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Vista Realizar Pago";
            // 
            // dtgvConceptoPago
            // 
            dtgvConceptoPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvConceptoPago.Columns.AddRange(new DataGridViewColumn[] { Nombre, Monto, IngresarMonton });
            dtgvConceptoPago.Location = new Point(12, 79);
            dtgvConceptoPago.Name = "dtgvConceptoPago";
            dtgvConceptoPago.RowTemplate.Height = 25;
            dtgvConceptoPago.Size = new Size(344, 150);
            dtgvConceptoPago.TabIndex = 1;
            dtgvConceptoPago.CellEndEdit += dtgvConceptoPago_CellEndEdit;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Monto
            // 
            Monto.HeaderText = "Deuda pendiente";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // IngresarMonton
            // 
            IngresarMonton.HeaderText = "Ingresar monto";
            IngresarMonton.Name = "IngresarMonton";
            // 
            // CmboxMetodoPago
            // 
            CmboxMetodoPago.Location = new Point(64, 254);
            CmboxMetodoPago.Name = "CmboxMetodoPago";
            CmboxMetodoPago.Size = new Size(184, 23);
            CmboxMetodoPago.TabIndex = 0;
            CmboxMetodoPago.Text = "Seleccionar método de pago";
            CmboxMetodoPago.KeyPress += CmboxMetodoPago_KeyPress;
            // 
            // TbxNumeroTarjeta
            // 
            TbxNumeroTarjeta.Location = new Point(445, 79);
            TbxNumeroTarjeta.Name = "TbxNumeroTarjeta";
            TbxNumeroTarjeta.PlaceholderText = "Número de tarjeta";
            TbxNumeroTarjeta.Size = new Size(139, 23);
            TbxNumeroTarjeta.TabIndex = 2;
            // 
            // TbxNombreTitular
            // 
            TbxNombreTitular.Location = new Point(445, 130);
            TbxNombreTitular.Name = "TbxNombreTitular";
            TbxNombreTitular.PlaceholderText = "Nombre del titular";
            TbxNombreTitular.Size = new Size(139, 23);
            TbxNombreTitular.TabIndex = 3;
            // 
            // TbxFechaVencimiento
            // 
            TbxFechaVencimiento.Location = new Point(445, 171);
            TbxFechaVencimiento.Name = "TbxFechaVencimiento";
            TbxFechaVencimiento.PlaceholderText = "Fecha de vencimiento:";
            TbxFechaVencimiento.Size = new Size(139, 23);
            TbxFechaVencimiento.TabIndex = 4;
            // 
            // TbxCvv
            // 
            TbxCvv.Location = new Point(445, 206);
            TbxCvv.Name = "TbxCvv";
            TbxCvv.PlaceholderText = "CVV";
            TbxCvv.Size = new Size(139, 23);
            TbxCvv.TabIndex = 5;
            // 
            // CmboxCuota
            // 
            CmboxCuota.FormattingEnabled = true;
            CmboxCuota.Location = new Point(410, 254);
            CmboxCuota.Name = "CmboxCuota";
            CmboxCuota.Size = new Size(174, 23);
            CmboxCuota.TabIndex = 10;
            CmboxCuota.Text = "Seleccione cantidad cuota";
            CmboxCuota.KeyPress += CmboxMetodoPago_KeyPress;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(565, 303);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 23);
            btnPagar.TabIndex = 11;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(30, 303);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(127, 23);
            btnVolver.TabIndex = 13;
            btnVolver.TabStop = false;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnVolver);
            Controls.Add(btnPagar);
            Controls.Add(CmboxCuota);
            Controls.Add(TbxCvv);
            Controls.Add(TbxFechaVencimiento);
            Controls.Add(TbxNombreTitular);
            Controls.Add(TbxNumeroTarjeta);
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
        private TextBox TbxNumeroTarjeta;
        private TextBox TbxNombreTitular;
        private TextBox TbxFechaVencimiento;
        private TextBox TbxCvv;
        private ComboBox CmboxCuota;
        private Button btnPagar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn IngresarMonton;
        private Button btnVolver;
    }
}