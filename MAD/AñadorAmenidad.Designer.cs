namespace MAD
{
    partial class AñadorAmenidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AñadorAmenidad));
            groupBox1 = new GroupBox();
            label5 = new Label();
            textUnidad = new TextBox();
            textClaveSAT = new TextBox();
            label4 = new Label();
            label3 = new Label();
            comboClaveUnidad = new ComboBox();
            pictureBox1 = new PictureBox();
            dgvAmenidadExistente = new DataGridView();
            Servicio = new DataGridViewTextBoxColumn();
            label2 = new Label();
            textNombreAmenidad = new TextBox();
            btnAgregarAmenidad = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAmenidadExistente).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textUnidad);
            groupBox1.Controls.Add(textClaveSAT);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboClaveUnidad);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(dgvAmenidadExistente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textNombreAmenidad);
            groupBox1.Controls.Add(btnAgregarAmenidad);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 382);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión de amenidades";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(158, 84);
            label5.Name = "label5";
            label5.Size = new Size(73, 22);
            label5.TabIndex = 17;
            label5.Text = "Unidad:";
            // 
            // textUnidad
            // 
            textUnidad.Enabled = false;
            textUnidad.Location = new Point(157, 106);
            textUnidad.Name = "textUnidad";
            textUnidad.Size = new Size(125, 30);
            textUnidad.TabIndex = 16;
            textUnidad.KeyPress += textClaveSAT_KeyPress;
            // 
            // textClaveSAT
            // 
            textClaveSAT.Location = new Point(179, 51);
            textClaveSAT.Name = "textClaveSAT";
            textClaveSAT.Size = new Size(100, 30);
            textClaveSAT.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 29);
            label4.Name = "label4";
            label4.Size = new Size(126, 22);
            label4.TabIndex = 14;
            label4.Text = "Clave de SAT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 86);
            label3.Name = "label3";
            label3.Size = new Size(145, 22);
            label3.TabIndex = 13;
            label3.Text = "Clave de unidad:";
            // 
            // comboClaveUnidad
            // 
            comboClaveUnidad.FormattingEnabled = true;
            comboClaveUnidad.Location = new Point(6, 108);
            comboClaveUnidad.Name = "comboClaveUnidad";
            comboClaveUnidad.Size = new Size(121, 30);
            comboClaveUnidad.TabIndex = 12;
            comboClaveUnidad.SelectedIndexChanged += comboClaveUnidad_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(305, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // dgvAmenidadExistente
            // 
            dgvAmenidadExistente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmenidadExistente.Columns.AddRange(new DataGridViewColumn[] { Servicio });
            dgvAmenidadExistente.Location = new Point(6, 173);
            dgvAmenidadExistente.Name = "dgvAmenidadExistente";
            dgvAmenidadExistente.RowHeadersWidth = 51;
            dgvAmenidadExistente.Size = new Size(244, 195);
            dgvAmenidadExistente.TabIndex = 4;
            // 
            // Servicio
            // 
            Servicio.HeaderText = "Nombre";
            Servicio.MinimumWidth = 6;
            Servicio.Name = "Servicio";
            Servicio.Width = 200;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 151);
            label2.Name = "label2";
            label2.Size = new Size(196, 22);
            label2.TabIndex = 3;
            label2.Text = "Amenidades existentes:";
            // 
            // textNombreAmenidad
            // 
            textNombreAmenidad.Location = new Point(6, 51);
            textNombreAmenidad.Name = "textNombreAmenidad";
            textNombreAmenidad.Size = new Size(158, 30);
            textNombreAmenidad.TabIndex = 2;
            // 
            // btnAgregarAmenidad
            // 
            btnAgregarAmenidad.Location = new Point(305, 334);
            btnAgregarAmenidad.Name = "btnAgregarAmenidad";
            btnAgregarAmenidad.Size = new Size(135, 34);
            btnAgregarAmenidad.TabIndex = 1;
            btnAgregarAmenidad.Text = "Agregar amenidad";
            btnAgregarAmenidad.UseVisualStyleBackColor = true;
            btnAgregarAmenidad.Click += btnAgregarAmenidad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(205, 22);
            label1.TabIndex = 0;
            label1.Text = "Nombre de la amenidad:";
            // 
            // AñadorAmenidad
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(482, 405);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AñadorAmenidad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AñadorAmenidad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAmenidadExistente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private DataGridView dgvAmenidadExistente;
        private DataGridViewTextBoxColumn Servicio;
        private Label label2;
        private TextBox textNombreAmenidad;
        private Button btnAgregarAmenidad;
        private Label label1;
        private Label label3;
        private ComboBox comboClaveUnidad;
        private TextBox textClaveSAT;
        private Label label4;
        private Label label5;
        private TextBox textUnidad;
    }
}