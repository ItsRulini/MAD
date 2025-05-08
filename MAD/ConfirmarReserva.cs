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
    public partial class ConfirmarReserva : Form
    {
        private Reservacion reservacion;
        private Dictionary<Habitacion, int> habitacionesReservadas;
        public ConfirmarReserva(Reservacion reservacion, Dictionary<Habitacion, int> habitaciones)
        {
            InitializeComponent();
            this.reservacion = reservacion;
            this.habitacionesReservadas = habitaciones;
            //numeroReservacion.Text = reservacion.IdReservacion.ToString();
            textNumeroReservacion.Text = reservacion.IdReservacion.ToString();
            inicializarGrid();
        }


        private void textReservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void inicializarGrid()
        {
            TipoHabitacionDAO tipoHabitacionDAO = new TipoHabitacionDAO();
            foreach (var habitacion in habitacionesReservadas)
            {
                int index = dgvReserva.Rows.Add();
                DataGridViewRow row = dgvReserva.Rows[index];

                row.Cells[0].Value = tipoHabitacionDAO.getTipoHabitacionPorIdHabitacion(habitacion.Key.IdHabitacion);

                row.Cells[1].Value = habitacion.Key.NumeroHabitacion;
                row.Cells[2].Value = habitacion.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReservacionDAO reservacionDAO = new ReservacionDAO();

            if (reservacionDAO.reservar(reservacion, habitacionesReservadas))
            {
                this.DialogResult = DialogResult.OK; // Indica que la operación fue exitosa
                MessageBox.Show("Reservación realizada con éxito.");
            }
            else
            {
                MessageBox.Show("Error al realizar la reservación.");
            }
            this.Close(); // Cierra el formulario
        }
    }
}
