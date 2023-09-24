namespace TpSysacad
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(196, 22);
            label1.Name = "label1";
            label1.Size = new Size(228, 21);
            label1.TabIndex = 0;
            label1.Text = "administración de inscripciones";
            // 
            // button1
            // 
            button1.Location = new Point(158, 116);
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
            label2.Location = new Point(128, 255);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 2;
            label2.Text = "administador Nombre";
            // 
            // FrmPanelAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}