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

            if(datosReservacion.MetodoPago == "Transferencia")
            {
                datosReservacion.MetodoPago = "Transeferencia";
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
        //Validamos si ya hizo check in/out para poder vender servicios
        public bool validarCheckInOut(Guid idReserva)
        {
            bool validar = false;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spValidarVentaServicio", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@idReservacion", idReserva);
                    // Ejecutar el comando
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                validar = bool.Parse(reader["Resultado"].ToString());
                            }
                        }
                    }
                }
                return validar;
            }
        }
        
        //Obtiene fecha de inicio/fin de hospedaje y el id del comprado
        public Reservacion getInfoReservacion(Guid idReservacion)
        {
            Reservacion reserva = null;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetInfoReservacion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@idReservacion", idReservacion);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                reserva = new Reservacion();
                                reserva.FechaInicioHospedaje = reader["fechaInicioHospedaje"] is DBNull
                                ? null
                                : DateOnly.FromDateTime((DateTime)reader["fechaInicioHospedaje"]);

                                reserva.FechaFinHospedaje = reader["fechaFinHospedaje"] is DBNull
                                ? null
                                : DateOnly.FromDateTime((DateTime)reader["fechaFinHospedaje"]);

                                reserva.IdComprador = Guid.Parse(reader["idComprador"].ToString());
                                reserva.CheckIn = bool.Parse(reader["checkIn"].ToString());
                                reserva.ChekOut = bool.Parse(reader["chekOut"].ToString());
                            }
                        }
                    }
                }
            }
            return reserva;
        }

        public DataTable ObtenerHabitacionesPorReservacion(Guid idReservacion)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("spGetHabitacionesPorReservacion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idReservacion", idReservacion);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public bool setCheckIn(Guid idReservacion, DateOnly? FechaInicio)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spSetCheckIn", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@idReservacion", idReservacion);
                    cmd.Parameters.AddWithValue("@fechaInicio", FechaInicio);
                    
                    // Ejecutar el comando
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Retorna true si se actualizó
                }
            }
        }
        
        public bool setCheckOut(Guid idReservacion)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spSetCheckOut", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@idReservacion", idReservacion);

                    // Ejecutar el comando
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public Reservacion ObtenerReservacion(Guid idReservacion)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetAllDatosReservacion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idReservacion", idReservacion);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Reservacion
                            {
                                IdReservacion = reader.GetGuid(reader.GetOrdinal("idReservacion")),
                                MetodoPago = reader.GetString(reader.GetOrdinal("metodoPago")),
                                Anticipo = reader.GetDecimal(reader.GetOrdinal("anticipo")),
                                MontoTotal = reader.GetDecimal(reader.GetOrdinal("montoTotal")),
                                FechaInicioHospedaje = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("fechaInicioHospedaje"))),
                                FechaFinHospedaje = DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal("fechaFinHospedaje"))),
                                CheckIn = reader.GetBoolean(reader.GetOrdinal("checkIn")),
                                ChekOut = reader.GetBoolean(reader.GetOrdinal("chekOut")), // ojo: es "chekOut" en tu tabla
                                FechaReservacion = reader.GetDateTime(reader.GetOrdinal("fechaReservacion")),
                                IdComprador = reader.GetGuid(reader.GetOrdinal("idComprador")),
                                IdVendedor = reader.GetGuid(reader.GetOrdinal("idVendedor")),
                                IdHotel = reader.GetGuid(reader.GetOrdinal("idHotel"))
                            };
                        }
                    }
                }
            }
            return null;
        }


    }



}
