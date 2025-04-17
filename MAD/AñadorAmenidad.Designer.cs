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
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(dgvAmenidadExistente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textNombreAmenidad);
            groupBox1.Controls.Add(btnAgregarAmenidad);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(611, 341);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión de amenidades";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(468, 17);
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
            dgvAmenidadExistente.Location = new Point(211, 117);
            dgvAmenidadExistente.Name = "dgvAmenidadExistente";
            dgvAmenidadExistente.Size = new Size(244, 195);
            dgvAmenidadExistente.TabIndex = 4;
            // 
            // Servicio
            // 
            Servicio.HeaderText = "Nombre";
            Servicio.Name = "Servicio";
            Servicio.Width = 200;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 95);
            label2.Name = "label2";
            label2.Size = new Size(149, 19);
            label2.TabIndex = 3;
            label2.Text = "Amenidades existentes:";
            // 
            // textNombreAmenidad
            // 
            textNombreAmenidad.Location = new Point(30, 128);
            textNombreAmenidad.Name = "textNombreAmenidad";
            textNombreAmenidad.Size = new Size(135, 26);
            textNombreAmenidad.TabIndex = 2;
            // 
            // btnAgregarAmenidad
            // 
            btnAgregarAmenidad.Location = new Point(30, 171);
            btnAgregarAmenidad.Name = "btnAgregarAmenidad";
            btnAgregarAmenidad.Size = new Size(135, 34);
            btnAgregarAmenidad.TabIndex = 1;
            btnAgregarAmenidad.Text = "Agregar amenidad";
            btnAgregarAmenidad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 95);
            label1.Name = "label1";
            label1.Size = new Size(158, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre de la amenidad:";
            // 
            // AñadorAmenidad
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(635, 365);
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
    }
}