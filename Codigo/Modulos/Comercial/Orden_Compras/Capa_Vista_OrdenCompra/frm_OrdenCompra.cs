using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Capa_Controlador_OrdenCompra;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Necesario para Directory, File, Path y SearchOption


namespace Capa_Vista_OrdenCompra
{
    public partial class frm_OrdenCompra : Form
    {
        logica logic;

        public frm_OrdenCompra()
        {
            InitializeComponent();
            logic = new logica();
            Btn_eliminarOC.Enabled = false;
            Btn_actualizarOC.Enabled = false;
            Btn_modificarOC.Enabled = true;
            Btn_agregarOC.Enabled = true;

            ToolTip tnuevoOC = new ToolTip();
            tnuevoOC.SetToolTip(Btn_agregarOC, "Nueva Orden de Compra");
            ToolTip tmodificarOC = new ToolTip();
            tmodificarOC.SetToolTip(Btn_modificarOC, "Modificar Orden de Compra");
            ToolTip tactualizarOC = new ToolTip();
            tactualizarOC.SetToolTip(Btn_actualizarOC, "Actualizar Orden de Compra");
            ToolTip teliminarOC = new ToolTip();
            teliminarOC.SetToolTip(Btn_eliminarOC, "Eliminar Orden de Compra");
            ToolTip treporte = new ToolTip();
            treporte.SetToolTip(Btn_reporteOC, "Generar Reporte");
            ToolTip tayudaOC = new ToolTip();
            tayudaOC.SetToolTip(Btn_ayudaOC, "Ayuda");
            ToolTip tsalirOC = new ToolTip();
            tsalirOC.SetToolTip(Btn_salirOC, "Salir");

            actualizardatagriew();

        }

        public void actualizardatagriew()
        {
            try
            {
                // Obtener los datos desde la base de datos
                DataTable dtEncabezado;

                dtEncabezado = logic.funConsultaLogicaOrdenes();

                if (dtEncabezado == null || dtEncabezado.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron datos o el DataTable está vacío.");
                }
                else
                {

                    // Asignar el DataTable al DataGridView
                    Dgv_OrdenesGeneradas.DataSource = dtEncabezado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar los datos: {ex.Message}");
            }
        }



        /* public void actualizardatagriewOrdenesGeneradas()
         {


             try
             {
                 // Obtener los datos desde la base de datos
                 DataTable dt = logic.funConsultaLogicaOrdenesGeneradas("Tbl_detalle_ordenes_compra");

                 if (dt != null && dt.Rows.Count > 0)
                 {
                     // Asignar el DataTable al DataGridView
                     Dgv_ordenesGeneradas.DataSource = dt;
                 }
                 else
                 {
                     MessageBox.Show("No se encontraron datos.");
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Error al buscar los datos: {ex.Message}");
             }
         }
        */


        private void frm_OrdenCompra_Load(object sender, EventArgs e)
        {

        }


        private void Dgv_OrdenesGeneradas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Btn_agregarOC_Click(object sender, EventArgs e)
        {
            frm_generarOrdenParaCompra generarOrdenForm = new frm_generarOrdenParaCompra();
            generarOrdenForm.ShowDialog(); // Abre el formulario como modal
            actualizardatagriew();

        }

        private void Btn_modificarOC_Click(object sender, EventArgs e)
        {
            Btn_eliminarOC.Enabled = true;
            Btn_actualizarOC.Enabled = true;
            Btn_modificarOC.Enabled = false;
            Btn_agregarOC.Enabled = false;
        }

        private void Btn_eliminarOC_Click(object sender, EventArgs e)
        {
            Btn_eliminarOC.Enabled = false;
            Btn_actualizarOC.Enabled = false;
            Btn_modificarOC.Enabled = true;
            Btn_agregarOC.Enabled = true;


            // Verificar si se ha seleccionado una fila en el DataGridView de encabezado
            if (Dgv_OrdenesGeneradas.Rows.Count == 0 || Dgv_OrdenesGeneradas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una orden de compra para eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el número de orden de compra desde la fila seleccionada
            var filaSeleccionada = Dgv_OrdenesGeneradas.SelectedRows[0];
            string numeroOC = filaSeleccionada.Cells["NoCompra"].Value.ToString();

            // Confirmar la eliminación con el usuario
            var resultado = MessageBox.Show($"¿Estás seguro de que deseas eliminar la orden de compra: {numeroOC}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            // Llamar a la función de eliminación
            bool exito = logic.EliminarOrdenCompra(numeroOC); // Llama al método de eliminación que escribimos anteriormente

            // Verificar si la eliminación fue exitosa
            if (exito)
            {
                // Eliminar la fila del DataGridView de encabezados
                Dgv_OrdenesGeneradas.Rows.Remove(filaSeleccionada);

                MessageBox.Show("La orden de compra y sus detalles han sido eliminados exitosamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error al intentar eliminar la orden de compra. Por favor, inténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        actualizardatagriew();
        }



        private void Btn_actualizarOC_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (Dgv_OrdenesGeneradas.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = Dgv_OrdenesGeneradas.SelectedRows[0];

                // Captura los valores de la fila seleccionada
                string noCompra = filaSeleccionada.Cells["NoCompra"].Value.ToString();
                int idProveedor = Convert.ToInt32(filaSeleccionada.Cells["IdProveedor"].Value);
                DateTime fecha = Convert.ToDateTime(filaSeleccionada.Cells["Fecha"].Value);
                decimal total = Convert.ToDecimal(filaSeleccionada.Cells["Total"].Value);

                // Abre el formulario para actualizar la orden de compra y pasa los datos
                frm_generarOrdenParaCompra generarOrdenForm = new frm_generarOrdenParaCompra(noCompra, idProveedor, fecha, total);
                generarOrdenForm.ShowDialog(); // Muestra el formulario como un diálogo
                actualizardatagriew(); // Vuelve a cargar la lista de órdenes después de actualizar
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una orden para actualizar.");
            }
        }

        private void Btn_salirOC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
    
    
