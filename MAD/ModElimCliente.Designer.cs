namespace MAD
{
    partial class ModElimCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModElimCliente));
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            btnBuscarCliente = new Button();
            textBuscarCliente = new TextBox();
            label14 = new Label();
            btnElimCliente = new Button();
            btnModCliente = new Button();
            groupBox3 = new GroupBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
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
            textCP = new TextBox();
            textColonia = new TextBox();
            label16 = new Label();
            label17 = new Label();
            textNumero = new TextBox();
            textCalle = new TextBox();
            label15 = new Label();
            label18 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(btnElimCliente);
            groupBox1.Controls.Add(btnModCliente);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(657, 720);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestionar clientes";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnBuscarCliente);
            groupBox4.Controls.Add(textBuscarCliente);
            groupBox4.Controls.Add(label14);
            groupBox4.Location = new Point(12, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(489, 81);
            groupBox4.TabIndex = 35;
            groupBox4.TabStop = false;
            groupBox4.Text = "Filtro:";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(379, 40);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(75, 30);
            btnBuscarCliente.TabIndex = 3;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // textBuscarCliente
            // 
            textBuscarCliente.Location = new Point(12, 44);
            textBuscarCliente.Name = "textBuscarCliente";
            textBuscarCliente.Size = new Size(234, 30);
            textBuscarCliente.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 22);
            label14.Name = "label14";
            label14.Size = new Size(72, 22);
            label14.TabIndex = 0;
            label14.Text = "Correo:";
            // 
            // btnElimCliente
            // 
            btnElimCliente.Location = new Point(508, 358);
            btnElimCliente.Name = "btnElimCliente";
            btnElimCliente.Size = new Size(142, 55);
            btnElimCliente.TabIndex = 34;
            btnElimCliente.Text = "Eliminar";
            btnElimCliente.UseVisualStyleBackColor = true;
            btnElimCliente.Click += btnElimCliente_Click;
            // 
            // btnModCliente
            // 
            btnModCliente.Location = new Point(508, 265);
            btnModCliente.Name = "btnModCliente";
            btnModCliente.Size = new Size(142, 62);
            btnModCliente.TabIndex = 33;
            btnModCliente.Text = "Modificar";
            btnModCliente.UseVisualStyleBackColor = true;
            btnModCliente.Click += btnModCliente_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textCP);
            groupBox3.Controls.Add(textColonia);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(textNumero);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(textCalle);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(textCorreo);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(6, 475);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(570, 239);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos de contacto:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(422, 57);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 30);
            comboBox3.TabIndex = 30;
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
            groupBox2.Location = new Point(6, 113);
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
            // textCP
            // 
            textCP.Location = new Point(422, 203);
            textCP.Name = "textCP";
            textCP.Size = new Size(114, 30);
            textCP.TabIndex = 41;
            // 
            // textColonia
            // 
            textColonia.Location = new Point(9, 203);
            textColonia.Name = "textColonia";
            textColonia.Size = new Size(407, 30);
            textColonia.TabIndex = 40;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(422, 171);
            label16.Name = "label16";
            label16.Size = new Size(40, 22);
            label16.TabIndex = 43;
            label16.Text = "CP:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 171);
            label17.Name = "label17";
            label17.Size = new Size(79, 22);
            label17.TabIndex = 42;
            label17.Text = "Colonia:";
            // 
            // textNumero
            // 
            textNumero.Location = new Point(422, 130);
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(114, 30);
            textNumero.TabIndex = 37;
            // 
            // textCalle
            // 
            textCalle.Location = new Point(9, 130);
            textCalle.Name = "textCalle";
            textCalle.Size = new Size(407, 30);
            textCalle.TabIndex = 36;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(422, 98);
            label15.Name = "label15";
            label15.Size = new Size(80, 22);
            label15.TabIndex = 39;
            label15.Text = "Número:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 98);
            label18.Name = "label18";
            label18.Size = new Size(131, 22);
            label18.TabIndex = 38;
            label18.Text = "Calle/Avenida:";
            // 
            // ModElimCliente
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(685, 744);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ModElimCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModElimCliente";
            Load += ModElimCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnElimCliente;
        private Button btnModCliente;
        private GroupBox groupBox3;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox textCorreo;
        private Label label4;
        private GroupBox groupBox2;
        private ComboBox comboRegimenFiscal;
        private Label label13;
        private TextBox textRFC;
        private Label label9;
        private ComboBox comboEstadoCivil;
        private Label label5;
        private Label label6;
        private Label label3;
        private DateTimePicker dtpFechaNacimiento;
        private Label label2;
        private Label label8;
        private Label label1;
        private TextBox textNombre;
        private TextBox textNumCelular;
        private Label label7;
        private TextBox textApellidoMaterno;
        private TextBox textApellidoPaterno;
        private TextBox textNumCasa;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
        private TextBox textBuscarCliente;
        private Label label14;
        private Button btnBuscarCliente;
        private TextBox textCP;
        private TextBox textColonia;
        private Label label16;
        private Label label17;
        private TextBox textNumero;
        private TextBox textCalle;
        private Label label15;
        private Label label18;
    }
}