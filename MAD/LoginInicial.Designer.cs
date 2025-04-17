namespace MAD
{
    partial class LoginInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginInicial));
            textCorreo = new TextBox();
            textContrasenia = new TextBox();
            iniciarSesion = new Button();
            labelCorreo = new Label();
            labelContrasenia = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textCorreo
            // 
            textCorreo.Font = new Font("Times New Roman", 12F);
            textCorreo.Location = new Point(54, 257);
            textCorreo.Margin = new Padding(4);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(192, 26);
            textCorreo.TabIndex = 0;
            // 
            // textContrasenia
            // 
            textContrasenia.Location = new Point(49, 390);
            textContrasenia.Margin = new Padding(4);
            textContrasenia.Name = "textContrasenia";
            textContrasenia.Size = new Size(192, 26);
            textContrasenia.TabIndex = 1;
            // 
            // iniciarSesion
            // 
            iniciarSesion.Font = new Font("Times New Roman", 12F);
            iniciarSesion.Location = new Point(54, 446);
            iniciarSesion.Margin = new Padding(4);
            iniciarSesion.Name = "iniciarSesion";
            iniciarSesion.Size = new Size(176, 53);
            iniciarSesion.TabIndex = 2;
            iniciarSesion.Text = "Ingresar";
            iniciarSesion.UseVisualStyleBackColor = true;
            iniciarSesion.Click += iniciarSesion_Click;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Times New Roman", 12F);
            labelCorreo.Location = new Point(54, 213);
            labelCorreo.Margin = new Padding(4, 0, 4, 0);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(56, 19);
            labelCorreo.TabIndex = 3;
            labelCorreo.Text = "Correo:";
            // 
            // labelContrasenia
            // 
            labelContrasenia.AutoSize = true;
            labelContrasenia.Font = new Font("Times New Roman", 12F);
            labelContrasenia.Location = new Point(49, 342);
            labelContrasenia.Margin = new Padding(4, 0, 4, 0);
            labelContrasenia.Name = "labelContrasenia";
            labelContrasenia.Size = new Size(81, 19);
            labelContrasenia.TabIndex = 4;
            labelContrasenia.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_HOTEL_removebg_preview;
            pictureBox1.Location = new Point(54, 13);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LoginInicial
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(303, 535);
            Controls.Add(labelContrasenia);
            Controls.Add(labelCorreo);
            Controls.Add(iniciarSesion);
            Controls.Add(textContrasenia);
            Controls.Add(textCorreo);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "LoginInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrownHotelManager";
            Load += LoginInicial_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textCorreo;
        private TextBox textContrasenia;
        private Button iniciarSesion;
        private Label labelCorreo;
        private Label labelContrasenia;
        private PictureBox pictureBox1;
    }
}
