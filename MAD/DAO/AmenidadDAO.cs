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

        public List<Amenidad> getAmenidaes()
        {
            List<Amenidad> amenidades = new List<Amenidad>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetAmenidades", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
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

        public ICollection<Amenidad> getAmenidadesNoEnTipoHabitacion(Guid habitacion)
        {
            ICollection<Amenidad> amenidades = new List<Amenidad>();

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetAmenidadNoEnTipoHabitacion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idTipoHabitacion", habitacion);

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

        public ICollection<AmenidadTipoHabitacion> getAmenidadesTipoHabitacion(Guid habitacion)
        {
            ICollection<AmenidadTipoHabitacion> amenidades = new List<AmenidadTipoHabitacion>();

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetAmenidadPorTipoHabitacion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idTipoHabitacion", habitacion);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                AmenidadTipoHabitacion amenidad = new AmenidadTipoHabitacion();
                                amenidad.IdAmenidad = Guid.Parse(reader["idAmenidad"].ToString());
                                amenidades.Add(amenidad);
                            }
                        }
                    }
                }
            }
            return amenidades;
        }

        public bool insertarAmenidad(string nombre, long claveSAT, string claveUnidad)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spInsertServicio_Amenidad", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tipo", "Amenidad");
                    cmd.Parameters.AddWithValue("@concepto", nombre);
                    cmd.Parameters.AddWithValue("@claveSAT", claveSAT);
                    cmd.Parameters.AddWithValue("@claveUnidad", claveUnidad);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool insertAmenidadesTipoHabitacion(ICollection<Amenidad> amenidades, Guid idTipoHabitacion)
        {
            DataTable amenidad = new DataTable();
            amenidad.Columns.Add("idAmenidad", typeof(Guid));
            amenidad.Columns.Add("idTipoHabitacion", typeof(Guid));
            amenidad.Columns.Add("cantidad", typeof(int));

            foreach (Amenidad item in amenidades)
            {
                DataRow row = amenidad.NewRow();
                row["idAmenidad"] = item.IdAmenidad;
                row["idTipoHabitacion"] = idTipoHabitacion;
                row["cantidad"] = 1; // Asignar un valor por defecto o el que necesites
                amenidad.Rows.Add(row);
            }

            using (SqlCommand cmd = new SqlCommand("spInsertAmenidadesTipoHabitacion", Conexion.ObtenerConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@amenidades", amenidad);
                cmd.Parameters["@amenidades"].SqlDbType = SqlDbType.Structured;
                cmd.Parameters["@amenidades"].TypeName = "amenidadTipohabitacion"; // El mismo nombre del tipo creado en SQL Server

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }

        }
        public Guid getIdAmenidad(string amenidad)
        {
            Guid idAmenidad = Guid.Empty;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetIdAmenidad", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@amenidad", amenidad);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                idAmenidad = Guid.Parse(reader["idAmenidad"].ToString());
                            }
                        }
                    }
                }
            }
            return idAmenidad;

        }

        public string getAmenidadPorId(Guid id) {
            string amenidad = null;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetAmenidadPorId", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                amenidad = reader["amenidad"].ToString();
                            }
                        }
                    }
                }
            }
            return amenidad;

        }
    }
}
