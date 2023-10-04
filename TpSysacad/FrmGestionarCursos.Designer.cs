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
            btnInscripcion = new Button();
            SuspendLayout();
            // 
            // BtnAgregarCurso
            // 
            BtnAgregarCurso.Location = new Point(43, 395);
            BtnAgregarCurso.Name = "BtnAgregarCurso";
            BtnAgregarCurso.Size = new Size(127, 23);
            BtnAgregarCurso.TabIndex = 0;
            BtnAgregarCurso.Text = "Agregar Curso";
            BtnAgregarCurso.UseVisualStyleBackColor = true;
            BtnAgregarCurso.Click += BtnAgregarCurso_Click;
            // 
            // BtnEditarCursos
            // 
            BtnEditarCursos.Location = new Point(328, 395);
            BtnEditarCursos.Name = "BtnEditarCursos";
            BtnEditarCursos.Size = new Size(118, 23);
            BtnEditarCursos.TabIndex = 1;
            BtnEditarCursos.Text = "Editar Curso";
            BtnEditarCursos.UseVisualStyleBackColor = true;
            BtnEditarCursos.Click += BtnEditarCursos_Click;
            // 
            // BtnEliminarCursos
            // 
            BtnEliminarCursos.Location = new Point(578, 395);
            BtnEliminarCursos.Name = "BtnEliminarCursos";
            BtnEliminarCursos.Size = new Size(93, 23);
            BtnEliminarCursos.TabIndex = 2;
            BtnEliminarCursos.Text = "Eliminar curso";
            BtnEliminarCursos.UseVisualStyleBackColor = true;
            BtnEliminarCursos.Click += BtnEliminarCursos_Click;
            // 
            // listBoxCursos
            // 
            listBoxCursos.FormattingEnabled = true;
            listBoxCursos.ItemHeight = 15;
            listBoxCursos.Location = new Point(54, 88);
            listBoxCursos.Name = "listBoxCursos";
            listBoxCursos.Size = new Size(630, 274);
            listBoxCursos.TabIndex = 3;
            listBoxCursos.SelectedIndexChanged += listBoxCursos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 4;
            label1.Text = "Lista de cursos";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(54, 54);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(88, 15);
            labelResultado.TabIndex = 5;
            labelResultado.Text = "seleccione algo";
            // 
            // btnInscripcion
            // 
            btnInscripcion.Location = new Point(43, 394);
            btnInscripcion.Margin = new Padding(2);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(127, 26);
            btnInscripcion.TabIndex = 6;
            btnInscripcion.Text = "inscripcion";
            btnInscripcion.UseVisualStyleBackColor = true;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // FrmGestionarCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInscripcion);
            Controls.Add(labelResultado);
            Controls.Add(label1);
            Controls.Add(listBoxCursos);
            Controls.Add(BtnEliminarCursos);
            Controls.Add(BtnEditarCursos);
            Controls.Add(BtnAgregarCurso);
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
        private Button btnInscripcion;
    }
}