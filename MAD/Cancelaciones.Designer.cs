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
            fechaFin = new Label();
            label5 = new Label();
            fechaInicio = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnBuscarReservacion = new Button();
            btnCancelarReservacion = new Button();
            groupBox2 = new GroupBox();
            dgvDetallesReserva = new DataGridView();
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
            groupBox1.Controls.Add(fechaFin);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(fechaInicio);
            groupBox1.Controls.Add(label3);
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
            groupBox1.Size = new Size(600, 394);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión de cancelaciones";
            // 
            // fechaFin
            // 
            fechaFin.AutoSize = true;
            fechaFin.Location = new Point(148, 146);
            fechaFin.Name = "fechaFin";
            fechaFin.Size = new Size(52, 22);
            fechaFin.TabIndex = 15;
            fechaFin.Text = "0/0/0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 146);
            label5.Name = "label5";
            label5.Size = new Size(89, 22);
            label5.TabIndex = 14;
            label5.Text = "Fecha fin:";
            // 
            // fechaInicio
            // 
            fechaInicio.AutoSize = true;
            fechaInicio.Location = new Point(148, 114);
            fechaInicio.Name = "fechaInicio";
            fechaInicio.Size = new Size(52, 22);
            fechaInicio.TabIndex = 13;
            fechaInicio.Text = "0/0/0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 114);
            label3.Name = "label3";
            label3.Size = new Size(114, 22);
            label3.TabIndex = 12;
            label3.Text = "Fecha inicio:";
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
            btnBuscarReservacion.Location = new Point(419, 310);
            btnBuscarReservacion.Name = "btnBuscarReservacion";
            btnBuscarReservacion.Size = new Size(175, 36);
            btnBuscarReservacion.TabIndex = 3;
            btnBuscarReservacion.Text = "Buscar reservación";
            btnBuscarReservacion.UseVisualStyleBackColor = true;
            btnBuscarReservacion.Click += btnBuscarReservacion_Click;
            // 
            // btnCancelarReservacion
            // 
            btnCancelarReservacion.Location = new Point(419, 352);
            btnCancelarReservacion.Name = "btnCancelarReservacion";
            btnCancelarReservacion.Size = new Size(175, 36);
            btnCancelarReservacion.TabIndex = 4;
            btnCancelarReservacion.Text = "Cancelar reservación";
            btnCancelarReservacion.UseVisualStyleBackColor = true;
            btnCancelarReservacion.Click += btnCancelarReservacion_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDetallesReserva);
            groupBox2.Location = new Point(6, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(399, 205);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalles de la reserva:";
            // 
            // dgvDetallesReserva
            // 
            dgvDetallesReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesReserva.Location = new Point(10, 34);
            dgvDetallesReserva.Name = "dgvDetallesReserva";
            dgvDetallesReserva.RowHeadersWidth = 51;
            dgvDetallesReserva.Size = new Size(383, 150);
            dgvDetallesReserva.TabIndex = 6;
            // 
            // textHotel
            // 
            textHotel.Enabled = false;
            textHotel.Location = new Point(251, 60);
            textHotel.Name = "textHotel";
            textHotel.Size = new Size(154, 30);
            textHotel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 35);
            label2.Name = "label2";
            label2.Size = new Size(60, 22);
            label2.TabIndex = 2;
            label2.Text = "Hotel:";
            // 
            // textNumReservacion
            // 
            textNumReservacion.Location = new Point(15, 60);
            textNumReservacion.Name = "textNumReservacion";
            textNumReservacion.Size = new Size(193, 30);
            textNumReservacion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(202, 22);
            label1.TabIndex = 0;
            label1.Text = "Número de reservación:";
            // 
            // Cancelaciones
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(624, 418);
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
        private TextBox textHotel;
        private Label label2;
        private TextBox textNumReservacion;
        private Label label1;
        private Button btnCancelarReservacion;
        private Button btnBuscarReservacion;
        private PictureBox pictureBox1;
        private Label fechaFin;
        private Label label5;
        private Label fechaInicio;
        private Label label3;
    }
}