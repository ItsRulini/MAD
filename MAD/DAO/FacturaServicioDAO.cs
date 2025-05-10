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
    internal class FacturaServicioDAO
    {
        public FacturaServicioDAO() { }

        public bool insertFacturaServicio (Dictionary<Guid,int> servicios,Guid idFactura)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("idServicio", typeof(Guid));
            dt.Columns.Add("cantidad", typeof(int));
            foreach (var item in servicios)
            {
                dt.Rows.Add(item.Key, item.Value);
            }

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spInsertFacturaServicio", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@idFactura", idFactura);
                    
                    SqlParameter tvpParam = cmd.Parameters.AddWithValue("@servicios", dt);
                    tvpParam.SqlDbType = SqlDbType.Structured;
                    tvpParam.TypeName = "servicioCantidad"; // nombre del tipo en SQL Server
                    // Ejecutar el comando
                    cmd.ExecuteNonQuery();
                    return true; // Retorna true si se insertó correctamente
                }
            }
        }
    }
}
