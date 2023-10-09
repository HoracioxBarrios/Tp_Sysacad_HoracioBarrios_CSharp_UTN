namespace Formularios
{
    partial class FormConsultarHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultarHorario));
            dataGridViewHorario = new DataGridView();
            dias = new DataGridViewTextBoxColumn();
            turnoManiana = new DataGridViewTextBoxColumn();
            turnoTarde = new DataGridViewTextBoxColumn();
            turnoNoche = new DataGridViewTextBoxColumn();
            labelHorario = new Label();
            label1 = new Label();
            labelHorarioVacio = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorario).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHorario
            // 
            dataGridViewHorario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewHorario.BackgroundColor = SystemColors.Highlight;
            dataGridViewHorario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHorario.Columns.AddRange(new DataGridViewColumn[] { dias, turnoManiana, turnoTarde, turnoNoche });
            dataGridViewHorario.GridColor = SystemColors.ControlDarkDark;
            dataGridViewHorario.Location = new Point(50, 78);
            dataGridViewHorario.Margin = new Padding(3, 2, 3, 2);
            dataGridViewHorario.Name = "dataGridViewHorario";
            dataGridViewHorario.RowHeadersWidth = 51;
            dataGridViewHorario.RowTemplate.Height = 29;
            dataGridViewHorario.Size = new Size(688, 313);
            dataGridViewHorario.TabIndex = 0;
            dataGridViewHorario.CellContentClick += dataGridViewHorario_CellContentClick;
            // 
            // dias
            // 
            dias.HeaderText = "Materia";
            dias.MinimumWidth = 6;
            dias.Name = "dias";
            dias.ReadOnly = true;
            dias.Width = 125;
            // 
            // turnoManiana
            // 
            turnoManiana.HeaderText = "Turno";
            turnoManiana.MinimumWidth = 6;
            turnoManiana.Name = "turnoManiana";
            turnoManiana.ReadOnly = true;
            turnoManiana.Width = 170;
            // 
            // turnoTarde
            // 
            turnoTarde.HeaderText = "Día";
            turnoTarde.MinimumWidth = 6;
            turnoTarde.Name = "turnoTarde";
            turnoTarde.ReadOnly = true;
            turnoTarde.Width = 170;
            // 
            // turnoNoche
            // 
            turnoNoche.HeaderText = "Aula";
            turnoNoche.MinimumWidth = 6;
            turnoNoche.Name = "turnoNoche";
            turnoNoche.ReadOnly = true;
            turnoNoche.Width = 170;
            // 
            // labelHorario
            // 
            labelHorario.AutoSize = true;
            labelHorario.BackColor = Color.Transparent;
            labelHorario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelHorario.ForeColor = Color.Crimson;
            labelHorario.Location = new Point(325, 40);
            labelHorario.Name = "labelHorario";
            labelHorario.Size = new Size(157, 25);
            labelHorario.TabIndex = 1;
            labelHorario.Text = "Horario de clases";
            labelHorario.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 50);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // labelHorarioVacio
            // 
            labelHorarioVacio.AutoSize = true;
            labelHorarioVacio.BackColor = Color.OrangeRed;
            labelHorarioVacio.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelHorarioVacio.ForeColor = Color.White;
            labelHorarioVacio.Location = new Point(158, 195);
            labelHorarioVacio.Name = "labelHorarioVacio";
            labelHorarioVacio.Size = new Size(482, 25);
            labelHorarioVacio.TabIndex = 3;
            labelHorarioVacio.Text = "No estás inscrito en ningún curso. Tu horario está vacío.";
            labelHorarioVacio.TextAlign = ContentAlignment.MiddleCenter;
            labelHorarioVacio.Click += labelHorarioVacio_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Crimson;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(363, 396);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(105, 23);
            btnVolver.TabIndex = 12;
            btnVolver.TabStop = false;
            btnVolver.Text = "Volver";
            btnVolver.TextAlign = ContentAlignment.BottomCenter;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormConsultarHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 461);
            Controls.Add(btnVolver);
            Controls.Add(labelHorarioVacio);
            Controls.Add(label1);
            Controls.Add(labelHorario);
            Controls.Add(dataGridViewHorario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormConsultarHorario";
            Text = "Consultar Horarios";
            Load += FormConsultarHorario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewHorario;
        private Label labelHorario;
        private Label label1;
        private Label labelHorarioVacio;
        private DataGridViewTextBoxColumn dias;
        private DataGridViewTextBoxColumn turnoManiana;
        private DataGridViewTextBoxColumn turnoTarde;
        private DataGridViewTextBoxColumn turnoNoche;
        private Button btnVolver;
    }
}