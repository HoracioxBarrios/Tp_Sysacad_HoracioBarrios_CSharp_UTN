namespace Formularios
{
    partial class FormPanelUsuario
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
            button1 = new Button();
            BtnGestionarCursos = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 106);
            button1.Name = "button1";
            button1.Size = new Size(186, 34);
            button1.TabIndex = 0;
            button1.Text = "Registrar Estudiante";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnGestionarCursos
            // 
            BtnGestionarCursos.Location = new Point(12, 213);
            BtnGestionarCursos.Name = "BtnGestionarCursos";
            BtnGestionarCursos.Size = new Size(186, 34);
            BtnGestionarCursos.TabIndex = 1;
            BtnGestionarCursos.Text = "Gestionar Curso";
            BtnGestionarCursos.UseVisualStyleBackColor = true;
            BtnGestionarCursos.Click += BtnGestionarCursos_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(368, 47);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 2;
            label2.Text = "Panel";
            // 
            // button2
            // 
            button2.Location = new Point(292, 106);
            button2.Name = "button2";
            button2.Size = new Size(186, 34);
            button2.TabIndex = 3;
            button2.Text = "Inscripcion a cursos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(292, 213);
            button3.Name = "button3";
            button3.Size = new Size(186, 34);
            button3.TabIndex = 4;
            button3.Text = "Consultar Horario";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormPanelUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnGestionarCursos);
            Controls.Add(button1);
            Name = "FormPanelUsuario";
            Text = "PanelUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button BtnGestionarCursos;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
    }
}