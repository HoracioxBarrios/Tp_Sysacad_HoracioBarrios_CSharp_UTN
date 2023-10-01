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
            SuspendLayout();
            // 
            // BtnAgregarCurso
            // 
            BtnAgregarCurso.Location = new Point(49, 527);
            BtnAgregarCurso.Margin = new Padding(3, 4, 3, 4);
            BtnAgregarCurso.Name = "BtnAgregarCurso";
            BtnAgregarCurso.Size = new Size(145, 31);
            BtnAgregarCurso.TabIndex = 0;
            BtnAgregarCurso.Text = "Agregar Curso";
            BtnAgregarCurso.UseVisualStyleBackColor = true;
            BtnAgregarCurso.Click += BtnAgregarCurso_Click;
            // 
            // BtnEditarCursos
            // 
            BtnEditarCursos.Location = new Point(375, 527);
            BtnEditarCursos.Margin = new Padding(3, 4, 3, 4);
            BtnEditarCursos.Name = "BtnEditarCursos";
            BtnEditarCursos.Size = new Size(135, 31);
            BtnEditarCursos.TabIndex = 1;
            BtnEditarCursos.Text = "Editar Curso";
            BtnEditarCursos.UseVisualStyleBackColor = true;
            BtnEditarCursos.Click += BtnEditarCursos_Click;
            // 
            // BtnEliminarCursos
            // 
            BtnEliminarCursos.Location = new Point(661, 527);
            BtnEliminarCursos.Margin = new Padding(3, 4, 3, 4);
            BtnEliminarCursos.Name = "BtnEliminarCursos";
            BtnEliminarCursos.Size = new Size(106, 31);
            BtnEliminarCursos.TabIndex = 2;
            BtnEliminarCursos.Text = "Eliminar curso";
            BtnEliminarCursos.UseVisualStyleBackColor = true;
            BtnEliminarCursos.Click += BtnEliminarCursos_Click;
            // 
            // listBoxCursos
            // 
            listBoxCursos.FormattingEnabled = true;
            listBoxCursos.ItemHeight = 20;
            listBoxCursos.Location = new Point(62, 117);
            listBoxCursos.Margin = new Padding(3, 4, 3, 4);
            listBoxCursos.Name = "listBoxCursos";
            listBoxCursos.Size = new Size(720, 364);
            listBoxCursos.TabIndex = 3;
            listBoxCursos.SelectedIndexChanged += listBoxCursos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(286, 12);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 4;
            label1.Text = "Lista de cursos";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(62, 72);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(112, 20);
            labelResultado.TabIndex = 5;
            labelResultado.Text = "seleccione algo";
            // 
            // FrmGestionarCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(labelResultado);
            Controls.Add(label1);
            Controls.Add(listBoxCursos);
            Controls.Add(BtnEliminarCursos);
            Controls.Add(BtnEditarCursos);
            Controls.Add(BtnAgregarCurso);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}