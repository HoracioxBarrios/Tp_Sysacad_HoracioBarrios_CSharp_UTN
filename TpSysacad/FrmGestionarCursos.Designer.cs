namespace Formularios
{
    partial class FrmGestionarCursos
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
            BtnAgregarCurso = new Button();
            BtnEditarCursos = new Button();
            BtnEliminarCursos = new Button();
            listBoxCursos = new ListBox();
            label1 = new Label();
            labelResultado = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // BtnAgregarCurso
            // 
            BtnAgregarCurso.Location = new Point(61, 659);
            BtnAgregarCurso.Margin = new Padding(4, 5, 4, 5);
            BtnAgregarCurso.Name = "BtnAgregarCurso";
            BtnAgregarCurso.Size = new Size(181, 39);
            BtnAgregarCurso.TabIndex = 0;
            BtnAgregarCurso.Text = "Agregar Curso";
            BtnAgregarCurso.UseVisualStyleBackColor = true;
            BtnAgregarCurso.Click += BtnAgregarCurso_Click;
            // 
            // BtnEditarCursos
            // 
            BtnEditarCursos.Location = new Point(469, 659);
            BtnEditarCursos.Margin = new Padding(4, 5, 4, 5);
            BtnEditarCursos.Name = "BtnEditarCursos";
            BtnEditarCursos.Size = new Size(169, 39);
            BtnEditarCursos.TabIndex = 1;
            BtnEditarCursos.Text = "Editar Curso";
            BtnEditarCursos.UseVisualStyleBackColor = true;
            BtnEditarCursos.Click += BtnEditarCursos_Click;
            // 
            // BtnEliminarCursos
            // 
            BtnEliminarCursos.Location = new Point(826, 659);
            BtnEliminarCursos.Margin = new Padding(4, 5, 4, 5);
            BtnEliminarCursos.Name = "BtnEliminarCursos";
            BtnEliminarCursos.Size = new Size(132, 39);
            BtnEliminarCursos.TabIndex = 2;
            BtnEliminarCursos.Text = "Eliminar curso";
            BtnEliminarCursos.UseVisualStyleBackColor = true;
            BtnEliminarCursos.Click += BtnEliminarCursos_Click;
            // 
            // listBoxCursos
            // 
            listBoxCursos.FormattingEnabled = true;
            listBoxCursos.ItemHeight = 25;
            listBoxCursos.Location = new Point(78, 146);
            listBoxCursos.Margin = new Padding(4, 5, 4, 5);
            listBoxCursos.Name = "listBoxCursos";
            listBoxCursos.Size = new Size(899, 454);
            listBoxCursos.TabIndex = 3;
            listBoxCursos.SelectedIndexChanged += listBoxCursos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(358, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 32);
            label1.TabIndex = 4;
            label1.Text = "Lista de cursos";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(78, 90);
            labelResultado.Margin = new Padding(4, 0, 4, 0);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(132, 25);
            labelResultado.TabIndex = 5;
            labelResultado.Text = "seleccione algo";
            // 
            // button1
            // 
            button1.Location = new Point(61, 656);
            button1.Name = "button1";
            button1.Size = new Size(181, 42);
            button1.TabIndex = 6;
            button1.Text = "inscripcion";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmGestionarCursos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 750);
            Controls.Add(button1);
            Controls.Add(labelResultado);
            Controls.Add(label1);
            Controls.Add(listBoxCursos);
            Controls.Add(BtnEliminarCursos);
            Controls.Add(BtnEditarCursos);
            Controls.Add(BtnAgregarCurso);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmGestionarCursos";
            Text = "Sistemas de Gestion de Cursos";
            Load += FrmGestionarCursos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAgregarCurso;
        private Button BtnEditarCursos;
        private Button BtnEliminarCursos;
        private ListBox listBoxCursos;
        private Label label1;
        private Label labelResultado;
        private Button button1;
    }
}