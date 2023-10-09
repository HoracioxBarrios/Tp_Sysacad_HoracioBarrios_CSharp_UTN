namespace Formularios
{
    partial class FrmPanelUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPanelUsuario));
            btnRegistrarEstudiante = new Button();
            btnGestionarCursos = new Button();
            label2 = new Label();
            btnInscripcionCurso = new Button();
            btnConsultarHorario = new Button();
            btnRealizarPagos = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnRegistrarEstudiante
            // 
            btnRegistrarEstudiante.BackColor = Color.OrangeRed;
            btnRegistrarEstudiante.Cursor = Cursors.Hand;
            btnRegistrarEstudiante.FlatAppearance.BorderSize = 0;
            btnRegistrarEstudiante.FlatStyle = FlatStyle.Flat;
            btnRegistrarEstudiante.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarEstudiante.ForeColor = Color.White;
            btnRegistrarEstudiante.Location = new Point(337, 156);
            btnRegistrarEstudiante.Margin = new Padding(2);
            btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            btnRegistrarEstudiante.Size = new Size(150, 25);
            btnRegistrarEstudiante.TabIndex = 0;
            btnRegistrarEstudiante.Text = "Registrar Estudiante";
            btnRegistrarEstudiante.UseVisualStyleBackColor = false;
            btnRegistrarEstudiante.Click += button1_Click;
            // 
            // btnGestionarCursos
            // 
            btnGestionarCursos.BackColor = Color.OrangeRed;
            btnGestionarCursos.Cursor = Cursors.Hand;
            btnGestionarCursos.FlatAppearance.BorderSize = 0;
            btnGestionarCursos.FlatStyle = FlatStyle.Flat;
            btnGestionarCursos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionarCursos.ForeColor = Color.White;
            btnGestionarCursos.Location = new Point(337, 262);
            btnGestionarCursos.Margin = new Padding(2);
            btnGestionarCursos.Name = "btnGestionarCursos";
            btnGestionarCursos.Size = new Size(150, 25);
            btnGestionarCursos.TabIndex = 1;
            btnGestionarCursos.Text = "Gestionar Curso";
            btnGestionarCursos.UseVisualStyleBackColor = false;
            btnGestionarCursos.Click += BtnGestionarCursos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(333, 39);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 2;
            label2.Text = "Panel de Usuario";
            // 
            // btnInscripcionCurso
            // 
            btnInscripcionCurso.BackColor = Color.Crimson;
            btnInscripcionCurso.Cursor = Cursors.Hand;
            btnInscripcionCurso.FlatAppearance.BorderSize = 0;
            btnInscripcionCurso.FlatStyle = FlatStyle.Flat;
            btnInscripcionCurso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInscripcionCurso.ForeColor = Color.White;
            btnInscripcionCurso.Location = new Point(337, 102);
            btnInscripcionCurso.Margin = new Padding(2);
            btnInscripcionCurso.Name = "btnInscripcionCurso";
            btnInscripcionCurso.Size = new Size(150, 25);
            btnInscripcionCurso.TabIndex = 3;
            btnInscripcionCurso.Text = "Inscripcion a cursos";
            btnInscripcionCurso.UseVisualStyleBackColor = false;
            btnInscripcionCurso.Click += button2_Click;
            // 
            // btnConsultarHorario
            // 
            btnConsultarHorario.BackColor = Color.Crimson;
            btnConsultarHorario.Cursor = Cursors.Hand;
            btnConsultarHorario.FlatAppearance.BorderSize = 0;
            btnConsultarHorario.FlatStyle = FlatStyle.Flat;
            btnConsultarHorario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultarHorario.ForeColor = Color.White;
            btnConsultarHorario.Location = new Point(337, 206);
            btnConsultarHorario.Margin = new Padding(2);
            btnConsultarHorario.Name = "btnConsultarHorario";
            btnConsultarHorario.Size = new Size(150, 25);
            btnConsultarHorario.TabIndex = 4;
            btnConsultarHorario.Text = "Consultar Horario";
            btnConsultarHorario.UseVisualStyleBackColor = false;
            btnConsultarHorario.Click += button3_Click;
            // 
            // btnRealizarPagos
            // 
            btnRealizarPagos.BackColor = Color.Crimson;
            btnRealizarPagos.Cursor = Cursors.Hand;
            btnRealizarPagos.FlatAppearance.BorderSize = 0;
            btnRealizarPagos.FlatStyle = FlatStyle.Flat;
            btnRealizarPagos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRealizarPagos.ForeColor = Color.White;
            btnRealizarPagos.Location = new Point(337, 316);
            btnRealizarPagos.Margin = new Padding(2);
            btnRealizarPagos.Name = "btnRealizarPagos";
            btnRealizarPagos.Size = new Size(150, 25);
            btnRealizarPagos.TabIndex = 5;
            btnRealizarPagos.Text = "Realizar Pagos";
            btnRealizarPagos.UseVisualStyleBackColor = false;
            btnRealizarPagos.Click += button4_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Crimson;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(362, 383);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 25);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPanelUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(btnSalir);
            Controls.Add(btnRealizarPagos);
            Controls.Add(btnConsultarHorario);
            Controls.Add(btnInscripcionCurso);
            Controls.Add(label2);
            Controls.Add(btnGestionarCursos);
            Controls.Add(btnRegistrarEstudiante);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FormPanelUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel de Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarEstudiante;
        private Button btnGestionarCursos;
        private Label label2;
        private Button btnInscripcionCurso;
        private Button btnConsultarHorario;
        private Button btnRealizarPagos;
        private Button btnSalir;
    }
}