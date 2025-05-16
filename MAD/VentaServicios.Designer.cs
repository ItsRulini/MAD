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
            id = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            dgvCarritoServicio = new DataGridView();
            servicioCarrito = new DataGridViewTextBoxColumn();
            costo = new DataGridViewTextBoxColumn();
            eliminar = new DataGridViewImageColumn();
            idSerCarrito = new DataGridViewTextBoxColumn();
            textNumReserva = new TextBox();
            label3 = new Label();
            textHotel = new TextBox();
            btnAggServicio = new Button();
            btnComprarServicio = new Button();
            btnBuscarReservacion = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            precioTotal = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarritoServicio).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox2.Location = new Point(920, 30);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 137);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // dgvServicio
            // 
            dgvServicio.AllowUserToAddRows = false;
            dgvServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicio.Columns.AddRange(new DataGridViewColumn[] { Servicio, CostoServicio, id });
            dgvServicio.Location = new Point(22, 164);
            dgvServicio.Name = "dgvServicio";
            dgvServicio.RowHeadersWidth = 51;
            dgvServicio.Size = new Size(275, 250);
            dgvServicio.TabIndex = 27;
            // 
            // Servicio
            // 
            Servicio.Frozen = true;
            Servicio.HeaderText = "Servicio";
            Servicio.MinimumWidth = 6;
            Servicio.Name = "Servicio";
            Servicio.Width = 125;
            // 
            // CostoServicio
            // 
            CostoServicio.Frozen = true;
            CostoServicio.HeaderText = "Costo";
            CostoServicio.MinimumWidth = 6;
            CostoServicio.Name = "CostoServicio";
            CostoServicio.Width = 125;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 126);
            label1.Name = "label1";
            label1.Size = new Size(92, 22);
            label1.TabIndex = 28;
            label1.Text = "Servicios:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 50);
            label2.Name = "label2";
            label2.Size = new Size(60, 22);
            label2.TabIndex = 29;
            label2.Text = "Hotel:";
            // 
            // dgvCarritoServicio
            // 
            dgvCarritoServicio.AllowUserToAddRows = false;
            dgvCarritoServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarritoServicio.Columns.AddRange(new DataGridViewColumn[] { servicioCarrito, costo, eliminar, idSerCarrito });
            dgvCarritoServicio.Location = new Point(329, 164);
            dgvCarritoServicio.Name = "dgvCarritoServicio";
            dgvCarritoServicio.RowHeadersWidth = 51;
            dgvCarritoServicio.Size = new Size(476, 250);
            dgvCarritoServicio.TabIndex = 31;
            dgvCarritoServicio.CellContentClick += dgvCarritoServicio_CellContentClick;
            // 
            // servicioCarrito
            // 
            servicioCarrito.Frozen = true;
            servicioCarrito.HeaderText = "Servicio";
            servicioCarrito.MinimumWidth = 6;
            servicioCarrito.Name = "servicioCarrito";
            servicioCarrito.Width = 175;
            // 
            // costo
            // 
            costo.Frozen = true;
            costo.HeaderText = "Costo";
            costo.MinimumWidth = 6;
            costo.Name = "costo";
            costo.Width = 125;
            // 
            // eliminar
            // 
            eliminar.Frozen = true;
            eliminar.HeaderText = "Eliminar";
            eliminar.Image = Properties.Resources.basura;
            eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            eliminar.MinimumWidth = 6;
            eliminar.Name = "eliminar";
            eliminar.Resizable = DataGridViewTriState.True;
            eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            eliminar.Width = 125;
            // 
            // idSerCarrito
            // 
            idSerCarrito.HeaderText = "id";
            idSerCarrito.MinimumWidth = 6;
            idSerCarrito.Name = "idSerCarrito";
            idSerCarrito.Width = 125;
            // 
            // textNumReserva
            // 
            textNumReserva.Location = new Point(341, 84);
            textNumReserva.Name = "textNumReserva";
            textNumReserva.Size = new Size(154, 30);
            textNumReserva.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 50);
            label3.Name = "label3";
            label3.Size = new Size(202, 22);
            label3.TabIndex = 33;
            label3.Text = "Número de reservación:";
            // 
            // textHotel
            // 
            textHotel.Enabled = false;
            textHotel.Location = new Point(34, 84);
            textHotel.Name = "textHotel";
            textHotel.Size = new Size(249, 30);
            textHotel.TabIndex = 34;
            // 
            // btnAggServicio
            // 
            btnAggServicio.Location = new Point(835, 361);
            btnAggServicio.Name = "btnAggServicio";
            btnAggServicio.Size = new Size(108, 53);
            btnAggServicio.TabIndex = 35;
            btnAggServicio.Text = "Agregar servicio";
            btnAggServicio.UseVisualStyleBackColor = true;
            btnAggServicio.Click += btnAggServicio_Click;
            // 
            // btnComprarServicio
            // 
            btnComprarServicio.Location = new Point(949, 361);
            btnComprarServicio.Name = "btnComprarServicio";
            btnComprarServicio.Size = new Size(108, 53);
            btnComprarServicio.TabIndex = 36;
            btnComprarServicio.Text = "Finalizar compra";
            btnComprarServicio.UseVisualStyleBackColor = true;
            btnComprarServicio.Click += btnComprarServicio_Click;
            // 
            // btnBuscarReservacion
            // 
            btnBuscarReservacion.Location = new Point(536, 83);
            btnBuscarReservacion.Name = "btnBuscarReservacion";
            btnBuscarReservacion.Size = new Size(75, 27);
            btnBuscarReservacion.TabIndex = 37;
            btnBuscarReservacion.Text = "Buscar";
            btnBuscarReservacion.UseVisualStyleBackColor = true;
            btnBuscarReservacion.Click += btnBuscarReservacion_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 126);
            label4.Name = "label4";
            label4.Size = new Size(73, 22);
            label4.TabIndex = 38;
            label4.Text = "Carrito:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(precioTotal);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnComprarServicio);
            groupBox1.Controls.Add(btnAggServicio);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(dgvCarritoServicio);
            groupBox1.Controls.Add(dgvServicio);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1063, 420);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Venta de servicios:";
            // 
            // precioTotal
            // 
            precioTotal.AutoSize = true;
            precioTotal.Location = new Point(920, 292);
            precioTotal.Name = "precioTotal";
            precioTotal.Size = new Size(85, 22);
            precioTotal.TabIndex = 28;
            precioTotal.Text = "$ 0 MXN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(835, 292);
            label5.Name = "label5";
            label5.Size = new Size(57, 22);
            label5.TabIndex = 27;
            label5.Text = "Total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 139);
            label6.Name = "label6";
            label6.Size = new Size(407, 22);
            label6.TabIndex = 37;
            label6.Text = "Seleccione la primer celda (la que está en blanco)";
            // 
            // VentaServicios
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1087, 444);
            Controls.Add(label4);
            Controls.Add(btnBuscarReservacion);
            Controls.Add(textHotel);
            Controls.Add(label3);
            Controls.Add(textNumReserva);
            Controls.Add(label2);
            Controls.Add(label1);
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
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private DataGridView dgvServicio;
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
        private Label precioTotal;
        private Label label5;
        private DataGridViewTextBoxColumn Servicio;
        private DataGridViewTextBoxColumn CostoServicio;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn servicioCarrito;
        private DataGridViewTextBoxColumn costo;
        private DataGridViewImageColumn eliminar;
        private DataGridViewTextBoxColumn idSerCarrito;
        private Label label6;
    }
}