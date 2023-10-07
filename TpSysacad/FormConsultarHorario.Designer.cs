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
            dataGridViewHorario = new DataGridView();
            labelHorario = new Label();
            label1 = new Label();
            labelHorarioVacio = new Label();
            dias = new DataGridViewTextBoxColumn();
            turnoManiana = new DataGridViewTextBoxColumn();
            turnoTarde = new DataGridViewTextBoxColumn();
            turnoNoche = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHorario).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewHorario
            // 
            dataGridViewHorario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewHorario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHorario.Columns.AddRange(new DataGridViewColumn[] { dias, turnoManiana, turnoTarde, turnoNoche });
            dataGridViewHorario.GridColor = SystemColors.ControlDarkDark;
            dataGridViewHorario.Location = new Point(34, 101);
            dataGridViewHorario.Name = "dataGridViewHorario";
            dataGridViewHorario.RowHeadersWidth = 51;
            dataGridViewHorario.RowTemplate.Height = 29;
            dataGridViewHorario.Size = new Size(690, 254);
            dataGridViewHorario.TabIndex = 0;
            dataGridViewHorario.CellContentClick += dataGridViewHorario_CellContentClick;
            // 
            // labelHorario
            // 
            labelHorario.AutoSize = true;
            labelHorario.Location = new Point(316, 50);
            labelHorario.Name = "labelHorario";
            labelHorario.Size = new Size(124, 20);
            labelHorario.TabIndex = 1;
            labelHorario.Text = "Horario de clases";
            labelHorario.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 66);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // labelHorarioVacio
            // 
            labelHorarioVacio.AutoSize = true;
            labelHorarioVacio.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelHorarioVacio.Location = new Point(102, 219);
            labelHorarioVacio.Name = "labelHorarioVacio";
            labelHorarioVacio.Size = new Size(580, 31);
            labelHorarioVacio.TabIndex = 3;
            labelHorarioVacio.Text = "No estás inscrito en ningún curso. Tu horario está vacío.";
            labelHorarioVacio.TextAlign = ContentAlignment.MiddleCenter;
            labelHorarioVacio.Click += labelHorarioVacio_Click;
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
            // FormConsultarHorario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelHorarioVacio);
            Controls.Add(label1);
            Controls.Add(labelHorario);
            Controls.Add(dataGridViewHorario);
            Name = "FormConsultarHorario";
            Text = "FormConsultarHorario";
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
    }
}