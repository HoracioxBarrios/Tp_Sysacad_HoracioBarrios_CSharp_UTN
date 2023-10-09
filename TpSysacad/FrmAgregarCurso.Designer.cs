namespace Formularios
{
    partial class FrmAgregarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCurso));
            textNombre = new TextBox();
            textCodigo = new TextBox();
            textDescripcion = new TextBox();
            textCupoMax = new TextBox();
            BtnAgregar = new Button();
            label1 = new Label();
            cBAula = new ComboBox();
            cBHorarios = new ComboBox();
            cBDias = new ComboBox();
            SuspendLayout();
            // 
            // textNombre
            // 
            textNombre.Location = new Point(240, 106);
            textNombre.Margin = new Padding(3, 2, 3, 2);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Nombre";
            textNombre.Size = new Size(110, 23);
            textNombre.TabIndex = 0;
            textNombre.TextChanged += textBox1_TextChanged;
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(240, 173);
            textCodigo.Margin = new Padding(3, 2, 3, 2);
            textCodigo.Name = "textCodigo";
            textCodigo.PlaceholderText = "Código";
            textCodigo.Size = new Size(110, 23);
            textCodigo.TabIndex = 1;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(240, 233);
            textDescripcion.Margin = new Padding(3, 2, 3, 2);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.PlaceholderText = "Descripción";
            textDescripcion.Size = new Size(110, 23);
            textDescripcion.TabIndex = 2;
            // 
            // textCupoMax
            // 
            textCupoMax.Location = new Point(240, 305);
            textCupoMax.Margin = new Padding(3, 2, 3, 2);
            textCupoMax.Name = "textCupoMax";
            textCupoMax.PlaceholderText = "Cupo Máximo";
            textCupoMax.Size = new Size(110, 23);
            textCupoMax.TabIndex = 3;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Crimson;
            BtnAgregar.FlatAppearance.BorderSize = 0;
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(354, 359);
            BtnAgregar.Margin = new Padding(3, 2, 3, 2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(118, 27);
            BtnAgregar.TabIndex = 4;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(351, 47);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 5;
            label1.Text = "Nuevo Curso";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // cBAula
            // 
            cBAula.FormattingEnabled = true;
            cBAula.Location = new Point(476, 152);
            cBAula.Margin = new Padding(2);
            cBAula.Name = "cBAula";
            cBAula.Size = new Size(80, 23);
            cBAula.TabIndex = 6;
            cBAula.Text = "Aula";
            cBAula.KeyPress += cBAula_KeyPress;
            // 
            // cBHorarios
            // 
            cBHorarios.FormattingEnabled = true;
            cBHorarios.Location = new Point(476, 233);
            cBHorarios.Margin = new Padding(2);
            cBHorarios.Name = "cBHorarios";
            cBHorarios.Size = new Size(80, 23);
            cBHorarios.TabIndex = 7;
            cBHorarios.Text = "Horarios";
            cBHorarios.KeyPress += cBHorarios_KeyPress;
            // 
            // cBDias
            // 
            cBDias.FormattingEnabled = true;
            cBDias.Location = new Point(476, 305);
            cBDias.Margin = new Padding(2);
            cBDias.Name = "cBDias";
            cBDias.Size = new Size(80, 23);
            cBDias.TabIndex = 8;
            cBDias.Text = "Dias";
            cBDias.KeyPress += cBDias_KeyPress;
            // 
            // FrmAgregarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(cBDias);
            Controls.Add(cBHorarios);
            Controls.Add(cBAula);
            Controls.Add(label1);
            Controls.Add(BtnAgregar);
            Controls.Add(textCupoMax);
            Controls.Add(textDescripcion);
            Controls.Add(textCodigo);
            Controls.Add(textNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAgregarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Nuevo Curso";
            Load += FrmAgregarCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNombre;
        private TextBox textCodigo;
        private TextBox textDescripcion;
        private TextBox textCupoMax;
        private Button BtnAgregar;
        private Label label1;
        private ComboBox cBAula;
        private ComboBox cBHorarios;
        private ComboBox cBDias;
    }
}