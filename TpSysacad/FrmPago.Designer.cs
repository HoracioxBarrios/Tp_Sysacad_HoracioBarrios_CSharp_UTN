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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(316, 27);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 0;
            label1.Text = "Realizar Pagos";
            // 
            // dtgvConceptoPago
            // 
            dtgvConceptoPago.BackgroundColor = SystemColors.Highlight;
            dtgvConceptoPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvConceptoPago.Columns.AddRange(new DataGridViewColumn[] { Nombre, Monto, IngresarMonton });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtgvConceptoPago.DefaultCellStyle = dataGridViewCellStyle1;
            dtgvConceptoPago.Location = new Point(54, 79);
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
            CmboxMetodoPago.ForeColor = SystemColors.MenuHighlight;
            CmboxMetodoPago.Location = new Point(106, 254);
            CmboxMetodoPago.Name = "CmboxMetodoPago";
            CmboxMetodoPago.Size = new Size(184, 23);
            CmboxMetodoPago.TabIndex = 0;
            CmboxMetodoPago.Text = "Seleccionar método de pago";
            CmboxMetodoPago.SelectedIndexChanged += CmboxMetodoPago_SelectedIndexChanged_1;
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
            CmboxCuota.BackColor = Color.White;
            CmboxCuota.ForeColor = SystemColors.MenuHighlight;
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
            btnPagar.BackColor = Color.FromArgb(255, 128, 0);
            btnPagar.Cursor = Cursors.Hand;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Location = new Point(509, 303);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(75, 23);
            btnPagar.TabIndex = 11;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Crimson;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(106, 303);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(127, 23);
            btnVolver.TabIndex = 13;
            btnVolver.TabStop = false;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmPago";
            Text = "Pagos";
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