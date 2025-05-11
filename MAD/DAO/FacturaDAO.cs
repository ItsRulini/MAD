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
        public Guid getIdFacturaPorReservacion(Guid idReservacion)
        {
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

        public DataTable generarFactura(Guid idReservacion)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("spGenerarFactura", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idReservacion", idReservacion);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public decimal GetSubtotalPorReservacion(Guid idReservacion)
        {
            decimal subtotal = 0;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetSubtotal", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idReservacion", idReservacion);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["Subtotal"] != DBNull.Value)
                                {
                                    subtotal = Convert.ToDecimal(reader["Subtotal"]);
                                }
                            }
                        }
                    }
                }
            }
            return subtotal;
        }


        public decimal GetIVAPorReservacion(Guid idReservacion)
        {
            decimal iva = 0;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetIVA", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idReservacion", idReservacion);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["IVA"] != DBNull.Value)
                                {
                                    iva = Convert.ToDecimal(reader["IVA"]);
                                }
                            }
                        }
                    }
                }
            }
            return iva;
        }

        public decimal GetTotalPorReservacion(Guid idReservacion)
        {
            decimal total = 0;
            using (SqlConnection conn = Conexion.ObtenerConexion())
            {
                using (var cmd = new SqlCommand("spGetTotal", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idReservacion", idReservacion);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["Total"] != DBNull.Value)
                                {
                                    total = Convert.ToDecimal(reader["Total"]);
                                }
                            }
                        }
                    }
                }
            }
            return total;
        }


    }
}
