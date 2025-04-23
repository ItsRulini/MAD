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
    internal class DatosPersonaDAO
    {
        public DatosPersonaDAO() { }

        public DatosPersona getDatosPersona (string correo)
        {
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetDatosPersona", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@correo", correo);
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
    }
}
