namespace MAD
{
    partial class HistorialCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialCliente));
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioTodaHistoria = new RadioButton();
            btnHistorial = new Button();
            radioMesAño = new RadioButton();
            radioAño = new RadioButton();
            label3 = new Label();
            comboCliente = new ComboBox();
            checkApellidos = new CheckBox();
            pictureBox1 = new PictureBox();
            btnFiltrar = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBuscar = new TextBox();
            label1 = new Label();
            dgvHistCliente = new DataGridView();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistCliente).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboCliente);
            groupBox1.Controls.Add(checkApellidos);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBuscar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvHistCliente);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1357, 597);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historial de cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioTodaHistoria);
            groupBox2.Controls.Add(btnHistorial);
            groupBox2.Controls.Add(radioMesAño);
            groupBox2.Controls.Add(radioAño);
            groupBox2.Location = new Point(767, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 108);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar por:";
            // 
            // radioTodaHistoria
            // 
            radioTodaHistoria.AutoSize = true;
            radioTodaHistoria.Location = new Point(204, 27);
            radioTodaHistoria.Name = "radioTodaHistoria";
            radioTodaHistoria.Size = new Size(156, 26);
            radioTodaHistoria.TabIndex = 20;
            radioTodaHistoria.TabStop = true;
            radioTodaHistoria.Text = "Toda la historia";
            radioTodaHistoria.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(94, 69);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(179, 33);
            btnHistorial.TabIndex = 17;
            btnHistorial.Text = "Ver historial";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // radioMesAño
            // 
            radioMesAño.AutoSize = true;
            radioMesAño.Location = new Point(14, 27);
            radioMesAño.Name = "radioMesAño";
            radioMesAño.Size = new Size(113, 26);
            radioMesAño.TabIndex = 18;
            radioMesAño.TabStop = true;
            radioMesAño.Text = "Mes y año";
            radioMesAño.UseVisualStyleBackColor = true;
            // 
            // radioAño
            // 
            radioAño.AutoSize = true;
            radioAño.Location = new Point(133, 26);
            radioAño.Name = "radioAño";
            radioAño.Size = new Size(65, 26);
            radioAño.TabIndex = 19;
            radioAño.TabStop = true;
            radioAño.Text = "Año";
            radioAño.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 38);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 16;
            label3.Text = "Cliente:";
            // 
            // comboCliente
            // 
            comboCliente.FormattingEnabled = true;
            comboCliente.Location = new Point(337, 75);
            comboCliente.Name = "comboCliente";
            comboCliente.Size = new Size(202, 30);
            comboCliente.TabIndex = 15;
            // 
            // checkApellidos
            // 
            checkApellidos.AutoSize = true;
            checkApellidos.Location = new Point(22, 128);
            checkApellidos.Name = "checkApellidos";
            checkApellidos.Size = new Size(198, 26);
            checkApellidos.TabIndex = 14;
            checkApellidos.Text = "Buscar por apellidos";
            checkApellidos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(1203, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(337, 123);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(202, 35);
            btnFiltrar.TabIndex = 5;
            btnFiltrar.Text = "Filtrar cliente";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(602, 38);
            label2.Name = "label2";
            label2.Size = new Size(50, 22);
            label2.TabIndex = 4;
            label2.Text = "Año:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(602, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(129, 30);
            dateTimePicker1.TabIndex = 3;
            // 
            // textBuscar
            // 
            textBuscar.Location = new Point(22, 72);
            textBuscar.Name = "textBuscar";
            textBuscar.Size = new Size(288, 30);
            textBuscar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 38);
            label1.Name = "label1";
            label1.Size = new Size(245, 22);
            label1.TabIndex = 1;
            label1.Text = "Correo/Apellidos del cliente:";
            // 
            // dgvHistCliente
            // 
            dgvHistCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistCliente.Location = new Point(6, 191);
            dgvHistCliente.Name = "dgvHistCliente";
            dgvHistCliente.RowHeadersWidth = 51;
            dgvHistCliente.Size = new Size(1334, 400);
            dgvHistCliente.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1184, 151);
            label4.Name = "label4";
            label4.Size = new Size(156, 22);
            label4.TabIndex = 22;
            label4.Text = "(precios en MXN)";
            // 
            // HistorialCliente
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1381, 621);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "HistorialCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HistorialCliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvHistCliente;
        private Button btnFiltrar;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBuscar;
        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox checkApellidos;
        private Label label3;
        private ComboBox comboCliente;
        private Button btnHistorial;
        private GroupBox groupBox2;
        private RadioButton radioTodaHistoria;
        private RadioButton radioMesAño;
        private RadioButton radioAño;
        private Label label4;
    }
}