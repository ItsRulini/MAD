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
    internal class AmenidadDAO
    {
        public AmenidadDAO() { }

        public List<Amenidad> getAmenidadesTipoHabitacion(string habitacion)
        {
            List<Amenidad> amenidades = new List<Amenidad>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetAmenidadPorTipoHabitacion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nivel", habitacion);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Amenidad amenidad = new Amenidad();
                                amenidad.IdAmenidad = Guid.Parse(reader["idAmenidad"].ToString());
                                amenidad.Amenidad1 = reader["amenidad"].ToString();
                                amenidades.Add(amenidad);
                            }
                        }
                    }
                }
            }
            return amenidades;
        }

    }
}
