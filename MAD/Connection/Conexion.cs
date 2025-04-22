using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD.Connection
{
    internal class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Trusted_Connection=True;TrustServerCertificate=True;Initial Catalog=MAD;Data Source=MERA"); // raula

            conexion.Open();
            return conexion;
        }
    }
}
