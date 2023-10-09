namespace Formularios
{
    partial class FrmEditarCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarCurso));
            label1 = new Label();
            textBoxNombre = new TextBox();
            textBoxCodigo = new TextBox();
            textBoxDescripcion = new TextBox();
            textBoxCupoMax = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(371, 59);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Editar";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(96, 205);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 1;
            textBoxNombre.Text = "Nombre";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(269, 205);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(100, 23);
            textBoxCodigo.TabIndex = 2;
            textBoxCodigo.Text = "Codigo";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(432, 205);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(117, 23);
            textBoxDescripcion.TabIndex = 3;
            textBoxDescripcion.Text = "Descripcion";
            // 
            // textBoxCupoMax
            // 
            textBoxCupoMax.Location = new Point(597, 205);
            textBoxCupoMax.Name = "textBoxCupoMax";
            textBoxCupoMax.Size = new Size(100, 23);
            textBoxCupoMax.TabIndex = 4;
            textBoxCupoMax.Text = "Cupo Maximo";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Crimson;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(345, 360);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(118, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmEditarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(btnAceptar);
            Controls.Add(textBoxCupoMax);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxCodigo);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEditarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Curso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNombre;
        private TextBox textBoxCodigo;
        private TextBox textBoxDescripcion;
        private TextBox textBoxCupoMax;
        private Button btnAceptar;
    }
}