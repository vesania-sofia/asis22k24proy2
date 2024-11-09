using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Controlador_OrdenCompra;
using System.Windows.Forms;

namespace Capa_Vista_OrdenCompra
{
    public partial class frm_compra : Form
    {
        logica logic;
        public frm_compra()
        {
            InitializeComponent();

            logic = new logica();

            ToolTip tbuscarOC = new ToolTip();
            tbuscarOC.SetToolTip(Btn_buscar, "Buscar Orden de Compra");
            ToolTip tguardarOC = new ToolTip();
            tguardarOC.SetToolTip(Btn_guardarEcnDet, "Guardar Compra");
            ToolTip tlimpiarOC = new ToolTip();
            tlimpiarOC.SetToolTip(Btn_cancearEncDet, "Limpiar Orden de Compra");
            ToolTip teliminarOC = new ToolTip();
            teliminarOC.SetToolTip(Btn_reporteOC, "Reporte de Compra");
            ToolTip tayudaOC = new ToolTip();
            tayudaOC.SetToolTip(Btn_ayudaOC, "Ayuda");
            ToolTip tsalirOC = new ToolTip();
            tsalirOC.SetToolTip(Btn_salirOC, "Salir");



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }




        private void Dgv_Proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idProveedor = Convert.ToInt32(Dgv_ordenesGenerar.Rows[e.RowIndex].Cells["Pk_prov_id"].Value);

                // Llama al método de la lógica para obtener el proveedor
                DataTable proveedor = logic.ObtenerProveedorPorId(idProveedor);

