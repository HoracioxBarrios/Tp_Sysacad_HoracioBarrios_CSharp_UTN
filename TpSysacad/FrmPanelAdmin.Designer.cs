namespace Formularios
{
    partial class FrmPanelAdmin
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
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnGestionarCursos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(196, 22);
            label1.Name = "label1";
            label1.Size = new Size(230, 21);
            label1.TabIndex = 0;
            label1.Text = "Administración de Inscripciones";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(12, 77);
            button1.Name = "button1";
            button1.Size = new Size(151, 23);
            button1.TabIndex = 1;
            button1.Text = "Registrar Estudiante";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 343);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Administador:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(453, 318);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 3;
            label3.Text = "Panel de Administrador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(541, 343);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Nombre";
            // 
            // BtnGestionarCursos
            // 
            BtnGestionarCursos.Location = new Point(12, 151);
            BtnGestionarCursos.Name = "BtnGestionarCursos";
            BtnGestionarCursos.Size = new Size(151, 23);
            BtnGestionarCursos.TabIndex = 5;
            BtnGestionarCursos.Text = "Gestionar Cursos";
            BtnGestionarCursos.UseVisualStyleBackColor = true;
            BtnGestionarCursos.Click += BtnGestionarCursos_Click;
            // 
            // FrmPanelAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGestionarCursos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FrmPanelAdmin";
            Text = "PanelAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnGestionarCursos;
    }
}