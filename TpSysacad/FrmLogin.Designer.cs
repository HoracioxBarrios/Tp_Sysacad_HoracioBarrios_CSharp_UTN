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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            label2 = new Label();
            BtnLogin = new Button();
            textUsuario = new TextBox();
            textContraseña = new TextBox();
            btnAutoCompleUser = new Button();
            btnAutoCompleAlumno = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(190, 26);
            label1.Name = "label1";
            label1.Size = new Size(417, 37);
            label1.TabIndex = 0;
            label1.Text = "Universidad Tecnológica Nacional";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(293, 81);
            label2.Name = "label2";
            label2.Size = new Size(217, 21);
            label2.TabIndex = 1;
            label2.Text = "Sistema Académico SYSACAD";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = SystemColors.MenuHighlight;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.ForeColor = Color.Snow;
            BtnLogin.Location = new Point(351, 374);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(81, 23);
            BtnLogin.TabIndex = 2;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // textUsuario
            // 
            textUsuario.Cursor = Cursors.Hand;
            textUsuario.ForeColor = Color.DimGray;
            textUsuario.Location = new Point(334, 286);
            textUsuario.Name = "textUsuario";
            textUsuario.PlaceholderText = "Usuario";
            textUsuario.Size = new Size(112, 23);
            textUsuario.TabIndex = 3;
            textUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // textContraseña
            // 
            textContraseña.Cursor = Cursors.Hand;
            textContraseña.ForeColor = Color.DimGray;
            textContraseña.Location = new Point(334, 324);
            textContraseña.Name = "textContraseña";
            textContraseña.PasswordChar = '*';
            textContraseña.PlaceholderText = "Contraseña";
            textContraseña.Size = new Size(112, 23);
            textContraseña.TabIndex = 4;
            textContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAutoCompleUser
            // 
            btnAutoCompleUser.BackColor = Color.Azure;
            btnAutoCompleUser.Cursor = Cursors.Hand;
            btnAutoCompleUser.FlatAppearance.BorderSize = 0;
            btnAutoCompleUser.FlatStyle = FlatStyle.Flat;
            btnAutoCompleUser.ForeColor = Color.Red;
            btnAutoCompleUser.Location = new Point(12, 388);
            btnAutoCompleUser.Name = "btnAutoCompleUser";
            btnAutoCompleUser.Size = new Size(170, 23);
            btnAutoCompleUser.TabIndex = 5;
            btnAutoCompleUser.Text = "AutoCompleAdmininstrador";
            btnAutoCompleUser.UseVisualStyleBackColor = false;
            btnAutoCompleUser.Click += btnAutoCompleAdm_Click;
            // 
            // btnAutoCompleAlumno
            // 
            btnAutoCompleAlumno.BackColor = Color.Azure;
            btnAutoCompleAlumno.Cursor = Cursors.Hand;
            btnAutoCompleAlumno.FlatAppearance.BorderSize = 0;
            btnAutoCompleAlumno.FlatStyle = FlatStyle.Flat;
            btnAutoCompleAlumno.ForeColor = Color.DodgerBlue;
            btnAutoCompleAlumno.Location = new Point(12, 428);
            btnAutoCompleAlumno.Name = "btnAutoCompleAlumno";
            btnAutoCompleAlumno.Size = new Size(170, 23);
            btnAutoCompleAlumno.TabIndex = 6;
            btnAutoCompleAlumno.Text = "AutoCompleEstudiante";
            btnAutoCompleAlumno.UseVisualStyleBackColor = false;
            btnAutoCompleAlumno.Click += btnAutoCompleAlumno_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(661, 348);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 103);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(pictureBox1);
            Controls.Add(btnAutoCompleAlumno);
            Controls.Add(btnAutoCompleUser);
            Controls.Add(textContraseña);
            Controls.Add(textUsuario);
            Controls.Add(BtnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "FrmLogin";
            Text = "Sistema Academico Sysacad ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnLogin;
        private TextBox textUsuario;
        private TextBox textContraseña;
        private Button btnAutoCompleUser;
        private Button btnAutoCompleAlumno;
        private PictureBox pictureBox1;
    }
}