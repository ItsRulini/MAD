﻿using MAD.Connection;
using MAD.Models;
using System.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.DAO
{
    internal class DatosPersonaDAO
    {
        public DatosPersonaDAO() { }

        public DatosPersona getDatosPersona (string info)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetDatosPersona", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@info", info);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DatosPersona datosPersona = new DatosPersona();
                                datosPersona.IdPersona = Guid.Parse(reader["idPersona"].ToString());
                                datosPersona.Correo = reader["correo"].ToString();
                                datosPersona.Nombres = reader["nombres"].ToString();
                                datosPersona.Paterno = reader["paterno"].ToString();
                                datosPersona.Materno = reader["materno"].ToString();
                                datosPersona.TelefonoCasa = long.Parse(reader["telefonoCasa"].ToString());
                                datosPersona.Celular = long.Parse(reader["celular"].ToString());
                                datosPersona.FechaNacimiento = DateOnly.FromDateTime(DateTime.Parse(reader["fechaNacimiento"].ToString()));
                                return datosPersona;
                            }
                        }
                    }
                }
            }
            return null;
        }
        //Busqueda RFC o Correo
        public List<string> busquedaAvanzadaCliente (string DatosCliente) {
            List<string> listaClientes = new List<string>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spBusquedaAvanzadaCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@info", DatosCliente);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //ver qué hacer aquí xd no le entiendo tilin ayuda, llevamos un vergo de veces y sigo sin entender, no me papies bro, al menos ya le avancé en esto xdxdxd
                                string datosPersona = reader["Resultado"].ToString();
                                listaClientes.Add(datosPersona);
                            }
                        }
                    }
                }
            }

            return listaClientes;
        }
        //Busqueda por Apellidos
        public List<string> busquedaAvanzadaApellidos(string A_Paterno, string A_Materno)
        {
            List<string> listaClientes = new List<string>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spBuscarClientePorApellidos", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@paterno", A_Paterno);
                    cmd.Parameters.AddWithValue("@materno", A_Materno);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //ver qué hacer aquí xd no le entiendo tilin ayuda, llevamos un vergo de veces y sigo sin entender, no me papies bro, al menos ya le avancé en esto xdxdxd
                                string datosPersona = reader["Resultado"].ToString();
                                listaClientes.Add(datosPersona);
                            }
                        }
                    }
                }
            }

            return listaClientes;
        }


        public Guid getIdPersonaPorCorreo (string correo)
        {
            Guid idPersona = Guid.Empty;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetIdPersonaPorCorreo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@correo", correo);
                    
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //ver qué hacer aquí xd no le entiendo tilin ayuda, llevamos un vergo de veces y sigo sin entender, no me papies bro, al menos ya le avancé en esto xdxdxd
                                idPersona = Guid.Parse(reader["idPersona"].ToString());
                            }
                        }
                    }
                }
            }

            return idPersona;
        }


        public Guid getIdPersonaPorApellidos (string nombre, string A_Paterno, string A_Materno)
        {
            Guid idPersona = Guid.Empty;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetIdPersonaPorNombreCompleto", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombres", nombre);
                    cmd.Parameters.AddWithValue("@paterno", A_Paterno);
                    cmd.Parameters.AddWithValue("@materno", A_Materno);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //ver qué hacer aquí xd no le entiendo tilin ayuda, llevamos un vergo de veces y sigo sin entender, no me papies bro, al menos ya le avancé en esto xdxdxd
                                idPersona = Guid.Parse(reader["idPersona"].ToString());
                            }
                        }
                    }
                }
            }
            return idPersona;
        }
        //Obtiene los datos de la persona por un Id de Reserva
        public DatosPersona getDatosPersonaPorId(Guid? idPersona)
        {
            DatosPersona Datos = null;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetNombreCompletoPorId", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@idPersona", idPersona);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Datos = new DatosPersona();
                                Datos.Nombres = reader["nombres"].ToString();
                                Datos.Paterno = reader["paterno"].ToString();
                                Datos.Materno = reader["materno"].ToString();
                            }
                        }
                    }

                }
            }
            return Datos;
        }


        public DatosPersona ObtenerDatosPersona(Guid idPersona)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetAllDatosPersona", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPersona", idPersona);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new DatosPersona
                            {
                                IdPersona = reader.GetGuid(reader.GetOrdinal("idPersona")),
                                Correo = reader.GetString(reader.GetOrdinal("correo")),
                                Nombres = reader.GetString(reader.GetOrdinal("nombres")),
                                Paterno = reader.GetString(reader.GetOrdinal("paterno")),
                                Materno = reader.GetString(reader.GetOrdinal("materno")),
                                FechaNacimiento = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("fechaNacimiento"))),
                                TelefonoCasa = reader.GetInt64(reader.GetOrdinal("telefonoCasa")),
                                Celular = reader.GetInt64(reader.GetOrdinal("celular")),
                                FechaRegistro = reader.GetDateTime(reader.GetOrdinal("fechaRegistro"))
                            };
                        }
                    }
                }
            }
            return null;
        }

    }
}
