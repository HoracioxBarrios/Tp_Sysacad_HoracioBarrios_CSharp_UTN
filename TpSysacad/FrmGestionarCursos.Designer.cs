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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarCursos));
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
            dataGridViewCursos.BackgroundColor = SystemColors.Highlight;
            dataGridViewCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCursos.Columns.AddRange(new DataGridViewColumn[] { codigo, curso, descripcion, cuposDisponibles, cupoMaximo });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewCursos.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCursos.Location = new Point(82, 88);
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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(351, 33);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 5;
            label1.Text = "Lista de cursos";
            label1.Click += label1_Click;
            // 
            // btnInscripcion
            // 
            btnInscripcion.BackColor = Color.DarkGreen;
            btnInscripcion.Cursor = Cursors.Hand;
            btnInscripcion.FlatAppearance.BorderSize = 0;
            btnInscripcion.FlatStyle = FlatStyle.Flat;
            btnInscripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscripcion.ForeColor = Color.White;
            btnInscripcion.Location = new Point(93, 337);
            btnInscripcion.Margin = new Padding(2);
            btnInscripcion.Name = "btnInscripcion";
            btnInscripcion.Size = new Size(118, 23);
            btnInscripcion.TabIndex = 7;
            btnInscripcion.Text = "inscripcion";
            btnInscripcion.UseVisualStyleBackColor = false;
            btnInscripcion.Click += btnInscripcion_Click;
            // 
            // BtnEditarCursos
            // 
            BtnEditarCursos.BackColor = SystemColors.MenuHighlight;
            BtnEditarCursos.Cursor = Cursors.Hand;
            BtnEditarCursos.FlatAppearance.BorderSize = 0;
            BtnEditarCursos.FlatStyle = FlatStyle.Flat;
            BtnEditarCursos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEditarCursos.ForeColor = Color.White;
            BtnEditarCursos.Location = new Point(351, 340);
            BtnEditarCursos.Name = "BtnEditarCursos";
            BtnEditarCursos.Size = new Size(118, 23);
            BtnEditarCursos.TabIndex = 8;
            BtnEditarCursos.Text = "Editar Curso";
            BtnEditarCursos.UseVisualStyleBackColor = false;
            BtnEditarCursos.Click += BtnEditarCursos_Click;
            // 
            // BtnEliminarCursos
            // 
            BtnEliminarCursos.BackColor = Color.Red;
            BtnEliminarCursos.Cursor = Cursors.Hand;
            BtnEliminarCursos.FlatAppearance.BorderSize = 0;
            BtnEliminarCursos.FlatStyle = FlatStyle.Flat;
            BtnEliminarCursos.ForeColor = Color.White;
            BtnEliminarCursos.Location = new Point(604, 340);
            BtnEliminarCursos.Name = "BtnEliminarCursos";
            BtnEliminarCursos.Size = new Size(118, 23);
            BtnEliminarCursos.TabIndex = 9;
            BtnEliminarCursos.Text = "Eliminar curso";
            BtnEliminarCursos.UseVisualStyleBackColor = false;
            BtnEliminarCursos.Click += BtnEliminarCursos_Click;
            // 
            // BtnAgregarCurso
            // 
            BtnAgregarCurso.BackColor = Color.DarkGreen;
            BtnAgregarCurso.Cursor = Cursors.Hand;
            BtnAgregarCurso.FlatAppearance.BorderSize = 0;
            BtnAgregarCurso.FlatStyle = FlatStyle.Flat;
            BtnAgregarCurso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAgregarCurso.ForeColor = Color.White;
            BtnAgregarCurso.Location = new Point(93, 337);
            BtnAgregarCurso.Name = "BtnAgregarCurso";
            BtnAgregarCurso.Size = new Size(118, 23);
            BtnAgregarCurso.TabIndex = 10;
            BtnAgregarCurso.Text = "Agregar Curso";
            BtnAgregarCurso.UseVisualStyleBackColor = false;
            BtnAgregarCurso.Click += BtnAgregarCurso_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Crimson;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(110, 408);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(77, 23);
            btnVolver.TabIndex = 11;
            btnVolver.TabStop = false;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmGestionarCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(btnVolver);
            Controls.Add(BtnAgregarCurso);
            Controls.Add(BtnEliminarCursos);
            Controls.Add(BtnEditarCursos);
            Controls.Add(btnInscripcion);
            Controls.Add(label1);
            Controls.Add(dataGridViewCursos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmGestionarCursos";
            Text = "Gestionar Curso";
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