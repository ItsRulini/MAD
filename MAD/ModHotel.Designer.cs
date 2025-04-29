namespace MAD
{
    partial class ModHotel
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnBusquedaHotel = new Button();
            label4 = new Label();
            label3 = new Label();
            textNombreHotel = new TextBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            dgvNuevoServicio = new DataGridView();
            dgvServicio = new DataGridView();
            Servicio = new DataGridViewTextBoxColumn();
            Precio = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            btnAgregarServicio = new Button();
            label1 = new Label();
            label9 = new Label();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            Eliminar = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            btnAddAmenidad = new Button();
            groupBox4 = new GroupBox();
            comboAmenidad = new ComboBox();
            comboBox3 = new ComboBox();
            label7 = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            EliminarServicio = new DataGridViewCheckBoxColumn();
            comboServicio = new ComboBox();
            groupBox5 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNuevoServicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1338, 479);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion del hotel";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBusquedaHotel);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textNombreHotel);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(7, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 100);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda de hotel:";
            // 
            // btnBusquedaHotel
            // 
            btnBusquedaHotel.Font = new Font("Times New Roman", 12F);
            btnBusquedaHotel.Location = new Point(338, 49);
            btnBusquedaHotel.Name = "btnBusquedaHotel";
            btnBusquedaHotel.Size = new Size(75, 25);
            btnBusquedaHotel.TabIndex = 4;
            btnBusquedaHotel.Text = "Buscar";
            btnBusquedaHotel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(198, 26);
            label4.Name = "label4";
            label4.Size = new Size(56, 19);
            label4.TabIndex = 3;
            label4.Text = "Ciudad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(13, 26);
            label3.Name = "label3";
            label3.Size = new Size(115, 19);
            label3.TabIndex = 2;
            label3.Text = "Nombre de hotel:";
            // 
            // textNombreHotel
            // 
            textNombreHotel.Font = new Font("Times New Roman", 12F);
            textNombreHotel.Location = new Point(13, 48);
            textNombreHotel.Name = "textNombreHotel";
            textNombreHotel.Size = new Size(154, 26);
            textNombreHotel.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(198, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(1175, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboServicio);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(dgvNuevoServicio);
            groupBox3.Controls.Add(dgvServicio);
            groupBox3.Controls.Add(Precio);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(btnAgregarServicio);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(694, 140);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(638, 321);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Gestión de servicios:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(4, 97);
            label5.Name = "label5";
            label5.Size = new Size(125, 19);
            label5.TabIndex = 15;
            label5.Text = "Servicios añadidos:";
            // 
            // dgvNuevoServicio
            // 
            dgvNuevoServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNuevoServicio.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, EliminarServicio });
            dgvNuevoServicio.Location = new Point(4, 119);
            dgvNuevoServicio.Name = "dgvNuevoServicio";
            dgvNuevoServicio.Size = new Size(344, 195);
            dgvNuevoServicio.TabIndex = 14;
            // 
            // dgvServicio
            // 
            dgvServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicio.Columns.AddRange(new DataGridViewColumn[] { Servicio });
            dgvServicio.Location = new Point(374, 119);
            dgvServicio.Name = "dgvServicio";
            dgvServicio.Size = new Size(244, 195);
            dgvServicio.TabIndex = 4;
            // 
            // Servicio
            // 
            Servicio.HeaderText = "Nombre";
            Servicio.Name = "Servicio";
            Servicio.Width = 200;
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Font = new Font("Times New Roman", 12F);
            Precio.Location = new Point(173, 35);
            Precio.Name = "Precio";
            Precio.Size = new Size(51, 19);
            Precio.TabIndex = 13;
            Precio.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(374, 98);
            label2.Name = "label2";
            label2.Size = new Size(129, 19);
            label2.TabIndex = 3;
            label2.Text = "Servicios existentes:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 23);
            textBox1.TabIndex = 12;
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.Font = new Font("Times New Roman", 12F);
            btnAgregarServicio.Location = new Point(374, 49);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(135, 34);
            btnAgregarServicio.TabIndex = 1;
            btnAgregarServicio.Text = "Agregar servicio";
            btnAgregarServicio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(5, 35);
            label1.Name = "label1";
            label1.Size = new Size(135, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre del servicio:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F);
            label9.Location = new Point(173, 35);
            label9.Name = "label9";
            label9.Size = new Size(139, 19);
            label9.TabIndex = 0;
            label9.Text = "Seleccione amenidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F);
            label8.Location = new Point(376, 98);
            label8.Name = "label8";
            label8.Size = new Size(262, 19);
            label8.TabIndex = 3;
            label8.Text = "Amenidades existentes (No modificables):";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3 });
            dataGridView2.Location = new Point(376, 120);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(244, 195);
            dataGridView2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, Eliminar });
            dataGridView1.Location = new Point(6, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(345, 195);
            dataGridView1.TabIndex = 14;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(6, 98);
            label6.Name = "label6";
            label6.Size = new Size(141, 19);
            label6.TabIndex = 15;
            label6.Text = "Amenidades añadidas";
            // 
            // btnAddAmenidad
            // 
            btnAddAmenidad.Font = new Font("Times New Roman", 12F);
            btnAddAmenidad.Location = new Point(376, 42);
            btnAddAmenidad.Name = "btnAddAmenidad";
            btnAddAmenidad.Size = new Size(139, 33);
            btnAddAmenidad.TabIndex = 16;
            btnAddAmenidad.Text = "Agregar amenidad";
            btnAddAmenidad.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(comboBox3);
            groupBox4.Controls.Add(comboAmenidad);
            groupBox4.Controls.Add(btnAddAmenidad);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(7, 140);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(668, 321);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Gestión de amenidades:";
            // 
            // comboAmenidad
            // 
            comboAmenidad.FormattingEnabled = true;
            comboAmenidad.Location = new Point(173, 57);
            comboAmenidad.Name = "comboAmenidad";
            comboAmenidad.Size = new Size(158, 23);
            comboAmenidad.TabIndex = 17;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(13, 57);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(142, 23);
            comboBox3.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F);
            label7.Location = new Point(11, 35);
            label7.Name = "label7";
            label7.Size = new Size(123, 19);
            label7.TabIndex = 19;
            label7.Text = "Tipo de habitación:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // EliminarServicio
            // 
            EliminarServicio.HeaderText = "Eliminar";
            EliminarServicio.Name = "EliminarServicio";
            EliminarServicio.Resizable = DataGridViewTriState.True;
            EliminarServicio.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // comboServicio
            // 
            comboServicio.FormattingEnabled = true;
            comboServicio.Location = new Point(9, 57);
            comboServicio.Name = "comboServicio";
            comboServicio.Size = new Size(148, 23);
            comboServicio.TabIndex = 16;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(numericUpDown1);
            groupBox5.Location = new Point(445, 29);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(362, 93);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Configuración del hotel:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(14, 46);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 19);
            label10.Name = "label10";
            label10.Size = new Size(100, 15);
            label10.TabIndex = 1;
            label10.Text = "Número de pisos:";
            // 
            // ModHotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1362, 505);
            Controls.Add(groupBox1);
            Name = "ModHotel";
            Text = "Modificar Hotel";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNuevoServicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private DataGridView dgvServicio;
        private DataGridViewTextBoxColumn Servicio;
        private Label label2;
        private TextBox textNombreServicio;
        private Button btnAgregarServicio;
        private Label label1;
        private Label Precio;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button btnBusquedaHotel;
        private Label label4;
        private Label label3;
        private TextBox textNombreHotel;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private Label label5;
        private DataGridView dgvNuevoServicio;
        private Label label7;
        private TextBox textBox2;
        private GroupBox groupBox4;
        private ComboBox comboBox3;
        private ComboBox comboAmenidad;
        private Button btnAddAmenidad;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewCheckBoxColumn Eliminar;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label8;
        private Label label9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn EliminarServicio;
        private ComboBox comboServicio;
        private GroupBox groupBox5;
        private NumericUpDown numericUpDown1;
        private Label label10;
    }
}