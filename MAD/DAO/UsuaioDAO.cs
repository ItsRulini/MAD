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
            }

            return usuario;
        }

        public void insertUsuarioOperativo(Usuario usuario, DatosFiscal fiscal, DatosPersona persona, Contraseña contraseña)
        {
            using (var context = new MadContext())
            {
                context.Usuarios.Add(usuario);
                context.DatosFiscals.Add(fiscal);
                context.DatosPersonas.Add(persona);
                context.Contraseñas.Add(contraseña);
                context.SaveChanges();
            }
        }
    }
}
