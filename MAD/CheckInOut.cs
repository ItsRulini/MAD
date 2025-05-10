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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MAD
{
    public partial class CheckInOut : Form
    {
        Guid idReservacion;
        public CheckInOut()
        {
            InitializeComponent();

            btnCheckIn.Enabled = false;
            btnCheckOut.Enabled = false;
        }

        private void btnBuscarReservacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textIdReservacion.Text))
            {
                MessageBox.Show("Por favor ingresa un número de reservación");
                return;
            }

            idReservacion = Guid.Parse(textIdReservacion.Text);

            ReservacionDAO reservacionDAO = new ReservacionDAO();
            Reservacion reservacion = reservacionDAO.getInfoReservacion(idReservacion);

            if (reservacion == null)
            {
                MessageBox.Show("Reservacion no encontrada");
                return;
            }

            // Convert FechaFinHospedaje (DateOnly?) to DateTime for comparison
            if (reservacion.FechaFinHospedaje.HasValue &&
                reservacion.FechaFinHospedaje.Value.ToDateTime(TimeOnly.MinValue) < DateTime.Today)
            {
                MessageBox.Show("Reservación fuera de fechas");

                if (reservacion.CheckIn.Value) // Sí se hizo
                    reservacionDAO.setCheckOut(idReservacion); // Si se pasó la fecha que se haga check out automaticamente
                return;
            }

            if (!reservacion.CheckIn.Value)
            {
                btnCheckIn.Enabled = true;
            }
            else
            {
                btnCheckOut.Enabled = true;
                
            }

            textDesde.Text = reservacion.FechaInicioHospedaje.ToString();
            textHasta.Text = reservacion.FechaFinHospedaje.ToString();

            DatosPersonaDAO datosPersonaDAO = new DatosPersonaDAO();
            DatosPersona persona = datosPersonaDAO.getDatosPersonaPorId(reservacion.IdComprador);

            textNombre.Text = persona.Nombres;
            textApellidoP.Text = persona.Paterno;
            textApellidoM.Text = persona.Materno;

            DataTable dt = reservacionDAO.ObtenerHabitacionesPorReservacion(idReservacion);

            dgvHabitaciones.DataSource = dt;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            ReservacionDAO reservacionDAO = new ReservacionDAO();

            DateOnly? dateOnly = textDesde.Text != null ? DateOnly.Parse(textDesde.Text) : null;

            if (reservacionDAO.setCheckIn(idReservacion, dateOnly))
            {
                MessageBox.Show("Check in realizado correctamente");
                btnCheckIn.Enabled = false;
                btnCheckOut.Enabled = true;
            }
            else
            {
                MessageBox.Show("Error al hacer check in");
            }

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            ReservacionDAO reservacionDAO = new ReservacionDAO();

            if (reservacionDAO.setCheckOut(idReservacion))
            {
                MessageBox.Show("Check out realizado correctamente.\nRedirigiengo a la facturación");
                btnCheckOut.Enabled = false;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al hacer check out");
            }
        }
    }
}
