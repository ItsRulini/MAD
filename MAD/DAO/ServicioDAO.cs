﻿using MAD.Connection;
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

        public List<Servicio> getServiciosHotel(Guid idHotel)
        {
            List<Servicio> servicios = new List<Servicio>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetServiciosHotel", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHotel", idHotel);
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
        //Obtiene nombre por ID
        public Servicio getServicioPorId(Guid id)
        {
            Servicio servicio = null;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetServicioPorId", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idServicio", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                servicio = new Servicio();
                                servicio.Nombre = reader["nombre"].ToString();
                            }
                        }
                    }
                }
            }
            return servicio;
        }

        public bool insertarServicio(string nombre, long claveSAT, string claveUnidad)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spInsertServicio_Amenidad", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tipo", "Servicio");
                    cmd.Parameters.AddWithValue("@concepto", nombre);
                    cmd.Parameters.AddWithValue("@claveSAT", claveSAT);
                    cmd.Parameters.AddWithValue("@claveUnidad", claveUnidad);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public List<Servicio> getServiciosNoHotel(Guid idHotel)
        {
            List<Servicio> servicios = new List<Servicio>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetServiciosNoEnHotel", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHotel", idHotel);
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
        //Obtiene servicios y precios de cada hotel (complementar con el método de obtener el nombre del servicio por el id de servicio)
        public Dictionary<Guid,decimal> getIdServicio_Precio_Hotel(Guid idHotel)
        {
            Dictionary<Guid, decimal> servicios = new Dictionary<Guid, decimal>();

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetId_PrecioServiciosHotel", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHotel", idHotel);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Guid idServicio = Guid.Parse(reader["idServicio"].ToString());
                                decimal precio = decimal.Parse(reader["precio"].ToString());
                                servicios.Add(idServicio, precio);
                            }
                        }
                    }
                }
            }

            return servicios;
        }


    }
}
