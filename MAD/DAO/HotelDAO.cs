using MAD.Connection;
using MAD.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.DAO
{
    internal class HotelDAO
    {
        public HotelDAO() { }

        public bool insertHotel(Hotel hotel, List<HotelServicio> servicios, Dictionary<TipoHabitacion, int> tipoHabitaciones, Guid idUsuario)
        {

            DataTable guidTable = new DataTable();
            guidTable.Columns.Add("id", typeof(Guid));
            guidTable.Columns.Add("precio", typeof(decimal));

            foreach (var item in servicios)
            {
                guidTable.Rows.Add(item.IdServicio, item.Precio);
            }

            DataTable guidTable2 = new DataTable();
            guidTable2.Columns.Add("id", typeof(Guid));
            guidTable2.Columns.Add("cantidad", typeof(int));

            foreach (var item in tipoHabitaciones)
            {
                guidTable2.Rows.Add(item.Key.IdTipoHabitacion, item.Value);
            }

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("spInsertHotel", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@rfc", hotel.Rfc);
                    cmd.Parameters.AddWithValue("@nombre", hotel.Nombre);
                    cmd.Parameters.AddWithValue("@domicilio", hotel.Domicilio);
                    cmd.Parameters.AddWithValue("@numeroPisos", hotel.NumeroPisos);
                    cmd.Parameters.AddWithValue("@fechaInicioOperaciones", hotel.FechaInicioOperaciones);
                    cmd.Parameters.AddWithValue("@idUbicacion", hotel.IdUbicacion);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    cmd.Parameters.AddWithValue("@tipoHabitaciones", guidTable2);
                    cmd.Parameters["@tipoHabitaciones"].SqlDbType = SqlDbType.Structured;
                    cmd.Parameters["@tipoHabitaciones"].TypeName = "tipo_Habitacion"; // El mismo nombre del tipo creado en SQL Server

                    cmd.Parameters.AddWithValue("@servicios", guidTable);
                    cmd.Parameters["@servicios"].SqlDbType = SqlDbType.Structured;
                    cmd.Parameters["@servicios"].TypeName = "serviciosHotel"; // El mismo nombre del tipo creado en SQL Server

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }


            return false;
        }

        public List<Hotel> getHotelesDisponibles(DateOnly inicio, DateOnly fin, string ciudad)
        {
            List<Hotel> hoteles = new List<Hotel>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetHotelesDisponibles", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaInicio", inicio);
                    cmd.Parameters.AddWithValue("@fechaFin", fin);
                    cmd.Parameters.AddWithValue("@ciudad", ciudad);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Hotel hotel = new Hotel();
                                hotel.IdHotel = Guid.Parse(reader["idHotel"].ToString());
                                hotel.Nombre = reader["nombre"].ToString();
                                hoteles.Add(hotel);
                            }
                        }
                    }
                }
            }
            return hoteles;
        }

    }
}
