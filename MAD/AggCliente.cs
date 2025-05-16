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
    public partial class AggCliente : Form
    {
        public AggCliente()
        {
            InitializeComponent();
            inicializarComboRegimen();
            inicializarComboEstadoCivil();
            inicializarComboUbicacion();
            comboBox1.Enabled = true; //Pais
            comboBox2.Enabled = false; //Estado
            comboBox3.Enabled = false; //Ciudad
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

        private void btnAggCliente_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();

            DatosPersona persona = new DatosPersona();
            Cliente cliente = new Cliente();
            DatosFiscal fiscal = new DatosFiscal();
            Ubicacion ubicacion = new Ubicacion();
            //Contraseña contraseña = new Contraseña();

            //ASIGNACIÓN DE VALORES A LOS OBJETOS

            persona.Nombres = textNombre.Text;
            persona.Paterno = textApellidoPaterno.Text;
            persona.Materno = textApellidoMaterno.Text;
            persona.TelefonoCasa = long.Parse(textNumCasa.Text);
            persona.Celular = long.Parse(textNumCelular.Text);
            persona.Correo = textCorreo.Text;
            persona.FechaNacimiento = DateOnly.FromDateTime(dtpFechaNacimiento.Value);

            cliente.EstadoCivil = comboEstadoCivil.Text;
            cliente.Rfc = textRFC.Text;

            cliente.Domicilio = textCalle.Text + " #" + textNumero.Text;
            cliente.Colonia = textColonia.Text;
            cliente.Cp = int.Parse(textCP.Text.ToString());

            ubicacion.Pais = comboBox1.Text;
            ubicacion.Estado = comboBox2.Text;
            ubicacion.Ciudad = comboBox3.Text;

            fiscal.RegimenFiscal = comboRegimenFiscal.Text;

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


            if(string.IsNullOrEmpty(fiscal.RegimenFiscal))
            {
                MessageBox.Show("El régimen fiscal no puede estar vacío.");
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

            if (cliente.Cp.ToString().Length < 5 || cliente.Cp.ToString().Length > 7)
            {
                MessageBox.Show("El código postal debe de tener una longitud de 5 o 6 digitos.");
                return;
            }

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

            // Traer el id de la ubicación
            UbicacionDAO ubicacionDAO = new UbicacionDAO();
            ubicacion.IdUbicacion = ubicacionDAO.getIdUbicacion(comboBox3.Text);

            //INSERCIÓN DE OBJETOS
            bool insertado = clienteDAO.insertCliente(cliente, persona, fiscal, ubicacion);

            if (insertado)
            {
                MessageBox.Show("Cliente agregado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al agregar cliente. El correo ya está en uso");
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Seleccionó un país
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
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) // Seleccionó un estado
        {
            comboBox3.SelectedIndex = -1;
            llenarCiudades();
            comboBox3.Enabled = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) // Seleccionó una ciudad
        {
            
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

    }
}
