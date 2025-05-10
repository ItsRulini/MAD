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
    internal class CancelacionDAO
    {
        public CancelacionDAO() { }

        public bool cancelar(Guid idReservacion,Guid idAdmin)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spCancelar", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@idReservacion", idReservacion);
                    cmd.Parameters.AddWithValue("@idAdministrador", idAdmin);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool validarCancelacion(Guid IdReservacion)
        {
            bool existente = false;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spValidarCancelacionExistente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@idReservacion", IdReservacion);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                existente = bool.Parse(reader["Resultado"].ToString());
                            }
                        }
                    }
                }
            }
            return existente;
        }



    }
}
