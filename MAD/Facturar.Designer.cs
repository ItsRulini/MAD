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
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnBuscarReservacion);
            groupBox1.Controls.Add(textIdReservacion);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 566);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Facturar:";
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
            dataGridView1.Size = new Size(585, 391);
            dataGridView1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(598, 497);
            button2.Name = "button2";
            button2.Size = new Size(177, 63);
            button2.TabIndex = 11;
            button2.Text = "Generar factura";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnBuscarReservacion
            // 
            btnBuscarReservacion.Location = new Point(225, 56);
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
            textIdReservacion.Size = new Size(204, 30);
            textIdReservacion.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(638, 30);
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
            ClientSize = new Size(805, 590);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Facturar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturar";
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
    }
}