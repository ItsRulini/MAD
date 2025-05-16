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
    public partial class PantallaInicialAdmin : Form
    {
        UbicacionDAO ubicacionDAO = new UbicacionDAO();
        HotelDAO hotelDAO = new HotelDAO();

        private Guid idAdmin; // Almacena el ID del administrador
        //public PantallaInicialAdmin()
        //{
        //    InitializeComponent();
        //}

        public PantallaInicialAdmin(Guid idAdmin)
        {
            InitializeComponent();
            this.idAdmin = idAdmin;
            comboCiudad.Enabled = false;
            comboHotel.Enabled = false;
            inicializarComboPaises();
        }

        private void agregarHotelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AñadirHotel FAddHotel = new AñadirHotel(idAdmin);
            this.Hide();
            FAddHotel.ShowDialog();
            this.Show();
        }

        private void agregarAmenidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AñadorAmenidad FAddAmenidad = new AñadorAmenidad();
            this.Hide();
            FAddAmenidad.ShowDialog();
            this.Show();
        }

        private void cancelacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancelaciones FCancelaciones = new Cancelaciones(idAdmin);
            this.Hide();
            FCancelaciones.ShowDialog();
            this.Show();
        }

        private void reporteDeOcupaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteOcupacion FRptOcupacion = new ReporteOcupacion();
            this.Hide();
            FRptOcupacion.ShowDialog();
            this.Show();
        }

        private void historalDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialCliente FHistCliente = new HistorialCliente();
            this.Hide();
            FHistCliente.ShowDialog();
            this.Show();
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AggUsuario FAggUsuario = new AggUsuario();
            this.Hide();
            FAggUsuario.ShowDialog();
            this.Show();
        }

        private void modificarUsuariioOperativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModElimUsuario FModElimUsuario = new ModElimUsuario(idAdmin);
            this.Hide();
            FModElimUsuario.ShowDialog();
            this.Show();
        }
        private void modificarHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // esta es la de modificar hotel
            ModHotel FModHotel = new ModHotel();
            this.Hide();
            FModHotel.ShowDialog();
            this.Show();
        }
        private void agregarServicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // agregar servicios al catálogo
            AñadirServicio FAggServicio = new AñadirServicio();
            this.Hide();
            FAggServicio.ShowDialog();
            this.Show();
        }
        private void agregarAmenidadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // agregar amenidaes al catalogo
            AñadorAmenidad FAggAmenidad = new AñadorAmenidad();
            this.Hide();
            FAggAmenidad.ShowDialog();
            this.Show();
        }


        private void agregarHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void agregarUsuarioOperativoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void serviciosYAmenidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void agregarServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

            // Obtén el nombre de la ciudad seleccionada
            string ciudadSeleccionada = comboCiudad.SelectedItem.ToString();

            // Busca en la lista 'ciudades' el ID correspondiente
            Ubicacion ciudad = ciudades.FirstOrDefault(c => c.Ciudad == ciudadSeleccionada);

            hoteles = hotelDAO.obtenerHotelesPorCiudad(ciudad.IdUbicacion);

            foreach (Hotel hotel in hoteles)
            {
                comboHotel.Items.Add(hotel.Nombre);
            }

            if(!checkBox1.Checked)
                comboHotel.Enabled = true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (comboCiudad.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una ciudad");
                return;
            }

            if(dtpAño.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha no puede ser mayor a la actual");
                return;
            }


            DataTable dt = new DataTable();

            if (!checkBox1.Checked) // seleccionó hotel
            {
                if(comboHotel.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un hotel");
                    return;
                }

                Hotel hotel = hoteles.FirstOrDefault(h => h.Nombre == comboHotel.SelectedItem.ToString());
                
                dt = hotelDAO.getReporteVentasHotel(hotel.IdHotel, DateOnly.FromDateTime(dtpAño.Value));
            }
            else // Todos los hoteles de esa ciudad
            {
                // Obtén el nombre de la ciudad seleccionada
                string ciudadSeleccionada = comboCiudad.SelectedItem.ToString();

                // Busca en la lista 'ciudades' el ID correspondiente
                Ubicacion ciudad = ciudades.FirstOrDefault(c => c.Ciudad == ciudadSeleccionada);

                dt = hotelDAO.getReporteVentasCiudad(ciudad.IdUbicacion, DateOnly.FromDateTime(dtpAño.Value));
            }

            dataGridView1.DataSource = dt;

            // Da formato a la columna "Total" como divisa mexicana (MXN)
            if (dataGridView1.Columns.Contains("IngresosTotales"))
            {
                dataGridView1.Columns["Ingresos Hospedaje"].DefaultCellStyle.Format = "C2";
                dataGridView1.Columns["Ingresos Servicios"].DefaultCellStyle.Format = "C2";
                dataGridView1.Columns["IngresosTotales"].DefaultCellStyle.Format = "C2";
            }
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
                comboHotel.Enabled = true;
            }
        }
    }
}
