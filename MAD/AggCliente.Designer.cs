﻿namespace MAD
{
    partial class AggCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AggCliente));
            groupBox1 = new GroupBox();
            btnAggCliente = new Button();
            groupBox3 = new GroupBox();
            textCP = new TextBox();
            textColonia = new TextBox();
            label16 = new Label();
            label17 = new Label();
            textNumero = new TextBox();
            comboBox3 = new ComboBox();
            textCalle = new TextBox();
            label14 = new Label();
            comboBox2 = new ComboBox();
            label15 = new Label();
            comboBox1 = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            textCorreo = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            comboRegimenFiscal = new ComboBox();
            label13 = new Label();
            textRFC = new TextBox();
            label9 = new Label();
            comboEstadoCivil = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label2 = new Label();
            label8 = new Label();
            label1 = new Label();
            textNombre = new TextBox();
            textNumCelular = new TextBox();
            label7 = new Label();
            textApellidoMaterno = new TextBox();
            textApellidoPaterno = new TextBox();
            textNumCasa = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAggCliente);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(657, 655);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registar cliente:";
            // 
            // btnAggCliente
            // 
            btnAggCliente.Location = new Point(507, 188);
            btnAggCliente.Name = "btnAggCliente";
            btnAggCliente.Size = new Size(142, 57);
            btnAggCliente.TabIndex = 33;
            btnAggCliente.Text = "Agregar cliente";
            btnAggCliente.UseVisualStyleBackColor = true;
            btnAggCliente.Click += btnAggCliente_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textCP);
            groupBox3.Controls.Add(textColonia);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(textNumero);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(textCalle);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(textCorreo);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(6, 388);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(551, 261);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos de contacto:";
            // 
            // textCP
            // 
            textCP.Location = new Point(422, 208);
            textCP.Name = "textCP";
            textCP.Size = new Size(114, 30);
            textCP.TabIndex = 32;
            textCP.KeyPress += textClaveSAT_KeyPress;
            // 
            // textColonia
            // 
            textColonia.Location = new Point(9, 208);
            textColonia.Name = "textColonia";
            textColonia.Size = new Size(407, 30);
            textColonia.TabIndex = 31;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(422, 176);
            label16.Name = "label16";
            label16.Size = new Size(40, 22);
            label16.TabIndex = 34;
            label16.Text = "CP:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 176);
            label17.Name = "label17";
            label17.Size = new Size(79, 22);
            label17.TabIndex = 33;
            label17.Text = "Colonia:";
            // 
            // textNumero
            // 
            textNumero.Location = new Point(422, 135);
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(114, 30);
            textNumero.TabIndex = 9;
            textNumero.KeyPress += textClaveSAT_KeyPress;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(422, 57);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 30);
            comboBox3.TabIndex = 30;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // textCalle
            // 
            textCalle.Location = new Point(9, 135);
            textCalle.Name = "textCalle";
            textCalle.Size = new Size(407, 30);
            textCalle.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(422, 103);
            label14.Name = "label14";
            label14.Size = new Size(80, 22);
            label14.TabIndex = 11;
            label14.Text = "Número:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(295, 57);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 30);
            comboBox2.TabIndex = 29;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 103);
            label15.Name = "label15";
            label15.Size = new Size(131, 22);
            label15.TabIndex = 10;
            label15.Text = "Calle/Avenida:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(164, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 30);
            comboBox1.TabIndex = 28;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(422, 35);
            label12.Name = "label12";
            label12.Size = new Size(73, 22);
            label12.TabIndex = 27;
            label12.Text = "Ciudad:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(295, 36);
            label11.Name = "label11";
            label11.Size = new Size(70, 22);
            label11.TabIndex = 26;
            label11.Text = "Estado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(164, 35);
            label10.Name = "label10";
            label10.Size = new Size(50, 22);
            label10.TabIndex = 25;
            label10.Text = "País:";
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(6, 58);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(145, 30);
            textCorreo.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 35);
            label4.Name = "label4";
            label4.Size = new Size(166, 22);
            label4.TabIndex = 24;
            label4.Text = "Correo electrónico:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboRegimenFiscal);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(textRFC);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(comboEstadoCivil);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dtpFechaNacimiento);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textNombre);
            groupBox2.Controls.Add(textNumCelular);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textApellidoMaterno);
            groupBox2.Controls.Add(textApellidoPaterno);
            groupBox2.Controls.Add(textNumCasa);
            groupBox2.Location = new Point(6, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(495, 356);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos personales:";
            // 
            // comboRegimenFiscal
            // 
            comboRegimenFiscal.FormattingEnabled = true;
            comboRegimenFiscal.Location = new Point(18, 316);
            comboRegimenFiscal.Name = "comboRegimenFiscal";
            comboRegimenFiscal.Size = new Size(199, 30);
            comboRegimenFiscal.TabIndex = 36;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 288);
            label13.Name = "label13";
            label13.Size = new Size(134, 22);
            label13.TabIndex = 35;
            label13.Text = "Régimen fiscal:";
            // 
            // textRFC
            // 
            textRFC.Location = new Point(279, 245);
            textRFC.Name = "textRFC";
            textRFC.Size = new Size(199, 30);
            textRFC.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(280, 223);
            label9.Name = "label9";
            label9.Size = new Size(53, 22);
            label9.TabIndex = 33;
            label9.Text = "RFC:";
            // 
            // comboEstadoCivil
            // 
            comboEstadoCivil.FormattingEnabled = true;
            comboEstadoCivil.Location = new Point(18, 245);
            comboEstadoCivil.Name = "comboEstadoCivil";
            comboEstadoCivil.Size = new Size(198, 30);
            comboEstadoCivil.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 223);
            label5.Name = "label5";
            label5.Size = new Size(112, 22);
            label5.TabIndex = 31;
            label5.Text = "Estado civil:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 33);
            label6.Name = "label6";
            label6.Size = new Size(178, 22);
            label6.TabIndex = 26;
            label6.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 99);
            label3.Name = "label3";
            label3.Size = new Size(155, 22);
            label3.TabIndex = 21;
            label3.Text = "Apellido materno:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(278, 55);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 30);
            dtpFechaNacimiento.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 99);
            label2.Name = "label2";
            label2.Size = new Size(151, 22);
            label2.TabIndex = 20;
            label2.Text = "Apellido paterno:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(280, 162);
            label8.Name = "label8";
            label8.Size = new Size(146, 22);
            label8.TabIndex = 30;
            label8.Text = "Teléfono celular:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(102, 22);
            label1.TabIndex = 19;
            label1.Text = "Nombre(s):";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(18, 55);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(199, 30);
            textNombre.TabIndex = 16;
            // 
            // textNumCelular
            // 
            textNumCelular.Location = new Point(280, 184);
            textNumCelular.Name = "textNumCelular";
            textNumCelular.Size = new Size(199, 30);
            textNumCelular.TabIndex = 27;
            textNumCelular.KeyPress += textClaveSAT_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 162);
            label7.Name = "label7";
            label7.Size = new Size(150, 22);
            label7.TabIndex = 29;
            label7.Text = "Telefono de casa:";
            // 
            // textApellidoMaterno
            // 
            textApellidoMaterno.Location = new Point(279, 121);
            textApellidoMaterno.Name = "textApellidoMaterno";
            textApellidoMaterno.Size = new Size(199, 30);
            textApellidoMaterno.TabIndex = 18;
            // 
            // textApellidoPaterno
            // 
            textApellidoPaterno.Location = new Point(18, 121);
            textApellidoPaterno.Name = "textApellidoPaterno";
            textApellidoPaterno.Size = new Size(199, 30);
            textApellidoPaterno.TabIndex = 17;
            // 
            // textNumCasa
            // 
            textNumCasa.Location = new Point(18, 184);
            textNumCasa.Name = "textNumCasa";
            textNumCasa.Size = new Size(198, 30);
            textNumCasa.TabIndex = 28;
            textNumCasa.KeyPress += textClaveSAT_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(508, 26);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // AggCliente
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(684, 679);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "AggCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AggCliente";
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private DateTimePicker dtpFechaNacimiento;
        private Label label8;
        private TextBox textNombre;
        private Label label7;
        private TextBox textApellidoPaterno;
        private TextBox textNumCasa;
        private TextBox textApellidoMaterno;
        private TextBox textNumCelular;
        private Label label1;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textCorreo;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox textRFC;
        private Label label9;
        private ComboBox comboEstadoCivil;
        private Label label5;
        private Button btnAggCliente;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox comboRegimenFiscal;
        private Label label13;
        private TextBox textCP;
        private TextBox textColonia;
        private Label label16;
        private Label label17;
        private TextBox textNumero;
        private TextBox textCalle;
        private Label label14;
        private Label label15;
    }
}