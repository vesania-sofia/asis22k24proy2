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
using System.Diagnostics;

namespace Capa_Vista_OrdenCompra
{
    public partial class frm_generarOrdenParaCompra : Form
    {
        logica logic;


        string valorSeleccionadoProveedor;
        public frm_generarOrdenParaCompra()
        {
            InitializeComponent();
            Txt_CostoC.Enabled = false;
            Txt_Total.Enabled = false;
            logic = new logica();
            Txt_nombre.Visible = false;
            Txt_id.Visible = false;
            Txt_roveedor2.Visible = false;
            ToolTip tnuevodetalle = new ToolTip();
            tnuevodetalle.SetToolTip(Btn_agregarDet, "Agregar Detalle");
            ToolTip tborrardetalle = new ToolTip();
            tborrardetalle.SetToolTip(Btn_eliminarDet, "Eliminar Detalle");
            ToolTip tguardarrencabezadodetalle = new ToolTip();
            tguardarrencabezadodetalle.SetToolTip(Btn_guardar, "Guardar Orden de Compra");
            ToolTip tcancelarorden = new ToolTip();
            tcancelarorden.SetToolTip(Btn_cancelarEncDet, "Cancelar Orden de Compra");
            ToolTip tactualizardetalle = new ToolTip();
            tguardarrencabezadodetalle.SetToolTip(Btn_actualizarDET, "Actualizar Orden de Compra");
            ToolTip tsalirOC = new ToolTip();
            tsalirOC.SetToolTip(Btn_salirOC, "Regresar");
            ConfigurarDgv_ordenesGenerar();
            string stablav = "tbl_productos";
            string scampo1v = "codigoProducto";
            string scampo2v = "nombreProducto";

            // string stablae = "Tbl_ordenes_compra";
            // string scampo1e = "Pk_encOrCom_id";
            // string scampo2e = "EncOrCom_numero";

            string stablapv = "Tbl_proveedores";
            string scampo1pv = "Pk_prov_id";
            string scampo2pv = "Prov_nombre";



            prollenarseProductos(stablav, scampo1v, scampo2v);
            //prollenarseEncabezado(stablae, scampo1e, scampo2e);
            prollenarseProveedor(stablapv, scampo1pv, scampo2pv);

            Cbo_ProDetOrCom.SelectedIndexChanged += new EventHandler(Cbo_ProDetOrCom_SelectedIndexChanged);
            //Cbo_id_EncOrCom.SelectedIndexChanged += new EventHandler(Cbo_id_EncOrCom_SelectedIndexChanged);
            Cbo_proveedor.SelectedIndexChanged += new EventHandler(Cbo_proveedor_SelectedIndexChanged);
        }

        public frm_generarOrdenParaCompra(string noCompra, int idProveedor, DateTime fecha, decimal total)
        {
            InitializeComponent();
            Txt_CostoC.Enabled = false;
            Txt_Total.Enabled = false;
            logic = new logica();
            Cbo_proveedor.Visible = false;
            Txt_proveedor1.Visible = false;
            ToolTip tnuevodetalle = new ToolTip();
            tnuevodetalle.SetToolTip(Btn_agregarDet, "Agregar Detalle");
            ToolTip tborrardetalle = new ToolTip();
            tborrardetalle.SetToolTip(Btn_eliminarDet, "Eliminar Detalle");
            ToolTip tguardarrencabezadodetalle = new ToolTip();
            tguardarrencabezadodetalle.SetToolTip(Btn_guardar, "Guardar Orden de Compra");
            ToolTip tcancelarorden = new ToolTip();
            tcancelarorden.SetToolTip(Btn_cancelarEncDet, "Cancelar Orden de Compra");
            ToolTip tactualizardetalle = new ToolTip();
            tguardarrencabezadodetalle.SetToolTip(Btn_actualizarDET, "Actualizar Orden de Compra");
            ToolTip tsalirOC = new ToolTip();
            tsalirOC.SetToolTip(Btn_salirOC, "Regresar");
            CargarDatos(noCompra, idProveedor, fecha, total);

            string stablav = "tbl_productos";
            string scampo1v = "codigoProducto";
            string scampo2v = "nombreProducto";

            // string stablae = "Tbl_ordenes_compra";
            // string scampo1e = "Pk_encOrCom_id";
            // string scampo2e = "EncOrCom_numero";

            string stablapv = "Tbl_proveedores";
            string scampo1pv = "Pk_prov_id";
            string scampo2pv = "Prov_nombre";



            prollenarseProductos(stablav, scampo1v, scampo2v);
            //prollenarseEncabezado(stablae, scampo1e, scampo2e);
            prollenarseProveedor(stablapv, scampo1pv, scampo2pv);

            Cbo_ProDetOrCom.SelectedIndexChanged += new EventHandler(Cbo_ProDetOrCom_SelectedIndexChanged);
            //Cbo_id_EncOrCom.SelectedIndexChanged += new EventHandler(Cbo_id_EncOrCom_SelectedIndexChanged);
            Cbo_proveedor.SelectedIndexChanged += new EventHandler(Cbo_proveedor_SelectedIndexChanged);
        }



