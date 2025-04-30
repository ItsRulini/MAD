namespace MAD
{
    partial class AñadirServicio
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
            textClaveSAT = new TextBox();
            label4 = new Label();
            label3 = new Label();
            comboClaveUnidad = new ComboBox();
            pictureBox1 = new PictureBox();
            dgvServiciosExistente = new DataGridView();
            Servicio = new DataGridViewTextBoxColumn();
            label2 = new Label();
            textNombreServicio = new TextBox();
            btnAgregarServicio = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiciosExistente).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textClaveSAT);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboClaveUnidad);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(dgvServiciosExistente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textNombreServicio);
            groupBox1.Controls.Add(btnAgregarServicio);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 382);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestión de servicios";
            // 
            // textClaveSAT
            // 
            textClaveSAT.Location = new Point(179, 51);
            textClaveSAT.Name = "textClaveSAT";
            textClaveSAT.Size = new Size(100, 26);
            textClaveSAT.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 29);
            label4.Name = "label4";
            label4.Size = new Size(96, 19);
            label4.TabIndex = 14;
            label4.Text = "Clave de SAT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 86);
            label3.Name = "label3";
            label3.Size = new Size(110, 19);
            label3.TabIndex = 13;
            label3.Text = "Clave de unidad:";
            // 
            // comboClaveUnidad
            // 
            comboClaveUnidad.FormattingEnabled = true;
            comboClaveUnidad.Location = new Point(6, 108);
            comboClaveUnidad.Name = "comboClaveUnidad";
            comboClaveUnidad.Size = new Size(121, 27);
            comboClaveUnidad.TabIndex = 12;
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
            // dgvServiciosExistente
            // 
            dgvServiciosExistente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiciosExistente.Columns.AddRange(new DataGridViewColumn[] { Servicio });
            dgvServiciosExistente.Location = new Point(6, 173);
            dgvServiciosExistente.Name = "dgvServiciosExistente";
            dgvServiciosExistente.Size = new Size(244, 195);
            dgvServiciosExistente.TabIndex = 4;
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
            label2.Location = new Point(6, 151);
            label2.Name = "label2";
            label2.Size = new Size(129, 19);
            label2.TabIndex = 3;
            label2.Text = "Servicios existentes:";
            // 
            // textNombreServicio
            // 
            textNombreServicio.Location = new Point(6, 51);
            textNombreServicio.Name = "textNombreServicio";
            textNombreServicio.Size = new Size(158, 26);
            textNombreServicio.TabIndex = 2;
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.Location = new Point(144, 103);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(135, 34);
            btnAgregarServicio.TabIndex = 1;
            btnAgregarServicio.Text = "Agregar servicio";
            btnAgregarServicio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(135, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre del servicio:";
            // 
            // AñadirServicio
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(482, 405);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F);
            Margin = new Padding(4);
            Name = "AñadirServicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AñadirServicio";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvServiciosExistente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textClaveSAT;
        private Label label4;
        private Label label3;
        private ComboBox comboClaveUnidad;
        private PictureBox pictureBox1;
        private DataGridView dgvServiciosExistente;
        private DataGridViewTextBoxColumn Servicio;
        private Label label2;
        private TextBox textNombreServicio;
        private Button btnAgregarServicio;
        private Label label1;
    }
}