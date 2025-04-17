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
    public partial class Reservar : Form
    {
        public Reservar()
        {
            InitializeComponent();
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reservar FReservar = new Reservar();
            //this.Hide();
            //FReservar.ShowDialog();
            //this.Show();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaServicios FVentaServicios = new VentaServicios();
            this.Hide();
            FVentaServicios.ShowDialog();
            this.Show();
        }

        private void checkInCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInOut FCheckInOut = new CheckInOut();
            this.Hide();
            FCheckInOut.ShowDialog();
            this.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturar FFacturar = new Facturar();
            this.Hide();
            FFacturar.ShowDialog();
            this.Show();
        }


        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AggCliente FAgregarCliente = new AggCliente();
            this.Hide();
            FAgregarCliente.ShowDialog();
            this.Show();
        }

        private void modificarEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModElimCliente FModElimCliente = new ModElimCliente();
            this.Hide();
            FModElimCliente.ShowDialog();
            this.Show();
        }
        //No sirve
        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

    }
}
