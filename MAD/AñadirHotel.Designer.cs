namespace MAD
{
    partial class AñadirHotel
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadirHotel));
            groupBox1 = new GroupBox();
            textNumero = new TextBox();
            textCalle = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboCiudad = new ComboBox();
            comboEstado = new ComboBox();
            comboPais = new ComboBox();
            label1 = new Label();
            textNombreHotel = new TextBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            dtpInicioOperacion = new DateTimePicker();
            btnAgregarHotel = new Button();
            cantPisos = new NumericUpDown();
            label9 = new Label();
            groupBox4 = new GroupBox();
            linkLabel1 = new LinkLabel();
            gridServiciosHotel = new DataGridView();
            NombreServicio = new DataGridViewTextBoxColumn();
            PrecioServicio = new DataGridViewTextBoxColumn();
            EliminarServicio = new DataGridViewImageColumn();
            textPrecioServicio = new TextBox();
            label11 = new Label();
            btnAgregarServicio = new Button();
            comboServicio = new ComboBox();
            label10 = new Label();
            groupBox3 = new GroupBox();
            btnConfigurarHabitaciones = new Button();
            label14 = new Label();
            gridHabitaciones = new DataGridView();
            TipoHab = new DataGridViewTextBoxColumn();
            CantidadHab = new DataGridViewTextBoxColumn();
            AmenidadHab = new DataGridViewTextBoxColumn();
            EliminarTipoHab = new DataGridViewImageColumn();
            btnAgregarHabitacion = new Button();
            cantHab = new NumericUpDown();
            label8 = new Label();
            comboTipoHab = new ComboBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantPisos).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridServiciosHotel).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridHabitaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantHab).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textNumero);
            groupBox1.Controls.Add(textCalle);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboCiudad);
            groupBox1.Controls.Add(comboEstado);
            groupBox1.Controls.Add(comboPais);
            groupBox1.Location = new Point(21, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(551, 214);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ubicación:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textNumero
            // 
            textNumero.Location = new Point(25, 154);
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(114, 30);
            textNumero.TabIndex = 6;
            textNumero.KeyPress += textClaveSAT_KeyPress;
            // 
            // textCalle
            // 
            textCalle.Location = new Point(25, 85);
            textCalle.Name = "textCalle";
            textCalle.Size = new Size(276, 30);
            textCalle.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 122);
            label6.Name = "label6";
            label6.Size = new Size(80, 22);
            label6.TabIndex = 7;
            label6.Text = "Número:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 41);
            label5.Name = "label5";
            label5.Size = new Size(131, 22);
            label5.TabIndex = 6;
            label5.Text = "Calle/Avenida:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(352, 31);
            label4.Name = "label4";
            label4.Size = new Size(50, 22);
            label4.TabIndex = 5;
            label4.Text = "Pais:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 92);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 4;
            label3.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 154);
            label2.Name = "label2";
            label2.Size = new Size(73, 22);
            label2.TabIndex = 3;
            label2.Text = "Ciudad:";
            // 
            // comboCiudad
            // 
            comboCiudad.FormattingEnabled = true;
            comboCiudad.Location = new Point(352, 176);
            comboCiudad.Name = "comboCiudad";
            comboCiudad.Size = new Size(121, 30);
            comboCiudad.TabIndex = 9;
            // 
            // comboEstado
            // 
            comboEstado.FormattingEnabled = true;
            comboEstado.Location = new Point(352, 114);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(121, 30);
            comboEstado.TabIndex = 8;
            comboEstado.SelectedIndexChanged += comboEstado_SelectedIndexChanged;
            // 
            // comboPais
            // 
            comboPais.FormattingEnabled = true;
            comboPais.Location = new Point(352, 53);
            comboPais.Name = "comboPais";
            comboPais.Size = new Size(121, 30);
            comboPais.TabIndex = 7;
            comboPais.SelectedIndexChanged += comboPais_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // textNombreHotel
            // 
            textNombreHotel.Location = new Point(21, 64);
            textNombreHotel.Name = "textNombreHotel";
            textNombreHotel.Size = new Size(238, 30);
            textNombreHotel.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(dtpInicioOperacion);
            groupBox2.Controls.Add(btnAgregarHotel);
            groupBox2.Controls.Add(cantPisos);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(textNombreHotel);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(27, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1114, 582);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del hotel:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(478, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 30);
            textBox1.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(478, 33);
            label13.Name = "label13";
            label13.Size = new Size(53, 22);
            label13.TabIndex = 1;
            label13.Text = "RFC:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(971, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(675, 33);
            label12.Name = "label12";
            label12.Size = new Size(187, 22);
            label12.TabIndex = 9;
            label12.Text = "Inicio de operaciones:";
            // 
            // dtpInicioOperacion
            // 
            dtpInicioOperacion.Location = new Point(675, 64);
            dtpInicioOperacion.Name = "dtpInicioOperacion";
            dtpInicioOperacion.Size = new Size(200, 30);
            dtpInicioOperacion.TabIndex = 3;
            // 
            // btnAgregarHotel
            // 
            btnAgregarHotel.Location = new Point(776, 534);
            btnAgregarHotel.Name = "btnAgregarHotel";
            btnAgregarHotel.Size = new Size(137, 42);
            btnAgregarHotel.TabIndex = 18;
            btnAgregarHotel.Text = "Agregar hotel";
            btnAgregarHotel.UseVisualStyleBackColor = true;
            btnAgregarHotel.Click += btnAgregarHotel_Click;
            // 
            // cantPisos
            // 
            cantPisos.Location = new Point(308, 64);
            cantPisos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cantPisos.Name = "cantPisos";
            cantPisos.Size = new Size(131, 30);
            cantPisos.TabIndex = 2;
            cantPisos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(308, 33);
            label9.Name = "label9";
            label9.Size = new Size(158, 22);
            label9.TabIndex = 5;
            label9.Text = "Cantidad de pisos:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(linkLabel1);
            groupBox4.Controls.Add(gridServiciosHotel);
            groupBox4.Controls.Add(textPrecioServicio);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(btnAgregarServicio);
            groupBox4.Controls.Add(comboServicio);
            groupBox4.Controls.Add(label10);
            groupBox4.Location = new Point(21, 339);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(551, 237);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Servicios del hotel:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(309, 205);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(236, 22);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Agregar servicio al catálogo";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // gridServiciosHotel
            // 
            gridServiciosHotel.AllowUserToAddRows = false;
            gridServiciosHotel.AllowUserToDeleteRows = false;
            gridServiciosHotel.AllowUserToResizeColumns = false;
            gridServiciosHotel.AllowUserToResizeRows = false;
            gridServiciosHotel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridServiciosHotel.Columns.AddRange(new DataGridViewColumn[] { NombreServicio, PrecioServicio, EliminarServicio });
            gridServiciosHotel.Location = new Point(206, 40);
            gridServiciosHotel.Name = "gridServiciosHotel";
            gridServiciosHotel.RowHeadersWidth = 51;
            gridServiciosHotel.Size = new Size(339, 150);
            gridServiciosHotel.TabIndex = 19;
            gridServiciosHotel.CellContentClick += gridServiciosHotel_CellContentClick;
            // 
            // NombreServicio
            // 
            NombreServicio.HeaderText = "Nombre";
            NombreServicio.MinimumWidth = 6;
            NombreServicio.Name = "NombreServicio";
            NombreServicio.ReadOnly = true;
            NombreServicio.Width = 125;
            // 
            // PrecioServicio
            // 
            PrecioServicio.HeaderText = "Precio";
            PrecioServicio.MinimumWidth = 6;
            PrecioServicio.Name = "PrecioServicio";
            PrecioServicio.ReadOnly = true;
            PrecioServicio.Width = 80;
            // 
            // EliminarServicio
            // 
            EliminarServicio.HeaderText = "Eliminar";
            EliminarServicio.Image = Properties.Resources.basura;
            EliminarServicio.ImageLayout = DataGridViewImageCellLayout.Zoom;
            EliminarServicio.MinimumWidth = 6;
            EliminarServicio.Name = "EliminarServicio";
            EliminarServicio.Resizable = DataGridViewTriState.True;
            EliminarServicio.Width = 75;
            // 
            // textPrecioServicio
            // 
            textPrecioServicio.Location = new Point(28, 141);
            textPrecioServicio.Name = "textPrecioServicio";
            textPrecioServicio.Size = new Size(124, 30);
            textPrecioServicio.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 116);
            label11.Name = "label11";
            label11.Size = new Size(132, 22);
            label11.TabIndex = 3;
            label11.Text = "Precio (MXN):";
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.Location = new Point(25, 177);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(124, 54);
            btnAgregarServicio.TabIndex = 17;
            btnAgregarServicio.Text = "Agregar servicio";
            btnAgregarServicio.UseVisualStyleBackColor = true;
            btnAgregarServicio.Click += btnAgregarServicio_Click;
            // 
            // comboServicio
            // 
            comboServicio.FormattingEnabled = true;
            comboServicio.Location = new Point(28, 72);
            comboServicio.Name = "comboServicio";
            comboServicio.Size = new Size(121, 30);
            comboServicio.TabIndex = 15;
            comboServicio.SelectedIndexChanged += comboServicio_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 40);
            label10.Name = "label10";
            label10.Size = new Size(180, 22);
            label10.TabIndex = 0;
            label10.Text = "Nombre del servicio:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnConfigurarHabitaciones);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(gridHabitaciones);
            groupBox3.Controls.Add(btnAgregarHabitacion);
            groupBox3.Controls.Add(cantHab);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(comboTipoHab);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(578, 123);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(530, 406);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tipos de habitación:";
            // 
            // btnConfigurarHabitaciones
            // 
            btnConfigurarHabitaciones.Location = new Point(285, 82);
            btnConfigurarHabitaciones.Name = "btnConfigurarHabitaciones";
            btnConfigurarHabitaciones.Size = new Size(158, 52);
            btnConfigurarHabitaciones.TabIndex = 22;
            btnConfigurarHabitaciones.Text = "Configurar habitaciones";
            btnConfigurarHabitaciones.UseVisualStyleBackColor = true;
            btnConfigurarHabitaciones.Click += btnConfigurarHabitaciones_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(273, 54);
            label14.Name = "label14";
            label14.Size = new Size(243, 22);
            label14.TabIndex = 21;
            label14.Text = "¡Configure habitaciones aquí!";
            // 
            // gridHabitaciones
            // 
            gridHabitaciones.AllowUserToAddRows = false;
            gridHabitaciones.AllowUserToDeleteRows = false;
            gridHabitaciones.AllowUserToResizeColumns = false;
            gridHabitaciones.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F);
            gridHabitaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridHabitaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridHabitaciones.Columns.AddRange(new DataGridViewColumn[] { TipoHab, CantidadHab, AmenidadHab, EliminarTipoHab });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridHabitaciones.DefaultCellStyle = dataGridViewCellStyle2;
            gridHabitaciones.Location = new Point(30, 194);
            gridHabitaciones.Name = "gridHabitaciones";
            gridHabitaciones.RowHeadersWidth = 51;
            gridHabitaciones.Size = new Size(482, 201);
            gridHabitaciones.TabIndex = 20;
            gridHabitaciones.CellContentClick += gridHabitaciones_CellContentClick;
            // 
            // TipoHab
            // 
            TipoHab.HeaderText = "Tipo";
            TipoHab.MinimumWidth = 6;
            TipoHab.Name = "TipoHab";
            TipoHab.ReadOnly = true;
            TipoHab.Resizable = DataGridViewTriState.False;
            TipoHab.Width = 125;
            // 
            // CantidadHab
            // 
            CantidadHab.HeaderText = "Cantidad";
            CantidadHab.MinimumWidth = 6;
            CantidadHab.Name = "CantidadHab";
            CantidadHab.ReadOnly = true;
            CantidadHab.Resizable = DataGridViewTriState.False;
            CantidadHab.Width = 75;
            // 
            // AmenidadHab
            // 
            AmenidadHab.HeaderText = "Amenidades";
            AmenidadHab.MinimumWidth = 6;
            AmenidadHab.Name = "AmenidadHab";
            AmenidadHab.ReadOnly = true;
            AmenidadHab.Width = 175;
            // 
            // EliminarTipoHab
            // 
            EliminarTipoHab.HeaderText = "Eliminar";
            EliminarTipoHab.Image = Properties.Resources.basura;
            EliminarTipoHab.ImageLayout = DataGridViewImageCellLayout.Zoom;
            EliminarTipoHab.MinimumWidth = 6;
            EliminarTipoHab.Name = "EliminarTipoHab";
            EliminarTipoHab.Resizable = DataGridViewTriState.True;
            EliminarTipoHab.Width = 75;
            // 
            // btnAgregarHabitacion
            // 
            btnAgregarHabitacion.Location = new Point(30, 148);
            btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            btnAgregarHabitacion.Size = new Size(121, 37);
            btnAgregarHabitacion.TabIndex = 13;
            btnAgregarHabitacion.Text = "Agregar habitación";
            btnAgregarHabitacion.UseVisualStyleBackColor = true;
            btnAgregarHabitacion.Click += btnAgregarHabitacion_Click;
            // 
            // cantHab
            // 
            cantHab.Location = new Point(31, 114);
            cantHab.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cantHab.Name = "cantHab";
            cantHab.Size = new Size(120, 30);
            cantHab.TabIndex = 12;
            cantHab.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 92);
            label8.Name = "label8";
            label8.Size = new Size(87, 22);
            label8.TabIndex = 2;
            label8.Text = "Cantidad:";
            // 
            // comboTipoHab
            // 
            comboTipoHab.FormattingEnabled = true;
            comboTipoHab.Location = new Point(30, 53);
            comboTipoHab.Name = "comboTipoHab";
            comboTipoHab.Size = new Size(121, 30);
            comboTipoHab.TabIndex = 11;
            comboTipoHab.SelectedIndexChanged += comboTipoHab_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 31);
            label7.Name = "label7";
            label7.Size = new Size(53, 22);
            label7.TabIndex = 0;
            label7.Text = "Tipo:";
            // 
            // AñadirHotel
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1153, 620);
            Controls.Add(groupBox2);
            Font = new Font("Times New Roman", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AñadirHotel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrownHotelManager";
            Load += AñadirHotel_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cantPisos).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridServiciosHotel).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridHabitaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)cantHab).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboCiudad;
        private ComboBox comboEstado;
        private ComboBox comboPais;
        private Label label1;
        private TextBox textNombreHotel;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textCalle;
        private Label label6;
        private Label label5;
        private TextBox textNumero;
        private GroupBox groupBox3;
        private DataGridView gridHabitaciones;
        private Button btnAgregarHabitacion;
        private NumericUpDown cantHab;
        private Label label8;
        private ComboBox comboTipoHab;
        private Label label7;
        private GroupBox groupBox4;
        private Label label9;
        private NumericUpDown cantPisos;
        private Button btnAgregarServicio;
        private ComboBox comboServicio;
        private Label label10;
        private TextBox textPrecioServicio;
        private Label label11;
        private Button btnAgregarHotel;
        private DataGridView gridServiciosHotel;
        private Label label12;
        private DateTimePicker dtpInicioOperacion;
        private PictureBox pictureBox1;
        private Label label13;
        private TextBox textBox1;
        private Button btnConfigurarHabitaciones;
        private Label label14;
        private LinkLabel linkLabel1;
        private DataGridViewTextBoxColumn NombreServicio;
        private DataGridViewTextBoxColumn PrecioServicio;
        private DataGridViewImageColumn EliminarServicio;
        private DataGridViewTextBoxColumn TipoHab;
        private DataGridViewTextBoxColumn CantidadHab;
        private DataGridViewTextBoxColumn AmenidadHab;
        private DataGridViewImageColumn EliminarTipoHab;
    }
}