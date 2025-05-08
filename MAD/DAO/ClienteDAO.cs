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
    internal class ClienteDAO
    {
        public ClienteDAO() { }

        public bool insertCliente(Cliente cliente, DatosPersona persona, DatosFiscal fiscal, Ubicacion ubicacion)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spInsertCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@nombres", persona.Nombres);
                    cmd.Parameters.AddWithValue("@paterno", persona.Paterno);
                    cmd.Parameters.AddWithValue("@materno", persona.Materno);
                    cmd.Parameters.AddWithValue("@telefono", persona.TelefonoCasa);
                    cmd.Parameters.AddWithValue("@celular", persona.Celular);
                    cmd.Parameters.AddWithValue("@correo", persona.Correo);
                    cmd.Parameters.AddWithValue("@nacimiento", persona.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@estadoCivil", cliente.EstadoCivil);
                    cmd.Parameters.AddWithValue("@rfc", cliente.Rfc);
                    cmd.Parameters.AddWithValue("@ubicacion", ubicacion.IdUbicacion);
                    cmd.Parameters.AddWithValue("@regimenFiscal", fiscal.RegimenFiscal);
                    // Ejecutar el comando
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Retorna true si se insertó correctamente
                }
            }
        }

        public bool borrarCliente(string correo)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spEliminarCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@correo", correo);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Retorna true si se borró correctamente
                }
            }
        }

        public bool updateCliente(Cliente cliente, DatosFiscal fiscal, DatosPersona persona)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spUpdateCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@correo", persona.Correo);
                    cmd.Parameters.AddWithValue("@nombres", persona.Nombres);
                    cmd.Parameters.AddWithValue("@paterno", persona.Paterno);
                    cmd.Parameters.AddWithValue("@materno", persona.Materno);
                    cmd.Parameters.AddWithValue("@nacimiento", persona.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@telefono", persona.TelefonoCasa);
                    cmd.Parameters.AddWithValue("@celular", persona.Celular);
                    cmd.Parameters.AddWithValue("@estadoCivil", cliente.EstadoCivil);
                    cmd.Parameters.AddWithValue("@rfc", cliente.Rfc);
                    cmd.Parameters.AddWithValue("@regimenFiscal", fiscal.RegimenFiscal);
                    cmd.Parameters.AddWithValue("@ubicacion", cliente.IdUbicacion);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        public Cliente getCliente(string correo)
        {
            Cliente cliente = null;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetDatosCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@correo", correo);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cliente = new Cliente();
                                cliente.Rfc = reader["rfc"].ToString();
                                cliente.EstadoCivil = reader["estadoCivil"].ToString();
                                cliente.Estado = bool.Parse(reader["estado"].ToString());
                                cliente.IdUbicacion = Guid.Parse(reader["idUbicacion"].ToString());
                            }
                        }
                    }
                }
            }
            return cliente;
        }

        public Cliente getIdCliente(string correo)
        {
            Cliente cliente = null;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetDatosCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@correo", correo);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cliente = new Cliente();
                                cliente.IdCliente = Guid.Parse(reader["idCliente"].ToString());
                            }
                        }
                    }
                }
            }
            return cliente;
        }

    }
}
