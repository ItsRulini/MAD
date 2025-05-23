using MAD.Models;
using MAD.DAO;

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

            if (textCorreo.Text == "ADMIN" && textContrasenia.Text == "ADMIN")
            {
                AggUsuario FAggUsuario = new AggUsuario();
                this.Hide();
                FAggUsuario.ShowDialog();
                this.textCorreo.Clear();
                this.textContrasenia.Clear();
                this.Show();
                return;
            }

            if (string.IsNullOrEmpty(textCorreo.Text) || string.IsNullOrEmpty(textContrasenia.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            UsuarioDAO usuarioDAO = new UsuarioDAO();

            Usuario usuario = usuarioDAO.getUsuarioLogin(textCorreo.Text, textContrasenia.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuario o contraseņa incorrectos.");
                return;
            }

            if (usuario.TipoUsuario == "Administrador")
            {
                PantallaInicialAdmin FAdmin = new PantallaInicialAdmin(usuario.IdUsuario);
                this.Hide();
                FAdmin.ShowDialog();
                this.Show();
            }
            else
            {
                Reservar freservar = new Reservar(usuario.IdUsuario);
                this.Hide();
                freservar.ShowDialog();
                this.Show();
            }
            LoginInicial_Load(sender, e);
        }

        private void LoginInicial_Load(object sender, EventArgs e)
        {
            textCorreo.Clear();
            textContrasenia.Clear();
        }
    }
}
