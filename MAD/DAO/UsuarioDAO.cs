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
    internal class UsuarioDAO
    {
        public UsuarioDAO() { }

        public Usuario getUsuarioLogin(string correo, string contraseña)
        {
            Usuario usuario = null;

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {

                using (var cmd = new SqlCommand("spLogin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", correo);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Si la primera columna es string, es un mensaje de error
                                string mensaje = reader.GetString(0);
                                if (mensaje == "Usuario no encontrado" || mensaje == "Usuario dado de baja" || mensaje == "Algún dato es erróneo")
                                {
                                    MessageBox.Show(mensaje);
                                    return null;
                                }

                                // Si no es string, asumimos que es el SELECT válido con tipoUsuario e idUsuario
                                usuario = new Usuario();
                                usuario.TipoUsuario = reader["tipoUsuario"].ToString();
                                usuario.IdUsuario = Guid.Parse(reader["idUsuario"].ToString());
                                
                            }
                        }
                    }
                }

                conn.Close(); // Cerrar la conexión aquí para evitar problemas de conexión
            }

            return usuario;
        }

        public Usuario getInfoUsuario(string buscar)
        {
            Usuario usuario = null;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetDatosUsuario", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@buscar", buscar);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                usuario = new Usuario();
                                usuario.Estado = bool.Parse(reader["estado"].ToString());
                                usuario.Nomina = long.Parse(reader["nomina"].ToString());
                            }
                        }
                    }
                }
                conn.Close(); // Cerrar la conexión aquí para evitar problemas de conexión
            }
            return usuario;
        }

        public bool insertUsuario(DatosPersona persona, Contraseña contraseña, string tipoUsuario)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spInsertUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
                    cmd.Parameters.AddWithValue("@correo", persona.Correo);
                    cmd.Parameters.AddWithValue("@nombres", persona.Nombres);
                    cmd.Parameters.AddWithValue("@paterno", persona.Paterno);
                    cmd.Parameters.AddWithValue("@materno", persona.Materno);
                    cmd.Parameters.AddWithValue("@telefono", persona.TelefonoCasa);
                    cmd.Parameters.AddWithValue("@celular", persona.Celular);
                    cmd.Parameters.AddWithValue("@nacimiento", persona.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@regimenFiscal", "Asalariados"); // Asalaiados, Honorarios, Regimen general
                    cmd.Parameters.AddWithValue("@contraseña", contraseña.Contraseña1);

                    try
                    {
                        int filasAfectadas = cmd.ExecuteNonQuery(); // ejecuta el procedimiento

                        conn.Close();
                        return filasAfectadas > 0; // retorna true si al menos una fila fue insertada
                    }
                    catch (Exception ex)
                    {
                        // puedes registrar el error o manejarlo según tu necesidad
                        MessageBox.Show("Error al insertar usuario operativo: " + ex.Message);
                        conn.Close();
                        return false;
                    }
                }
            }
        }

        public bool updateUsuarioOperativo(Usuario usuario, DatosPersona persona)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spUpdateUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@correo", persona.Correo);
                    cmd.Parameters.AddWithValue("@nombres", persona.Nombres);
                    cmd.Parameters.AddWithValue("@paterno", persona.Paterno);
                    cmd.Parameters.AddWithValue("@materno", persona.Materno);
                    cmd.Parameters.AddWithValue("@telefono", persona.TelefonoCasa);
                    cmd.Parameters.AddWithValue("@celular", persona.Celular);
                    cmd.Parameters.AddWithValue("@nacimiento", persona.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@nomina", usuario.Nomina);
                    cmd.Parameters.AddWithValue("@estado", usuario.Estado);

                    try
                    {
                        int filasAfectadas = cmd.ExecuteNonQuery(); // ejecuta el procedimiento
                        conn.Close();
                        return filasAfectadas > 0; // retorna true si al menos una fila fue insertada
                    }
                    catch (Exception ex)
                    {
                        // puedes registrar el error o manejarlo según tu necesidad
                        MessageBox.Show("Error al actualizar usuario operativo: " + ex.Message);
                        conn.Close();
                        return false;
                    }
                }
            }
        }
    }
}
