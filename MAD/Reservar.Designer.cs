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
            label1 = new Label();
            comboHabitacion = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboNumPersonas = new ComboBox();
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
            label10 = new Label();
            comboBox1 = new ComboBox();
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(906, 30);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // dgvHoteles
            // 
            dgvHoteles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoteles.Columns.AddRange(new DataGridViewColumn[] { Hotel });
            dgvHoteles.Location = new Point(25, 140);
            dgvHoteles.Name = "dgvHoteles";
            dgvHoteles.Size = new Size(293, 365);
            dgvHoteles.TabIndex = 8;
            // 
            // Hotel
            // 
            Hotel.HeaderText = "Hotel";
            Hotel.Name = "Hotel";
            Hotel.Width = 250;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 118);
            label1.Name = "label1";
            label1.Size = new Size(129, 19);
            label1.TabIndex = 9;
            label1.Text = "Hoteles disponibles:";
            // 
            // comboHabitacion
            // 
            comboHabitacion.FormattingEnabled = true;
            comboHabitacion.Location = new Point(359, 140);
            comboHabitacion.Name = "comboHabitacion";
            comboHabitacion.Size = new Size(170, 27);
            comboHabitacion.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 118);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 11;
            label2.Text = "Seleccione habitación:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 184);
            label3.Name = "label3";
            label3.Size = new Size(139, 19);
            label3.TabIndex = 12;
            label3.Text = "Número de personas:";
            // 
            // comboNumPersonas
            // 
            comboNumPersonas.FormattingEnabled = true;
            comboNumPersonas.Location = new Point(359, 206);
            comboNumPersonas.Name = "comboNumPersonas";
            comboNumPersonas.Size = new Size(170, 27);
            comboNumPersonas.TabIndex = 13;
            // 
            // dgvCarritoReserva
            // 
            dgvCarritoReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarritoReserva.Columns.AddRange(new DataGridViewColumn[] { Habitación, NumPersonas });
            dgvCarritoReserva.Location = new Point(573, 140);
            dgvCarritoReserva.Name = "dgvCarritoReserva";
            dgvCarritoReserva.Size = new Size(256, 365);
            dgvCarritoReserva.TabIndex = 14;
            // 
            // Habitación
            // 
            Habitación.HeaderText = "Habitacion";
            Habitación.Name = "Habitación";
            // 
            // NumPersonas
            // 
            NumPersonas.HeaderText = "Numero de personas";
            NumPersonas.Name = "NumPersonas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(573, 118);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 15;
            label4.Text = "Carrito:";
            // 
            // textDetallesHab
            // 
            textDetallesHab.Location = new Point(359, 280);
            textDetallesHab.Multiline = true;
            textDetallesHab.Name = "textDetallesHab";
            textDetallesHab.Size = new Size(170, 160);
            textDetallesHab.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 258);
            label5.Name = "label5";
            label5.Size = new Size(158, 19);
            label5.TabIndex = 17;
            label5.Text = "Detalles de la habitación:";
            // 
            // btnAggCarrito
            // 
            btnAggCarrito.Location = new Point(394, 456);
            btnAggCarrito.Name = "btnAggCarrito";
            btnAggCarrito.Size = new Size(107, 49);
            btnAggCarrito.TabIndex = 18;
            btnAggCarrito.Text = "Añadir al carrito";
            btnAggCarrito.UseVisualStyleBackColor = true;
            // 
            // btnComprarReserva
            // 
            btnComprarReserva.Location = new Point(906, 456);
            btnComprarReserva.Name = "btnComprarReserva";
            btnComprarReserva.Size = new Size(107, 49);
            btnComprarReserva.TabIndex = 19;
            btnComprarReserva.Text = "Finalizar compra";
            btnComprarReserva.UseVisualStyleBackColor = true;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(12, 56);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(142, 26);
            dtpDesde.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 34);
            label6.Name = "label6";
            label6.Size = new Size(51, 19);
            label6.TabIndex = 21;
            label6.Text = "Desde:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(176, 34);
            label7.Name = "label7";
            label7.Size = new Size(47, 19);
            label7.TabIndex = 22;
            label7.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(176, 56);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(142, 26);
            dtpHasta.TabIndex = 23;
            // 
            // btnBuscarFechas
            // 
            btnBuscarFechas.Location = new Point(359, 49);
            btnBuscarFechas.Name = "btnBuscarFechas";
            btnBuscarFechas.Size = new Size(75, 33);
            btnBuscarFechas.TabIndex = 24;
            btnBuscarFechas.Text = "Buscar";
            btnBuscarFechas.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(892, 213);
            label8.Name = "label8";
            label8.Size = new Size(114, 19);
            label8.TabIndex = 25;
            label8.Text = "Método de pago:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(892, 287);
            label9.Name = "label9";
            label9.Size = new Size(63, 19);
            label9.TabIndex = 26;
            label9.Text = "Anticipo:";
            // 
            // textAnticipo
            // 
            textAnticipo.Location = new Point(892, 309);
            textAnticipo.Name = "textAnticipo";
            textAnticipo.Size = new Size(139, 26);
            textAnticipo.TabIndex = 28;
            // 
            // comboMetodoPago
            // 
            comboMetodoPago.FormattingEnabled = true;
            comboMetodoPago.Location = new Point(892, 235);
            comboMetodoPago.Name = "comboMetodoPago";
            comboMetodoPago.Size = new Size(139, 27);
            comboMetodoPago.TabIndex = 29;
            // 
            // groupBox1
            // 
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
            groupBox1.Controls.Add(btnBuscarFechas);
            groupBox1.Controls.Add(comboHabitacion);
            groupBox1.Controls.Add(dtpHasta);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboNumPersonas);
            groupBox1.Controls.Add(dtpDesde);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnComprarReserva);
            groupBox1.Controls.Add(textDetallesHab);
            groupBox1.Controls.Add(btnAggCarrito);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1074, 515);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reservar:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(573, 31);
            label10.Name = "label10";
            label10.Size = new Size(54, 19);
            label10.TabIndex = 31;
            label10.Text = "Cliente:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(573, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 27);
            comboBox1.TabIndex = 30;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { reservarToolStripMenuItem, venderToolStripMenuItem, checkInCheckOutToolStripMenuItem, facturarToolStripMenuItem, agregarClienteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1098, 27);
            menuStrip1.TabIndex = 31;
            menuStrip1.Text = "menuStrip1";
            // 
            // reservarToolStripMenuItem
            // 
            reservarToolStripMenuItem.Name = "reservarToolStripMenuItem";
            reservarToolStripMenuItem.Size = new Size(75, 23);
            reservarToolStripMenuItem.Text = "Reservar";
            reservarToolStripMenuItem.Click += reservarToolStripMenuItem_Click;
            // 
            // venderToolStripMenuItem
            // 
            venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            venderToolStripMenuItem.Size = new Size(114, 23);
            venderToolStripMenuItem.Text = "Vender servicio";
            venderToolStripMenuItem.Click += venderToolStripMenuItem_Click;
            // 
            // checkInCheckOutToolStripMenuItem
            // 
            checkInCheckOutToolStripMenuItem.Name = "checkInCheckOutToolStripMenuItem";
            checkInCheckOutToolStripMenuItem.Size = new Size(148, 23);
            checkInCheckOutToolStripMenuItem.Text = "Check In/Check Out";
            checkInCheckOutToolStripMenuItem.Click += checkInCheckOutToolStripMenuItem_Click;
            // 
            // facturarToolStripMenuItem
            // 
            facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            facturarToolStripMenuItem.Size = new Size(72, 23);
            facturarToolStripMenuItem.Text = "Facturar";
            facturarToolStripMenuItem.Click += facturarToolStripMenuItem_Click;
            // 
            // agregarClienteToolStripMenuItem
            // 
            agregarClienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, modificarEliminarToolStripMenuItem });
            agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            agregarClienteToolStripMenuItem.Size = new Size(63, 23);
            agregarClienteToolStripMenuItem.Text = "Cliente";
            agregarClienteToolStripMenuItem.Click += agregarClienteToolStripMenuItem_Click;
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(189, 24);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // modificarEliminarToolStripMenuItem
            // 
            modificarEliminarToolStripMenuItem.Name = "modificarEliminarToolStripMenuItem";
            modificarEliminarToolStripMenuItem.Size = new Size(189, 24);
            modificarEliminarToolStripMenuItem.Text = "Modificar/Eliminar";
            modificarEliminarToolStripMenuItem.Click += modificarEliminarToolStripMenuItem_Click;
            // 
            // Reservar
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1098, 567);
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgvHoteles;
        private DataGridViewTextBoxColumn Hotel;
        private Label label1;
        private ComboBox comboHabitacion;
        private Label label2;
        private Label label3;
        private ComboBox comboNumPersonas;
        private DataGridView dgvCarritoReserva;
        private DataGridViewTextBoxColumn Habitación;
        private DataGridViewTextBoxColumn NumPersonas;
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
    }
}