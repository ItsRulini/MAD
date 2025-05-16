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
        private void textClaveSAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo dígitos y teclas de control como backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla presionada
                MessageBox.Show("Por favor, ingrese solo números.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                MessageBox.Show("Un administrador no puede eliminarse o cambiar su puesto a sí mismo");
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioAdmin.Enabled = false;
                radioOperativo.Enabled = false;
            } else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioAdmin.Enabled = true;
                radioOperativo.Enabled = true;
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
            radioAdmin.Checked = (usuario.TipoUsuario == "Administrador");
            radioOperativo.Checked = (usuario.TipoUsuario == "Operativo");

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

            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajustar si no ha cumplido años todavía este año
            if (fechaNacimiento > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            if (edad < 18)
            {
                MessageBox.Show("El usuario debe tener al menos 18 años.", "Edad no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


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

                // Update a la contraseña
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

            string tipoUsuario = null;

            if (radioAdmin.Checked)
                tipoUsuario = "Administrador";
            else if (radioOperativo.Checked)
                tipoUsuario = "Operativo";
            else
                tipoUsuario = null;

            if (string.IsNullOrEmpty(persona.Nombres) || string.IsNullOrEmpty(persona.Paterno) || string.IsNullOrEmpty(persona.Materno)
                || string.IsNullOrEmpty(textNumCasa.Text) || string.IsNullOrEmpty(textNumCelular.Text) || string.IsNullOrEmpty(persona.Correo)
                || string.IsNullOrEmpty(tipoUsuario) || string.IsNullOrEmpty(textNomina.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            if(persona.Correo.Contains("@") == false || persona.Correo.Contains(".com") == false)
            {
                MessageBox.Show("El formato del correo no es válido.");
                return;
            }

            if (persona.TelefonoCasa.ToString().Length != 10 || persona.Celular.ToString().Length != 10)
            {
                MessageBox.Show("El número de teléfono debe tener 10 dígitos.");
                return;
            }

            // Update a la persona
            if (usuarioDAO.updateUsuarioOperativo(usuario, persona, tipoUsuario))
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
