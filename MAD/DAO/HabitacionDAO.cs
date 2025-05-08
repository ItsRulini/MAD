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
    internal class HabitacionDAO
    {
        public HabitacionDAO() { }

        public List<Habitacion> getHabitacionesParaReservar(Guid idHotel, Dictionary<Guid, int> tipoHabitaciones, DateTime fechaInicio, DateTime fechaFin)
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            
            DataTable tipo_Habitacion = new DataTable();

            tipo_Habitacion.Columns.Add("id",typeof(Guid));
            tipo_Habitacion.Columns.Add("cantidad",typeof(int));

            foreach (var item in tipoHabitaciones)
            {
                // id del tipo de habitacion, cantidad por tipo de habtiación
                tipo_Habitacion.Rows.Add(item.Key, item.Value);
            }
            
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetHabitacionesParaReservar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHotel", idHotel);

                    cmd.Parameters.AddWithValue("@habitaciones", tipo_Habitacion);
                    cmd.Parameters["@habitaciones"].SqlDbType = SqlDbType.Structured;
                    cmd.Parameters["@habitaciones"].TypeName = "tipo_habitacion";

                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Habitacion habitacion = new Habitacion();
                                habitacion.IdHabitacion = Guid.Parse(reader["idHabitacion"].ToString());
                                habitacion.NumeroHabitacion = int.Parse(reader["numeroHabitacion"].ToString());
                                habitaciones.Add(habitacion);
                            }
                        }
                    }
                }
            }
            return habitaciones;
        }

        public int getCantidadTipoHabitacion_Hotel(Guid idHotel, string tipoHabitacion, DateTime fechaInicio, DateTime fechaFin)
        {
            int cantidad = 0;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetCantidadesPorTipoEnHotel", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHotel", idHotel);
                    cmd.Parameters.AddWithValue("@tipoHabitacion", tipoHabitacion);
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cantidad = int.Parse(reader["cantidad"].ToString());
                            }
                        }
                    }
                }
            }
            return cantidad;
        }

    }
}
