using MAD.DAO;
using MAD.Models;
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
    public partial class ReporteOcupacion : Form
    {
        UbicacionDAO ubicacionDAO = new UbicacionDAO();
        HotelDAO hotelDAO = new HotelDAO();
        public ReporteOcupacion()
        {
            InitializeComponent();
            inicializarComboPaises();
            comboCiudad.Enabled = false;
            comboHotel.Enabled = false;
        }

        private void inicializarComboPaises()
        {
            comboPais.Items.Clear();
            List<Ubicacion> paises = ubicacionDAO.getPaises();

            foreach (Ubicacion p in paises)
            {
                comboPais.Items.Add(p.Pais);
            }

        }
        List<Ubicacion> ciudades = new List<Ubicacion>();
        private void comboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPais.SelectedIndex < 0) return;

            comboCiudad.Items.Clear();
            comboHotel.Items.Clear();
            comboCiudad.SelectedIndex = -1;
            comboHotel.SelectedIndex = -1;

            ciudades = ubicacionDAO.getCiudadesDePais(comboPais.Text);

            foreach (Ubicacion p in ciudades)
            {
                comboCiudad.Items.Add(p.Ciudad);
            }
            comboCiudad.Enabled = true;
        }

        List<Hotel> hoteles = new List<Hotel>();

        private void comboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCiudad.SelectedIndex < 0) return;

            comboHotel.Items.Clear();
            comboHotel.SelectedIndex = -1;
            comboHotel.Text = "";

            // Obtén el nombre de la ciudad seleccionada
            string ciudadSeleccionada = comboCiudad.SelectedItem.ToString();

            // Busca en la lista 'ciudades' el ID correspondiente
            Ubicacion ciudad = ciudades.FirstOrDefault(c => c.Ciudad == ciudadSeleccionada);

            hoteles = hotelDAO.obtenerHotelesPorCiudad(ciudad.IdUbicacion);

            foreach (Hotel hotel in hoteles)
            {
                comboHotel.Items.Add(hotel.Nombre);
            }

            if (!checkBox1.Checked)
                comboHotel.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // filtrar todos los de esa ciudad
        {
            if (checkBox1.Checked)
            {
                comboHotel.Enabled = false;
                comboHotel.SelectedIndex = -1;
            }
            else
            {
                //comboHotel.Enabled = true;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltarOcupacion_Click(object sender, EventArgs e)
        {
            if (comboCiudad.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una ciudad");
                return;
            }

            if (dtpAñoReporte.Value > DateTime.Today)
            {
                MessageBox.Show("No se puede generar un reporte para una fecha futura");
                return;
            }

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            if (!checkBox1.Checked) // seleccionó hotel
            {
                if (comboHotel.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un hotel");
                    return;
                }

                Hotel hotel = hoteles.FirstOrDefault(h => h.Nombre == comboHotel.SelectedItem.ToString());

                dt1 = hotelDAO.getReporteOcupacionDetalladoPorHotel(hotel.IdHotel, DateOnly.FromDateTime(dtpAñoReporte.Value));
                dt2 = hotelDAO.getReporteOcupacionResumenPorHotel(hotel.IdHotel, DateOnly.FromDateTime(dtpAñoReporte.Value));
            }
            else // Todos los hoteles de esa ciudad
            {
                // Obtén el nombre de la ciudad seleccionada
                string ciudadSeleccionada = comboCiudad.SelectedItem.ToString();

                // Busca en la lista 'ciudades' el ID correspondiente
                Ubicacion ciudad = ciudades.FirstOrDefault(c => c.Ciudad == ciudadSeleccionada);

                dt1 = hotelDAO.getReporteOcupacionDetalladoPorCiudad(ciudad.IdUbicacion, DateOnly.FromDateTime(dtpAñoReporte.Value));
                dt2 = hotelDAO.getReporteOcupacionResumenPorCiudad(ciudad.IdUbicacion, DateOnly.FromDateTime(dtpAñoReporte.Value));
            }

            dgvVistaUno.DataSource = dt1;
            dgvVistaDos.DataSource = dt2;
        }
    }
}
