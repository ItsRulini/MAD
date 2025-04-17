namespace MAD
{
    partial class VentaServicios
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
            pictureBox2 = new PictureBox();
            dgvServicio = new DataGridView();
            Servicio = new DataGridViewTextBoxColumn();
            CostoServicio = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            dgvCarritoServicio = new DataGridView();
            textNumReserva = new TextBox();
            label3 = new Label();
            textHotel = new TextBox();
            btnAggServicio = new Button();
            btnComprarServicio = new Button();
            btnBuscarReservacion = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarritoServicio).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox2.Location = new Point(674, 26);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 137);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // dgvServicio
            // 
            dgvServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicio.Columns.AddRange(new DataGridViewColumn[] { Servicio, CostoServicio });
            dgvServicio.Location = new Point(34, 157);
            dgvServicio.Name = "dgvServicio";
            dgvServicio.Size = new Size(244, 225);
            dgvServicio.TabIndex = 27;
            // 
            // Servicio
            // 
            Servicio.HeaderText = "Servicio";
            Servicio.Name = "Servicio";
            // 
            // CostoServicio
            // 
            CostoServicio.HeaderText = "Costo";
            CostoServicio.Name = "CostoServicio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 126);
            label1.Name = "label1";
            label1.Size = new Size(67, 19);
            label1.TabIndex = 28;
            label1.Text = "Servicios:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 50);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 29;
            label2.Text = "Seleccione hotel:";
            // 
            // dgvCarritoServicio
            // 
            dgvCarritoServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarritoServicio.Location = new Point(341, 157);
            dgvCarritoServicio.Name = "dgvCarritoServicio";
            dgvCarritoServicio.Size = new Size(240, 225);
            dgvCarritoServicio.TabIndex = 31;
            // 
            // textNumReserva
            // 
            textNumReserva.Location = new Point(341, 84);
            textNumReserva.Name = "textNumReserva";
            textNumReserva.Size = new Size(154, 26);
            textNumReserva.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 50);
            label3.Name = "label3";
            label3.Size = new Size(154, 19);
            label3.TabIndex = 33;
            label3.Text = "Número de reservación:";
            // 
            // textHotel
            // 
            textHotel.Enabled = false;
            textHotel.Location = new Point(34, 84);
            textHotel.Name = "textHotel";
            textHotel.Size = new Size(154, 26);
            textHotel.TabIndex = 34;
            // 
            // btnAggServicio
            // 
            btnAggServicio.Location = new Point(593, 329);
            btnAggServicio.Name = "btnAggServicio";
            btnAggServicio.Size = new Size(108, 53);
            btnAggServicio.TabIndex = 35;
            btnAggServicio.Text = "Agregar servicio";
            btnAggServicio.UseVisualStyleBackColor = true;
            // 
            // btnComprarServicio
            // 
            btnComprarServicio.Location = new Point(707, 329);
            btnComprarServicio.Name = "btnComprarServicio";
            btnComprarServicio.Size = new Size(108, 53);
            btnComprarServicio.TabIndex = 36;
            btnComprarServicio.Text = "Finalizar compra";
            btnComprarServicio.UseVisualStyleBackColor = true;
            // 
            // btnBuscarReservacion
            // 
            btnBuscarReservacion.Location = new Point(536, 83);
            btnBuscarReservacion.Name = "btnBuscarReservacion";
            btnBuscarReservacion.Size = new Size(75, 27);
            btnBuscarReservacion.TabIndex = 37;
            btnBuscarReservacion.Text = "Buscar";
            btnBuscarReservacion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 126);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 38;
            label4.Text = "Carrito:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(823, 387);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Venta de servicios y amenidades:";
            // 
            // VentaServicios
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(847, 411);
            Controls.Add(label4);
            Controls.Add(btnBuscarReservacion);
            Controls.Add(btnComprarServicio);
            Controls.Add(btnAggServicio);
            Controls.Add(textHotel);
            Controls.Add(label3);
            Controls.Add(textNumReserva);
            Controls.Add(dgvCarritoServicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvServicio);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F);
            Margin = new Padding(4);
            Name = "VentaServicios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentaServicios";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarritoServicio).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private DataGridView dgvServicio;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn CostoServicio;
        private Label label1;
        private Label label2;
        private DataGridView dgvCarritoServicio;
        private TextBox textNumReserva;
        private Label label3;
        private TextBox textHotel;
        private Button btnAggServicio;
        private Button btnComprarServicio;
        private Button btnBuscarReservacion;
        private Label label4;
        private GroupBox groupBox1;
    }
}