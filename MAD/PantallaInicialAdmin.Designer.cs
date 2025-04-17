namespace MAD
{
    partial class PantallaInicialAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicialAdmin));
            menuStrip1 = new MenuStrip();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            reporteDeVentasToolStripMenuItem = new ToolStripMenuItem();
            reporteDeOcupaciónToolStripMenuItem = new ToolStripMenuItem();
            gestiónDeHotelesToolStripMenuItem = new ToolStripMenuItem();
            agregarHotelToolStripMenuItem = new ToolStripMenuItem();
            historalDeClienteToolStripMenuItem = new ToolStripMenuItem();
            cancelacionesToolStripMenuItem = new ToolStripMenuItem();
            agregarUsuarioOperativoToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            modificarUsuariioOperativoToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboPais = new ComboBox();
            comboCiudad = new ComboBox();
            comboHotel = new ComboBox();
            dtpAño = new DateTimePicker();
            btnFiltrar = new Button();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            Ciudad = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Año = new DataGridViewTextBoxColumn();
            Mes = new DataGridViewTextBoxColumn();
            IngresosHospedaje = new DataGridViewTextBoxColumn();
            IngresosServicios = new DataGridViewTextBoxColumn();
            IngresosTotales = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Times New Roman", 12F);
            menuStrip1.GripMargin = new Padding(2, 5, 0, 5);
            menuStrip1.Items.AddRange(new ToolStripItem[] { reportesToolStripMenuItem, gestiónDeHotelesToolStripMenuItem, historalDeClienteToolStripMenuItem, cancelacionesToolStripMenuItem, agregarUsuarioOperativoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 0, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(981, 45);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.BackColor = Color.White;
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reporteDeVentasToolStripMenuItem, reporteDeOcupaciónToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(76, 43);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            reporteDeVentasToolStripMenuItem.Size = new Size(212, 24);
            reporteDeVentasToolStripMenuItem.Text = "Reporte de ventas";
            // 
            // reporteDeOcupaciónToolStripMenuItem
            // 
            reporteDeOcupaciónToolStripMenuItem.Name = "reporteDeOcupaciónToolStripMenuItem";
            reporteDeOcupaciónToolStripMenuItem.Size = new Size(212, 24);
            reporteDeOcupaciónToolStripMenuItem.Text = "Reporte de ocupación";
            reporteDeOcupaciónToolStripMenuItem.Click += reporteDeOcupaciónToolStripMenuItem_Click;
            // 
            // gestiónDeHotelesToolStripMenuItem
            // 
            gestiónDeHotelesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarHotelToolStripMenuItem });
            gestiónDeHotelesToolStripMenuItem.Margin = new Padding(0, 10, 0, 10);
            gestiónDeHotelesToolStripMenuItem.Name = "gestiónDeHotelesToolStripMenuItem";
            gestiónDeHotelesToolStripMenuItem.Size = new Size(132, 23);
            gestiónDeHotelesToolStripMenuItem.Text = "Gestión de hoteles";
            // 
            // agregarHotelToolStripMenuItem
            // 
            agregarHotelToolStripMenuItem.BackColor = Color.Transparent;
            agregarHotelToolStripMenuItem.Name = "agregarHotelToolStripMenuItem";
            agregarHotelToolStripMenuItem.Size = new Size(160, 24);
            agregarHotelToolStripMenuItem.Text = "Agregar hotel";
            agregarHotelToolStripMenuItem.Click += agregarHotelToolStripMenuItem_Click_1;
            // 
            // historalDeClienteToolStripMenuItem
            // 
            historalDeClienteToolStripMenuItem.Margin = new Padding(0, 10, 0, 10);
            historalDeClienteToolStripMenuItem.Name = "historalDeClienteToolStripMenuItem";
            historalDeClienteToolStripMenuItem.Size = new Size(129, 23);
            historalDeClienteToolStripMenuItem.Text = "Historal de cliente";
            historalDeClienteToolStripMenuItem.Click += historalDeClienteToolStripMenuItem_Click;
            // 
            // cancelacionesToolStripMenuItem
            // 
            cancelacionesToolStripMenuItem.Margin = new Padding(0, 10, 0, 10);
            cancelacionesToolStripMenuItem.Name = "cancelacionesToolStripMenuItem";
            cancelacionesToolStripMenuItem.Size = new Size(108, 23);
            cancelacionesToolStripMenuItem.Text = "Cancelaciones";
            cancelacionesToolStripMenuItem.Click += cancelacionesToolStripMenuItem_Click;
            // 
            // agregarUsuarioOperativoToolStripMenuItem
            // 
            agregarUsuarioOperativoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, modificarUsuariioOperativoToolStripMenuItem });
            agregarUsuarioOperativoToolStripMenuItem.Name = "agregarUsuarioOperativoToolStripMenuItem";
            agregarUsuarioOperativoToolStripMenuItem.Size = new Size(74, 43);
            agregarUsuarioOperativoToolStripMenuItem.Text = "Usuarios";
            agregarUsuarioOperativoToolStripMenuItem.Click += agregarUsuarioOperativoToolStripMenuItem_Click;
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(189, 24);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // modificarUsuariioOperativoToolStripMenuItem
            // 
            modificarUsuariioOperativoToolStripMenuItem.Name = "modificarUsuariioOperativoToolStripMenuItem";
            modificarUsuariioOperativoToolStripMenuItem.Size = new Size(189, 24);
            modificarUsuariioOperativoToolStripMenuItem.Text = "Modificar/Eliminar";
            modificarUsuariioOperativoToolStripMenuItem.Click += modificarUsuariioOperativoToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(773, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(dtpAño);
            groupBox1.Controls.Add(comboHotel);
            groupBox1.Controls.Add(comboCiudad);
            groupBox1.Controls.Add(comboPais);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(658, 109);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Location = new Point(12, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(957, 511);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reporte de ventas:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(37, 19);
            label1.TabIndex = 0;
            label1.Text = "País:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 33);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 1;
            label2.Text = "Ciudad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 33);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 2;
            label3.Text = "Año:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 33);
            label4.Name = "label4";
            label4.Size = new Size(45, 19);
            label4.TabIndex = 3;
            label4.Text = "Hotel:";
            // 
            // comboPais
            // 
            comboPais.FormattingEnabled = true;
            comboPais.Location = new Point(21, 55);
            comboPais.Name = "comboPais";
            comboPais.Size = new Size(121, 27);
            comboPais.TabIndex = 4;
            // 
            // comboCiudad
            // 
            comboCiudad.FormattingEnabled = true;
            comboCiudad.Location = new Point(154, 55);
            comboCiudad.Name = "comboCiudad";
            comboCiudad.Size = new Size(121, 27);
            comboCiudad.TabIndex = 5;
            // 
            // comboHotel
            // 
            comboHotel.FormattingEnabled = true;
            comboHotel.Location = new Point(393, 55);
            comboHotel.Name = "comboHotel";
            comboHotel.Size = new Size(121, 27);
            comboHotel.TabIndex = 7;
            // 
            // dtpAño
            // 
            dtpAño.CustomFormat = "yyyy";
            dtpAño.Format = DateTimePickerFormat.Custom;
            dtpAño.Location = new Point(295, 56);
            dtpAño.Name = "dtpAño";
            dtpAño.Size = new Size(75, 26);
            dtpAño.TabIndex = 8;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(543, 55);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 27);
            btnFiltrar.TabIndex = 9;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ciudad, Nombre, Año, Mes, IngresosHospedaje, IngresosServicios, IngresosTotales });
            dataGridView1.Location = new Point(6, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 314);
            dataGridView1.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(6, 160);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(763, 345);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Reporte:";
            // 
            // Ciudad
            // 
            Ciudad.HeaderText = "Ciudad";
            Ciudad.Name = "Ciudad";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Año
            // 
            Año.HeaderText = "Año";
            Año.Name = "Año";
            // 
            // Mes
            // 
            Mes.HeaderText = "Mes";
            Mes.Name = "Mes";
            // 
            // IngresosHospedaje
            // 
            IngresosHospedaje.HeaderText = "Ingresos por hospedaje";
            IngresosHospedaje.Name = "IngresosHospedaje";
            // 
            // IngresosServicios
            // 
            IngresosServicios.HeaderText = "Ingresos por servicios";
            IngresosServicios.Name = "IngresosServicios";
            // 
            // IngresosTotales
            // 
            IngresosTotales.HeaderText = "Ingresos totales";
            IngresosTotales.Name = "IngresosTotales";
            // 
            // PantallaInicialAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(981, 571);
            Controls.Add(groupBox2);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "PantallaInicialAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrownHotelManager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestiónDeHotelesToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private ToolStripMenuItem reporteDeOcupaciónToolStripMenuItem;
        private ToolStripMenuItem historalDeClienteToolStripMenuItem;
        private ToolStripMenuItem cancelacionesToolStripMenuItem;
        private ToolStripMenuItem agregarHotelToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem agregarUsuarioOperativoToolStripMenuItem;
        private ToolStripMenuItem modificarUsuariioOperativoToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private GroupBox groupBox1;
        private DateTimePicker dtpAño;
        private ComboBox comboHotel;
        private ComboBox comboCiudad;
        private ComboBox comboPais;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnFiltrar;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Ciudad;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Año;
        private DataGridViewTextBoxColumn Mes;
        private DataGridViewTextBoxColumn IngresosHospedaje;
        private DataGridViewTextBoxColumn IngresosServicios;
        private DataGridViewTextBoxColumn IngresosTotales;
    }
}