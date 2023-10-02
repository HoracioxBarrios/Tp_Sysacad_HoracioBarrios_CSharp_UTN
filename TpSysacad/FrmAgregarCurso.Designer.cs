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
            textNombre = new TextBox();
            textCodigo = new TextBox();
            textDescripcion = new TextBox();
            textCupoMax = new TextBox();
            BtnAgregar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textNombre
            // 
            textNombre.Location = new Point(317, 77);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Nombre";
            textNombre.Size = new Size(125, 27);
            textNombre.TabIndex = 0;
            textNombre.TextChanged += textBox1_TextChanged;
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(317, 151);
            textCodigo.Name = "textCodigo";
            textCodigo.PlaceholderText = "Código";
            textCodigo.Size = new Size(125, 27);
            textCodigo.TabIndex = 1;
            textCodigo.TextChanged += textBox2_TextChanged;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(317, 228);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.PlaceholderText = "Descripción";
            textDescripcion.Size = new Size(125, 27);
            textDescripcion.TabIndex = 2;
            // 
            // textCupoMax
            // 
            textCupoMax.Location = new Point(317, 301);
            textCupoMax.Name = "textCupoMax";
            textCupoMax.PlaceholderText = "Cupo Máximo";
            textCupoMax.Size = new Size(125, 27);
            textCupoMax.TabIndex = 3;
            textCupoMax.TextChanged += textBox4_TextChanged;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(327, 374);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(94, 29);
            BtnAgregar.TabIndex = 4;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 32);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 5;
            label1.Text = "Nuevo Curso";
            label1.Click += label1_Click;
            // 
            // FrmAgregarCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(BtnAgregar);
            Controls.Add(textCupoMax);
            Controls.Add(textDescripcion);
            Controls.Add(textCodigo);
            Controls.Add(textNombre);
            Name = "FrmAgregarCurso";
            Text = "FrmAgregarCurso";
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
    }
}