namespace Formularios
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            BtnLogin = new Button();
            textUsuario = new TextBox();
            textContraseña = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(417, 37);
            label1.TabIndex = 0;
            label1.Text = "Universidad Tecnológica Nacional";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(235, 56);
            label2.Name = "label2";
            label2.Size = new Size(217, 21);
            label2.TabIndex = 1;
            label2.Text = "Sistema Académico SYSACAD";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(273, 301);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 23);
            BtnLogin.TabIndex = 2;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // textUsuario
            // 
            textUsuario.Location = new Point(260, 154);
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "Usuario";
            textUsuario.Size = new Size(100, 23);
            textUsuario.TabIndex = 3;
            // 
            // textContraseña
            // 
            textContraseña.Location = new Point(260, 222);
            textContraseña.Name = "textContraseña";
            textContraseña.PasswordChar = '*';
            textContraseña.PlaceholderText = "Contraseña";
            textContraseña.Size = new Size(100, 23);
            textContraseña.TabIndex = 4;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textContraseña);
            Controls.Add(textUsuario);
            Controls.Add(BtnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "Sysacad Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnLogin;
        private TextBox textUsuario;
        private TextBox textContraseña;
    }
}