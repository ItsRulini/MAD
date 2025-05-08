namespace MAD
{
    partial class ConfirmarReserva
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
            groupBox1 = new GroupBox();
            textNumeroReservacion = new TextBox();
            label1 = new Label();
            dgvReserva = new DataGridView();
            TipoHabitacion = new DataGridViewTextBoxColumn();
            NumeroHabitacion = new DataGridViewTextBoxColumn();
            CantidadHuespedes = new DataGridViewTextBoxColumn();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReserva).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textNumeroReservacion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvReserva);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 497);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de la reserva";
            // 
            // textNumeroReservacion
            // 
            textNumeroReservacion.Location = new Point(114, 35);
            textNumeroReservacion.Name = "textNumeroReservacion";
            textNumeroReservacion.ReadOnly = true;
            textNumeroReservacion.Size = new Size(323, 27);
            textNumeroReservacion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 2;
            label1.Text = "Reservación:";
            // 
            // dgvReserva
            // 
            dgvReserva.AllowUserToAddRows = false;
            dgvReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReserva.Columns.AddRange(new DataGridViewColumn[] { TipoHabitacion, NumeroHabitacion, CantidadHuespedes });
            dgvReserva.Location = new Point(6, 84);
            dgvReserva.Name = "dgvReserva";
            dgvReserva.RowHeadersWidth = 51;
            dgvReserva.Size = new Size(431, 352);
            dgvReserva.TabIndex = 1;
            // 
            // TipoHabitacion
            // 
            TipoHabitacion.HeaderText = "Habitación";
            TipoHabitacion.MinimumWidth = 6;
            TipoHabitacion.Name = "TipoHabitacion";
            TipoHabitacion.Width = 125;
            // 
            // NumeroHabitacion
            // 
            NumeroHabitacion.HeaderText = "Número de habitación";
            NumeroHabitacion.MinimumWidth = 6;
            NumeroHabitacion.Name = "NumeroHabitacion";
            NumeroHabitacion.Width = 125;
            // 
            // CantidadHuespedes
            // 
            CantidadHuespedes.HeaderText = "Huéspedes";
            CantidadHuespedes.MinimumWidth = 6;
            CantidadHuespedes.Name = "CantidadHuespedes";
            CantidadHuespedes.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(274, 442);
            button1.Name = "button1";
            button1.Size = new Size(176, 49);
            button1.TabIndex = 0;
            button1.Text = "Reservar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ConfirmarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 521);
            Controls.Add(groupBox1);
            Name = "ConfirmarReserva";
            Text = "ConfirmarReserva";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReserva).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Label label1;
        private DataGridView dgvReserva;
        private DataGridViewTextBoxColumn TipoHabitacion;
        private DataGridViewTextBoxColumn NumeroHabitacion;
        private DataGridViewTextBoxColumn CantidadHuespedes;
        private TextBox textNumeroReservacion;
    }
}