using MAD.DAO;
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
using System.Reflection.PortableExecutable;

namespace MAD
{
    public partial class Reservar : Form
    {
        private string precioNocheHabitacion;
        private string precioPersonaHabitacion;

        private double subtotal;
        private double iva;
        private double total;

        DataGridViewCell subtotalCelda;
        DataGridViewCell ivaCelda;
        DataGridViewCell totalCelda;


        public Reservar()
        {
            InitializeComponent();
            inicializarComboPagos();
            inicializarComboCiudades();

            inicializarGridCarrito();
        }

        private void inicializarGridCarrito()
        {
            subtotal = 0;
            iva = 0;
            total = 0;

            // Primero agregas las filas y guardas el índice
            int filaSubtotal = dgvCarritoReserva.Rows.Add("Subtotal", "$" + subtotal + " MXN");
            int filaIVA = dgvCarritoReserva.Rows.Add("IVA", "$" + subtotal * 0.16 + " MXN");
            int filaTotal = dgvCarritoReserva.Rows.Add("Total", "$" + subtotal * 1.16 + " MXN");

            // Ahora sí obtienes las celdas que quieras modificar luego
            subtotalCelda = dgvCarritoReserva.Rows[filaSubtotal].Cells[1]; // Columna 1: el monto
            ivaCelda = dgvCarritoReserva.Rows[filaIVA].Cells[1];
            totalCelda = dgvCarritoReserva.Rows[filaTotal].Cells[1];
        }

        private void ResetForm(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 1;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
                else if (control is DataGridView)
                {
                    ((DataGridView)control).Rows.Clear();
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                else if (control.HasChildren)
                {
                    // Si el control contiene otros controles (como GroupBox, Panel, TabPage)
                    ResetForm(control);
                }
            }
        }



        private void inicializarComboCiudades()
        {
            UbicacionDAO ubicacionDAO = new UbicacionDAO();

            List<Ubicacion> ciudades = ubicacionDAO.getCiudadesHotel();

            foreach (Ubicacion ci in ciudades)
            {
                comboCiudad.Items.Add(ci.Ciudad);
            }

        }
        private void inicializarComboPagos()
        {
            comboMetodoPago.Items.Add("Efectivo");
            comboMetodoPago.Items.Add("Tarjeta");
            comboMetodoPago.Items.Add("Transferencia");
        }

        private void incializarGridHotelesDisponibles()
        {
            HotelDAO hotelDAO = new HotelDAO();

            DateOnly inicio = DateOnly.FromDateTime(dtpDesde.Value);
            DateOnly fin = DateOnly.FromDateTime(dtpHasta.Value);

            List<Hotel> hoteles = hotelDAO.getHotelesDisponibles(inicio, fin, comboCiudad.Text);

            foreach (Hotel hotel in hoteles)
            {
                dgvHoteles.Rows.Add(hotel.Nombre, hotel.IdHotel);
            }
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
            ResetForm(this);
            inicializarGridCarrito();
            this.Show();
        }

