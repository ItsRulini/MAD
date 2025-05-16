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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MAD
{
    public partial class ModElimCliente : Form
    {
        public ModElimCliente()
        {
            InitializeComponent();
            inicializarComboRegimen();
            inicializarComboEstadoCivil();
            inicializarComboUbicacion();

            //Iniciamos todo apagado hasta su busqueda
            textNombre.Enabled = false;
            textApellidoPaterno.Enabled = false;
            textApellidoMaterno.Enabled = false;
            textNumCasa.Enabled = false;
            textNumCelular.Enabled = false;
            textCorreo.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            comboEstadoCivil.Enabled = false;
            textRFC.Enabled = false;
            comboRegimenFiscal.Enabled = false;

            comboBox1.Enabled = false; //Pais
            comboBox2.Enabled = false; //Estado
            comboBox3.Enabled = false; //Ciudad


            textCalle.Enabled = false;
            textNumero.Enabled = false;
            textColonia.Enabled = false;
            textCP.Enabled = false;
        }

        private void inicializarComboUbicacion()
        {
            UbicacionDAO ubicacionDAO = new UbicacionDAO();

            List<Ubicacion> paises = ubicacionDAO.getPaises();

            foreach (Ubicacion ubicacion in paises)
            {
                comboBox1.Items.Add(ubicacion.Pais);
            }

        }
        private void inicializarComboEstadoCivil()
        {
            comboEstadoCivil.Items.Add("Soltero");
            comboEstadoCivil.Items.Add("Casado");
            comboEstadoCivil.Items.Add("Divorciado");
            comboEstadoCivil.Items.Add("Viudo");
        }

        private void inicializarComboRegimen()
        {
            comboRegimenFiscal.Items.Add("Asalariados");
            comboRegimenFiscal.Items.Add("Honorarios");
        }

        private void limpiarVentana()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            textBuscarCliente.Clear();
            textNombre.Clear();
            textApellidoPaterno.Clear();
            textApellidoMaterno.Clear();
            textNumCasa.Clear();
            textNumCelular.Clear();
            textCorreo.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            comboEstadoCivil.SelectedIndex = -1;
            textRFC.Clear();
            comboRegimenFiscal.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }
        private void btnElimCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBuscarCliente.Text))
            {
                MessageBox.Show("Por favor, ingrese un email.");
                return;
            }

            ClienteDAO clienteDAO = new ClienteDAO();
            if (clienteDAO.borrarCliente(textBuscarCliente.Text))
            {
                MessageBox.Show("Cliente eliminado");
                ModElimCliente_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Error al eliminar el cliente");
            }
        }

        private void btnModCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBuscarCliente.Text))
            {
                MessageBox.Show("Por favor, ingrese un email.");
                return;
            }

            ClienteDAO clienteDao = new ClienteDAO();

            DatosPersona persona = new DatosPersona();
            DatosFiscal fiscal = new DatosFiscal();
            Cliente cliente = new Cliente();
            Ubicacion ubicacion = new Ubicacion();

            // Asignar valores a los objetos
            long telefonoCasa;
            long telefonoCelular;


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
            persona.Celular = long.TryParse(textNumCelular.Text, out telefonoCelular) ? telefonoCelular : -1;
            persona.Correo = textCorreo.Text;
            persona.FechaNacimiento = DateOnly.FromDateTime(dtpFechaNacimiento.Value);

            cliente.EstadoCivil = comboEstadoCivil.Text;
            cliente.Rfc = textRFC.Text;

            cliente.Domicilio = textCalle.Text + textNumero.Text;
            cliente.Colonia = textColonia.Text;
            cliente.Cp = int.Parse(textCP.Text.ToString());

            ubicacion.Pais = comboBox1.Text;
            ubicacion.Estado = comboBox2.Text;
            ubicacion.Ciudad = comboBox3.Text;

            fiscal.RegimenFiscal = comboRegimenFiscal.Text;

            // Traer el id de la ubicación
            UbicacionDAO ubicacionDAO = new UbicacionDAO();
            cliente.IdUbicacion = ubicacionDAO.getIdUbicacion(comboBox3.Text);

            // Validaciones
            if (string.IsNullOrEmpty(persona.Nombres) || string.IsNullOrEmpty(persona.Paterno) || string.IsNullOrEmpty(persona.Materno))
            {
                MessageBox.Show("Los nombres no pueden estar vacíos.");
                return;
            }
            if (string.IsNullOrEmpty(persona.TelefonoCasa.ToString()) || string.IsNullOrEmpty(persona.Celular.ToString()))
            {
                MessageBox.Show("Los números de teléfono no pueden estar vacíos.");
                return;
            }
            if (string.IsNullOrEmpty(persona.Correo))
            {
                MessageBox.Show("El correo no puede estar vacío.");
                return;
            }
            if (string.IsNullOrEmpty(cliente.EstadoCivil))
            {
                MessageBox.Show("El estado civil no puede estar vacío.");
                return;
            }

            if (string.IsNullOrEmpty(ubicacion.Pais) || string.IsNullOrEmpty(ubicacion.Estado) || string.IsNullOrEmpty(ubicacion.Ciudad))
            {
                MessageBox.Show("La ubicación no puede estar vacía.");
                return;
            }

            if (string.IsNullOrEmpty(cliente.Rfc))
            {
                MessageBox.Show("El RFC no puede estar vacío.");
                return;
            }

            //Validad lo del domicilio
            if (string.IsNullOrEmpty(cliente.Domicilio) || string.IsNullOrEmpty(cliente.Colonia) || string.IsNullOrEmpty(cliente.Cp.ToString()))
            {
                MessageBox.Show("Rellene los datos de contacto");
                return;
            }

            if(persona.Correo.Contains("@") == false && persona.Correo.Contains(".com") == false)
            {
                MessageBox.Show("El formato del correo no es válido.");
                return;
            }

            if(cliente.Cp.ToString().Length < 5 || cliente.Cp.ToString().Length > 7)
            {
                MessageBox.Show("El código postal debe de tener una longitud de 5 o 6 digitos.");
                return;
            }

            if (string.IsNullOrEmpty(fiscal.RegimenFiscal))
            {
                MessageBox.Show("El régimen fiscal no puede estar vacío.");
                return;
            }

            if(persona.TelefonoCasa.ToString().Length != 10 || persona.Celular.ToString().Length != 10)
            {
                MessageBox.Show("El número de teléfono debe tener 10 dígitos.");
                return;
            }


            // Validar que que se actualice el cliente

            if (clienteDao.updateCliente(cliente, fiscal, persona))
            {
                MessageBox.Show("Cliente modificado");
            }
            else
            {
                MessageBox.Show("Error al modificar el cliente");
            }
            if (persona.TelefonoCasa.ToString().Length != 10 || persona.Celular.ToString().Length != 10)
            {
                MessageBox.Show("El número de teléfono debe tener 10 dígitos.");
                return;
            }

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


        private void llenarEstados()
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            UbicacionDAO ubicacionDAO = new UbicacionDAO();
            List<Ubicacion> estados = ubicacionDAO.getEstados(comboBox1.Text);
            foreach (Ubicacion ubicacion in estados)
            {
                comboBox2.Items.Add(ubicacion.Estado);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarEstados();
            comboBox2.Enabled = true;
        }

        private void llenarCiudades()
        {
            comboBox3.Items.Clear();
            UbicacionDAO ubicacionDAO = new UbicacionDAO();
            List<Ubicacion> ciudades = ubicacionDAO.getCiudades(comboBox2.Text);
            foreach (Ubicacion ubicacion in ciudades)
            {
                comboBox3.Items.Add(ubicacion.Ciudad);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = -1;
            llenarCiudades();
            comboBox3.Enabled = true;
        }

        private void llenarDatos(Cliente cliente, DatosPersona persona, DatosFiscal fiscal, Ubicacion ubicacion)
        {
            textNombre.Text = persona.Nombres;
            textApellidoPaterno.Text = persona.Paterno;
            textApellidoMaterno.Text = persona.Materno;
            textNumCasa.Text = persona.TelefonoCasa.ToString();
            textNumCelular.Text = persona.Celular.ToString();
            textCorreo.Text = persona.Correo;
            dtpFechaNacimiento.Value = DateTime.Parse(persona.FechaNacimiento.ToString());


            comboEstadoCivil.Text = cliente.EstadoCivil;
            textRFC.Text = cliente.Rfc;

            // Acceder a las partes
            string[] partes = cliente.Domicilio.Split(" #");
            string calle = partes[0];
            string numero = partes[1];

            textCalle.Text = calle;
            textNumero.Text = numero;
            textColonia.Text = cliente.Colonia;
            textCP.Text    = cliente.Cp.ToString();

            comboRegimenFiscal.Text = fiscal.RegimenFiscal;


            comboBox1.Text = ubicacion.Pais;
            comboBox2.Text = ubicacion.Estado;
            comboBox3.Text = ubicacion.Ciudad;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBuscarCliente.Text))
            {
                MessageBox.Show("Porfavor ingrese un email.");
                return;
            }

            DatosFiscalDAO fiscalDAO = new DatosFiscalDAO();
            DatosPersonaDAO personaDAO = new DatosPersonaDAO();
            ClienteDAO clienteDAO = new ClienteDAO();
            UbicacionDAO ubicacionDAO = new UbicacionDAO();

            Cliente cliente = new Cliente();
            DatosPersona persona = new DatosPersona();
            DatosFiscal fiscal = new DatosFiscal();
            Ubicacion ubicacion = new Ubicacion();

            fiscal = fiscalDAO.getDatosFiscal(textBuscarCliente.Text);
            persona = personaDAO.getDatosPersona(textBuscarCliente.Text);
            cliente = clienteDAO.getCliente(textBuscarCliente.Text);

            if(cliente == null)
            {
                MessageBox.Show("Cliente no encontrado");
                return;
            }

            if (cliente.Estado == false)
            {
                MessageBox.Show("Cliente dado de baja");
                return;
            }

            ubicacion = ubicacionDAO.getUbicacion(cliente.IdUbicacion);
            llenarDatos(cliente, persona, fiscal, ubicacion);

            textNombre.Enabled = true;
            textApellidoPaterno.Enabled = true;
            textApellidoMaterno.Enabled = true;
            textNumCasa.Enabled = true;
            textNumCelular.Enabled = true;
            textCorreo.Enabled = false;
            dtpFechaNacimiento.Enabled = true;
            comboEstadoCivil.Enabled = true;
            textRFC.Enabled = true;
            comboRegimenFiscal.Enabled = true;

            comboBox1.Enabled = true; //Pais
            comboBox2.Enabled = false; //Estado
            comboBox3.Enabled = false; //Ciudad

            textCalle.Enabled = true;
            textNumero.Enabled = true;
            textColonia.Enabled = true;
            textCP.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ModElimCliente_Load(object sender, EventArgs e)
        {
            limpiarVentana();
        }
    }
}
