using MAD.Connection;
using MAD.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.DAO
{
    internal class TipoHabitacionDAO
    {
        public TipoHabitacionDAO() { }
        public List<TipoHabitacion> getTiposHabitacion()
        {
            List<TipoHabitacion> tiposHabitacion = new List<TipoHabitacion>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetTipoHabitacion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                TipoHabitacion tipoHabitacion = new TipoHabitacion();
                                tipoHabitacion.IdTipoHabitacion = Guid.Parse(reader["idTipoHabitacion"].ToString());
                                tipoHabitacion.NivelHabitacion = reader["nivelHabitacion"].ToString();
                                tiposHabitacion.Add(tipoHabitacion);
                            }
                        }
                    }
                }
            }
            return tiposHabitacion;
        }

        public List<TipoHabitacion> getTiposHabitacionPorHotel(Guid idHotel)
        {
            List<TipoHabitacion> tiposHabitacion = new List<TipoHabitacion>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetTipoHabitacionHotel", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHotel", idHotel);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                TipoHabitacion tipoHabitacion = new TipoHabitacion();
                                tipoHabitacion.IdTipoHabitacion = Guid.Parse(reader["idTipoHabitacion"].ToString());
                                tipoHabitacion.NivelHabitacion = reader["nivelHabitacion"].ToString();
                                tiposHabitacion.Add(tipoHabitacion);
                            }
                        }
                    }
                }
            }
            return tiposHabitacion;
        }

        public bool insertTipoHabitacion(TipoHabitacion tipo, Guid idHotel, DataTable camas)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spInsertTipoHabitacion_Hotel", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nivelHabitacion", tipo.NivelHabitacion);
                    cmd.Parameters.AddWithValue("@precioPorPersona", tipo.PrecioPorPersona);
                    cmd.Parameters.AddWithValue("@precioPorNoche", tipo.PrecioPorNoche);
                    cmd.Parameters.AddWithValue("@canidadMaximaPersonas", tipo.CanidadMaximaPersonas);
                    cmd.Parameters.AddWithValue("@ubicacion", tipo.Ubicacion);
                    cmd.Parameters.AddWithValue("@idHotel", idHotel);
                    cmd.Parameters.AddWithValue("@idTipo", tipo.IdTipoHabitacion);

                    cmd.Parameters.AddWithValue("@camas", camas);
                    cmd.Parameters["@camas"].SqlDbType = SqlDbType.Structured;
                    cmd.Parameters["@camas"].TypeName = "cama"; // El mismo nombre del tipo creado en SQL Server

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }

            }
        }


        public Guid getIdTipoHabitacion(string tipoHabitacion, Guid idHotel)
        {
            Guid idTipohabitacion = Guid.Empty;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetIdTipoHabitacion_Hotel", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tipo", tipoHabitacion);
                    cmd.Parameters.AddWithValue("@idHotel", idHotel);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                idTipohabitacion = Guid.Parse(reader["id"].ToString());
                            }
                        }
                    }
                }
            }
            return idTipohabitacion;
        }

        public List<TipoHabitacion> getTiposHabitacionPorHotel(DateOnly inicio, DateOnly fin, Guid idHotel)
        {
            List<TipoHabitacion> tiposHabitacion = new List<TipoHabitacion>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetTiposHabitacionHotel", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fechaInicio", inicio);
                    cmd.Parameters.AddWithValue("@fechaFin", fin);
                    cmd.Parameters.AddWithValue("@idHotel", idHotel);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                TipoHabitacion tipoHabitacion = new TipoHabitacion();
                                tipoHabitacion.NivelHabitacion = reader["nivelHabitacion"].ToString();
                                tiposHabitacion.Add(tipoHabitacion);
                            }
                        }
                    }
                }
            }
            return tiposHabitacion;
        }



        public Dictionary<TipoHabitacion, Amenidad> getCaracteristicas(string habitacion, Guid idHotel)
        {
            Dictionary<TipoHabitacion, Amenidad> caracteristicas = new Dictionary<TipoHabitacion, Amenidad>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetCaracteristicasPorTipoHabitacion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nivel", habitacion);
                    cmd.Parameters.AddWithValue("@idHotel", idHotel);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Amenidad amenidad = new Amenidad();
                                TipoHabitacion tipoHabitacion = new TipoHabitacion();

                                amenidad.IdAmenidad = Guid.Parse(reader["idAmenidad"].ToString());
                                amenidad.Amenidad1 = reader["amenidad"].ToString();
                                tipoHabitacion.PrecioPorNoche = decimal.Parse(reader["precioPorNoche"].ToString());
                                tipoHabitacion.PrecioPorPersona = decimal.Parse(reader["precioPorPersona"].ToString());
                                tipoHabitacion.CanidadMaximaPersonas = int.Parse(reader["canidadMaximaPersonas"].ToString());

                                caracteristicas.Add(tipoHabitacion, amenidad);
                            }
                        }
                    }
                }
            }
            return caracteristicas;
        }


        public Dictionary<Guid, int> getCantidadHabitacionesPorTipo(Guid idHotel, Dictionary<Guid, int> habitacionesSolicitadas)
        {
            Dictionary<Guid, int> habitaciones = new Dictionary<Guid, int>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetCantidadHabitacionesPorTipoEnHotel", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHotel", idHotel);
                    cmd.Parameters.AddWithValue("@habitacionesSolicitadas", habitacionesSolicitadas);   
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Guid idTipoHabitacion = Guid.Parse(reader["idTipoHabitacion"].ToString());
                                int cantidadHabitaciones = int.Parse(reader["cantidadHabitaciones"].ToString());
                                habitaciones.Add(idTipoHabitacion, cantidadHabitaciones);
                            }
                        }
                    }
                }
            }
            return habitaciones;
        }

        public string getTipoHabitacionPorIdHabitacion(Guid idHabitacion)
        {
            string tipoHabitacion = string.Empty;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetTipoPorIdHabitacion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                tipoHabitacion = reader["nivel"].ToString();
                            }
                        }
                    }
                }
            }
            return tipoHabitacion;
        }

    }
}
