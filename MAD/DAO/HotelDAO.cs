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

        public bool insertHotel(Hotel hotel)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spInsertHotel", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHotel", hotel.IdHotel);
                    cmd.Parameters.AddWithValue("@rfc", hotel.Rfc);
                    cmd.Parameters.AddWithValue("@nombre", hotel.Nombre);
                    cmd.Parameters.AddWithValue("@domicilio", hotel.Domicilio);
                    cmd.Parameters.AddWithValue("@numeroPisos", hotel.NumeroPisos);
                    cmd.Parameters.AddWithValue("@fechaInicioOperaciones", hotel.FechaInicioOperaciones);
                    cmd.Parameters.AddWithValue("@idUsuario", hotel.IdUsuario);
                    cmd.Parameters.AddWithValue("@idUbicacion", hotel.IdUbicacion);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool insertInfoHotel(Hotel hotel, List<HotelServicio> servicios, Dictionary<TipoHabitacion, int> tipoHabitaciones)
        {

            DataTable serviciosHotel = new DataTable();
            serviciosHotel.Columns.Add("id", typeof(Guid));
            serviciosHotel.Columns.Add("precio", typeof(decimal));

            foreach (var item in servicios)
            {
                serviciosHotel.Rows.Add(item.IdServicio, item.Precio);
            }

            DataTable tipos = new DataTable();
            tipos.Columns.Add("id", typeof(Guid));
            tipos.Columns.Add("cantidad", typeof(int));

            foreach (var item in tipoHabitaciones)
            {
                tipos.Rows.Add(item.Key.IdTipoHabitacion, item.Value);
            }

            DataTable amenidades = new DataTable();
            amenidades.Columns.Add("idAmenidad", typeof(Guid));
            amenidades.Columns.Add("idTipoHabitacion", typeof(Guid));
            amenidades.Columns.Add("cantidad", typeof(int));

            foreach (var item in tipoHabitaciones)
            {
                foreach (var amenidad in item.Key.AmenidadTipoHabitacions)
                {
                    amenidades.Rows.Add(amenidad.IdAmenidad, item.Key.IdTipoHabitacion, 1);
                }
            }

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("spInsertInfoHotel", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHotel", hotel.IdHotel);

                    cmd.Parameters.AddWithValue("@tipoHabitaciones", tipos);
                    cmd.Parameters["@tipoHabitaciones"].SqlDbType = SqlDbType.Structured;
                    cmd.Parameters["@tipoHabitaciones"].TypeName = "tipo_Habitacion"; // El mismo nombre del tipo creado en SQL Server

                    cmd.Parameters.AddWithValue("@amenidades", amenidades);
                    cmd.Parameters["@amenidades"].SqlDbType = SqlDbType.Structured;
                    cmd.Parameters["@amenidades"].TypeName = "amenidadTipoHabitacion"; // El mismo nombre del tipo creado en SQL Server

                    cmd.Parameters.AddWithValue("@servicios", serviciosHotel);
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
