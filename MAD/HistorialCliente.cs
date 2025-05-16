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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MAD
{
    public partial class HistorialCliente : Form
    {
        DatosPersonaDAO personaDAO = new DatosPersonaDAO();
        List<string> persona = new List<string>();
        Guid idComprador = Guid.Empty;
        public HistorialCliente()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            comboCliente.Items.Clear();
            comboCliente.SelectedIndex = -1;
            if (checkApellidos.Checked) // búsqueda por apellidos  
            {
                // Fixing the declaration of the array and assignment  
                string[] apellidos = textBuscar.Text.Split(' ');

                // Ensure we pass the required arguments to the method  
                if (apellidos.Length >= 2)
                {
                    persona = personaDAO.busquedaAvanzadaApellidos(apellidos[0], apellidos[1]);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese ambos apellidos separados por un espacio.");
                    return;
                }
            }
            else // rfc o correo  
            {
                persona = personaDAO.busquedaAvanzadaCliente(textBuscar.Text);
            }

            if (persona.FirstOrDefault() == "Cliente no encontrado")
            {
                MessageBox.Show("Cliente no encontrado");
                return;
            }

            llenarComboCliente(persona);

        }

        private void llenarComboCliente(List<string> clientes)
        {
            foreach (string cliente in clientes)
            {
                comboCliente.Items.Add(cliente);
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {

            if (comboCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Debe de seleccionar un cliente");
                return;
            }


            if (!radioAño.Checked && !radioMesAño.Checked && !radioTodaHistoria.Checked)
            {
                MessageBox.Show("Debe de seleccionar un método de búsqueda");
                return;
            }

            if(radioAño.Checked && dateTimePicker1.Value > DateTime.Today)
            {
                MessageBox.Show("No puedes buscar un año futuro");
                return;
            }

            if (comboCliente.Text.Contains("@"))
            {
                idComprador = personaDAO.getIdPersonaPorCorreo(comboCliente.Text);
            }
            else
            {
                string nombreCompleto = comboCliente.Text;
                string[] partesNombre = nombreCompleto.Split(' ');

                if (partesNombre.Length > 3)
                {
                    partesNombre[0] = partesNombre[0] + " " + partesNombre[1];
                    partesNombre[1] = partesNombre[2];
                    partesNombre[2] = partesNombre[3];

                }

                idComprador = personaDAO.getIdPersonaPorApellidos(partesNombre[0], partesNombre[1], partesNombre[2]);
            }

            ClienteDAO clienteDAO = new ClienteDAO();
            DataTable dt = new DataTable();
            DateOnly inicio = new DateOnly();
            DateOnly fin = new DateOnly();

            if (radioAño.Checked) // Todo ese año de inicio a fin
            {
                int año = dateTimePicker1.Value.Year;
                inicio = new DateOnly(año, 1, 1); // 1 de enero
                fin = new DateOnly(año, 12, 31);  // 31 de diciembre
            }
            else if (radioMesAño.Checked) // Todo ese mes del año
            {
                int año = dateTimePicker1.Value.Year;
                int mes = dateTimePicker1.Value.Month;
                inicio = new DateOnly(año, mes, 1); // 1er día del mes

                // Calculamos el último día del mes:
                int ultimoDia = DateTime.DaysInMonth(año, mes);
                fin = new DateOnly(año, mes, ultimoDia);
            }
            else // Toda la historia
            {
                inicio = new DateOnly(1753, 1, 1); // Fecha mínima soportada por SQL Server
                fin = new DateOnly(9999, 12, 31);  // Fecha máxima soportada por SQL Server
            }

            dt = clienteDAO.getHistorialClientePorFechas(idComprador, inicio, fin);
            dgvHistCliente.DataSource = dt;
        }
    }
}
