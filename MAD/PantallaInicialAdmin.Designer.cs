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
            modificarHotelToolStripMenuItem = new ToolStripMenuItem();
            historalDeClienteToolStripMenuItem = new ToolStripMenuItem();
            cancelacionesToolStripMenuItem = new ToolStripMenuItem();
            agregarUsuarioOperativoToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            modificarUsuariioOperativoToolStripMenuItem = new ToolStripMenuItem();
            serviciosAmenidadesToolStripMenuItem = new ToolStripMenuItem();
            agregarServicioToolStripMenuItem = new ToolStripMenuItem();
            agregarAmenidadToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            btnFiltrar = new Button();
            dtpAño = new DateTimePicker();
            comboHotel = new ComboBox();
            comboCiudad = new ComboBox();
            comboPais = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Times New Roman", 12F);
            menuStrip1.GripMargin = new Padding(2, 5, 0, 5);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { reportesToolStripMenuItem, gestiónDeHotelesToolStripMenuItem, historalDeClienteToolStripMenuItem, cancelacionesToolStripMenuItem, agregarUsuarioOperativoToolStripMenuItem, serviciosAmenidadesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 0, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(981, 48);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.BackColor = Color.White;
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reporteDeVentasToolStripMenuItem, reporteDeOcupaciónToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(95, 46);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            reporteDeVentasToolStripMenuItem.Size = new Size(267, 26);
            reporteDeVentasToolStripMenuItem.Text = "Reporte de ventas";
            // 
            // reporteDeOcupaciónToolStripMenuItem
            // 
            reporteDeOcupaciónToolStripMenuItem.Name = "reporteDeOcupaciónToolStripMenuItem";
            reporteDeOcupaciónToolStripMenuItem.Size = new Size(267, 26);
            reporteDeOcupaciónToolStripMenuItem.Text = "Reporte de ocupación";
            reporteDeOcupaciónToolStripMenuItem.Click += reporteDeOcupaciónToolStripMenuItem_Click;
            // 
            // gestiónDeHotelesToolStripMenuItem
            // 
            gestiónDeHotelesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarHotelToolStripMenuItem, modificarHotelToolStripMenuItem });
            gestiónDeHotelesToolStripMenuItem.Margin = new Padding(0, 10, 0, 10);
            gestiónDeHotelesToolStripMenuItem.Name = "gestiónDeHotelesToolStripMenuItem";
            gestiónDeHotelesToolStripMenuItem.Size = new Size(170, 26);
            gestiónDeHotelesToolStripMenuItem.Text = "Gestión de hoteles";
            // 
            // agregarHotelToolStripMenuItem
            // 
            agregarHotelToolStripMenuItem.BackColor = Color.Transparent;
            agregarHotelToolStripMenuItem.Name = "agregarHotelToolStripMenuItem";
            agregarHotelToolStripMenuItem.Size = new Size(218, 26);
            agregarHotelToolStripMenuItem.Text = "Agregar hotel";
            agregarHotelToolStripMenuItem.Click += agregarHotelToolStripMenuItem_Click_1;
            // 
            // modificarHotelToolStripMenuItem
            // 
            modificarHotelToolStripMenuItem.Name = "modificarHotelToolStripMenuItem";
            modificarHotelToolStripMenuItem.Size = new Size(218, 26);
            modificarHotelToolStripMenuItem.Text = "Modificar hotel";
            modificarHotelToolStripMenuItem.Click += modificarHotelToolStripMenuItem_Click;
            // 
            // historalDeClienteToolStripMenuItem
            // 
            historalDeClienteToolStripMenuItem.Margin = new Padding(0, 10, 0, 10);
            historalDeClienteToolStripMenuItem.Name = "historalDeClienteToolStripMenuItem";
            historalDeClienteToolStripMenuItem.Size = new Size(171, 26);
            historalDeClienteToolStripMenuItem.Text = "Historal de cliente";
            historalDeClienteToolStripMenuItem.Click += historalDeClienteToolStripMenuItem_Click;
            // 
            // cancelacionesToolStripMenuItem
            // 
            cancelacionesToolStripMenuItem.Margin = new Padding(0, 10, 0, 10);
            cancelacionesToolStripMenuItem.Name = "cancelacionesToolStripMenuItem";
            cancelacionesToolStripMenuItem.Size = new Size(139, 26);
            cancelacionesToolStripMenuItem.Text = "Cancelaciones";
            cancelacionesToolStripMenuItem.Click += cancelacionesToolStripMenuItem_Click;
            // 
            // agregarUsuarioOperativoToolStripMenuItem
            // 
            agregarUsuarioOperativoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, modificarUsuariioOperativoToolStripMenuItem });
            agregarUsuarioOperativoToolStripMenuItem.Name = "agregarUsuarioOperativoToolStripMenuItem";
            agregarUsuarioOperativoToolStripMenuItem.Size = new Size(94, 46);
            agregarUsuarioOperativoToolStripMenuItem.Text = "Usuarios";
            agregarUsuarioOperativoToolStripMenuItem.Click += agregarUsuarioOperativoToolStripMenuItem_Click;
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(249, 26);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // modificarUsuariioOperativoToolStripMenuItem
            // 
            modificarUsuariioOperativoToolStripMenuItem.Name = "modificarUsuariioOperativoToolStripMenuItem";
            modificarUsuariioOperativoToolStripMenuItem.Size = new Size(249, 26);
            modificarUsuariioOperativoToolStripMenuItem.Text = "Modificar/Eliminar";
            modificarUsuariioOperativoToolStripMenuItem.Click += modificarUsuariioOperativoToolStripMenuItem_Click;
            // 
            // serviciosAmenidadesToolStripMenuItem
            // 
            serviciosAmenidadesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarServicioToolStripMenuItem, agregarAmenidadToolStripMenuItem });
            serviciosAmenidadesToolStripMenuItem.Name = "serviciosAmenidadesToolStripMenuItem";
            serviciosAmenidadesToolStripMenuItem.Size = new Size(204, 46);
            serviciosAmenidadesToolStripMenuItem.Text = "Servicios/Amenidades";
            // 
            // agregarServicioToolStripMenuItem
            // 
            agregarServicioToolStripMenuItem.Name = "agregarServicioToolStripMenuItem";
            agregarServicioToolStripMenuItem.Size = new Size(239, 26);
            agregarServicioToolStripMenuItem.Text = "Agregar servicio";
            agregarServicioToolStripMenuItem.Click += agregarServicioToolStripMenuItem_Click_1;
            // 
            // agregarAmenidadToolStripMenuItem
            // 
            agregarAmenidadToolStripMenuItem.Name = "agregarAmenidadToolStripMenuItem";
            agregarAmenidadToolStripMenuItem.Size = new Size(239, 26);
            agregarAmenidadToolStripMenuItem.Text = "Agregar amenidad";
            agregarAmenidadToolStripMenuItem.Click += agregarAmenidadToolStripMenuItem_Click_1;
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
            groupBox1.Controls.Add(checkBox1);
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
            groupBox1.Size = new Size(658, 129);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(154, 97);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(252, 26);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Buscar todos en esta ciudad";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(543, 55);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 27);
            btnFiltrar.TabIndex = 9;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dtpAño
            // 
            dtpAño.CustomFormat = "yyyy";
            dtpAño.Format = DateTimePickerFormat.Custom;
            dtpAño.Location = new Point(295, 56);
            dtpAño.Name = "dtpAño";
            dtpAño.Size = new Size(75, 30);
            dtpAño.TabIndex = 8;
            // 
            // comboHotel
            // 
            comboHotel.FormattingEnabled = true;
            comboHotel.Location = new Point(393, 55);
            comboHotel.Name = "comboHotel";
            comboHotel.Size = new Size(121, 30);
            comboHotel.TabIndex = 7;
            // 
            // comboCiudad
            // 
            comboCiudad.FormattingEnabled = true;
            comboCiudad.Location = new Point(154, 55);
            comboCiudad.Name = "comboCiudad";
            comboCiudad.Size = new Size(121, 30);
            comboCiudad.TabIndex = 5;
            comboCiudad.SelectedIndexChanged += comboCiudad_SelectedIndexChanged;
            // 
            // comboPais
            // 
            comboPais.FormattingEnabled = true;
            comboPais.Location = new Point(21, 55);
            comboPais.Name = "comboPais";
            comboPais.Size = new Size(121, 30);
            comboPais.TabIndex = 4;
            comboPais.SelectedIndexChanged += comboPais_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 33);
            label4.Name = "label4";
            label4.Size = new Size(60, 22);
            label4.TabIndex = 3;
            label4.Text = "Hotel:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 33);
            label3.Name = "label3";
            label3.Size = new Size(50, 22);
            label3.TabIndex = 2;
            label3.Text = "Año:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 33);
            label2.Name = "label2";
            label2.Size = new Size(73, 22);
            label2.TabIndex = 1;
            label2.Text = "Ciudad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(50, 22);
            label1.TabIndex = 0;
            label1.Text = "País:";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(744, 314);
            dataGridView1.TabIndex = 3;
            // 
            // PantallaInicialAdmin
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
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
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private ToolStripMenuItem modificarHotelToolStripMenuItem;
        private ToolStripMenuItem serviciosAmenidadesToolStripMenuItem;
        private ToolStripMenuItem agregarServicioToolStripMenuItem;
        private ToolStripMenuItem agregarAmenidadToolStripMenuItem;
        private CheckBox checkBox1;
    }
}