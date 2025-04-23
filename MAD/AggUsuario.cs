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

            bool insertado = usuarioDAO.insertUsuarioOperativo(persona, contraseña);

            if(insertado)
            {
                MessageBox.Show("Usuario agregado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar el usuario.");
            }
        }
    }
}
