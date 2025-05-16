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
            checkBox1 = new CheckBox();
            dgvVistaUno = new DataGridView();
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
            dgvVistaDos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVistaUno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVistaDos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(dgvVistaUno);
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
            groupBox1.Controls.Add(dgvVistaDos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1035, 638);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reporte de ocupación";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(184, 121);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(265, 26);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Buscar hoteles en esta ciudad";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dgvVistaUno
            // 
            dgvVistaUno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVistaUno.Location = new Point(11, 166);
            dgvVistaUno.Name = "dgvVistaUno";
            dgvVistaUno.RowHeadersWidth = 51;
            dgvVistaUno.Size = new Size(840, 222);
            dgvVistaUno.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(866, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnFiltarOcupacion
            // 
            btnFiltarOcupacion.Location = new Point(866, 584);
            btnFiltarOcupacion.Name = "btnFiltarOcupacion";
            btnFiltarOcupacion.Size = new Size(163, 39);
            btnFiltarOcupacion.TabIndex = 10;
            btnFiltarOcupacion.Text = "Filtrar";
            btnFiltarOcupacion.UseVisualStyleBackColor = true;
            btnFiltarOcupacion.Click += btnFiltarOcupacion_Click;
            // 
            // comboHotel
            // 
            comboHotel.FormattingEnabled = true;
            comboHotel.Location = new Point(398, 72);
            comboHotel.Name = "comboHotel";
            comboHotel.Size = new Size(165, 30);
            comboHotel.TabIndex = 9;
            // 
            // comboCiudad
            // 
            comboCiudad.FormattingEnabled = true;
            comboCiudad.Location = new Point(184, 72);
            comboCiudad.Name = "comboCiudad";
            comboCiudad.Size = new Size(208, 30);
            comboCiudad.TabIndex = 8;
            comboCiudad.SelectedIndexChanged += comboCiudad_SelectedIndexChanged;
            // 
            // dtpAñoReporte
            // 
            dtpAñoReporte.CustomFormat = "yyyy";
            dtpAñoReporte.Format = DateTimePickerFormat.Custom;
            dtpAñoReporte.Location = new Point(586, 72);
            dtpAñoReporte.Name = "dtpAñoReporte";
            dtpAñoReporte.Size = new Size(110, 30);
            dtpAñoReporte.TabIndex = 7;
            // 
            // comboPais
            // 
            comboPais.FormattingEnabled = true;
            comboPais.Location = new Point(11, 72);
            comboPais.Name = "comboPais";
            comboPais.Size = new Size(167, 30);
            comboPais.TabIndex = 6;
            comboPais.SelectedIndexChanged += comboPais_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 47);
            label4.Name = "label4";
            label4.Size = new Size(60, 22);
            label4.TabIndex = 5;
            label4.Text = "Hotel:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 47);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 4;
            label3.Text = "Ciudad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(586, 47);
            label2.Name = "label2";
            label2.Size = new Size(50, 22);
            label2.TabIndex = 3;
            label2.Text = "Año:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 47);
            label1.Name = "label1";
            label1.Size = new Size(50, 22);
            label1.TabIndex = 2;
            label1.Text = "Pais:";
            label1.Click += label1_Click;
            // 
            // dgvVistaDos
            // 
            dgvVistaDos.AllowUserToDeleteRows = false;
            dgvVistaDos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVistaDos.Location = new Point(11, 416);
            dgvVistaDos.Name = "dgvVistaDos";
            dgvVistaDos.RowHeadersWidth = 51;
            dgvVistaDos.Size = new Size(840, 207);
            dgvVistaDos.TabIndex = 1;
            // 
            // ReporteOcupacion
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1059, 662);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ReporteOcupacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteOcupacion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVistaUno).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVistaDos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dgvVistaDos;
        private DateTimePicker dtpAñoReporte;
        private ComboBox comboPais;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboCiudad;
        private Button btnFiltarOcupacion;
        private ComboBox comboHotel;
        private PictureBox pictureBox1;
        private DataGridView dgvVistaUno;
        private CheckBox checkBox1;
    }
}