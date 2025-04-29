namespace MAD
{
    partial class Reservar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservar));
            pictureBox1 = new PictureBox();
            dgvHoteles = new DataGridView();
            Hotel = new DataGridViewTextBoxColumn();
            idHotel = new DataGridViewTextBoxColumn();
            label1 = new Label();
            comboHabitacion = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dgvCarritoReserva = new DataGridView();
            Habitación = new DataGridViewTextBoxColumn();
            NumPersonas = new DataGridViewTextBoxColumn();
            label4 = new Label();
            textDetallesHab = new TextBox();
            label5 = new Label();
            btnAggCarrito = new Button();
            btnComprarReserva = new Button();
            dtpDesde = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            dtpHasta = new DateTimePicker();
            btnBuscarFechas = new Button();
            label8 = new Label();
            label9 = new Label();
            textAnticipo = new TextBox();
            comboMetodoPago = new ComboBox();
            groupBox1 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            textBuscarCliente = new TextBox();
            numeroPersonas = new NumericUpDown();
            label10 = new Label();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            comboCiudad = new ComboBox();
            groupBox3 = new GroupBox();
            menuStrip1 = new MenuStrip();
            reservarToolStripMenuItem = new ToolStripMenuItem();
            venderToolStripMenuItem = new ToolStripMenuItem();
            checkInCheckOutToolStripMenuItem = new ToolStripMenuItem();
            facturarToolStripMenuItem = new ToolStripMenuItem();
            agregarClienteToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            modificarEliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoteles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarritoReserva).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeroPersonas).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(1009, 30);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // dgvHoteles
            // 
            dgvHoteles.AllowUserToResizeColumns = false;
            dgvHoteles.AllowUserToResizeRows = false;
            dgvHoteles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoteles.Columns.AddRange(new DataGridViewColumn[] { Hotel, idHotel });
            dgvHoteles.Location = new Point(24, 282);
            dgvHoteles.Name = "dgvHoteles";
            dgvHoteles.RowHeadersWidth = 51;
            dgvHoteles.Size = new Size(293, 365);
            dgvHoteles.TabIndex = 8;
            dgvHoteles.CellContentClick += dgvHoteles_CellContentClick;
            // 
            // Hotel
            // 
            Hotel.HeaderText = "Hotel";
            Hotel.MinimumWidth = 6;
            Hotel.Name = "Hotel";
            Hotel.Width = 250;
            // 
            // idHotel
            // 
            idHotel.HeaderText = "ID";
            idHotel.MinimumWidth = 6;
            idHotel.Name = "idHotel";
            idHotel.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 260);
            label1.Name = "label1";
            label1.Size = new Size(174, 22);
            label1.TabIndex = 9;
            label1.Text = "Hoteles disponibles:";
            // 
            // comboHabitacion
            // 
            comboHabitacion.FormattingEnabled = true;
            comboHabitacion.Location = new Point(401, 282);
            comboHabitacion.Name = "comboHabitacion";
            comboHabitacion.Size = new Size(170, 30);
            comboHabitacion.TabIndex = 10;
            comboHabitacion.SelectedIndexChanged += comboHabitacion_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 260);
            label2.Name = "label2";
            label2.Size = new Size(190, 22);
            label2.TabIndex = 11;
            label2.Text = "Seleccione habitación:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 326);
            label3.Name = "label3";
            label3.Size = new Size(179, 22);
            label3.TabIndex = 12;
            label3.Text = "Número de personas:";
            // 
            // dgvCarritoReserva
            // 
            dgvCarritoReserva.AllowUserToResizeColumns = false;
            dgvCarritoReserva.AllowUserToResizeRows = false;
            dgvCarritoReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarritoReserva.Columns.AddRange(new DataGridViewColumn[] { Habitación, NumPersonas });
            dgvCarritoReserva.Location = new Point(652, 282);
            dgvCarritoReserva.Name = "dgvCarritoReserva";
            dgvCarritoReserva.RowHeadersWidth = 51;
            dgvCarritoReserva.Size = new Size(461, 365);
            dgvCarritoReserva.TabIndex = 14;
            dgvCarritoReserva.CellContentClick += dgvCarritoReserva_CellContentClick;
            // 
            // Habitación
            // 
            Habitación.HeaderText = "Habitacion";
            Habitación.MinimumWidth = 6;
            Habitación.Name = "Habitación";
            Habitación.Width = 200;
            // 
            // NumPersonas
            // 
            NumPersonas.HeaderText = "Numero de personas";
            NumPersonas.MinimumWidth = 6;
            NumPersonas.Name = "NumPersonas";
            NumPersonas.Width = 200;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(652, 260);
            label4.Name = "label4";
            label4.Size = new Size(73, 22);
            label4.TabIndex = 15;
            label4.Text = "Carrito:";
            // 
            // textDetallesHab
            // 
            textDetallesHab.Location = new Point(358, 426);
            textDetallesHab.Multiline = true;
            textDetallesHab.Name = "textDetallesHab";
            textDetallesHab.Size = new Size(251, 160);
            textDetallesHab.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(372, 397);
            label5.Name = "label5";
            label5.Size = new Size(213, 22);
            label5.TabIndex = 17;
            label5.Text = "Detalles de la habitación:";
            label5.Click += label5_Click;
            // 
            // btnAggCarrito
            // 
            btnAggCarrito.Location = new Point(401, 598);
            btnAggCarrito.Name = "btnAggCarrito";
            btnAggCarrito.Size = new Size(170, 49);
            btnAggCarrito.TabIndex = 18;
            btnAggCarrito.Text = "Añadir al carrito";
            btnAggCarrito.UseVisualStyleBackColor = true;
            btnAggCarrito.Click += btnAggCarrito_Click;
            // 
            // btnComprarReserva
            // 
            btnComprarReserva.Location = new Point(104, 183);
            btnComprarReserva.Name = "btnComprarReserva";
            btnComprarReserva.Size = new Size(153, 39);
            btnComprarReserva.TabIndex = 19;
            btnComprarReserva.Text = "Finalizar compra";
            btnComprarReserva.UseVisualStyleBackColor = true;
            btnComprarReserva.Click += btnComprarReserva_Click;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(41, 78);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(142, 30);
            dtpDesde.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(66, 22);
            label6.TabIndex = 21;
            label6.Text = "Desde:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(170, 23);
            label7.Name = "label7";
            label7.Size = new Size(61, 22);
            label7.TabIndex = 22;
            label7.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(205, 78);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(142, 30);
            dtpHasta.TabIndex = 23;
            // 
            // btnBuscarFechas
            // 
            btnBuscarFechas.Location = new Point(282, 121);
            btnBuscarFechas.Name = "btnBuscarFechas";
            btnBuscarFechas.Size = new Size(124, 33);
            btnBuscarFechas.TabIndex = 24;
            btnBuscarFechas.Text = "Buscar";
            btnBuscarFechas.UseVisualStyleBackColor = true;
            btnBuscarFechas.Click += btnBuscarFechas_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(652, 122);
            label8.Name = "label8";
            label8.Size = new Size(144, 22);
            label8.TabIndex = 25;
            label8.Text = "Método de pago:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(815, 122);
            label9.Name = "label9";
            label9.Size = new Size(85, 22);
            label9.TabIndex = 26;
            label9.Text = "Anticipo:";
            // 
            // textAnticipo
            // 
            textAnticipo.Location = new Point(815, 144);
            textAnticipo.Name = "textAnticipo";
            textAnticipo.Size = new Size(139, 30);
            textAnticipo.TabIndex = 28;
            // 
            // comboMetodoPago
            // 
            comboMetodoPago.FormattingEnabled = true;
            comboMetodoPago.Location = new Point(652, 144);
            comboMetodoPago.Name = "comboMetodoPago";
            comboMetodoPago.Size = new Size(139, 30);
            comboMetodoPago.TabIndex = 29;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBuscarCliente);
            groupBox1.Controls.Add(numeroPersonas);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboMetodoPago);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textAnticipo);
            groupBox1.Controls.Add(dgvCarritoReserva);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dgvHoteles);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboHabitacion);
            groupBox1.Controls.Add(dtpHasta);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpDesde);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textDetallesHab);
            groupBox1.Controls.Add(btnAggCarrito);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1152, 665);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reservar";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(41, 123);
            label12.Name = "label12";
            label12.Size = new Size(67, 22);
            label12.TabIndex = 35;
            label12.Text = "Ciudad";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(395, 54);
            label11.Name = "label11";
            label11.Size = new Size(150, 22);
            label11.TabIndex = 34;
            label11.Text = "Datos del cliente:";
            // 
            // textBuscarCliente
            // 
            textBuscarCliente.Location = new Point(395, 81);
            textBuscarCliente.Name = "textBuscarCliente";
            textBuscarCliente.Size = new Size(155, 30);
            textBuscarCliente.TabIndex = 33;
            // 
            // numeroPersonas
            // 
            numeroPersonas.Location = new Point(401, 355);
            numeroPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numeroPersonas.Name = "numeroPersonas";
            numeroPersonas.Size = new Size(179, 30);
            numeroPersonas.TabIndex = 32;
            numeroPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(652, 50);
            label10.Name = "label10";
            label10.Size = new Size(73, 22);
            label10.TabIndex = 31;
            label10.Text = "Cliente:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(652, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 30);
            comboBox1.TabIndex = 30;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboCiudad);
            groupBox2.Controls.Add(btnBuscarFechas);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(35, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(545, 177);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtro de hoteles";
            // 
            // comboCiudad
            // 
            comboCiudad.FormattingEnabled = true;
            comboCiudad.Location = new Point(6, 124);
            comboCiudad.Name = "comboCiudad";
            comboCiudad.Size = new Size(151, 30);
            comboCiudad.TabIndex = 25;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnComprarReserva);
            groupBox3.Location = new Point(628, 29);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(355, 228);
            groupBox3.TabIndex = 37;
            groupBox3.TabStop = false;
            groupBox3.Text = "Proceder a la compra";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { reservarToolStripMenuItem, venderToolStripMenuItem, checkInCheckOutToolStripMenuItem, facturarToolStripMenuItem, agregarClienteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1176, 30);
            menuStrip1.TabIndex = 31;
            menuStrip1.Text = "menuStrip1";
            // 
            // reservarToolStripMenuItem
            // 
            reservarToolStripMenuItem.Name = "reservarToolStripMenuItem";
            reservarToolStripMenuItem.Size = new Size(96, 26);
            reservarToolStripMenuItem.Text = "Reservar";
            reservarToolStripMenuItem.Click += reservarToolStripMenuItem_Click;
            // 
            // venderToolStripMenuItem
            // 
            venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            venderToolStripMenuItem.Size = new Size(149, 26);
            venderToolStripMenuItem.Text = "Vender servicio";
            venderToolStripMenuItem.Click += venderToolStripMenuItem_Click;
            // 
            // checkInCheckOutToolStripMenuItem
            // 
            checkInCheckOutToolStripMenuItem.Name = "checkInCheckOutToolStripMenuItem";
            checkInCheckOutToolStripMenuItem.Size = new Size(181, 26);
            checkInCheckOutToolStripMenuItem.Text = "Check In/Check Out";
            checkInCheckOutToolStripMenuItem.Click += checkInCheckOutToolStripMenuItem_Click;
            // 
            // facturarToolStripMenuItem
            // 
            facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            facturarToolStripMenuItem.Size = new Size(90, 26);
            facturarToolStripMenuItem.Text = "Facturar";
            facturarToolStripMenuItem.Click += facturarToolStripMenuItem_Click;
            // 
            // agregarClienteToolStripMenuItem
            // 
            agregarClienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, modificarEliminarToolStripMenuItem });
            agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            agregarClienteToolStripMenuItem.Size = new Size(81, 26);
            agregarClienteToolStripMenuItem.Text = "Cliente";
            agregarClienteToolStripMenuItem.Click += agregarClienteToolStripMenuItem_Click;
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(249, 26);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // modificarEliminarToolStripMenuItem
            // 
            modificarEliminarToolStripMenuItem.Name = "modificarEliminarToolStripMenuItem";
            modificarEliminarToolStripMenuItem.Size = new Size(249, 26);
            modificarEliminarToolStripMenuItem.Text = "Modificar/Eliminar";
            modificarEliminarToolStripMenuItem.Click += modificarEliminarToolStripMenuItem_Click;
            // 
            // Reservar
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1176, 710);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Reservar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoteles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarritoReserva).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeroPersonas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgvHoteles;
        private Label label1;
        private ComboBox comboHabitacion;
        private Label label2;
        private Label label3;
        private DataGridView dgvCarritoReserva;
        private Label label4;
        private TextBox textDetallesHab;
        private Label label5;
        private Button btnAggCarrito;
        private Button btnComprarReserva;
        private DateTimePicker dtpDesde;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpHasta;
        private Button btnBuscarFechas;
        private Label label8;
        private Label label9;
        private TextBox textAnticipo;
        private ComboBox comboMetodoPago;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem reservarToolStripMenuItem;
        private Label label10;
        private ComboBox comboBox1;
        private ToolStripMenuItem venderToolStripMenuItem;
        private ToolStripMenuItem checkInCheckOutToolStripMenuItem;
        private ToolStripMenuItem facturarToolStripMenuItem;
        private ToolStripMenuItem agregarClienteToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem modificarEliminarToolStripMenuItem;
        private NumericUpDown numeroPersonas;
        private DataGridViewTextBoxColumn Hotel;
        private DataGridViewTextBoxColumn idHotel;
        private Label label11;
        private TextBox textBuscarCliente;
        private Label label12;
        private GroupBox groupBox2;
        private ComboBox comboCiudad;
        private GroupBox groupBox3;
        private DataGridViewTextBoxColumn Habitación;
        private DataGridViewTextBoxColumn NumPersonas;
    }
}