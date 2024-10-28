using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace Capa_Modelo_Presupuesto
{
    public class Sentencia
    {
        private Conexion con = new Conexion();

        public OdbcDataAdapter ObtenerCuentas()
        {
            string sSql = "SELECT Pk_id_cuenta , nombre_cuenta FROM tbl_cuentas";
            OdbcCommand comando = new OdbcCommand(sSql, con.NuevaConexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(comando);
            return adaptador;
        }

        public int CrearPresupuesto(string sNombre, int iEjercicio)
        {
            string sSql = @"INSERT INTO tbl_presupuesto (nombre_presupuesto, ejercicio_presupuesto, fecha_creacion, total_presupuesto) VALUES (? ,?, CURDATE(), 0.00);";

            using (OdbcCommand comando = new OdbcCommand(sSql, con.NuevaConexion()))
            {
                comando.Parameters.AddWithValue("@nombre_presupuesto", sNombre);
                comando.Parameters.AddWithValue("@ejercicio_presupuesto", iEjercicio);
                comando.ExecuteNonQuery();

                comando.CommandText = "SELECT LAST_INSERT_ID();";
                int iIdGenerado = Convert.ToInt32(comando.ExecuteScalar());
                return iIdGenerado;
            }
        }

        public void InsertarDetalle(int iFkPresupuesto, int iFkCuenta, decimal[] deMeses, decimal deTotalAnualCuenta)
        {
            string sSql = @"INSERT INTO tbl_detalle_presupuesto (Fk_id_presupuesto, Fk_id_cuenta,mes_enero, mes_febrero, mes_marzo, mes_abril, mes_mayo, 
                            mes_junio, mes_julio, mes_agosto, mes_septiembre,  mes_octubre, mes_noviembre, mes_diciembre, total_cuenta) 
                            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            using (OdbcCommand comando = new OdbcCommand(sSql, con.NuevaConexion()))
            {
                comando.Parameters.AddWithValue("@Fk_id_presupuesto", iFkPresupuesto);
                comando.Parameters.AddWithValue("@Fk_id_cuenta", iFkCuenta);

                for (int i = 0; i < 12; i++)
                {
                    comando.Parameters.AddWithValue($"@mes_{i + 1}", deMeses[i]);
                }
                comando.Parameters.AddWithValue("@total_cuenta", deTotalAnualCuenta);
                comando.ExecuteNonQuery();
            }
        }

        public void UpdateTblPresupuesto(int iPkPresupuesto)
        {
            string sSqlUpdate = @"UPDATE tbl_presupuesto SET total_presupuesto =(SELECT SUM(total_cuenta) FROM tbl_detalle_presupuesto WHERE Fk_id_presupuesto = ? ) WHERE Pk_id_presupuesto = ? ;";
            using (OdbcCommand comando = new OdbcCommand(sSqlUpdate, con.NuevaConexion()))
            {
                comando.Parameters.AddWithValue("?", iPkPresupuesto);
                comando.Parameters.AddWithValue("?", iPkPresupuesto);
                comando.ExecuteNonQuery();
            }
        }

        public List<string[]> ObtenerPresupuestos()
        {
            List<string[]> liPresupuestos = new List<string[]>();

            try
            {
                string sSql = "SELECT Pk_id_presupuesto, nombre_presupuesto FROM tbl_presupuesto";

                using (var vCmd = new OdbcCommand(sSql, con.NuevaConexion()))
                {
                    using (var vLector = vCmd.ExecuteReader())
                    {
                        while (vLector.Read())
                        {
                            string sId = vLector["Pk_id_presupuesto"].ToString();
                            string sNombre = vLector["nombre_presupuesto"].ToString();
                            liPresupuestos.Add(new string[] { sId, sNombre });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener presupuestos: {ex.Message}");
            }
            return liPresupuestos;
        }

        public DataTable ObtenerDetallesPresupuesto(int iIdPresupuesto)
        {
            DataTable dt = new DataTable();
            string sSql = @"SELECT d.Fk_id_cuenta,
					c.nombre_cuenta, 
                   d.mes_enero, 
                   d.mes_febrero, 
                   d.mes_marzo, 
                   d.mes_abril, 
                   d.mes_mayo, 
                   d.mes_junio, 
                   d.mes_julio, 
                   d.mes_agosto, 
                   d.mes_septiembre, 
                   d.mes_octubre, 
                   d.mes_noviembre, 
                   d.mes_diciembre,
                   d.total_cuenta
                FROM tbl_detalle_presupuesto d
                INNER JOIN tbl_cuentas c ON d.Fk_id_cuenta = c.Pk_id_cuenta
                WHERE d.Fk_id_presupuesto = ?";

            using (OdbcCommand cmd = new OdbcCommand(sSql, con.NuevaConexion()))
            {
                cmd.Parameters.AddWithValue("?", iIdPresupuesto);
                using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                {
                    da.Fill(dt); // Aquí llenamos el DataTable
                }
            }
            return dt;
        }

        public void ActualizarDetalle(int iFkPresupuesto, int iFkCuenta, decimal[] deMeses, decimal deTotalAnualCuenta)
        {
            string sSql = @"UPDATE tbl_detalle_presupuesto 
                   SET mes_enero = ?, 
                       mes_febrero = ?, 
                       mes_marzo = ?, 
                       mes_abril = ?, 
                       mes_mayo = ?, 
                       mes_junio = ?, 
                       mes_julio = ?, 
                       mes_agosto = ?, 
                       mes_septiembre = ?, 
                       mes_octubre = ?, 
                       mes_noviembre = ?, 
                       mes_diciembre = ?, 
                       total_cuenta = ? 
                   WHERE Fk_id_presupuesto = ? AND Fk_id_cuenta = ?";

            using (OdbcCommand comando = new OdbcCommand(sSql, con.NuevaConexion()))
            {

                for (int i = 0; i < 12; i++)
                {
                    comando.Parameters.AddWithValue($"@mes_{i + 1}", deMeses[i]);
                }
                comando.Parameters.AddWithValue("@total_cuenta", deTotalAnualCuenta);
                comando.Parameters.AddWithValue("@Fk_id_presupuesto", iFkPresupuesto);
                comando.Parameters.AddWithValue("@Fk_id_cuenta", iFkCuenta);// ID del detalle a actualizar
                comando.ExecuteNonQuery();
            }
        }

        public void EliminarDetallePresupuesto(int iIdPresupuesto)
        {
            string sSql = "DELETE FROM tbl_detalle_presupuesto WHERE Fk_id_presupuesto = ?";

            using (OdbcCommand comando = new OdbcCommand(sSql, con.NuevaConexion()))
            {
                comando.Parameters.AddWithValue("?", iIdPresupuesto);
                comando.ExecuteNonQuery();
            }
        }

        public void EliminarPresupuesto(int iIdPresupuesto)
        {
            string sSql = "DELETE FROM tbl_presupuesto WHERE Pk_id_presupuesto = ?";

            using (OdbcCommand comando = new OdbcCommand(sSql, con.NuevaConexion()))
            {
                comando.Parameters.AddWithValue("?", iIdPresupuesto);
                comando.ExecuteNonQuery();
            }
        }
    }
}

