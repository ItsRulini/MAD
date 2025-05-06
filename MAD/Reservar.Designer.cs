
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
            label4 = new Label();
            textDetallesHab = new TextBox();
            label5 = new Label();
            btnAggCarrito = new Button();
            btnComprarReserva = new Button();
            dtpDesde = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            dtpHasta = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            textAnticipo = new TextBox();
            comboMetodoPago = new ComboBox();
            groupBox1 = new GroupBox();
            numeroPersonas = new NumericUpDown();
            label10 = new Label();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            checkBuscarPorApellido = new CheckBox();
            btnBusqueda = new Button();
            comboCiudadReserva = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            textBox1 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            groupBox3 = new GroupBox();
            menuStrip1 = new MenuStrip();
            reservarToolStripMenuItem = new ToolStripMenuItem();
            venderToolStripMenuItem = new ToolStripMenuItem();
            checkInCheckOutToolStripMenuItem = new ToolStripMenuItem();
            facturarToolStripMenuItem = new ToolStripMenuItem();
            agregarClienteToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            modificarEliminarToolStripMenuItem = new ToolStripMenuItem();
            textBuscarCliente = new TextBox();
            btnBuscarFechas = new Button();
            label11 = new Label();
            comboCiudad = new ComboBox();
            label12 = new Label();
            checkBox1 = new CheckBox();
            Habitación = new DataGridViewTextBoxColumn();
            NumPersonas = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
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
            dgvCarritoReserva.Columns.AddRange(new DataGridViewColumn[] { Habitación, NumPersonas, Eliminar });
            dgvCarritoReserva.Location = new Point(652, 282);
            dgvCarritoReserva.Name = "dgvCarritoReserva";
            dgvCarritoReserva.RowHeadersWidth = 51;
            dgvCarritoReserva.Size = new Size(461, 365);
            dgvCarritoReserva.TabIndex = 14;
            dgvCarritoReserva.CellContentClick += dgvCarritoReserva_CellContentClick;
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
            dtpDesde.Location = new Point(14, 45);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(142, 30);
            dtpDesde.TabIndex = 20;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 0;
            // 
            // label7
            // 
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 0;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(200, 45);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(142, 30);
            dtpHasta.TabIndex = 23;
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
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
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
            groupBox2.Controls.Add(checkBuscarPorApellido);
            groupBox2.Controls.Add(btnBusqueda);
            groupBox2.Controls.Add(comboCiudadReserva);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(dtpHasta);
            groupBox2.Controls.Add(dtpDesde);
            groupBox2.Location = new Point(24, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(585, 227);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtro de busqueda:";
            // 
            // checkBuscarPorApellido
            // 
            checkBuscarPorApellido.AutoSize = true;
            checkBuscarPorApellido.Location = new Point(129, 190);
            checkBuscarPorApellido.Name = "checkBuscarPorApellido";
            checkBuscarPorApellido.Size = new Size(220, 26);
            checkBuscarPorApellido.TabIndex = 44;
            checkBuscarPorApellido.Text = "Busqueda por apellidos";
            checkBuscarPorApellido.UseVisualStyleBackColor = true;
            // 
            // btnBusqueda
            // 
            btnBusqueda.Location = new Point(14, 182);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(89, 37);
            btnBusqueda.TabIndex = 43;
            btnBusqueda.Text = "Buscar";
            btnBusqueda.UseVisualStyleBackColor = true;
            btnBusqueda.Click += btnBusqueda_Click;
            // 
            // comboCiudadReserva
            // 
            comboCiudadReserva.FormattingEnabled = true;
            comboCiudadReserva.Location = new Point(377, 44);
            comboCiudadReserva.Name = "comboCiudadReserva";
            comboCiudadReserva.Size = new Size(142, 30);
            comboCiudadReserva.TabIndex = 42;
            comboCiudadReserva.SelectedIndexChanged += comboCiudadReserva_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(377, 22);
            label16.Name = "label16";
            label16.Size = new Size(73, 22);
            label16.TabIndex = 41;
            label16.Text = "Ciudad:";
            label16.Click += label16_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(14, 92);
            label15.Name = "label15";
            label15.Size = new Size(200, 22);
            label15.TabIndex = 40;
            label15.Text = "RFC/Correo/Apellidos:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 30);
            textBox1.TabIndex = 39;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 23);
            label13.Name = "label13";
            label13.Size = new Size(66, 22);
            label13.TabIndex = 38;
            label13.Text = "Desde:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(200, 23);
            label14.Name = "label14";
            label14.Size = new Size(61, 22);
            label14.TabIndex = 0;
            label14.Text = "Hasta:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnComprarReserva);
            groupBox3.Location = new Point(632, 25);
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
            // textBuscarCliente
            // 
            textBuscarCliente.Location = new Point(0, 0);
            textBuscarCliente.Name = "textBuscarCliente";
            textBuscarCliente.Size = new Size(100, 27);
            textBuscarCliente.TabIndex = 0;
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
            // label11
            // 
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 0;
            // 
            // comboCiudad
            // 
            comboCiudad.Location = new Point(0, 0);
            comboCiudad.Name = "comboCiudad";
            comboCiudad.Size = new Size(121, 28);
            comboCiudad.TabIndex = 0;
            // 
            // label12
            // 
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(100, 23);
            label12.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(0, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 24);
            checkBox1.TabIndex = 0;
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
            NumPersonas.Width = 125;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.basura;
            Eliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            Eliminar.Width = 125;
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

        private void label16_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private DateTimePicker dtpHasta;
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
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private CheckBox checkBox1;
        private Label label12;
        private ComboBox comboCiudad;
        private Label label11;
        private Button btnBuscarFechas;
        private TextBox textBuscarCliente;
        private Label label7;
        private Label label6;
        private ComboBox comboCiudadReserva;
        private Label label16;
        private Label label15;
        private TextBox textBox1;
        private Label label13;
        private Label label14;
        private Button btnBusqueda;
        private CheckBox checkBuscarPorApellido;
        private DataGridViewTextBoxColumn Habitación;
        private DataGridViewTextBoxColumn NumPersonas;
        private DataGridViewImageColumn Eliminar;
    }
}