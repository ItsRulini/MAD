namespace MAD
{
    partial class AggUsuario
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioAdmin = new RadioButton();
            radioOperativo = new RadioButton();
            btnAggUsuario = new Button();
            textNumNomina = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textNumCasa = new TextBox();
            textNumCelular = new TextBox();
            label6 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            textContrasenia = new TextBox();
            textCorreo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textApellidoMaterno = new TextBox();
            textApellidoPaterno = new TextBox();
            textNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(466, 18);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnAggUsuario);
            groupBox1.Controls.Add(textNumNomina);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textNumCasa);
            groupBox1.Controls.Add(textNumCelular);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textContrasenia);
            groupBox1.Controls.Add(textCorreo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textApellidoMaterno);
            groupBox1.Controls.Add(textApellidoPaterno);
            groupBox1.Controls.Add(textNombre);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(618, 382);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del usuario:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioAdmin);
            groupBox2.Controls.Add(radioOperativo);
            groupBox2.Location = new Point(448, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(164, 125);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de usuario:";
            // 
            // radioAdmin
            // 
            radioAdmin.AutoSize = true;
            radioAdmin.Location = new Point(7, 70);
            radioAdmin.Name = "radioAdmin";
            radioAdmin.Size = new Size(146, 26);
            radioAdmin.TabIndex = 19;
            radioAdmin.TabStop = true;
            radioAdmin.Text = "Administrador";
            radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioOperativo
            // 
            radioOperativo.AutoSize = true;
            radioOperativo.Location = new Point(7, 38);
            radioOperativo.Name = "radioOperativo";
            radioOperativo.Size = new Size(111, 26);
            radioOperativo.TabIndex = 18;
            radioOperativo.TabStop = true;
            radioOperativo.Text = "Operativo";
            radioOperativo.UseVisualStyleBackColor = true;
            // 
            // btnAggUsuario
            // 
            btnAggUsuario.Location = new Point(243, 311);
            btnAggUsuario.Name = "btnAggUsuario";
            btnAggUsuario.Size = new Size(198, 47);
            btnAggUsuario.TabIndex = 8;
            btnAggUsuario.Text = "Agregar usuario";
            btnAggUsuario.UseVisualStyleBackColor = true;
            btnAggUsuario.Click += btnAggUsuario_Click;
            // 
            // textNumNomina
            // 
            textNumNomina.Enabled = false;
            textNumNomina.Location = new Point(13, 311);
            textNumNomina.Name = "textNumNomina";
            textNumNomina.Size = new Size(199, 30);
            textNumNomina.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 289);
            label9.Name = "label9";
            label9.Size = new Size(166, 22);
            label9.TabIndex = 16;
            label9.Text = "Número de nómina:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(243, 163);
            label8.Name = "label8";
            label8.Size = new Size(146, 22);
            label8.TabIndex = 15;
            label8.Text = "Teléfono celular:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 163);
            label7.Name = "label7";
            label7.Size = new Size(150, 22);
            label7.TabIndex = 14;
            label7.Text = "Telefono de casa:";
            label7.Click += label7_Click;
            // 
            // textNumCasa
            // 
            textNumCasa.Location = new Point(18, 185);
            textNumCasa.Name = "textNumCasa";
            textNumCasa.Size = new Size(198, 30);
            textNumCasa.TabIndex = 13;
            textNumCasa.KeyPress += textClaveSAT_KeyPress;
            // 
            // textNumCelular
            // 
            textNumCelular.Location = new Point(243, 185);
            textNumCelular.Name = "textNumCelular";
            textNumCelular.Size = new Size(199, 30);
            textNumCelular.TabIndex = 12;
            textNumCelular.KeyPress += textClaveSAT_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 34);
            label6.Name = "label6";
            label6.Size = new Size(178, 22);
            label6.TabIndex = 11;
            label6.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(241, 56);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 30);
            dtpFechaNacimiento.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 223);
            label5.Name = "label5";
            label5.Size = new Size(105, 22);
            label5.TabIndex = 9;
            label5.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 223);
            label4.Name = "label4";
            label4.Size = new Size(166, 22);
            label4.TabIndex = 8;
            label4.Text = "Correo electrónico:";
            // 
            // textContrasenia
            // 
            textContrasenia.Location = new Point(243, 245);
            textContrasenia.Name = "textContrasenia";
            textContrasenia.PasswordChar = '*';
            textContrasenia.Size = new Size(199, 30);
            textContrasenia.TabIndex = 7;
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(18, 245);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(199, 30);
            textCorreo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 100);
            label3.Name = "label3";
            label3.Size = new Size(155, 22);
            label3.TabIndex = 5;
            label3.Text = "Apellido materno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 100);
            label2.Name = "label2";
            label2.Size = new Size(151, 22);
            label2.TabIndex = 4;
            label2.Text = "Apellido paterno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 32);
            label1.Name = "label1";
            label1.Size = new Size(102, 22);
            label1.TabIndex = 3;
            label1.Text = "Nombre(s):";
            // 
            // textApellidoMaterno
            // 
            textApellidoMaterno.Location = new Point(242, 122);
            textApellidoMaterno.Name = "textApellidoMaterno";
            textApellidoMaterno.Size = new Size(199, 30);
            textApellidoMaterno.TabIndex = 2;
            // 
            // textApellidoPaterno
            // 
            textApellidoPaterno.Location = new Point(18, 122);
            textApellidoPaterno.Name = "textApellidoPaterno";
            textApellidoPaterno.Size = new Size(199, 30);
            textApellidoPaterno.TabIndex = 1;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(18, 56);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(199, 30);
            textNombre.TabIndex = 0;
            // 
            // AggUsuario
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(643, 407);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F);
            Margin = new Padding(4);
            Name = "AggUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AggUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox textApellidoMaterno;
        private TextBox textApellidoPaterno;
        private TextBox textNombre;
        private Button btnAggUsuario;
        private TextBox textContrasenia;
        private TextBox textCorreo;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox textNumCasa;
        private TextBox textNumCelular;
        private Label label6;
        private DateTimePicker dtpFechaNacimiento;
        private Label label5;
        private Label label4;
        private Label label8;
        private TextBox textNumNomina;
        private Label label9;
        private GroupBox groupBox2;
        private RadioButton radioAdmin;
        private RadioButton radioOperativo;
    }
}