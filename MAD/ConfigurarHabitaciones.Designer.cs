namespace MAD
{
    partial class ConfigurarHabitaciones
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            dgvCamas = new DataGridView();
            tipoDeCama = new DataGridViewTextBoxColumn();
            cantDeCama = new DataGridViewTextBoxColumn();
            eliminarCama = new DataGridViewImageColumn();
            groupBox2 = new GroupBox();
            radioTerraza = new RadioButton();
            radioVentana = new RadioButton();
            radioPasillo = new RadioButton();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            CantCamas = new NumericUpDown();
            comboTipoCama = new ComboBox();
            CantMaxPers = new NumericUpDown();
            textPrecioPersona = new TextBox();
            textNombre = new TextBox();
            dgvAmenidades = new DataGridView();
            Amenidad = new DataGridViewTextBoxColumn();
            AmenidadSelect = new DataGridViewCheckBoxColumn();
            btnAgregarHabitacion = new Button();
            btnAgregarCama = new Button();
            dgvConfigHab = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            UbicacionHab = new DataGridViewTextBoxColumn();
            PrecioPorNoche = new DataGridViewTextBoxColumn();
            PrecioPorPersona = new DataGridViewTextBoxColumn();
            MaxPersonas = new DataGridViewTextBoxColumn();
            TipoCama = new DataGridViewTextBoxColumn();
            CantidadCamas = new DataGridViewTextBoxColumn();
            AmenidadesHab = new DataGridViewTextBoxColumn();
            EliminarHab = new DataGridViewImageColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            btnFinConf = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCamas).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CantCamas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CantMaxPers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAmenidades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConfigHab).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(131, 22);
            label1.TabIndex = 0;
            label1.Text = "Nombre/Nivel:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 113);
            label2.Name = "label2";
            label2.Size = new Size(123, 22);
            label2.TabIndex = 1;
            label2.Text = "Tipo de cama:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 176);
            label3.Name = "label3";
            label3.Size = new Size(165, 22);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de camas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 19);
            label5.Name = "label5";
            label5.Size = new Size(167, 22);
            label5.TabIndex = 4;
            label5.Text = "Precio por persona:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 23);
            label6.Name = "label6";
            label6.Size = new Size(263, 22);
            label6.TabIndex = 5;
            label6.Text = "Cantidad máxima de huéspedes:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFinConf);
            groupBox1.Controls.Add(dgvCamas);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(CantCamas);
            groupBox1.Controls.Add(comboTipoCama);
            groupBox1.Controls.Add(CantMaxPers);
            groupBox1.Controls.Add(textPrecioPersona);
            groupBox1.Controls.Add(textNombre);
            groupBox1.Controls.Add(dgvAmenidades);
            groupBox1.Controls.Add(btnAgregarHabitacion);
            groupBox1.Controls.Add(btnAgregarCama);
            groupBox1.Controls.Add(dgvConfigHab);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1181, 654);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuración de habitaciones";
            // 
            // dgvCamas
            // 
            dgvCamas.AllowUserToAddRows = false;
            dgvCamas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCamas.Columns.AddRange(new DataGridViewColumn[] { tipoDeCama, cantDeCama, eliminarCama });
            dgvCamas.Location = new Point(188, 89);
            dgvCamas.Name = "dgvCamas";
            dgvCamas.RowHeadersWidth = 51;
            dgvCamas.Size = new Size(366, 229);
            dgvCamas.TabIndex = 19;
            dgvCamas.CellContentClick += dgvCamas_CellContentClick;
            // 
            // tipoDeCama
            // 
            tipoDeCama.HeaderText = "Tipo de cama";
            tipoDeCama.MinimumWidth = 6;
            tipoDeCama.Name = "tipoDeCama";
            tipoDeCama.Width = 125;
            // 
            // cantDeCama
            // 
            cantDeCama.HeaderText = "Cantidad";
            cantDeCama.MinimumWidth = 6;
            cantDeCama.Name = "cantDeCama";
            cantDeCama.Width = 125;
            // 
            // eliminarCama
            // 
            eliminarCama.HeaderText = "Eliminar";
            eliminarCama.Image = Properties.Resources.basura;
            eliminarCama.ImageLayout = DataGridViewImageCellLayout.Zoom;
            eliminarCama.MinimumWidth = 6;
            eliminarCama.Name = "eliminarCama";
            eliminarCama.Width = 125;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioTerraza);
            groupBox2.Controls.Add(radioVentana);
            groupBox2.Controls.Add(radioPasillo);
            groupBox2.Location = new Point(662, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 61);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ubicacion en el hotel:";
            // 
            // radioTerraza
            // 
            radioTerraza.AutoSize = true;
            radioTerraza.Location = new Point(209, 31);
            radioTerraza.Name = "radioTerraza";
            radioTerraza.Size = new Size(91, 26);
            radioTerraza.TabIndex = 2;
            radioTerraza.TabStop = true;
            radioTerraza.Text = "Terraza";
            radioTerraza.UseVisualStyleBackColor = true;
            // 
            // radioVentana
            // 
            radioVentana.AutoSize = true;
            radioVentana.Location = new Point(111, 31);
            radioVentana.Name = "radioVentana";
            radioVentana.Size = new Size(92, 26);
            radioVentana.TabIndex = 1;
            radioVentana.TabStop = true;
            radioVentana.Text = "Ventana";
            radioVentana.UseVisualStyleBackColor = true;
            // 
            // radioPasillo
            // 
            radioPasillo.AutoSize = true;
            radioPasillo.Location = new Point(18, 31);
            radioPasillo.Name = "radioPasillo";
            radioPasillo.Size = new Size(87, 26);
            radioPasillo.TabIndex = 0;
            radioPasillo.TabStop = true;
            radioPasillo.Text = "Pasillo";
            radioPasillo.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(616, 321);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(256, 22);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Añadir amenidades al catálogo";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(1017, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // CantCamas
            // 
            CantCamas.Location = new Point(18, 198);
            CantCamas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CantCamas.Name = "CantCamas";
            CantCamas.Size = new Size(133, 30);
            CantCamas.TabIndex = 15;
            CantCamas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboTipoCama
            // 
            comboTipoCama.FormattingEnabled = true;
            comboTipoCama.Location = new Point(18, 135);
            comboTipoCama.Name = "comboTipoCama";
            comboTipoCama.Size = new Size(133, 30);
            comboTipoCama.TabIndex = 14;
            // 
            // CantMaxPers
            // 
            CantMaxPers.Location = new Point(351, 45);
            CantMaxPers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CantMaxPers.Name = "CantMaxPers";
            CantMaxPers.Size = new Size(203, 30);
            CantMaxPers.TabIndex = 13;
            CantMaxPers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textPrecioPersona
            // 
            textPrecioPersona.Location = new Point(188, 44);
            textPrecioPersona.Name = "textPrecioPersona";
            textPrecioPersona.Size = new Size(142, 30);
            textPrecioPersona.TabIndex = 11;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(18, 44);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(154, 30);
            textNombre.TabIndex = 10;
            textNombre.TextChanged += timer1_Tick;
            // 
            // dgvAmenidades
            // 
            dgvAmenidades.AllowUserToAddRows = false;
            dgvAmenidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmenidades.Columns.AddRange(new DataGridViewColumn[] { Amenidad, AmenidadSelect });
            dgvAmenidades.Location = new Point(616, 89);
            dgvAmenidades.Name = "dgvAmenidades";
            dgvAmenidades.RowHeadersWidth = 51;
            dgvAmenidades.Size = new Size(395, 229);
            dgvAmenidades.TabIndex = 9;
            // 
            // Amenidad
            // 
            Amenidad.HeaderText = "Amenidad";
            Amenidad.MinimumWidth = 6;
            Amenidad.Name = "Amenidad";
            Amenidad.Width = 150;
            // 
            // AmenidadSelect
            // 
            AmenidadSelect.HeaderText = "Seleccione las amenidades para su habitación";
            AmenidadSelect.MinimumWidth = 6;
            AmenidadSelect.Name = "AmenidadSelect";
            AmenidadSelect.Width = 200;
            // 
            // btnAgregarHabitacion
            // 
            btnAgregarHabitacion.Location = new Point(1045, 241);
            btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            btnAgregarHabitacion.Size = new Size(130, 77);
            btnAgregarHabitacion.TabIndex = 8;
            btnAgregarHabitacion.Text = "Agregar habitación";
            btnAgregarHabitacion.UseVisualStyleBackColor = true;
            btnAgregarHabitacion.Click += btnAgregarHabitacion_Click;
            // 
            // btnAgregarCama
            // 
            btnAgregarCama.Location = new Point(23, 256);
            btnAgregarCama.Name = "btnAgregarCama";
            btnAgregarCama.Size = new Size(128, 31);
            btnAgregarCama.TabIndex = 7;
            btnAgregarCama.Text = "Agregar cama";
            btnAgregarCama.UseVisualStyleBackColor = true;
            btnAgregarCama.Click += btnAgregarCama_Click;
            // 
            // dgvConfigHab
            // 
            dgvConfigHab.AllowUserToAddRows = false;
            dgvConfigHab.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvConfigHab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConfigHab.Columns.AddRange(new DataGridViewColumn[] { Nombre, UbicacionHab, PrecioPorNoche, PrecioPorPersona, MaxPersonas, TipoCama, CantidadCamas, AmenidadesHab, EliminarHab });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvConfigHab.DefaultCellStyle = dataGridViewCellStyle1;
            dgvConfigHab.Location = new Point(18, 356);
            dgvConfigHab.Name = "dgvConfigHab";
            dgvConfigHab.RowHeadersWidth = 51;
            dgvConfigHab.Size = new Size(993, 291);
            dgvConfigHab.TabIndex = 6;
            dgvConfigHab.CellContentClick += dgvConfigHab_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nivel de habitación";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // UbicacionHab
            // 
            UbicacionHab.HeaderText = "Ubicación";
            UbicacionHab.MinimumWidth = 6;
            UbicacionHab.Name = "UbicacionHab";
            UbicacionHab.Width = 125;
            // 
            // PrecioPorNoche
            // 
            PrecioPorNoche.HeaderText = "Precio por noche";
            PrecioPorNoche.MinimumWidth = 6;
            PrecioPorNoche.Name = "PrecioPorNoche";
            PrecioPorNoche.Width = 125;
            // 
            // PrecioPorPersona
            // 
            PrecioPorPersona.HeaderText = "Precio por persona";
            PrecioPorPersona.MinimumWidth = 6;
            PrecioPorPersona.Name = "PrecioPorPersona";
            PrecioPorPersona.Width = 125;
            // 
            // MaxPersonas
            // 
            MaxPersonas.HeaderText = "Cantidad máxima de huéspedes";
            MaxPersonas.MinimumWidth = 6;
            MaxPersonas.Name = "MaxPersonas";
            MaxPersonas.Width = 125;
            // 
            // TipoCama
            // 
            TipoCama.HeaderText = "Tipo de cama";
            TipoCama.MinimumWidth = 6;
            TipoCama.Name = "TipoCama";
            TipoCama.Width = 125;
            // 
            // CantidadCamas
            // 
            CantidadCamas.HeaderText = "Cantidad de camas";
            CantidadCamas.MinimumWidth = 6;
            CantidadCamas.Name = "CantidadCamas";
            CantidadCamas.Width = 125;
            // 
            // AmenidadesHab
            // 
            AmenidadesHab.HeaderText = "Amenidades";
            AmenidadesHab.MinimumWidth = 6;
            AmenidadesHab.Name = "AmenidadesHab";
            AmenidadesHab.Width = 125;
            // 
            // EliminarHab
            // 
            EliminarHab.HeaderText = "Eliminar";
            EliminarHab.Image = Properties.Resources.basura;
            EliminarHab.ImageLayout = DataGridViewImageCellLayout.Zoom;
            EliminarHab.MinimumWidth = 6;
            EliminarHab.Name = "EliminarHab";
            EliminarHab.Resizable = DataGridViewTriState.True;
            EliminarHab.Width = 75;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnFinConf
            // 
            btnFinConf.Location = new Point(1045, 579);
            btnFinConf.Name = "btnFinConf";
            btnFinConf.Size = new Size(130, 68);
            btnFinConf.TabIndex = 20;
            btnFinConf.Text = "Terminar configuración";
            btnFinConf.UseVisualStyleBackColor = true;
            btnFinConf.Click += btnFinConf_Click;
            // 
            // ConfigurarHabitaciones
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1205, 671);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "ConfigurarHabitaciones";
            Text = "ConfigurarHabitaciones";
            Load += ConfigurarHabitaciones_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCamas).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CantCamas).EndInit();
            ((System.ComponentModel.ISupportInitialize)CantMaxPers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAmenidades).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConfigHab).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Button btnAgregarHabitacion;
        private RadioButton radioTerraza;
        private RadioButton radioPasillo;
        private Button btnAgregarCama;
        private DataGridView dgvConfigHab;
        private DataGridView dgvAmenidades;
        private TextBox textPrecioPersona;
        private TextBox textNombre;
        private NumericUpDown CantCamas;
        private ComboBox comboTipoCama;
        private NumericUpDown CantMaxPers;
        private DataGridViewTextBoxColumn Amenidad;
        private DataGridViewCheckBoxColumn AmenidadSelect;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private LinkLabel linkLabel1;
        private GroupBox groupBox2;
        private RadioButton radioVentana;
        private DataGridView dgvCamas;
        private DataGridViewTextBoxColumn tipoDeCama;
        private DataGridViewTextBoxColumn cantDeCama;
        private DataGridViewImageColumn eliminarCama;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn UbicacionHab;
        private DataGridViewTextBoxColumn PrecioPorNoche;
        private DataGridViewTextBoxColumn PrecioPorPersona;
        private DataGridViewTextBoxColumn MaxPersonas;
        private DataGridViewTextBoxColumn TipoCama;
        private DataGridViewTextBoxColumn CantidadCamas;
        private DataGridViewTextBoxColumn AmenidadesHab;
        private DataGridViewImageColumn EliminarHab;
        private Button btnFinConf;
    }
}