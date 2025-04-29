using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAD
{
    public partial class PantallaInicialAdmin : Form
    {
        private Guid idAdmin; // Almacena el ID del administrador
        public PantallaInicialAdmin()
        {
            InitializeComponent();
        }

        public PantallaInicialAdmin(Guid idAdmin)
        {
            InitializeComponent();
            this.idAdmin = idAdmin;
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
            Cancelaciones FCancelaciones = new Cancelaciones();
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
    }
}
