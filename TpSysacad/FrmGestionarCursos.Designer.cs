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
            dataGridViewCursos = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            curso = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            cuposDisponibles = new DataGridViewTextBoxColumn();
            cupoMaximo = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnInscripcion = new Button();
            BtnEditarCursos = new Button();
            BtnEliminarCursos = new Button();
            BtnAgregarCurso = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCursos
            // 
            dataGridViewCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCursos.Columns.AddRange(new DataGridViewColumn[] { codigo, curso, descripcion, cuposDisponibles, cupoMaximo });
            dataGridViewCursos.Location = new Point(93, 88);
            dataGridViewCursos.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCursos.Name = "dataGridViewCursos";
            dataGridViewCursos.RowHeadersWidth = 51;
            dataGridViewCursos.RowTemplate.Height = 29;
            dataGridViewCursos.Size = new Size(633, 223);
            dataGridViewCursos.TabIndex = 0;
            dataGridViewCursos.CellContentClick += dataGridView1_CellContentClick;
            dataGridViewCursos.SelectionChanged += dataGridViewCursos_SelectionChanged;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 75;
            // 
            // curso
            // 
            curso.HeaderText = "Curso";
            curso.MinimumWidth = 6;
            curso.Name = "curso";
            curso.ReadOnly = true;
            curso.Width = 125;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripción";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            descripcion.Width = 155;
            // 
            // cuposDisponibles
            // 
            cuposDisponibles.HeaderText = "Cupos Disponibles";
            cuposDisponibles.MinimumWidth = 6;
            cuposDisponibles.Name = "cuposDisponibles";
            cuposDisponibles.ReadOnly = true;
            cuposDisponibles.Width = 165;
            // 
            // cupoMaximo
            // 
            cupoMaximo.HeaderText = "Cupo Máximo";
            cupoMaximo.MinimumWidth = 6;
            cupoMaximo.Name = "cupoMaximo";
            cupoMaximo.ReadOnly = true;
            cupoMaximo.Width = 155;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(339, 38);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 5;
            label1.Text = "Lista de cursos";
            label1.Click += label1_Click;
            // 
            // btnInscripcion
            // 
            btnInscripcion.Location = new Point(93, 337);
            btnInscripcion.Margin = new Padding(2, 2, 2, 2);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(127, 26);
            btnInscripcion.TabIndex = 7;
            btnInscripcion.Text = "inscripcion";
            btnInscripcion.UseVisualStyleBackColor = true;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // BtnEditarCursos
            // 
            BtnEditarCursos.Location = new Point(354, 340);
            BtnEditarCursos.Name = "BtnEditarCursos";
            BtnEditarCursos.Size = new Size(118, 23);
            BtnEditarCursos.TabIndex = 8;
            BtnEditarCursos.Text = "Editar Curso";
            BtnEditarCursos.UseVisualStyleBackColor = true;
            BtnEditarCursos.Click += BtnEditarCursos_Click;
            // 
            // BtnEliminarCursos
            // 
            BtnEliminarCursos.Location = new Point(633, 340);
            BtnEliminarCursos.Name = "BtnEliminarCursos";
            BtnEliminarCursos.Size = new Size(93, 23);
            BtnEliminarCursos.TabIndex = 9;
            BtnEliminarCursos.Text = "Eliminar curso";
            BtnEliminarCursos.UseVisualStyleBackColor = true;
            BtnEliminarCursos.Click += BtnEliminarCursos_Click;
            // 
            // BtnAgregarCurso
            // 
            BtnAgregarCurso.Location = new Point(93, 337);
            BtnAgregarCurso.Name = "BtnAgregarCurso";
            BtnAgregarCurso.Size = new Size(127, 23);
            BtnAgregarCurso.TabIndex = 10;
            BtnAgregarCurso.Text = "Agregar Curso";
            BtnAgregarCurso.UseVisualStyleBackColor = true;
            BtnAgregarCurso.Click += BtnAgregarCurso_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(93, 370);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(127, 23);
            btnVolver.TabIndex = 11;
            btnVolver.TabStop = false;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmGestionarCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 405);
            Controls.Add(btnVolver);
            Controls.Add(BtnAgregarCurso);
            Controls.Add(BtnEliminarCursos);
            Controls.Add(BtnEditarCursos);
            Controls.Add(btnInscripcion);
            Controls.Add(label1);
            Controls.Add(dataGridViewCursos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmGestionarCursos";
            Text = "FrmGestionarCurso";
            Load += FrmGestionarCurso_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCursos;
        private Label label1;
        private Button btnInscripcion;
        private Button BtnEditarCursos;
        private Button BtnEliminarCursos;
        private Button BtnAgregarCurso;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn curso;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn cuposDisponibles;
        private DataGridViewTextBoxColumn cupoMaximo;
        private Button btnVolver;
    }
}