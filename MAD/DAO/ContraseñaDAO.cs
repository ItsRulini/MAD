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
    internal class ContraseñaDAO
    {
        public ContraseñaDAO() { }

        public Contraseña getContraseña(Guid id)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetContraseña", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUsuario", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Contraseña contraseña = new Contraseña();
                                contraseña.Contraseña1 = reader["contraseña"].ToString();
                                return contraseña;
                            }
                        }
                    }
                }
            }
            return null;
        }

        //La contraseña no debe ser igual a las últimas tres que tiene
        public bool updateContraseña(Contraseña contraseña, Guid idUsuario)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spUpdateContraseña", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña.Contraseña1);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Si la primera columna es string, es un mensaje de error
                                string mensaje = reader.GetString(0);
                                if (mensaje == "La contraseña no debe ser igual a las últimas tres que tiene")
                                {
                                    MessageBox.Show(mensaje);
                                    conn.Close();
                                    return false;
                                }

                            }
                        }
                    }
                }
                conn.Close(); // Cerrar la conexión aquí para evitar problemas de conexión
            }
            return true; // Si no hubo errores, se actualizó correctamente
        }
    }
}
