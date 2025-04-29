using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAD.Models;
using MAD.DAO;

namespace MAD
{
    public partial class ModElimUsuario : Form
    {
        private Guid idUsuarioEncontrado; // Almacena el ID del usuario a modificar o eliminar
        private Guid idAdministrador; // Almacena el ID del administrador
        public ModElimUsuario(Guid idAdmin)
        {
            InitializeComponent();
            idAdministrador = idAdmin;
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBuscarEmpleado.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID o email de un empleado.");
                return;
            }

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            DatosPersonaDAO personaDAO = new DatosPersonaDAO();
            ContraseñaDAO contraseñaDAO = new ContraseñaDAO();

            Usuario usuario = new Usuario();
            DatosPersona persona = new DatosPersona();
            Contraseña contraseña = new Contraseña();



            usuario = usuarioDAO.getInfoUsuario(textBuscarEmpleado.Text);
            persona = personaDAO.getDatosPersona(textBuscarEmpleado.Text);
            
            if (idAdministrador == persona.IdPersona)
            {
                MessageBox.Show("Un administrador no puede eliminarse a sí mismo");
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            } else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }

            if (usuario == null || persona == null)
            {
                MessageBox.Show("No se encontró el usuario.");
                return;
            }

            contraseña = contraseñaDAO.getContraseña(persona.IdPersona);

            idUsuarioEncontrado = persona.IdPersona;
            textNombre.Text = persona.Nombres;
            textApellidoPaterno.Text = persona.Paterno;
            textApellidoMaterno.Text = persona.Materno;
            textNumCasa.Text = persona.TelefonoCasa.ToString();
            textNumCelular.Text = persona.Celular.ToString();
            textCorreo.Text = persona.Correo;
            textNomina.Text = usuario.Nomina.ToString();
            textContrasenia.Text = contraseña.Contraseña1;
            dtpFechaNacimiento.Value = persona.FechaNacimiento.ToDateTime(new TimeOnly(0, 0));
            radioButton1.Checked = (bool) usuario.Estado;
            radioButton2.Checked = (bool) !usuario.Estado;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBuscarEmpleado.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID o email de un empleado.");
                return;
            }

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            ContraseñaDAO contraseñaDAO = new ContraseñaDAO();

            Usuario usuario = new Usuario();
            DatosPersona persona = new DatosPersona();
            Contraseña contraseña = new Contraseña();

            long telefonoCasa;
            long celular;
            long nomina;

            persona.Nombres = textNombre.Text;
            persona.Paterno = textApellidoPaterno.Text;
            persona.Materno = textApellidoMaterno.Text;
            persona.TelefonoCasa = long.TryParse(textNumCasa.Text, out telefonoCasa) ? telefonoCasa : -1;
            persona.Celular = long.TryParse(textNumCelular.Text, out celular) ? celular : -1;
            persona.Correo = textCorreo.Text;
            persona.FechaNacimiento = DateOnly.FromDateTime(dtpFechaNacimiento.Value);

            contraseña.Contraseña1 = textContrasenia.Text;

            usuario.Nomina = long.TryParse(textNomina.Text, out nomina) ? nomina : -1;
            usuario.Estado = radioButton1.Checked;

            if (cambioContraseña.Checked)
            {
                if (contraseñaDAO.updateContraseña(contraseña, idUsuarioEncontrado))
                {
                    MessageBox.Show("Contraseña modificada correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al modificar la contraseña.");
                }
                return; // Únicamente actualiza la contraseña
            }

            if (usuarioDAO.updateUsuarioOperativo(usuario, persona))
            {
                MessageBox.Show("Usuario modificado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al modificar el usuario.");
            }
            
        }

        //NO SIRVE
        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }
    }
}
