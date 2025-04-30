using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAD.DAO;
using MAD.Models;

namespace MAD
{
    public partial class AggUsuario : Form
    {
        public AggUsuario()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAggUsuario_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            DatosPersona persona = new DatosPersona();
            Contraseña contraseña = new Contraseña();

            // Asignar valores a los objetos

            persona.Nombres = textNombre.Text;
            persona.Paterno = textApellidoPaterno.Text;
            persona.Materno = textApellidoMaterno.Text;
            persona.TelefonoCasa = long.Parse(textNumCasa.Text);
            persona.Celular = long.Parse(textNumCelular.Text);
            persona.Correo = textCorreo.Text;
            persona.FechaNacimiento = DateOnly.FromDateTime(dtpFechaNacimiento.Value);

            contraseña.Contraseña1 = textContrasenia.Text;

            string tipoUsuario = null;

            if (radioAdmin.Checked)
                tipoUsuario = "Administrador";
            else if (radioOperativo.Checked)
                tipoUsuario = "Operativo";
            else
                tipoUsuario = null;

            if (string.IsNullOrEmpty(persona.Nombres) || string.IsNullOrEmpty(persona.Paterno) || string.IsNullOrEmpty(persona.Materno)
                || string.IsNullOrEmpty(textNumCasa.Text) || string.IsNullOrEmpty(textNumCelular.Text) || string.IsNullOrEmpty(persona.Correo)
                || string.IsNullOrEmpty(tipoUsuario))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            if (string.IsNullOrEmpty(contraseña.Contraseña1))
            {
                MessageBox.Show("Por favor, ingrese una contraseña.");
                return;
            }

            if (contraseña.Contraseña1.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                return;
            }

            bool tieneNumero = false;
            bool tieneMinuscula = false;
            bool tieneMayuscula = false;
            bool tieneEspecial = false;

            foreach (char c in contraseña.Contraseña1)
            {
                if (char.IsDigit(c))
                    tieneNumero = true;
                else if (char.IsLower(c))
                    tieneMinuscula = true;
                else if (char.IsUpper(c))
                    tieneMayuscula = true;
                else if (!char.IsLetterOrDigit(c))
                    tieneEspecial = true;
            }

            if (!(tieneNumero && tieneMinuscula && tieneMayuscula && tieneEspecial))
            {
                MessageBox.Show("La contraseña debe contener al menos un número, una mayúscula, una minúscula y un caracter especial.");
                return;
            }


            bool insertado = usuarioDAO.insertUsuario(persona, contraseña, tipoUsuario);

            if(insertado)
            {
                MessageBox.Show("Usuario" + tipoUsuario + " agregado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar el usuario.");
            }
        }
    }
}
