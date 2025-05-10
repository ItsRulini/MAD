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

namespace MAD
{
    public partial class VentaServicios : Form
    {
        private Guid idFactura;
        private decimal totalCarrito = 0;
        public VentaServicios()
        {
            InitializeComponent();

        }

        private void inicializarGrid(Guid idHotel)
        {
            dgvServicio.Rows.Clear();

            ServicioDAO hotelDAO = new ServicioDAO();
            Dictionary<Guid, decimal> servicios = new Dictionary<Guid, decimal>();
            servicios = hotelDAO.getIdServicio_Precio_Hotel(idHotel); // Cambiar por el id del hotel que se necesite

            foreach (var item in servicios)
            {
                Servicio servicio = hotelDAO.getServicioPorId(item.Key);
                dgvServicio.Rows.Add(servicio.Nombre, item.Value, item.Key);
            }

        }


        private void btnBuscarReservacion_Click(object sender, EventArgs e)
        {
            FacturaDAO facturaDAO = new FacturaDAO();
            HotelDAO hotelDAO = new HotelDAO();

            if(string.IsNullOrEmpty(textNumReserva.Text))
            {
                MessageBox.Show("Por favor ingresa un número de reservación");
                return;
            }

            Guid idReservacion = Guid.Parse(textNumReserva.Text);

            Guid idHotel = hotelDAO.getIdHotelPorReserva(idReservacion);

            if (idHotel == Guid.Empty)
            {
                MessageBox.Show("No se encontró la reservación");
                return;
            }

            // Validar si la reservación ya tiene check in o check out
            ReservacionDAO reservacionDAO = new ReservacionDAO();
            if (!reservacionDAO.validarCheckInOut(idReservacion))
            {
                MessageBox.Show("No se puede vender servicios, no se realizó el check in o ya se realizó el check out");
                return;
            }

            textHotel.Text = hotelDAO.getNombreHotelPorId(idHotel);

            idFactura = facturaDAO.getIdFacturaPorReservacion(idReservacion);

            inicializarGrid(idHotel);
        }

        private void btnAggServicio_Click(object sender, EventArgs e)
        {

            if (dgvServicio.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvServicio.SelectedRows[0];

                // Obtener los valores de la celda 0 y celda 1
                var valorCelda0 = filaSeleccionada.Cells[0].Value?.ToString();
                var valorCelda1 = decimal.Parse(filaSeleccionada.Cells[1].Value?.ToString());
                var valorCelda2 = filaSeleccionada.Cells[2].Value?.ToString();

                Image imagenCargada = Properties.Resources.basura;
                // Guardar el valor de la celda 1 en una variable
                totalCarrito += valorCelda1;
                precioTotal.Text = "$" + totalCarrito.ToString() + " MXN";
                // Agregar el valor de la celda 0 a otro DataGridView (por ejemplo, dgvDestino)
                dgvCarritoServicio.Rows.Add(valorCelda0, valorCelda1, imagenCargada, valorCelda2);
            }
            else
            {
                MessageBox.Show("Por favor selecciona una fila primero.");
            }
        }

        private void dgvCarritoServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) // Para evitar errores si clickeas en los encabezados
            {
                totalCarrito -= decimal.Parse(dgvCarritoServicio.Rows[e.RowIndex].Cells[1].Value.ToString());
                precioTotal.Text = "$" + totalCarrito + " MXN"; 
                dgvCarritoServicio.Rows.RemoveAt(e.RowIndex);
            }
        }


        private void btnComprarServicio_Click(object sender, EventArgs e)
        {
            Dictionary<Guid, int> servicios = new Dictionary<Guid, int>();

            foreach (DataGridViewRow row in dgvCarritoServicio.Rows)
            {
                Guid idServicio = Guid.Parse(row.Cells[3].Value.ToString());

                if (servicios.ContainsKey(idServicio))
                {
                    Guid claveExistente = servicios.Keys.First(k => k.Equals(idServicio));
                    servicios[claveExistente]++;
                }
                else
                {
                    servicios[idServicio] = 1;
                }

            }

            FacturaServicioDAO facturaDAO = new FacturaServicioDAO();

            if (facturaDAO.insertFacturaServicio(servicios, idFactura))
            {
                MessageBox.Show("Servicios comprados correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al comprar los servicios");

            }
        }

    }
}
