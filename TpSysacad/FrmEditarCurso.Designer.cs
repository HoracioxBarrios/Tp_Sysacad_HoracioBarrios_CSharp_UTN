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
            label1.Location = new Point(329, 84);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Editar";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(24, 173);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 1;
            textBoxNombre.Text = "Nombre";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(168, 173);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(100, 23);
            textBoxCodigo.TabIndex = 2;
            textBoxCodigo.Text = "Codigo";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(304, 173);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(117, 23);
            textBoxDescripcion.TabIndex = 3;
            textBoxDescripcion.Text = "Descripcion";
            // 
            // textBoxCupoMax
            // 
            textBoxCupoMax.Location = new Point(467, 173);
            textBoxCupoMax.Name = "textBoxCupoMax";
            textBoxCupoMax.Size = new Size(100, 23);
            textBoxCupoMax.TabIndex = 4;
            textBoxCupoMax.Text = "Cupo Maximo";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(304, 256);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FrmEditarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(textBoxCupoMax);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxCodigo);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Name = "FrmEditarCurso";
            Text = "FrmEditarCurso";
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