namespace TpSysacad
{
    partial class FrmRegistroEstudiante
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
            textNombre = new TextBox();
            textApellido = new TextBox();
            textDni = new TextBox();
            textDireccion = new TextBox();
            textTelefono = new TextBox();
            textEmail = new TextBox();
            btnRegistro = new Button();
            textContraseñaProvisional = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(262, 35);
            label1.Name = "label1";
            label1.Size = new Size(144, 21);
            label1.TabIndex = 0;
            label1.Text = "Registro Estudiante";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(284, 95);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Nombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 1;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(284, 124);
            textApellido.Name = "textApellido";
            textApellido.PlaceholderText = "Apellido";
            textApellido.Size = new Size(100, 23);
            textApellido.TabIndex = 2;
            // 
            // textDni
            // 
            textDni.Location = new Point(284, 165);
            textDni.Name = "textDni";
            textDni.PlaceholderText = "DNI";
            textDni.Size = new Size(100, 23);
            textDni.TabIndex = 3;
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(284, 207);
            textDireccion.Name = "textDireccion";
            textDireccion.PlaceholderText = "Direccion";
            textDireccion.Size = new Size(100, 23);
            textDireccion.TabIndex = 4;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(284, 245);
            textTelefono.Name = "textTelefono";
            textTelefono.PlaceholderText = "Telefono";
            textTelefono.Size = new Size(100, 23);
            textTelefono.TabIndex = 5;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(284, 288);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Email";
            textEmail.Size = new Size(100, 23);
            textEmail.TabIndex = 6;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(565, 351);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(75, 23);
            btnRegistro.TabIndex = 7;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += BtnRegistro_Click;
            // 
            // textContraseñaProvisional
            // 
            textContraseñaProvisional.Location = new Point(284, 326);
            textContraseñaProvisional.Name = "textContraseñaProvisional";
            textContraseñaProvisional.PlaceholderText = "Contraseña provisional";
            textContraseñaProvisional.Size = new Size(137, 23);
            textContraseñaProvisional.TabIndex = 8;
            // 
            // FrmRegistroEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textContraseñaProvisional);
            Controls.Add(btnRegistro);
            Controls.Add(textEmail);
            Controls.Add(textTelefono);
            Controls.Add(textDireccion);
            Controls.Add(textDni);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(label1);
            Name = "FrmRegistroEstudiante";
            Text = "FrmRegistroEstudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textDni;
        private TextBox textDireccion;
        private TextBox textTelefono;
        private TextBox textEmail;
        private Button btnRegistro;
        private TextBox textContraseñaProvisional;
    }
}