                if (proveedor != null && proveedor.Rows.Count > 0)
                {
                    Txt_id.Text = proveedor.Rows[0]["Pk_prov_id"].ToString();
                    Txt_nombre.Text = proveedor.Rows[0]["Prov_nombre"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró el proveedor con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConfigurarDgv_ordenesGenerar()
        {
            Dgv_ordenesGenerar.ColumnCount = 4;
            Dgv_ordenesGenerar.Columns[0].Name = "Producto";
            Dgv_ordenesGenerar.Columns[1].Name = "Costo";
            Dgv_ordenesGenerar.Columns[2].Name = "Cantidad";
            Dgv_ordenesGenerar.Columns[3].Name = "Total";

        }




        private void CargarDetallesEnDataGrid(string noCompra)
        {
            // Obtiene los detalles como DataTable
            DataTable detalles = logic.funConsultaDetallesOrdenCompra(noCompra);

            // Limpiar las filas actuales en el DataGridView antes de agregar nuevas
            Dgv_ordenesGenerar.Rows.Clear();
            ConfigurarDgv_ordenesGenerar();
            if (detalles != null && detalles.Rows.Count > 0)
            {
                // Recorrer cada fila del DataTable y agregarla manualmente al DataGridView
                foreach (DataRow row in detalles.Rows)
                {
                    Dgv_ordenesGenerar.Rows.Add(
                        row["FK_codigoProducto"],    // Columna para "Producto"
                        row["DetOrCom_precioU"],     // Columna para "Costo"
                        row["DetOrCom_cantidad"],    // Columna para "Cantidad"
                        row["DetOrCom_total"]        // Columna para "Total"
                    );
                }
            }
            else
            {
                MessageBox.Show("No se encontraron detalles para la orden de compra", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string numeroOC = Txt_buscar.Text.Trim();

            if (string.IsNullOrEmpty(numeroOC))
            {
                MessageBox.Show("Por favor, ingrese un número de orden de compra.");
                return;
            }

            // Variables para recibir los datos de la orden de compra
            int proveedorId;
            DateTime fechaEntrega;
            decimal total;
            List<(int codigoProducto, decimal precioU, int cantidad, decimal totalDetalle)> detalles;

            // Llamar a ObtenerOrdenCompra
            bool resultado = logic.ObtenerOrdenCompra(numeroOC, out proveedorId, out fechaEntrega, out total, out detalles);

            if (resultado)
            {
                // Llenar el encabezado de la orden en la interfaz
                Txt_id.Text = proveedorId.ToString();
                dateTime_enc.Text = fechaEntrega.ToString("dd/MM/yyyy");
                Txt_Total.Text = total.ToString("N2");

                // Llenar el DataGridView con los detalles de la orden
                Dgv_ordenesGenerar.Rows.Clear();
                foreach (var detalle in detalles)
                {
                    Dgv_ordenesGenerar.Rows.Add(detalle.codigoProducto, detalle.precioU, detalle.cantidad, detalle.totalDetalle);
                }

                // Buscar el nombre del proveedor usando el método BuscarProveedorPorId
                DataTable proveedorData = logic.ObtenerProveedorPorId(proveedorId);
                if (proveedorData.Rows.Count > 0)
                {
                    // Asignar el nombre del proveedor a la TextBox correspondiente
                    Txt_nombre.Text = proveedorData.Rows[0]["Prov_nombre"].ToString();
                }
                else
                {
                    Txt_nombre.Text = "Proveedor no encontrado";
                }
            }
            else
            {
                MessageBox.Show("No se encontró la orden de compra o ocurrió un error.");
            }
        }

        // Evento CellClick en la capa de vista
        private void dgvDetalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurar que la fila sea válida
            {
                // Obtener el código de producto de la fila seleccionada
                int codigoProducto = Convert.ToInt32(Dgv_ordenesGenerar.Rows[e.RowIndex].Cells["Producto"].Value);

                // Llamar al método de la capa de lógica para obtener el stock
                int stock = logic.ObtenerStockProducto(codigoProducto);

                // Mostrar el stock en el TextBox correspondiente
                Txt_stock.Text = stock.ToString();
            }
        }







        private void frm_compra_Load(object sender, EventArgs e)
        {
            ConfigurarDgv_ordenesGenerar();

        }

        private void Dgv_ordenesGenerar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Dgv_ordenesGenerar_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0) // Asegurar que la fila sea válida
            {
                // Obtener el código de producto de la fila seleccionada
                int codigoProducto = Convert.ToInt32(Dgv_ordenesGenerar.Rows[e.RowIndex].Cells["Producto"].Value);

                // Llamar al método de la capa de lógica para obtener el stock
                int stock = logic.ObtenerStockProducto(codigoProducto);

                // Mostrar el stock en el TextBox correspondiente
                Txt_stock.Text = stock.ToString();
            }

        }

        public bool GuardarOrdenCompra(int proveedorId)
        {
            try
            {
                // Calcular el total de los detalles en el DataGridView
                decimal totalDetalleCompra = 0;

                foreach (DataGridViewRow row in Dgv_ordenesGenerar.Rows)
                {
                    if (row.IsNewRow) continue; // Ignorar filas nuevas

                    // Verificar que el campo "Total" del producto no sea nulo
                    if (row.Cells["Total"] != null && row.Cells["Total"].Value != null)
                    {
                        decimal totalProducto = Convert.ToDecimal(row.Cells["Total"].Value);
                        totalDetalleCompra += totalProducto; // Sumar el total de cada producto
                    }
                }

                // Actualizar la deuda del proveedor con el total calculado de los detalles
                Console.WriteLine("Actualizando la deuda del proveedor con ID: " + proveedorId + " por un total de: " + totalDetalleCompra);
                bool deudaActualizada = logic.ActualizarDeudaProveedor(proveedorId, totalDetalleCompra);
                if (!deudaActualizada)
                {
                    Console.WriteLine("Error: No se pudo actualizar la deuda del proveedor.");
                    return false;
                }
                else
                {
                    Console.WriteLine("Deuda del proveedor actualizada correctamente.");
                }

                // Proceder con el resto de la lógica (actualizar el stock y guardar la orden de compra)



                // Recorrer todas las filas del DataGridView para actualizar el stock de cada producto
                foreach (DataGridViewRow row in Dgv_ordenesGenerar.Rows)
                {
                    if (row.IsNewRow) continue; // Ignorar filas nuevas

                    // Verificar que los campos no sean nulos
                    if (row.Cells["Producto"].Value == null || row.Cells["Cantidad"].Value == null)
                    {
                        MessageBox.Show("Asegúrate de llenar todos los campos de los productos en la lista de detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Obtener los valores de cada fila
                    int codigoProductoDetalle = Convert.ToInt32(row.Cells["Producto"].Value);
                    int cantidadDetalle = Convert.ToInt32(row.Cells["Cantidad"].Value);

                    // Actualizar el stock del producto en la base de datos
                    Console.WriteLine("Actualizando stock del producto con código: " + codigoProductoDetalle);
                    bool stockActualizado = logic.ActualizarStockProducto(codigoProductoDetalle, cantidadDetalle);
                    if (!stockActualizado)
                    {
                        Console.WriteLine("Error: No se pudo actualizar el stock del producto con código: " + codigoProductoDetalle);
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Stock del producto con código " + codigoProductoDetalle + " actualizado correctamente.");
                    }
                }

                // Todo ha sido guardado correctamente, mensaje final
                Console.WriteLine("Orden de compra guardada correctamente en la base de datos.");
                return true;
            }

            catch (Exception ex)
            {
                // Captura y muestra detalles adicionales del error
                MessageBox.Show($"Ocurrió un error al procesar la orden de compra: {ex.Message}\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
                return false;

            }
        }


        private void Btn_guardarEcnDet_Click(object sender, EventArgs e)
        {
             try
                {
                    // Obtener los valores del encabezado
                    string numeroOC = Txt_buscar.Text;

                    int proveedorId;
                    if (!int.TryParse(Txt_id.Text, out proveedorId))
                    {
                        MessageBox.Show("No pueden ir campos vacíos, busca una orden para llenar los datos de Id y Total de la Orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("Error: ID del proveedor no es un número válido.");
                        return;
                    }

                    DateTime fechaCompra = dateTime_enc.Value;

                    decimal totalCompra;
                    if (!decimal.TryParse(Txt_Total.Text, out totalCompra))
                    {
                        MessageBox.Show("No pueden ir campos vacíos, busca una orden para obtener el Total de la Orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("Error: Total de compra no es un número válido.");
                        return;
                    }

                    // Verificación de detalles antes de pasarlos al método
                    if (Dgv_ordenesGenerar.Rows.Count == 0 || Dgv_ordenesGenerar.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow || r.Cells["Producto"].Value == null))
                    {
                        MessageBox.Show("Por favor, ingrese al menos un producto en la lista de detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("Error: No hay productos válidos en la lista de detalles.");
                        return;
                    }

                    bool compraGuardada = true; // Variable para verificar si todos los detalles se guardaron correctamente

                // Recorrer cada fila de la grilla y agregar los detalles
                bool ordenGuardada = GuardarOrdenCompra(proveedorId);
                foreach (DataGridViewRow row in Dgv_ordenesGenerar.Rows)
                    {
                        if (row.IsNewRow) continue; // Ignorar la fila nueva

                        // Verificar cada campo y mostrar mensajes si algún campo es nulo o incorrecto
                        if (row.Cells["Producto"].Value == null || row.Cells["Costo"].Value == null ||
                            row.Cells["Cantidad"].Value == null || row.Cells["Total"].Value == null)
                        {
                            MessageBox.Show("Asegúrate de llenar todos los campos de los productos en la lista de detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Console.WriteLine("Error: Uno o más campos de los detalles del producto están vacíos.");
                            return;
                        }

                        // Obtener los datos de cada detalle
                        int codigoProducto = Convert.ToInt32(row.Cells["Producto"].Value);
                        decimal precioU = Convert.ToDecimal(row.Cells["Costo"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        decimal totalDetalle = Convert.ToDecimal(row.Cells["Total"].Value);

                        // Guardar cada detalle de la compra
                        
                        bool detalleGuardado = logic.GuardarCompra(numeroOC, proveedorId, fechaCompra, totalCompra, codigoProducto, precioU, cantidad, totalDetalle);

                        if (!detalleGuardado)
                        {
                            MessageBox.Show($"Error al guardar la compra, ya existe {numeroOC}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Console.WriteLine($"Error: No se pudo guardar el detalle para el producto {codigoProducto}.");
                            compraGuardada = false; // Marcar como fallido si no se guarda un detalle
                            break; // Terminar el bucle si ocurre un error
                        }
                        
                    }

                    // Si todos los detalles se guardaron correctamente
                    if (compraGuardada)
                    {
                        MessageBox.Show("La orden de compra se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar(); // Limpiar campos después de guardar correctamente
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error general: {ex.Message}");
                    Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                    MessageBox.Show($"Ocurrió un error: {ex.Message}\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }







            private void button1_Click(object sender, EventArgs e)
        {
            frm_OrdenCompra generarOrdenForm = new frm_OrdenCompra();
            generarOrdenForm.ShowDialog(); // Abre el formulario como modal
        }

        private void limpiar()
        {
            Txt_id.Clear();
            Txt_nombre.Clear();
            Txt_stock.Clear();
            dateTime_enc.Value = DateTime.Today;
            Txt_buscar.Clear();
            Dgv_ordenesGenerar.Rows.Clear();
            Txt_Total.Clear();
        }

        private void Btn_cancearEncDet_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Btn_salirOC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } }

    




