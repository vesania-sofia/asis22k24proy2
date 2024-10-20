using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Logistica
{
    public partial class MantenimientoNav : Form
    {
        public MantenimientoNav(string idUsuario)
        {
            InitializeComponent();
            string[] alias = { "id_Mantenimiento", "nombre_Solicitante", "tipo_de_Mantenimiento", "componente_Afectado", "fecha", "responsable_Asignado", "codigo_Error_Problema", "estado_del_Mantenimiento", "tiempo_Estimado", "id_movimiento" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("Tbl_mantenimiento");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Mantenimieto");
            navegador1.Dgv_Informacion.CellClick += DgvMantenimiento_CellClick;

        }
        private void DgvMantenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la fila seleccionada es válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = navegador1.Dgv_Informacion.Rows[e.RowIndex];
                string Pk_id_Mantenimiento = row.Cells["Pk_id_Mantenimiento"].Value.ToString();  // Asegúrate de que el nombre del campo sea correcto

                Mantenimiento movInventario = new Mantenimiento(Pk_id_Mantenimiento);
                movInventario.Show();
            }
        }
    }
}
