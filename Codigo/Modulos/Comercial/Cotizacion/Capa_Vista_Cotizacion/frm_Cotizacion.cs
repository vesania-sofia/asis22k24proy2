using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Cotizacion;

namespace Capa_Vista_Cotizacion
{
    public partial class frm_Cotizacion : Form

    {

        Logica logic;
        string valorSeleccionadovendedor;
        string valorSeleccionadoclientes;

        public frm_Cotizacion()
        {
            InitializeComponent();
            Btn_cancelar.Enabled = false;
            Btn_ingresar.Enabled = true;

            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(Btn_ingresar, "Guardar aplicación");
            ToolTip tcancelar = new ToolTip();
            tcancelar.SetToolTip(Btn_cancelar, "Cancelar Cambios");

            logic = new Logica();
            string stablav = "Tbl_vendedores";
            string scampo1v = "Pk_id_vendedor";
            string scampo2v = "vendedores_nombre";


            string stablaC = "Tbl_clientes";
            string scampo1C = "Pk_id_cliente";
            string scampo2C = "Clientes_nombre";


            prollenarseVendedores(stablav, scampo1v, scampo2v);
            prollenarseClientes(stablaC, scampo1C, scampo2C);



            // Asocia el evento SelectedIndexChanged después de poblar el ComboBox
            Cbo_vendedor.SelectedIndexChanged += new EventHandler(Cbo_vendedor_SelectedIndexChanged);
            Cbo_cliente.SelectedIndexChanged += new EventHandler(Cbo_cliente_SelectedIndexChanged);
            //proactualizardatagriew();
        }


        public void prollenarseVendedores(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt = logic.funenviar(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_vendedor.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_vendedor.Items.Add(new ComboBoxItem
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

            Cbo_vendedor.AutoCompleteCustomSource = coleccion;
            Cbo_vendedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_vendedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
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


        // /////////////////////////////////////////////////////////////////////////////////
        public void prollenarseClientes(string stabla, string scampo1, string scampo2)
        {
            // Obtén los datos para el ComboBox
            var dt = logic.funenviar(stabla, scampo1, scampo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_cliente.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_cliente.Items.Add(new ComboBoxItem1
                {
                    Value = row[scampo1].ToString(),
                    Display = row[scampo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row[scampo1]) + "-" + Convert.ToString(row[scampo2]));
                coleccion.Add(Convert.ToString(row[scampo2]) + "-" + Convert.ToString(row[scampo1]));
            }

            Cbo_cliente.AutoCompleteCustomSource = coleccion;
            Cbo_cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_cliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
        public class ComboBoxItem1
        {
            public string Value { get; set; }
            public string Display { get; set; }

            // Sobrescribir el método ToString para mostrar "ID-Nombre" en el ComboBox
            public override string ToString()
            {
                return $"{Value}-{Display}"; // Formato "ID-Nombre"
            }
        }

        private void Txt_producton_Click(object sender, EventArgs e)
        {

        }

        private void Txt_totaln_Click(object sender, EventArgs e)
        {

        }

        private void Cbo_vendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_vendedor.SelectedItem != null)
            {

                var selectedItem = (ComboBoxItem)Cbo_vendedor.SelectedItem;
                valorSeleccionadovendedor = selectedItem.Value;

                // MessageBox.Show($"Valor seleccionado: {valorSeleccionadousuario}", "Valor Seleccionado");
            }
        }

        private void Cbo_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_cliente.SelectedItem != null)
            {

                var selectedItem = (ComboBoxItem1)Cbo_cliente.SelectedItem;
                valorSeleccionadoclientes = selectedItem.Value;

                // MessageBox.Show($"Valor seleccionado: {valorSeleccionadousuario}", "Valor Seleccionado");
            }
        }

        private void ActualizarComboBox()
        {
            // Limpiar los ítems actuales de los ComboBox
            Cbo_vendedor.Items.Clear();
            Cbo_cliente.Items.Clear();

            // Definir las tablas y campos para los vendedores y clientes
            string stablav = "Tbl_vendedores";
            string scampo1v = "Pk_id_vendedor";
            string scampo2v = "vendedores_nombre";


            string stablaC = "Tbl_clientes";
            string scampo1C = "Pk_id_cliente";
            string scampo2C = "Clientes_nombre";

            // Llenar los ComboBox con las funciones correspondientes
            prollenarseVendedores(stablav, scampo1v, scampo2v);
            prollenarseClientes(stablaC, scampo1C, scampo2C);

            // Asociar los eventos SelectedIndexChanged si aún no se han registrado
            Cbo_vendedor.SelectedIndexChanged += new EventHandler(Cbo_vendedor_SelectedIndexChanged);
            Cbo_cliente.SelectedIndexChanged += new EventHandler(Cbo_cliente_SelectedIndexChanged);
        }

       /* private void Btn_ingresar_Click(object sender, EventArgs e)
        {

            // Validaciones básicas
            if (Txt_idEncezado.Text == "")
            {
                MessageBox.Show("Falta el ID de la Cotización");
                Btn_ingresar.Enabled = false;
                return;
            }
            else if (Cbo_vendedor.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Vendedor");
                Btn_ingresar.Enabled = false;
                return;
            }
            else if (Cbo_cliente.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Cliente");
                Btn_ingresar.Enabled = false;
                return;
            }

            try
            {
                // Obtener los valores necesarios de los controles
                string idCotizacion = Txt_idEncezado.Text;
                string valorSeleccionadoVendedor = Cbo_vendedor.SelectedValue.ToString();
                string valorSeleccionadoCliente = Cbo_cliente.SelectedValue.ToString();
                DateTime fechaVenc = Dtp_fecha.Value;
                decimal total = Convert.ToDecimal(Txt_total.Text);

                // Llamar a la lógica para insertar la cotización
                if (logic.funinsertarCotizacionEn(idCotizacion, valorSeleccionadoVendedor, valorSeleccionadoCliente, fechaVenc, total))
                {
                    MessageBox.Show("Cotización ingresada correctamente");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error al ingresar la cotización");
                }

                // Ajustar el estado de los controles tras la operación

                ActualizarComboBox();
                Btn_cancelar.Enabled = false;
                Btn_ingresar.Enabled = true;
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        */
        private void limpiar()
        {
            Txt_idEncezado.Clear();
            Cbo_vendedor.SelectedIndex = -1;
            Cbo_cliente.SelectedIndex = -1;
            Dtp_fecha.Value = DateTime.Today;
            Txt_total.Clear();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Dtp_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Txt_total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
