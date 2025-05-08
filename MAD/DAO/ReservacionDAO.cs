using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAD.Connection;
using MAD.Models;
using Microsoft.Data.SqlClient;


namespace MAD.DAO
{
    internal class ReservacionDAO
    {
        public ReservacionDAO() { }

        public bool reservar(Reservacion datosReservacion, Dictionary<Habitacion, int> habitaciones)
        {
            DataTable habTable = new DataTable();
            habTable.Columns.Add("idHabitacion", typeof(Guid));
            habTable.Columns.Add("numeroHabitacion", typeof(int));
            habTable.Columns.Add("cantidadPersonas", typeof(int));

            foreach (var item in habitaciones)
            {
                habTable.Rows.Add(item.Key.IdHabitacion, item.Key.NumeroHabitacion, item.Value);
            }

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spReservar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@idReservacion", datosReservacion.IdReservacion);
                    cmd.Parameters.AddWithValue("@metodoPago", datosReservacion.MetodoPago);
                    cmd.Parameters.AddWithValue("@anticipo", datosReservacion.Anticipo);
                    cmd.Parameters.AddWithValue("@montoTotal", datosReservacion.MontoTotal);
                    cmd.Parameters.AddWithValue("@fechaInicioHospedaje", datosReservacion.FechaInicioHospedaje);
                    cmd.Parameters.AddWithValue("@fechaFinHospedaje", datosReservacion.FechaFinHospedaje);
                    cmd.Parameters.AddWithValue("@idComprador", datosReservacion.IdComprador);
                    cmd.Parameters.AddWithValue("@idVendedor", datosReservacion.IdVendedor);
                    cmd.Parameters.AddWithValue("@idHotel", datosReservacion.IdHotel);

                    cmd.Parameters.AddWithValue("@habitaciones", habTable);
                    cmd.Parameters["@habitaciones"].SqlDbType = SqlDbType.Structured;
                    cmd.Parameters["@habitaciones"].TypeName = "habitacion";
                    // Ejecutar el comando
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Retorna true si se insertó correctamente
                }
            }

            return false;
        }
    }
}
