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
    internal class ServicioDAO
    {
        public ServicioDAO() { }

        public List<Servicio> getServicios()
        {
            List<Servicio> servicios = new List<Servicio>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetServicios", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Servicio servicio = new Servicio();
                                servicio.IdServicio = Guid.Parse(reader["idServicio"].ToString());
                                servicio.Nombre = reader["nombre"].ToString();
                                servicios.Add(servicio);
                            }
                        }
                    }
                }
            }
            return servicios;
        }

        public Guid getIdServicio(string servicio)
        {
            Guid idServicio = Guid.Empty;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetServicio", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@servicio", servicio);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                idServicio = Guid.Parse(reader["id"].ToString());
                            }
                        }
                    }
                }
            }
            return idServicio;
        }

    }
}
