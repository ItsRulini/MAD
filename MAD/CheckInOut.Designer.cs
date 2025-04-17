namespace MAD
{
    partial class CheckInOut
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
            btnBuscarReservacion = new Button();
            textIdReservacion = new TextBox();
            groupBox2 = new GroupBox();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            textHasta = new TextBox();
            textDesde = new TextBox();
            textApellidoM = new TextBox();
            textApellidoP = new TextBox();
            textNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvHabitaciones = new DataGridView();
            Habitaciones = new DataGridViewTextBoxColumn();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarReservacion);
            groupBox1.Controls.Add(textIdReservacion);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(626, 447);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Check In/Check Out";
            // 
            // btnBuscarReservacion
            // 
            btnBuscarReservacion.Location = new Point(241, 48);
            btnBuscarReservacion.Name = "btnBuscarReservacion";
            btnBuscarReservacion.Size = new Size(75, 26);
            btnBuscarReservacion.TabIndex = 35;
            btnBuscarReservacion.Text = "Buscar";
            btnBuscarReservacion.UseVisualStyleBackColor = true;
            // 
            // textIdReservacion
            // 
            textIdReservacion.Location = new Point(6, 48);
            textIdReservacion.Name = "textIdReservacion";
            textIdReservacion.Size = new Size(195, 26);
            textIdReservacion.TabIndex = 34;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCheckOut);
            groupBox2.Controls.Add(btnCheckIn);
            groupBox2.Controls.Add(textHasta);
            groupBox2.Controls.Add(textDesde);
            groupBox2.Controls.Add(textApellidoM);
            groupBox2.Controls.Add(textApellidoP);
            groupBox2.Controls.Add(textNombre);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dgvHabitaciones);
            groupBox2.Location = new Point(6, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(451, 344);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la reservación:";
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(330, 293);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(94, 33);
            btnCheckOut.TabIndex = 12;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(330, 254);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(94, 33);
            btnCheckIn.TabIndex = 11;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // textHasta
            // 
            textHasta.Enabled = false;
            textHasta.Location = new Point(158, 117);
            textHasta.Name = "textHasta";
            textHasta.Size = new Size(113, 26);
            textHasta.TabIndex = 10;
            // 
            // textDesde
            // 
            textDesde.Enabled = false;
            textDesde.Location = new Point(6, 117);
            textDesde.Name = "textDesde";
            textDesde.Size = new Size(128, 26);
            textDesde.TabIndex = 9;
            // 
            // textApellidoM
            // 
            textApellidoM.Enabled = false;
            textApellidoM.Location = new Point(294, 54);
            textApellidoM.Name = "textApellidoM";
            textApellidoM.Size = new Size(116, 26);
            textApellidoM.TabIndex = 8;
            // 
            // textApellidoP
            // 
            textApellidoP.Enabled = false;
            textApellidoP.Location = new Point(158, 54);
            textApellidoP.Name = "textApellidoP";
            textApellidoP.Size = new Size(113, 26);
            textApellidoP.TabIndex = 7;
            // 
            // textNombre
            // 
            textNombre.Enabled = false;
            textNombre.Location = new Point(6, 54);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(128, 26);
            textNombre.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(158, 95);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 5;
            label6.Text = "Hasta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 95);
            label5.Name = "label5";
            label5.Size = new Size(51, 19);
            label5.TabIndex = 4;
            label5.Text = "Desde:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 32);
            label4.Name = "label4";
            label4.Size = new Size(116, 19);
            label4.TabIndex = 3;
            label4.Text = "Apellido materno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 32);
            label3.Name = "label3";
            label3.Size = new Size(113, 19);
            label3.TabIndex = 2;
            label3.Text = "Apellido paterno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 32);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // dgvHabitaciones
            // 
            dgvHabitaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabitaciones.Columns.AddRange(new DataGridViewColumn[] { Habitaciones });
            dgvHabitaciones.Location = new Point(6, 176);
            dgvHabitaciones.Name = "dgvHabitaciones";
            dgvHabitaciones.Size = new Size(304, 150);
            dgvHabitaciones.TabIndex = 0;
            // 
            // Habitaciones
            // 
            Habitaciones.HeaderText = "Habitaciones";
            Habitaciones.Name = "Habitaciones";
            Habitaciones.Width = 250;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(134, 19);
            label1.TabIndex = 32;
            label1.Text = "ID de la reservación:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox3.Location = new Point(477, 26);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 135);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // CheckInOut
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(650, 471);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "CheckInOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckInOut";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox3;
        private Button btnBuscarReservacion;
        private TextBox textIdReservacion;
        private GroupBox groupBox2;
        private DataGridView dgvHabitaciones;
        private Label label1;
        private TextBox textHasta;
        private TextBox textDesde;
        private TextBox textApellidoM;
        private TextBox textApellidoP;
        private TextBox textNombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private DataGridViewTextBoxColumn Habitaciones;
    }
}