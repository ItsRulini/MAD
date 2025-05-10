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
    public partial class Cancelaciones : Form
    {
        Guid idReservacion,IdAdmin;
        Reservacion reservacion = null;
        public Cancelaciones(Guid idAdmin)
        {
            InitializeComponent();
            IdAdmin = idAdmin;
        }

        private void btnBuscarReservacion_Click(object sender, EventArgs e)
        {
            
            idReservacion = Guid.Parse(textNumReservacion.Text);

            ReservacionDAO reservacionDAO = new ReservacionDAO();
            reservacion = new Reservacion();
            reservacion = reservacionDAO.getInfoReservacion(idReservacion);

            if (reservacion == null) {
                MessageBox.Show("Reservación no existente");
                return;
            }

            CancelacionDAO cancelacionDAO = new CancelacionDAO();

            if (cancelacionDAO.validarCancelacion(idReservacion))
            {
                MessageBox.Show("Esta reservación ya ha sido cancelada.");
                btnCancelarReservacion.Enabled = false;
            }


            HotelDAO hotelDAO = new HotelDAO();
            Guid idHotel = hotelDAO.getIdHotelPorReserva(idReservacion);

            textHotel.Text = hotelDAO.getNombreHotelPorId(idHotel);

            fechaInicio.Text = reservacion.FechaInicioHospedaje.ToString();
            fechaFin.Text = reservacion.FechaFinHospedaje.ToString();

            DataTable dt = reservacionDAO.ObtenerHabitacionesPorReservacion(idReservacion);

            dgvDetallesReserva.DataSource = dt;

        }

        bool PuedeCancelar(Reservacion reservacion)
        {
            if (reservacion.FechaInicioHospedaje.HasValue)
            {
                DateTime fechaInicio = reservacion.FechaInicioHospedaje.Value.ToDateTime(TimeOnly.MinValue);
                return (fechaInicio - DateTime.Today).Days >= 3;
            }
            return false;
        }


        private void btnCancelarReservacion_Click(object sender, EventArgs e)
        {
            if(reservacion == null)
                { return; }

            if (!PuedeCancelar(reservacion))
            {
                MessageBox.Show("Ya no se puede cancelar, mínimo 3 días de anticipación.");
                return;
            }
            CancelacionDAO cancelacionDAO = new CancelacionDAO();

            if (cancelacionDAO.cancelar(idReservacion, IdAdmin))
            {
                MessageBox.Show("Cancelación realizada correctamente.");
                btnCancelarReservacion.Enabled = false;
            }

        }
    }
}
