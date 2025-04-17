namespace MAD
{
    partial class HistorialCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialCliente));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label1 = new Label();
            dgvHistCliente = new DataGridView();
            Cliente = new DataGridViewTextBoxColumn();
            Ciudad = new DataGridViewTextBoxColumn();
            Hotel = new DataGridViewTextBoxColumn();
            TipoHabit = new DataGridViewTextBoxColumn();
            NumHabitacion = new DataGridViewTextBoxColumn();
            NumHospedados = new DataGridViewTextBoxColumn();
            CodReserv = new DataGridViewTextBoxColumn();
            FechReservacion = new DataGridViewTextBoxColumn();
            CheckIn = new DataGridViewTextBoxColumn();
            CheckOut = new DataGridViewTextBoxColumn();
            EstatusReservacion = new DataGridViewTextBoxColumn();
            Anticipo = new DataGridViewTextBoxColumn();
            MontoHospedaje = new DataGridViewTextBoxColumn();
            MontoServAdicionales = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistCliente).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvHistCliente);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1357, 546);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historial de cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(1203, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(378, 72);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 5;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 38);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 4;
            label2.Text = "Año:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(266, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(60, 26);
            dateTimePicker1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 26);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 38);
            label1.Name = "label1";
            label1.Size = new Size(215, 19);
            label1.TabIndex = 1;
            label1.Text = "RFC/Correo/Apellidos del cliente:";
            // 
            // dgvHistCliente
            // 
            dgvHistCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistCliente.Columns.AddRange(new DataGridViewColumn[] { Cliente, Ciudad, Hotel, TipoHabit, NumHabitacion, NumHospedados, CodReserv, FechReservacion, CheckIn, CheckOut, EstatusReservacion, Anticipo, MontoHospedaje, MontoServAdicionales, Total });
            dgvHistCliente.Location = new Point(6, 130);
            dgvHistCliente.Name = "dgvHistCliente";
            dgvHistCliente.Size = new Size(1334, 400);
            dgvHistCliente.TabIndex = 0;
            // 
            // Cliente
            // 
            Cliente.Frozen = true;
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            Cliente.Width = 76;
            // 
            // Ciudad
            // 
            Ciudad.Frozen = true;
            Ciudad.HeaderText = "Ciudad";
            Ciudad.Name = "Ciudad";
            Ciudad.ReadOnly = true;
            Ciudad.Width = 78;
            // 
            // Hotel
            // 
            Hotel.Frozen = true;
            Hotel.HeaderText = "Hotel";
            Hotel.Name = "Hotel";
            Hotel.ReadOnly = true;
            Hotel.Width = 67;
            // 
            // TipoHabit
            // 
            TipoHabit.Frozen = true;
            TipoHabit.HeaderText = "Tipo dde habitación";
            TipoHabit.Name = "TipoHabit";
            TipoHabit.ReadOnly = true;
            // 
            // NumHabitacion
            // 
            NumHabitacion.Frozen = true;
            NumHabitacion.HeaderText = "# Habitación";
            NumHabitacion.Name = "NumHabitacion";
            NumHabitacion.ReadOnly = true;
            NumHabitacion.Width = 75;
            // 
            // NumHospedados
            // 
            NumHospedados.Frozen = true;
            NumHospedados.HeaderText = "# Hospedados";
            NumHospedados.Name = "NumHospedados";
            NumHospedados.ReadOnly = true;
            NumHospedados.Width = 75;
            // 
            // CodReserv
            // 
            CodReserv.Frozen = true;
            CodReserv.HeaderText = "Codigo de reservación";
            CodReserv.Name = "CodReserv";
            CodReserv.ReadOnly = true;
            // 
            // FechReservacion
            // 
            FechReservacion.Frozen = true;
            FechReservacion.HeaderText = "Fecha de reservación";
            FechReservacion.Name = "FechReservacion";
            FechReservacion.ReadOnly = true;
            FechReservacion.Width = 90;
            // 
            // CheckIn
            // 
            CheckIn.Frozen = true;
            CheckIn.HeaderText = "CheckIn";
            CheckIn.Name = "CheckIn";
            CheckIn.ReadOnly = true;
            CheckIn.Width = 80;
            // 
            // CheckOut
            // 
            CheckOut.Frozen = true;
            CheckOut.HeaderText = "CheckOut";
            CheckOut.Name = "CheckOut";
            CheckOut.ReadOnly = true;
            CheckOut.Width = 90;
            // 
            // EstatusReservacion
            // 
            EstatusReservacion.Frozen = true;
            EstatusReservacion.HeaderText = "Estatus de reservación";
            EstatusReservacion.Name = "EstatusReservacion";
            EstatusReservacion.ReadOnly = true;
            // 
            // Anticipo
            // 
            Anticipo.Frozen = true;
            Anticipo.HeaderText = "Anticipo";
            Anticipo.Name = "Anticipo";
            Anticipo.ReadOnly = true;
            Anticipo.Width = 85;
            // 
            // MontoHospedaje
            // 
            MontoHospedaje.Frozen = true;
            MontoHospedaje.HeaderText = "Monto Hospedaje";
            MontoHospedaje.Name = "MontoHospedaje";
            MontoHospedaje.ReadOnly = true;
            // 
            // MontoServAdicionales
            // 
            MontoServAdicionales.Frozen = true;
            MontoServAdicionales.HeaderText = "Monto por servicios";
            MontoServAdicionales.Name = "MontoServAdicionales";
            MontoServAdicionales.ReadOnly = true;
            // 
            // Total
            // 
            Total.Frozen = true;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 75;
            // 
            // HistorialCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1381, 570);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "HistorialCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HistorialCliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvHistCliente;
        private Button button1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Ciudad;
        private DataGridViewTextBoxColumn Hotel;
        private DataGridViewTextBoxColumn TipoHabit;
        private DataGridViewTextBoxColumn NumHabitacion;
        private DataGridViewTextBoxColumn NumHospedados;
        private DataGridViewTextBoxColumn CodReserv;
        private DataGridViewTextBoxColumn FechReservacion;
        private DataGridViewTextBoxColumn CheckIn;
        private DataGridViewTextBoxColumn CheckOut;
        private DataGridViewTextBoxColumn EstatusReservacion;
        private DataGridViewTextBoxColumn Anticipo;
        private DataGridViewTextBoxColumn MontoHospedaje;
        private DataGridViewTextBoxColumn MontoServAdicionales;
        private DataGridViewTextBoxColumn Total;
    }
}