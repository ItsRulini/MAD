namespace MAD
{
    partial class ModElimUsuario
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
            btnModificar = new Button();
            textNomina = new TextBox();
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
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox3 = new GroupBox();
            btnBuscarEmpleado = new Button();
            textBuscarEmpleado = new TextBox();
            label10 = new Label();
            pictureBox3 = new PictureBox();
            cambioContraseña = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cambioContraseña);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(textNomina);
            groupBox1.Controls.Add(label9);
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
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(619, 376);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modificar/eliminar usuario:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(470, 327);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(142, 34);
            btnModificar.TabIndex = 50;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // textNomina
            // 
            textNomina.Location = new Point(4, 305);
            textNomina.Name = "textNomina";
            textNomina.Size = new Size(199, 30);
            textNomina.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 283);
            label9.Name = "label9";
            label9.Size = new Size(166, 22);
            label9.TabIndex = 48;
            label9.Text = "Número de nómina:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(234, 157);
            label8.Name = "label8";
            label8.Size = new Size(146, 22);
            label8.TabIndex = 47;
            label8.Text = "Teléfono celular:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 157);
            label7.Name = "label7";
            label7.Size = new Size(150, 22);
            label7.TabIndex = 46;
            label7.Text = "Telefono de casa:";
            // 
            // textNumCasa
            // 
            textNumCasa.Location = new Point(9, 188);
            textNumCasa.Name = "textNumCasa";
            textNumCasa.Size = new Size(198, 30);
            textNumCasa.TabIndex = 45;
            // 
            // textNumCelular
            // 
            textNumCelular.Location = new Point(234, 188);
            textNumCelular.Name = "textNumCelular";
            textNumCelular.Size = new Size(199, 30);
            textNumCelular.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(232, 28);
            label6.Name = "label6";
            label6.Size = new Size(178, 22);
            label6.TabIndex = 43;
            label6.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(232, 50);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 30);
            dtpFechaNacimiento.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(234, 217);
            label5.Name = "label5";
            label5.Size = new Size(105, 22);
            label5.TabIndex = 41;
            label5.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 217);
            label4.Name = "label4";
            label4.Size = new Size(166, 22);
            label4.TabIndex = 39;
            label4.Text = "Correo electrónico:";
            // 
            // textContrasenia
            // 
            textContrasenia.Location = new Point(234, 239);
            textContrasenia.Name = "textContrasenia";
            textContrasenia.PasswordChar = '*';
            textContrasenia.Size = new Size(199, 30);
            textContrasenia.TabIndex = 38;
            // 
            // textCorreo
            // 
            textCorreo.Enabled = false;
            textCorreo.Location = new Point(9, 239);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(199, 30);
            textCorreo.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 94);
            label3.Name = "label3";
            label3.Size = new Size(155, 22);
            label3.TabIndex = 36;
            label3.Text = "Apellido materno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 94);
            label2.Name = "label2";
            label2.Size = new Size(151, 22);
            label2.TabIndex = 35;
            label2.Text = "Apellido paterno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(102, 22);
            label1.TabIndex = 34;
            label1.Text = "Nombre(s):";
            // 
            // textApellidoMaterno
            // 
            textApellidoMaterno.Location = new Point(234, 116);
            textApellidoMaterno.Name = "textApellidoMaterno";
            textApellidoMaterno.Size = new Size(199, 30);
            textApellidoMaterno.TabIndex = 33;
            // 
            // textApellidoPaterno
            // 
            textApellidoPaterno.Location = new Point(9, 116);
            textApellidoPaterno.Name = "textApellidoPaterno";
            textApellidoPaterno.Size = new Size(199, 30);
            textApellidoPaterno.TabIndex = 32;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(9, 50);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(199, 30);
            textNombre.TabIndex = 31;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(470, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(142, 91);
            groupBox2.TabIndex = 54;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estado:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(13, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 26);
            radioButton2.TabIndex = 53;
            radioButton2.TabStop = true;
            radioButton2.Text = "Inactivo";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(13, 27);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 26);
            radioButton1.TabIndex = 52;
            radioButton1.TabStop = true;
            radioButton1.Text = "Activo";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnBuscarEmpleado);
            groupBox3.Controls.Add(textBuscarEmpleado);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(424, 78);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            groupBox3.Text = "Buscar empleado:";
            // 
            // btnBuscarEmpleado
            // 
            btnBuscarEmpleado.Location = new Point(331, 45);
            btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            btnBuscarEmpleado.Size = new Size(83, 27);
            btnBuscarEmpleado.TabIndex = 4;
            btnBuscarEmpleado.Text = "Buscar";
            btnBuscarEmpleado.UseVisualStyleBackColor = true;
            btnBuscarEmpleado.Click += btnBuscarEmpleado_Click;
            // 
            // textBuscarEmpleado
            // 
            textBuscarEmpleado.Location = new Point(9, 44);
            textBuscarEmpleado.Name = "textBuscarEmpleado";
            textBuscarEmpleado.Size = new Size(278, 30);
            textBuscarEmpleado.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 22);
            label10.Name = "label10";
            label10.Size = new Size(210, 22);
            label10.TabIndex = 0;
            label10.Text = "ID/Correo del empleado:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox3.Location = new Point(489, 12);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 135);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // cambioContraseña
            // 
            cambioContraseña.AutoSize = true;
            cambioContraseña.Location = new Point(232, 309);
            cambioContraseña.Name = "cambioContraseña";
            cambioContraseña.Size = new Size(190, 26);
            cambioContraseña.TabIndex = 55;
            cambioContraseña.Text = "Cambiar contraseña";
            cambioContraseña.UseVisualStyleBackColor = true;
            // 
            // ModElimUsuario
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(643, 484);
            Controls.Add(pictureBox3);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F);
            Margin = new Padding(4);
            Name = "ModElimUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModElimUsuario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox textNomina;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textNumCasa;
        private TextBox textNumCelular;
        private Label label6;
        private DateTimePicker dtpFechaNacimiento;
        private Label label5;
        private Label label4;
        private TextBox textContrasenia;
        private TextBox textCorreo;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textApellidoMaterno;
        private TextBox textApellidoPaterno;
        private TextBox textNombre;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnModificar;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnBuscarEmpleado;
        private TextBox textBuscarEmpleado;
        private Label label10;
        private PictureBox pictureBox3;
        private CheckBox cambioContraseña;
    }
}