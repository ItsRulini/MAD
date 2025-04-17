namespace MAD
{
    partial class ReporteOcupacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteOcupacion));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnFiltarOcupacion = new Button();
            comboHotel = new ComboBox();
            comboCiudad = new ComboBox();
            dtpAñoReporte = new DateTimePicker();
            comboPais = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvRptOcupacion = new DataGridView();
            Ciudad = new DataGridViewTextBoxColumn();
            Hotel = new DataGridViewTextBoxColumn();
            Año = new DataGridViewTextBoxColumn();
            IngresosPorHospedaje = new DataGridViewTextBoxColumn();
            IngresosServAdicionales = new DataGridViewTextBoxColumn();
            IngresosTotales = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRptOcupacion).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnFiltarOcupacion);
            groupBox1.Controls.Add(comboHotel);
            groupBox1.Controls.Add(comboCiudad);
            groupBox1.Controls.Add(dtpAñoReporte);
            groupBox1.Controls.Add(comboPais);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvRptOcupacion);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(756, 546);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reporte de ocupación";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(613, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnFiltarOcupacion
            // 
            btnFiltarOcupacion.Location = new Point(532, 78);
            btnFiltarOcupacion.Name = "btnFiltarOcupacion";
            btnFiltarOcupacion.Size = new Size(75, 28);
            btnFiltarOcupacion.TabIndex = 10;
            btnFiltarOcupacion.Text = "Filtrar";
            btnFiltarOcupacion.UseVisualStyleBackColor = true;
            // 
            // comboHotel
            // 
            comboHotel.FormattingEnabled = true;
            comboHotel.Location = new Point(391, 77);
            comboHotel.Name = "comboHotel";
            comboHotel.Size = new Size(121, 27);
            comboHotel.TabIndex = 9;
            // 
            // comboCiudad
            // 
            comboCiudad.FormattingEnabled = true;
            comboCiudad.Location = new Point(247, 76);
            comboCiudad.Name = "comboCiudad";
            comboCiudad.Size = new Size(121, 27);
            comboCiudad.TabIndex = 8;
            // 
            // dtpAñoReporte
            // 
            dtpAñoReporte.CustomFormat = "yyyy";
            dtpAñoReporte.Format = DateTimePickerFormat.Custom;
            dtpAñoReporte.Location = new Point(158, 77);
            dtpAñoReporte.Name = "dtpAñoReporte";
            dtpAñoReporte.Size = new Size(60, 26);
            dtpAñoReporte.TabIndex = 7;
            // 
            // comboPais
            // 
            comboPais.FormattingEnabled = true;
            comboPais.Location = new Point(11, 76);
            comboPais.Name = "comboPais";
            comboPais.Size = new Size(121, 27);
            comboPais.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 42);
            label4.Name = "label4";
            label4.Size = new Size(45, 19);
            label4.TabIndex = 5;
            label4.Text = "Hotel:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 42);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 4;
            label3.Text = "Ciudad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 42);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 3;
            label2.Text = "Año:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 42);
            label1.Name = "label1";
            label1.Size = new Size(37, 19);
            label1.TabIndex = 2;
            label1.Text = "Pais:";
            label1.Click += label1_Click;
            // 
            // dgvRptOcupacion
            // 
            dgvRptOcupacion.AllowUserToDeleteRows = false;
            dgvRptOcupacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRptOcupacion.Columns.AddRange(new DataGridViewColumn[] { Ciudad, Hotel, Año, IngresosPorHospedaje, IngresosServAdicionales, IngresosTotales });
            dgvRptOcupacion.Location = new Point(11, 121);
            dgvRptOcupacion.Name = "dgvRptOcupacion";
            dgvRptOcupacion.Size = new Size(739, 419);
            dgvRptOcupacion.TabIndex = 1;
            // 
            // Ciudad
            // 
            Ciudad.Frozen = true;
            Ciudad.HeaderText = "Ciudad";
            Ciudad.Name = "Ciudad";
            Ciudad.ReadOnly = true;
            Ciudad.Width = 115;
            // 
            // Hotel
            // 
            Hotel.Frozen = true;
            Hotel.HeaderText = "Hotel";
            Hotel.Name = "Hotel";
            Hotel.ReadOnly = true;
            Hotel.Width = 115;
            // 
            // Año
            // 
            Año.Frozen = true;
            Año.HeaderText = "Año";
            Año.Name = "Año";
            Año.ReadOnly = true;
            Año.Width = 115;
            // 
            // IngresosPorHospedaje
            // 
            IngresosPorHospedaje.Frozen = true;
            IngresosPorHospedaje.HeaderText = "Ingresos por hospedaje";
            IngresosPorHospedaje.Name = "IngresosPorHospedaje";
            IngresosPorHospedaje.ReadOnly = true;
            IngresosPorHospedaje.Width = 115;
            // 
            // IngresosServAdicionales
            // 
            IngresosServAdicionales.Frozen = true;
            IngresosServAdicionales.HeaderText = "Ingresos por servicios adicionales";
            IngresosServAdicionales.Name = "IngresosServAdicionales";
            IngresosServAdicionales.ReadOnly = true;
            IngresosServAdicionales.Width = 115;
            // 
            // IngresosTotales
            // 
            IngresosTotales.Frozen = true;
            IngresosTotales.HeaderText = "Ingresos totales";
            IngresosTotales.Name = "IngresosTotales";
            IngresosTotales.ReadOnly = true;
            IngresosTotales.Width = 115;
            // 
            // ReporteOcupacion
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(780, 570);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ReporteOcupacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteOcupacion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRptOcupacion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dgvRptOcupacion;
        private DateTimePicker dtpAñoReporte;
        private ComboBox comboPais;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboCiudad;
        private Button btnFiltarOcupacion;
        private ComboBox comboHotel;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Ciudad;
        private DataGridViewTextBoxColumn Hotel;
        private DataGridViewTextBoxColumn Año;
        private DataGridViewTextBoxColumn IngresosPorHospedaje;
        private DataGridViewTextBoxColumn IngresosServAdicionales;
        private DataGridViewTextBoxColumn IngresosTotales;
    }
}