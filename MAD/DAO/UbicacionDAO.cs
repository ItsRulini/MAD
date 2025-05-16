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
    internal class UbicacionDAO
    {
        public UbicacionDAO() { }
        public List<Ubicacion> getPaises()
        {
            List<Ubicacion> ubicaciones = new List<Ubicacion>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetPaises", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Ubicacion ubicacion = new Ubicacion();
                                ubicacion.Pais = reader["pais"].ToString();
                                ubicaciones.Add(ubicacion);
                            }
                        }
                    }
                }
            }
            return ubicaciones;
        }

        public List<Ubicacion> getEstados(string pais)
        {
            List<Ubicacion> ubicaciones = new List<Ubicacion>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetEstadosDePais", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pais", pais);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Ubicacion ubicacion = new Ubicacion();
                                ubicacion.Estado = reader["estado"].ToString();
                                ubicaciones.Add(ubicacion);
                            }
                        }
                    }
                }
            }
            return ubicaciones;
        }

        public List<Ubicacion> getCiudades(string estado)
        {
            List<Ubicacion> ubicaciones = new List<Ubicacion>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetCiudadesDeEstado", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@estado", estado);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Ubicacion ubicacion = new Ubicacion();
                                ubicacion.Ciudad = reader["ciudad"].ToString();
                                ubicaciones.Add(ubicacion);
                            }
                        }
                    }
                }
            }
            return ubicaciones;
        }

        public List<Ubicacion> getCiudadesHotel()
        {
            List<Ubicacion> ubicaciones = new List<Ubicacion>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetCiudadesHotel", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Ubicacion ubicacion = new Ubicacion();
                                ubicacion.Ciudad = reader["ciudad"].ToString();
                                ubicaciones.Add(ubicacion);
                            }
                        }
                    }
                }
            }
            return ubicaciones;
        }

        public Guid getIdUbicacion(string ciudad)
        {
            Guid idUbicacion = Guid.Empty;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetIdUbicacion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ciudad", ciudad);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                idUbicacion = Guid.Parse(reader["idUbicacion"].ToString());
                            }
                        }
                    }
                }
            }
            return idUbicacion;
        }

        public Ubicacion getUbicacion(Guid? id)
        {
            Ubicacion ubicacion = new Ubicacion();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetUbicacion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUbicacion", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ubicacion.Pais = reader["pais"].ToString();
                                ubicacion.Estado = reader["estado"].ToString();
                                ubicacion.Ciudad = reader["ciudad"].ToString();
                            }
                        }
                    }
                }
            }
            return ubicacion;
        }


        public List<Ubicacion> getCiudadesDePais(string pais)
        {
            List<Ubicacion> ubicaciones = new List<Ubicacion>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetCiudadesDePais", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pais", pais);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Ubicacion ubicacion = new Ubicacion();
                                ubicacion.IdUbicacion = Guid.Parse(reader["idUbicacion"].ToString());
                                ubicacion.Ciudad = reader["ciudad"].ToString();
                                ubicaciones.Add(ubicacion);
                            }
                        }
                    }
                }
            }
            return ubicaciones;
        }

    }
}
