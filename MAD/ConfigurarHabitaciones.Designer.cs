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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            dgvCamas = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            dgvAmenidades = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            numericUpDown2 = new NumericUpDown();
            Amenidad = new DataGridViewTextBoxColumn();
            AmenidadSelect = new DataGridViewCheckBoxColumn();
            pictureBox1 = new PictureBox();
            Nombre = new DataGridViewTextBoxColumn();
            UbicacionHab = new DataGridViewTextBoxColumn();
            PrecioPorNoche = new DataGridViewTextBoxColumn();
            PrecioPorPersona = new DataGridViewTextBoxColumn();
            MaxPersonas = new DataGridViewTextBoxColumn();
            TipoCama = new DataGridViewTextBoxColumn();
            CantidadCamas = new DataGridViewTextBoxColumn();
            AmenidadesHab = new DataGridViewTextBoxColumn();
            EliminarHab = new DataGridViewCheckBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCamas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAmenidades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre/Nivel:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 113);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 1;
            label2.Text = "Tipo de cama:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 176);
            label3.Name = "label3";
            label3.Size = new Size(128, 19);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de camas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 22);
            label5.Name = "label5";
            label5.Size = new Size(128, 19);
            label5.TabIndex = 4;
            label5.Text = "Precio por persona:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 22);
            label6.Name = "label6";
            label6.Size = new Size(203, 19);
            label6.TabIndex = 5;
            label6.Text = "Cantidad máxima de huéspedes:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(dgvAmenidades);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dgvCamas);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(958, 546);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configuración de habitaciones";
            // 
            // dgvCamas
            // 
            dgvCamas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCamas.Columns.AddRange(new DataGridViewColumn[] { Nombre, UbicacionHab, PrecioPorNoche, PrecioPorPersona, MaxPersonas, TipoCama, CantidadCamas, AmenidadesHab, EliminarHab });
            dgvCamas.Location = new Point(23, 345);
            dgvCamas.Name = "dgvCamas";
            dgvCamas.Size = new Size(920, 168);
            dgvCamas.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(23, 256);
            button1.Name = "button1";
            button1.Size = new Size(128, 31);
            button1.TabIndex = 7;
            button1.Text = "Agregar cama";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(813, 241);
            button2.Name = "button2";
            button2.Size = new Size(130, 77);
            button2.TabIndex = 8;
            button2.Text = "Agregar habitación";
            button2.UseVisualStyleBackColor = true;
            // 
            // dgvAmenidades
            // 
            dgvAmenidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmenidades.Columns.AddRange(new DataGridViewColumn[] { Amenidad, AmenidadSelect });
            dgvAmenidades.Location = new Point(198, 89);
            dgvAmenidades.Name = "dgvAmenidades";
            dgvAmenidades.Size = new Size(395, 229);
            dgvAmenidades.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 26);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 26);
            textBox2.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(351, 44);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(203, 26);
            numericUpDown1.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 27);
            comboBox1.TabIndex = 14;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(18, 198);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(133, 26);
            numericUpDown2.TabIndex = 15;
            // 
            // Amenidad
            // 
            Amenidad.HeaderText = "Amenidad";
            Amenidad.Name = "Amenidad";
            Amenidad.Width = 150;
            // 
            // AmenidadSelect
            // 
            AmenidadSelect.HeaderText = "Seleccione las amenidades para su habitación";
            AmenidadSelect.Name = "AmenidadSelect";
            AmenidadSelect.Width = 200;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(794, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nivel de habitación";
            Nombre.Name = "Nombre";
            // 
            // UbicacionHab
            // 
            UbicacionHab.HeaderText = "Ubicación";
            UbicacionHab.Name = "UbicacionHab";
            // 
            // PrecioPorNoche
            // 
            PrecioPorNoche.HeaderText = "Precio por noche";
            PrecioPorNoche.Name = "PrecioPorNoche";
            // 
            // PrecioPorPersona
            // 
            PrecioPorPersona.HeaderText = "Precio por persona";
            PrecioPorPersona.Name = "PrecioPorPersona";
            // 
            // MaxPersonas
            // 
            MaxPersonas.HeaderText = "Cantidad máxima de huéspedes";
            MaxPersonas.Name = "MaxPersonas";
            // 
            // TipoCama
            // 
            TipoCama.HeaderText = "Tipo de cama";
            TipoCama.Name = "TipoCama";
            // 
            // CantidadCamas
            // 
            CantidadCamas.HeaderText = "Cantidad de camas";
            CantidadCamas.Name = "CantidadCamas";
            // 
            // AmenidadesHab
            // 
            AmenidadesHab.HeaderText = "Amenidades";
            AmenidadesHab.Name = "AmenidadesHab";
            // 
            // EliminarHab
            // 
            EliminarHab.HeaderText = "Eliminar";
            EliminarHab.Name = "EliminarHab";
            EliminarHab.Width = 75;
            // 
            // ConfigurarHabitaciones
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(983, 570);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 4, 4, 4);
            Name = "ConfigurarHabitaciones";
            Text = "ConfigurarHabitaciones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCamas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAmenidades).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button button2;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private Button button1;
        private DataGridView dgvCamas;
        private DataGridView dgvAmenidades;
        private TextBox textBox2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown2;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private DataGridViewTextBoxColumn Amenidad;
        private DataGridViewCheckBoxColumn AmenidadSelect;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn UbicacionHab;
        private DataGridViewTextBoxColumn PrecioPorNoche;
        private DataGridViewTextBoxColumn PrecioPorPersona;
        private DataGridViewTextBoxColumn MaxPersonas;
        private DataGridViewTextBoxColumn TipoCama;
        private DataGridViewTextBoxColumn CantidadCamas;
        private DataGridViewTextBoxColumn AmenidadesHab;
        private DataGridViewCheckBoxColumn EliminarHab;
    }
}