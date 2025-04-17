namespace MAD
{
    public partial class LoginInicial : Form
    {
        public LoginInicial()
        {
            InitializeComponent();
        }

        private void iniciarSesion_Click(object sender, EventArgs e)
        {
            //PantallaInicialAdmin FAdmin = new PantallaInicialAdmin();
            //this.Hide();
            //FAdmin.ShowDialog();
            //this.Show();
            Reservar freservar = new Reservar();
            this.Hide();
            freservar.ShowDialog();
            this.Show();
        }

        private void LoginInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