        private void checkInCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInOut FCheckInOut = new CheckInOut();
            this.Hide();
            FCheckInOut.ShowDialog();
            ResetForm(this);
            inicializarGridCarrito();
            this.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturar FFacturar = new Facturar();
            this.Hide();
            FFacturar.ShowDialog();
            ResetForm(this);
            inicializarGridCarrito();
            this.Show();
        }


        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AggCliente FAgregarCliente = new AggCliente();
            this.Hide();
            FAgregarCliente.ShowDialog();
            ResetForm(this);
            inicializarGridCarrito();
            this.Show();
        }

        private void modificarEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModElimCliente FModElimCliente = new ModElimCliente();
            this.Hide();
            FModElimCliente.ShowDialog();
            ResetForm(this);
            inicializarGridCarrito();
            this.Show();
        }


        private void btnAggCarrito_Click(object sender, EventArgs e)
        {

            if (comboHabitacion.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de habitación");
                return;
            }

            TipoHabitacionDAO tipoHab = new TipoHabitacionDAO();
            Dictionary<TipoHabitacion, Amenidad> precio = tipoHab.getCaracteristicas(comboHabitacion.Text);



            int? cantidadMaxina = precio.FirstOrDefault().Key.CanidadMaximaPersonas;

            if (numeroPersonas.Value > cantidadMaxina)
            {
                MessageBox.Show("La cantidad máxima de personas es de: " + cantidadMaxina);
                return;
            }

            subtotal += Math.Round(double.Parse(precio.FirstOrDefault().Key.PrecioPorNoche.ToString()));
            iva = Math.Round(subtotal * 0.16);
            total = Math.Round(iva + subtotal);

            subtotalCelda.Value = "$" + subtotal + " MXN";
            ivaCelda.Value = "$" + iva + " MXN";
            totalCelda.Value = "$" + total + " MXN";

            // Insertar la nueva fila en la posición 0
            dgvCarritoReserva.Rows.Insert(0, comboHabitacion.Text, numeroPersonas.Value);

            MessageBox.Show("Articulo agregado al carrito.");
            comboHabitacion.SelectedIndex = -1;
            textDetallesHab.Clear();


        }

        private void btnComprarReserva_Click(object sender, EventArgs e)
        {

        }

        private void comboHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboHabitacion.SelectedIndex == -1)
                return;

            textDetallesHab.Text = "";
            TipoHabitacionDAO tipoDAO = new TipoHabitacionDAO();
            Dictionary<TipoHabitacion, Amenidad> caracteristicas = tipoDAO.getCaracteristicas(comboHabitacion.Text);

            StringBuilder caracteristicasStrs = new StringBuilder();

            string precioNoche = caracteristicas.FirstOrDefault().Key.PrecioPorNoche.ToString().Trim();
            string precioPersona = caracteristicas.FirstOrDefault().Key.PrecioPorPersona.ToString().Trim();
            string cantPersonas = caracteristicas.FirstOrDefault().Key.CanidadMaximaPersonas.ToString().Trim();

            precioNocheHabitacion = precioNoche;
            precioPersonaHabitacion = precioPersona;

            caracteristicasStrs.Append("Precio por persona: $" + precioPersona + " MXN\n");
            caracteristicasStrs.Append("Precio por noche: $" + precioNoche + " MXN\n");
            caracteristicasStrs.Append("Personas máximas permitidas: " + cantPersonas + "\n");
            caracteristicasStrs.AppendLine("Amenidades:\n");

            foreach (var item in caracteristicas)
            {
                caracteristicasStrs.AppendLine(item.Value.Amenidad1 + "\n");
            }

            caracteristicasStrs.AppendLine("PRECIOS NO INCLUYEN IVA.");

            textDetallesHab.Text = caracteristicasStrs.ToString();
        }

        private void llenarComboHabitaciones()
        {
            DateOnly inicio = DateOnly.FromDateTime(dtpDesde.Value);
            DateOnly fin = DateOnly.FromDateTime(dtpHasta.Value);
            Guid id = Guid.Parse(dgvHoteles.CurrentRow.Cells[1].Value.ToString());

            TipoHabitacionDAO tipoDAO = new TipoHabitacionDAO();
            List<TipoHabitacion> habitaciones = tipoDAO.getTiposHabitacionPorHotel(inicio, fin, id);
            foreach (TipoHabitacion habitacion in habitaciones)
            {
                comboHabitacion.Items.Add(habitacion.NivelHabitacion);
            }
        }
        private void dgvHoteles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Seleccionado: " + dgvHoteles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            comboHabitacion.Items.Clear();
            llenarComboHabitaciones();
        }

        private void llenarComboCliente(List<string> clientes)
        {
            foreach (string cliente in clientes)
            {
                comboBox1.Items.Add(cliente);
            }
        }
        private void btnBuscarFechas_Click(object sender, EventArgs e)
        {
            List<string> persona = new List<string>();
            DatosPersonaDAO personaDAO = new DatosPersonaDAO();

            comboBox1.SelectedIndex = -1;
            comboBox1.Items.Clear();
            dgvHoteles.Rows.Clear();

            persona = personaDAO.busquedaAvanzadaCliente(textBuscarCliente.Text);

            if (persona.FirstOrDefault() == "Cliente no encontrado")
            {
                MessageBox.Show("Cliente no encontrado");
                return;
            }

            llenarComboCliente(persona);
            incializarGridHotelesDisponibles();
        }



        //No sirve
        private void label5_Click(object sender, EventArgs e)
        {

        }
        //No sirve
        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e) {/*no sirve*/}

        // Eliminar del carrito un item
        private void dgvCarritoReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex != subtotalCelda.RowIndex && e.RowIndex != ivaCelda.RowIndex
                && e.RowIndex != totalCelda.RowIndex) // Para evitar errores si clickeas en los encabezados
            {
                

                TipoHabitacionDAO tipoHab = new TipoHabitacionDAO();
                Dictionary<TipoHabitacion, Amenidad> precio = tipoHab.getCaracteristicas(dgvCarritoReserva.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString());

                subtotal -= Math.Round(double.Parse(precio.FirstOrDefault().Key.PrecioPorNoche.ToString()));
                iva = Math.Round(subtotal * 0.16);
                total = Math.Round(iva + subtotal);

                subtotalCelda.Value = "$" + subtotal + " MXN";
                ivaCelda.Value = "$" + iva + " MXN";
                totalCelda.Value = "$" + total + " MXN";

                dgvCarritoReserva.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
