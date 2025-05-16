namespace MAD
{
    partial class Facturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturar));
            label1 = new Label();
            groupBox1 = new GroupBox();
            textAnticipo = new Label();
            label4 = new Label();
            textTotal = new Label();
            label7 = new Label();
            textIVA = new Label();
            label5 = new Label();
            textSubTotal = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            btnBuscarReservacion = new Button();
            textIdReservacion = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(178, 22);
            label1.TabIndex = 0;
            label1.Text = "ID de la reservación:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textAnticipo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textTotal);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textIVA);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textSubTotal);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnBuscarReservacion);
            groupBox1.Controls.Add(textIdReservacion);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1159, 686);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Facturar:";
            // 
            // textAnticipo
            // 
            textAnticipo.AutoSize = true;
            textAnticipo.Location = new Point(531, 589);
            textAnticipo.Name = "textAnticipo";
            textAnticipo.Size = new Size(85, 22);
            textAnticipo.TabIndex = 20;
            textAnticipo.Text = "$ 0 MXN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 589);
            label4.Name = "label4";
            label4.Size = new Size(181, 22);
            label4.TabIndex = 19;
            label4.Text = "Descuento (anticipo):";
            // 
            // textTotal
            // 
            textTotal.AutoSize = true;
            textTotal.Location = new Point(531, 653);
            textTotal.Name = "textTotal";
            textTotal.Size = new Size(85, 22);
            textTotal.TabIndex = 18;
            textTotal.Text = "$ 0 MXN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(468, 653);
            label7.Name = "label7";
            label7.Size = new Size(57, 22);
            label7.TabIndex = 17;
            label7.Text = "Total:";
            // 
            // textIVA
            // 
            textIVA.AutoSize = true;
            textIVA.Location = new Point(531, 621);
            textIVA.Name = "textIVA";
            textIVA.Size = new Size(85, 22);
            textIVA.TabIndex = 16;
            textIVA.Text = "$ 0 MXN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(479, 621);
            label5.Name = "label5";
            label5.Size = new Size(46, 22);
            label5.TabIndex = 15;
            label5.Text = "IVA:";
            // 
            // textSubTotal
            // 
            textSubTotal.AutoSize = true;
            textSubTotal.Location = new Point(531, 554);
            textSubTotal.Name = "textSubTotal";
            textSubTotal.Size = new Size(85, 22);
            textSubTotal.TabIndex = 14;
            textSubTotal.Text = "$ 0 MXN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 554);
            label3.Name = "label3";
            label3.Size = new Size(81, 22);
            label3.TabIndex = 2;
            label3.Text = "Subtotal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 121);
            label2.Name = "label2";
            label2.Size = new Size(204, 22);
            label2.TabIndex = 13;
            label2.Text = "Resumen de facturación:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1003, 391);
            dataGridView1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(975, 617);
            button2.Name = "button2";
            button2.Size = new Size(177, 63);
            button2.TabIndex = 11;
            button2.Text = "Generar factura";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnBuscarReservacion
            // 
            btnBuscarReservacion.Location = new Point(432, 62);
            btnBuscarReservacion.Name = "btnBuscarReservacion";
            btnBuscarReservacion.Size = new Size(184, 37);
            btnBuscarReservacion.TabIndex = 10;
            btnBuscarReservacion.Text = "Buscar reservación";
            btnBuscarReservacion.UseVisualStyleBackColor = true;
            btnBuscarReservacion.Click += btnBuscarReservacion_Click;
            // 
            // textIdReservacion
            // 
            textIdReservacion.Location = new Point(6, 62);
            textIdReservacion.Name = "textIdReservacion";
            textIdReservacion.ReadOnly = true;
            textIdReservacion.Size = new Size(390, 30);
            textIdReservacion.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(1016, 30);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Facturar
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(1183, 710);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Facturar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturar";
            Load += Facturar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button btnBuscarReservacion;
        private TextBox textIdReservacion;
        private Label label2;
        private DataGridView dataGridView1;
        private Label textTotal;
        private Label label7;
        private Label textIVA;
        private Label label5;
        private Label textSubTotal;
        private Label label3;
        private Label textAnticipo;
        private Label label4;
    }
}