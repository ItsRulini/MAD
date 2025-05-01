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
    internal class UnidadDAO
    {
        public UnidadDAO() { }

        public List<Unidad> getUnidades()
        {
            List<Unidad> unidades = new List<Unidad>();
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetUnidades", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Unidad unidad = new Unidad();
                                unidad.ClaveUnidad = reader["claveUnidad"].ToString();
                                unidad.Unidad1 = reader["unidad"].ToString();
                                unidades.Add(unidad);
                            }
                        }
                    }
                }
            }
            return unidades;
        }

    }
}
