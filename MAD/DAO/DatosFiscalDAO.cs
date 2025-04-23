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
    internal class DatosFiscalDAO
    {
        public DatosFiscalDAO() { }

        public DatosFiscal getDatosFiscal(string correo)
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
                                DatosFiscal datosFiscal = new DatosFiscal();
                                datosFiscal.TipoContribuyente = reader["tipoContribuyente"].ToString();
                                datosFiscal.RegimenFiscal = reader["regimenFiscal"].ToString();
                                return datosFiscal;
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}
