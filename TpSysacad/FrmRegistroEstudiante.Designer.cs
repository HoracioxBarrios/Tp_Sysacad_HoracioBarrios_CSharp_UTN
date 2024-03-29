﻿namespace Formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroEstudiante));
            label1 = new Label();
            textNombre = new TextBox();
            textApellido = new TextBox();
            textDni = new TextBox();
            textDireccion = new TextBox();
            textTelefono = new TextBox();
            textEmail = new TextBox();
            btnRegistro = new Button();
            RbtnCambiarcontrasenia = new RadioButton();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(332, 38);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "Registro Estudiante";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(355, 91);
            textNombre.Name = "textNombre";
            textNombre.PlaceholderText = "Nombre";
            textNombre.Size = new Size(118, 23);
            textNombre.TabIndex = 1;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(355, 139);
            textApellido.Name = "textApellido";
            textApellido.PlaceholderText = "Apellido";
            textApellido.Size = new Size(118, 23);
            textApellido.TabIndex = 2;
            // 
            // textDni
            // 
            textDni.Location = new Point(355, 187);
            textDni.Name = "textDni";
            textDni.PlaceholderText = "DNI";
            textDni.Size = new Size(118, 23);
            textDni.TabIndex = 3;
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(355, 241);
            textDireccion.Name = "textDireccion";
            textDireccion.PlaceholderText = "Direccion";
            textDireccion.Size = new Size(118, 23);
            textDireccion.TabIndex = 4;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(355, 291);
            textTelefono.Name = "textTelefono";
            textTelefono.PlaceholderText = "Telefono";
            textTelefono.Size = new Size(118, 23);
            textTelefono.TabIndex = 5;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(355, 338);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Email";
            textEmail.Size = new Size(118, 23);
            textEmail.TabIndex = 6;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.DarkOrange;
            btnRegistro.Cursor = Cursors.Hand;
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.ForeColor = Color.Black;
            btnRegistro.Location = new Point(563, 382);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(75, 23);
            btnRegistro.TabIndex = 7;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += BtnRegistro_Click;
            // 
            // RbtnCambiarcontrasenia
            // 
            RbtnCambiarcontrasenia.AutoSize = true;
            RbtnCambiarcontrasenia.ForeColor = SystemColors.HotTrack;
            RbtnCambiarcontrasenia.Location = new Point(535, 342);
            RbtnCambiarcontrasenia.Name = "RbtnCambiarcontrasenia";
            RbtnCambiarcontrasenia.Size = new Size(122, 19);
            RbtnCambiarcontrasenia.TabIndex = 9;
            RbtnCambiarcontrasenia.TabStop = true;
            RbtnCambiarcontrasenia.Text = "Cambiar Contraña";
            RbtnCambiarcontrasenia.UseVisualStyleBackColor = true;
            RbtnCambiarcontrasenia.CheckedChanged += RbtnCambiarcontrasenia_CheckedChanged;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Crimson;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(151, 382);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(118, 23);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmRegistroEstudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(btnVolver);
            Controls.Add(RbtnCambiarcontrasenia);
            Controls.Add(btnRegistro);
            Controls.Add(textEmail);
            Controls.Add(textTelefono);
            Controls.Add(textDireccion);
            Controls.Add(textDni);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmRegistroEstudiante";
            Text = "Registro de Estudiante";
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
        private RadioButton RbtnCambiarcontrasenia;
        private Button btnVolver;
    }
}