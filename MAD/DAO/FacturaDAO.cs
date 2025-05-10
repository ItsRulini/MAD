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
    internal class FacturaDAO
    {
        public Guid getIdFacturaPorReservacion(Guid idReservacion) {
            Guid idFactura = Guid.Empty;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetIdFacturaPorReservacion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idReservacion", idReservacion);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                idFactura = Guid.Parse(reader["idFactura"].ToString());
                            }
                        }
                    }
                }
            }
            return idFactura;


        }
    }
}