        private void CargarDatos(string noCompra, int idProveedor, DateTime fecha, decimal total)
        {
            Txt_no_orCom.Text = noCompra;
            Cbo_proveedor.SelectedValue = idProveedor;
            dateTime_enc.Value = fecha;
            Txt_Total.Text = total.ToString("F2");

            CargarDetallesEnDataGrid(noCompra);

            // Obtén el proveedor usando su ID
            DataTable proveedorData = logic.ObtenerProveedorPorId(idProveedor);

            if (proveedorData != null && proveedorData.Rows.Count > 0)
            {
                // Asignar valores a los TextBox
                Txt_id.Text = proveedorData.Rows[0]["Pk_prov_id"].ToString();
                Txt_nombre.Text = proveedorData.Rows[0]["Prov_nombre"].ToString();
            }
            else
            {
                MessageBox.Show("Proveedor no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_id.Clear();
                Txt_nombre.Clear();
            }
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


        private void ActualizarComboBox()
        {
            // Limpiar los ítems actuales de los ComboBox
            Cbo_proveedor.Items.Clear();

            string stablapv = "Tbl_proveedores";
            string scampo1pv = "Pk_prov_id";
            string scampo2pv = "Prov_nombre";


            prollenarseProveedor(stablapv, scampo1pv, scampo2pv);

            Cbo_proveedor.SelectedIndexChanged += new EventHandler(Cbo_proveedor_SelectedIndexChanged);
        }

        private void limpiar()
        {
            Cbo_proveedor.SelectedIndex = -1;
            dateTime_enc.Value = DateTime.Today;
            Txt_no_orCom.Clear();
            Dgv_ordenesGenerar.Rows.Clear();
            Txt_Total.Clear();
        }

        public void prollenarseProductos(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt = logic.funenviar(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_ProDetOrCom.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_ProDetOrCom.Items.Add(new ComboBoxItem
                {
                    Value = row[campo1].ToString(),
                    Display = row[campo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            Cbo_ProDetOrCom.AutoCompleteCustomSource = coleccion;
            Cbo_ProDetOrCom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_ProDetOrCom.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItem
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        public void prollenarseProveedor(string stabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt = logic.funenviar2(stabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_proveedor.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Agrega el elemento mostrando solo el campo
                Cbo_proveedor.Items.Add(new ComboBoxItem2
                {
                    Value = row[campo1].ToString(), // ID o valor para la selección
                    Display = row[campo2].ToString()

                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                // Solo se agrega el campo para autocompletar
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            Cbo_proveedor.AutoCompleteCustomSource = coleccion;
            Cbo_proveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_proveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public class ComboBoxItem2
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }


        /* private void CargarProductos()
         {
             try
             {
                 DataTable dtProducto = logic.funConsultaLogicaProductos();
                 Cbo_ProDetOrCom.Items.Clear();
                 foreach (DataRow row in dtProducto.Rows)
                 {
                     Cbo_ProDetOrCom.Items.Add(row[0].ToString());
                 }
                 Cbo_ProDetOrCom.SelectedIndexChanged += new EventHandler(Cbo_ProDetOrCom_SelectedIndexChanged);
             }
             catch (Exception ex)
             {
                 Console.WriteLine("Error al cargar módulos: " + ex.Message);
             }

         }*/


        /* private void CargarProveedor()
         {
             try
             {
                 // Obtén el DataTable desde la lógica
                 DataTable dtProv = logic.funConsultaLogicaProveedor();

                 // Asigna el DataSource del ComboBox directamente con el DataTable
                 Cbo_proveedor.DataSource = dtProv;

                 Cbo_proveedor.ValueMember = "Id_Proveedor"; // Campo que se usará como valor

                 if (Cbo_proveedor.Items.Count > 0)
                 {
                     Cbo_proveedor.SelectedIndex = 0; // Selecciona el primer elemento
                 }
                 else
                 {
                     MessageBox.Show("No hay proveedores disponibles.");
                 }
             }
             catch (Exception ex)
             {
                 Console.WriteLine("Error al cargar proveedores: " + ex.Message);
             }
         }
        */


        private void Cbo_ProDetOrCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_ProDetOrCom.SelectedItem != null)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)Cbo_ProDetOrCom.SelectedItem;
                int CodigoProducto = int.Parse(selectedItem.Value);
                CargarDetallesProducto(CodigoProducto);
            }
        }

        private void frm_generarOrdenParaCompra_Load_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Btn_insertarDet_Click(object sender, EventArgs e)

        {
        }

        private void Cbo_id_EncOrCom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbo_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_proveedor.SelectedItem != null)
            {
                var selectedItem = (ComboBoxItem2)Cbo_proveedor.SelectedItem;
                valorSeleccionadoProveedor = selectedItem.Value;

                // MessageBox.Show($"Valor seleccionado: {valorSeleccionadousuario}", "Valor Seleccionado");
            }
        }




        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CargarDetallesProducto(int CodigoProducto)
        {
            try
            {
                DataTable dtProducto = logic.funConsultaLogicaProducto(CodigoProducto);

                if (dtProducto != null && dtProducto.Rows.Count > 0)
                {
                    DataRow row = dtProducto.Rows[0];

                    Txt_CostoC.Text = row["costo_compra"].ToString();




                }
                else
                {
                    Txt_CostoC.Text = "";

                    MessageBox.Show("Producto no encontrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar detalles del producto: " + ex.Message);
            }
        }


        private void AgregarProducto()
        {
            try
            {
                // Obtener los valores del ComboBox y NumericUpDown
                string numeroOC = Txt_no_orCom.Text; // Asumiendo que tienes un TextBox para el número de OC
                ComboBoxItem selectedItem = (ComboBoxItem)Cbo_ProDetOrCom.SelectedItem;
                string producto = selectedItem.Value; // Obtiene el texto mostrado en el ComboBox
                decimal precio = decimal.Parse(Txt_CostoC.Text);
                int cantidad;
                if (int.TryParse(Txt_Cantidad_DetOrCom.Text, out cantidad))
                {

                    // Calcular el subtotal
                    decimal total = precio * cantidad;

                    // Crear una nueva fila y agregarla al DataGridView
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(Dgv_ordenesGenerar);
                    row.Cells[0].Value = producto;
                    row.Cells[1].Value = precio;
                    row.Cells[2].Value = cantidad;
                    row.Cells[3].Value = total;
                    // row.Cells[5].Value = ""; // Valor para la columna de botón
                    Dgv_ordenesGenerar.Rows.Add(row);

                    // Limpiar los campos
                    Cbo_ProDetOrCom.SelectedIndex = -1;
                    Txt_CostoC.Clear();
                    Txt_Cantidad_DetOrCom.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        public class ComboBoxItemOC
        {
            public string Value { get; set; }
            public string Text { get; set; }


            public ComboBoxItemOC(string text, string value)
            {
                Value = value;
                Text = text;

            }

            public override string ToString()
            {
                return $"{Value}-{Text}";
            }
        }



        private void CalcularTotal()
        {
            decimal total = 0;
            if (Dgv_ordenesGenerar.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Dgv_ordenesGenerar.Rows)
                {
                    // Verifica si la celda no es nula y contiene datos antes de convertir
                    if (row.Cells["Total"].Value != null && row.Cells["Total"].Value.ToString() != "")
                    {
                        total += Convert.ToDecimal(row.Cells["Total"].Value.ToString());
                    }
                }
            }
            Txt_Total.Text = total.ToString("0.00");
        }


        private void frm_generarOrdenParaCompra_Load(object sender, EventArgs e)
        {
            ConfigurarDgv_ordenesGenerar();
        }


        private void ConfigurarDgv_ordenesGenerar()
        {
            Dgv_ordenesGenerar.ColumnCount = 4;
            Dgv_ordenesGenerar.Columns[0].Name = "Producto";
            Dgv_ordenesGenerar.Columns[1].Name = "Costo";
            Dgv_ordenesGenerar.Columns[2].Name = "Cantidad";
            Dgv_ordenesGenerar.Columns[3].Name = "Total";

            /*  // Agregar columna para el círculo
              DataGridViewTextBoxColumn estadoColumna = new DataGridViewTextBoxColumn();
              estadoColumna.Name = "Estado";
              estadoColumna.HeaderText = "";
              estadoColumna.ReadOnly = true; // Hacer que esta columna no sea editable
              Dgv_ordenesGenerar.Columns.Add(estadoColumna);

              // Configurar tamaños de las columnas si es necesario
              Dgv_ordenesGenerar.Columns[0].Width = 75;
              Dgv_ordenesGenerar.Columns[1].Width = 75;
              Dgv_ordenesGenerar.Columns[2].Width = 75;
              Dgv_ordenesGenerar.Columns[3].Width = 75;
              Dgv_ordenesGenerar.Columns[4].Width = 75;
              Dgv_ordenesGenerar.Columns[5].Width = 50;

              // Suscribir los eventos
             // Dgv_ordenesGenerar.CellPainting += Dgv_ordenesGenerar_CellPainting;
              //Dgv_ordenesGenerar.CellClick += Dgv_ordenesGenerar_CellContentClick;*/
        }

        private void Dgv_ordenesGenerar_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {/*
            if (e.RowIndex < 0)
                return;

            // Verifica si es la primera columna (puedes cambiar el índice según lo necesites)
            if (e.ColumnIndex == Dgv_ordenesGenerar.Columns["Estado"].Index)
            {
                // Pinta la celda normalmente
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Dibuja un círculo en el centro de la celda
                int diameter = 16; // Tamaño del círculo
                int x = e.CellBounds.Left + (e.CellBounds.Width - diameter) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - diameter) / 2;

                // Elige un color de relleno para el círculo
                using (Brush brush = new SolidBrush(Color.Red))
                {
                    e.Graphics.FillEllipse(brush, x, y, diameter, diameter);  // Dibuja un círculo
                }

                // Indica que el pintado de la celda está manejado
                e.Handled = true;
            }*/
        }

        private void Dgv_ordenesGenerar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {/*
            // Verifica si la celda clicada es de la columna "Estado"
            if (e.ColumnIndex == Dgv_ordenesGenerar.Columns["Estado"].Index && e.RowIndex >= 0)
            {
                // Eliminar la fila correspondiente
                Dgv_ordenesGenerar.Rows.RemoveAt(e.RowIndex);
                CalcularTotal();
            }*/
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            
                try
                {
                    // Obtener los valores del encabezado
                    string numeroOC = Txt_no_orCom.Text; // Asumiendo que tienes un TextBox para el número de OC
                    ComboBoxItem2 selectedProveedor = (ComboBoxItem2)Cbo_proveedor.SelectedItem; // Suponiendo que tienes un ComboBox para el proveedor
                    int proveedorId = Convert.ToInt32(selectedProveedor.Value);
                    DateTime fechaEntrega = dateTime_enc.Value; // Suponiendo que tienes un DateTimePicker para la fecha de entrega
                    decimal total;
                    if (!decimal.TryParse(Txt_Total.Text, out total))
                    {
                        MessageBox.Show("Por favor, ingrese un total válido.");
                        return; // Termina el método si el total no es válido
                    }

                    // Crear una lista para los detalles
                    List<(int codigoProducto, decimal precioU, int cantidad, decimal totalDetalle)> detalles = new List<(int, decimal, int, decimal)>();

                    // Iterar sobre las filas del DataGridView para extraer los detalles
                    foreach (DataGridViewRow row in Dgv_ordenesGenerar.Rows)
                    {
                        {
                            if (row.IsNewRow) continue; // Ignorar la fila nueva
                            int codigoProducto = Convert.ToInt32(row.Cells["Producto"].Value);
                            decimal precioU = Convert.ToDecimal(row.Cells["Costo"].Value);
                            int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                            decimal totalDetalle = Convert.ToDecimal(row.Cells["Total"].Value);

                            detalles.Add((codigoProducto, precioU, cantidad, totalDetalle));
                        }
                    }

                
                    // Llamar al método para insertar la orden completa
                    bool resultado = logic.CrearOrdenCompra(numeroOC, proveedorId, fechaEntrega, total, detalles);

                    // Manejar el resultado
                    if (resultado)
                    {
                        MessageBox.Show("Orden de compra creada exitosamente.");
                        // Opcional: Limpiar el DataGridView y los campos de entrada
                        Dgv_ordenesGenerar.Rows.Clear();
                        Txt_no_orCom.Clear();
                        Txt_Total.Clear();
                        Cbo_proveedor.SelectedIndex = -1;
                        dateTime_enc.Value = DateTime.Now; // Resetear a la fecha actual
                    }
                    else
                    {
                        MessageBox.Show("Error al crear la orden de compra. Detalle: " + logic.LastErrorMessage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la orden de compra: " + ex.Message);
                }
            

        }

        private void Btn_agregarDet_Click(object sender, EventArgs e)
        {
            AgregarProducto();
            CalcularTotal();
        }

        private void Btn_cancelarEncDet_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Btn_eliminarDet_Click(object sender, EventArgs e)
        {
           
                // Verificar si hay una fila seleccionada en el DataGridView
                if (Dgv_ordenesGenerar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el número de orden de compra y el código del producto de la fila seleccionada
                string numeroOC = Txt_no_orCom.Text; // El número de orden puede estar en el campo de texto
                var filaSeleccionada = Dgv_ordenesGenerar.SelectedRows[0];

                int codigoProducto = Convert.ToInt32(filaSeleccionada.Cells["Producto"].Value);
                decimal precioU = Convert.ToDecimal(filaSeleccionada.Cells["Costo"].Value);
                int cantidad = Convert.ToInt32(filaSeleccionada.Cells["Cantidad"].Value);
                decimal totalDetalle = Convert.ToDecimal(filaSeleccionada.Cells["Total"].Value);

                // Mostrar detalles específicos del producto a eliminar
                string mensaje = $"Vas a eliminar el siguiente detalle:\n\n" +
                                 $"Código de Producto: {codigoProducto}\n" +
                                 $"Descripción: {precioU}\n" +
                                 $"Precio Unitario: {cantidad}\n" +
                                 $"Cantidad: {totalDetalle}\n\n" +
                                 "¿Estás seguro de que deseas eliminar este detalle?";

                // Confirmar la eliminación con el usuario
                var resultado = MessageBox.Show(mensaje, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }

                // Llamar a la capa de negocios para eliminar el detalle en la base de datos
                bool exito = logic.EliminarDetalle(numeroOC, codigoProducto);

                // Si el detalle fue eliminado de la base de datos, se elimina de la vista también
                if (exito)
                {
                    MessageBox.Show("El detalle ha sido eliminado exitosamente de la base de datos.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si no existe en la base de datos, solo se elimina de la vista
                    MessageBox.Show("El detalle no existe en la base de datos, pero se eliminará de la vista.", "Eliminación sin conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Eliminar la fila del DataGridView
                Dgv_ordenesGenerar.Rows.Remove(filaSeleccionada);

                // Recalcular el total después de eliminar
                CalcularTotal();
            }





            private void Btn_actualizarDET_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Obtener los valores de los campos del formulario
                string numeroOC = Txt_no_orCom.Text;

                // Convertir el total correctamente
                if (!decimal.TryParse(Txt_Total.Text, out decimal nuevoTotal))
                {
                    MessageBox.Show("Por favor, ingrese un valor válido en el campo Total.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener los detalles de la orden desde el DataGridView
                List<(int codigoProducto, decimal precioU, int cantidad, decimal totalDetalle)> detalles = new List<(int, decimal, int, decimal)>();

                foreach (DataGridViewRow row in Dgv_ordenesGenerar.Rows)
                {
                    if (row.IsNewRow) continue; // Ignorar la fila nueva

                    // Extraer y convertir los valores de cada columna
                    int codigoProducto = Convert.ToInt32(row.Cells["Producto"].Value);
                    decimal precioU = Convert.ToDecimal(row.Cells["Costo"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal totalDetalle = Convert.ToDecimal(row.Cells["Total"].Value);

                    detalles.Add((codigoProducto, precioU, cantidad, totalDetalle));
                }

                // Llamar al método de actualización
                bool resultado = logic.ActualizarOrdenCompra(numeroOC, nuevoTotal, detalles);

                // Manejo de la respuesta
                if (resultado)
                {
                    MessageBox.Show("La orden de compra se actualizó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Hubo un error, ya existe uno con ese código" + logic.LastErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Captura errores no controlados para una mejor información
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_Total_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Btn_salirOC_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    }
}

