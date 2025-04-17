namespace MAD
{
    partial class Cancelaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cancelaciones));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnBuscarReservacion = new Button();
            btnCancelarReservacion = new Button();
            groupBox2 = new GroupBox();
            dgvDetallesReserva = new DataGridView();
            HabReservadas = new DataGridViewTextBoxColumn();
            FechaEntrada = new DataGridViewTextBoxColumn();
            FechaSalida = new DataGridViewTextBoxColumn();
            textHotel = new TextBox();
            label2 = new Label();
            textNumReservacion = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesReserva).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnBuscarReservacion);
            groupBox1.Controls.Add(btnCancelarReservacion);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(textHotel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textNumReservacion);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 325);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión de cancelaciones";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(457, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnBuscarReservacion
            // 
            btnBuscarReservacion.Location = new Point(411, 220);
            btnBuscarReservacion.Name = "btnBuscarReservacion";
            btnBuscarReservacion.Size = new Size(175, 36);
            btnBuscarReservacion.TabIndex = 3;
            btnBuscarReservacion.Text = "Buscar reservación";
            btnBuscarReservacion.UseVisualStyleBackColor = true;
            // 
            // btnCancelarReservacion
            // 
            btnCancelarReservacion.Location = new Point(411, 262);
            btnCancelarReservacion.Name = "btnCancelarReservacion";
            btnCancelarReservacion.Size = new Size(175, 36);
            btnCancelarReservacion.TabIndex = 4;
            btnCancelarReservacion.Text = "Cancelar reservación";
            btnCancelarReservacion.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDetallesReserva);
            groupBox2.Location = new Point(6, 114);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(399, 205);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles de la reserva:";
            // 
            // dgvDetallesReserva
            // 
            dgvDetallesReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesReserva.Columns.AddRange(new DataGridViewColumn[] { HabReservadas, FechaEntrada, FechaSalida });
            dgvDetallesReserva.Location = new Point(34, 34);
            dgvDetallesReserva.Name = "dgvDetallesReserva";
            dgvDetallesReserva.Size = new Size(344, 150);
            dgvDetallesReserva.TabIndex = 6;
            // 
            // HabReservadas
            // 
            HabReservadas.Frozen = true;
            HabReservadas.HeaderText = "Habitaciones reservadas";
            HabReservadas.Name = "HabReservadas";
            HabReservadas.ReadOnly = true;
            // 
            // FechaEntrada
            // 
            FechaEntrada.Frozen = true;
            FechaEntrada.HeaderText = "Entrada";
            FechaEntrada.Name = "FechaEntrada";
            FechaEntrada.ReadOnly = true;
            // 
            // FechaSalida
            // 
            FechaSalida.Frozen = true;
            FechaSalida.HeaderText = "Salida";
            FechaSalida.Name = "FechaSalida";
            FechaSalida.ReadOnly = true;
            // 
            // textHotel
            // 
            textHotel.Enabled = false;
            textHotel.Location = new Point(206, 60);
            textHotel.Name = "textHotel";
            textHotel.Size = new Size(154, 26);
            textHotel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 38);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 2;
            label2.Text = "Hotel:";
            // 
            // textNumReservacion
            // 
            textNumReservacion.Location = new Point(15, 60);
            textNumReservacion.Name = "textNumReservacion";
            textNumReservacion.Size = new Size(154, 26);
            textNumReservacion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 38);
            label1.Name = "label1";
            label1.Size = new Size(154, 19);
            label1.TabIndex = 0;
            label1.Text = "Número de reservación:";
            // 
            // Cancelaciones
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(624, 349);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Cancelaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cancelaciones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetallesReserva).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvDetallesReserva;
        private DataGridViewTextBoxColumn HabReservadas;
        private DataGridViewTextBoxColumn FechaEntrada;
        private DataGridViewTextBoxColumn FechaSalida;
        private TextBox textHotel;
        private Label label2;
        private TextBox textNumReservacion;
        private Label label1;
        private Button btnCancelarReservacion;
        private Button btnBuscarReservacion;
        private PictureBox pictureBox1;
    }
}