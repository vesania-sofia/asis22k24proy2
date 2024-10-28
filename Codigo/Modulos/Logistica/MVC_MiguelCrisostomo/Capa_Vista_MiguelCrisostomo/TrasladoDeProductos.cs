using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_MiguelCrisostomo;
using Capa_Modelo_MiguelCrisostomo; // Asegúrate de importar la capa del modelo




namespace Capa_Vista_MiguelCrisostomo
{
    public partial class TrasladoDeProductos : Form
    {
        controlador controlador = new controlador();
        private sentencias modelo = new sentencias(); // Instancia de la clase 'sentencias'
        
        //CONSTRUCTOR__*************************************************************************************************
        public TrasladoDeProductos()
        {
            InitializeComponent();// Inicializa los componentes del formulario
            CargarDestinos(); // Cargar destinos al iniciar el formulario
            CargarCodigosProductos(); // Cargar códigos de productos  

            Cbo_Destino.SelectedIndexChanged += Cbo_Destino_SelectedIndexChanged; // Enlazar el evento para destinos
            //Cbo_Destino.SelectedIndexChanged += Cbo_CodigoProd_SelectedIndexChanged; // Enlazar el evento para destinos
            Cbo_CodigoProd.SelectedIndexChanged += new EventHandler(Cbo_CodigoProd_SelectedIndexChanged); // Enlaza el evento cuando cambia la selección del combo de códigos de productos
            Txt_Cantidad.TextChanged += Txt_Cantidad_TextChanged;
            Btn_Aceptar.Click += new EventHandler(Btn_Aceptar_click);





            // Desactivar algunos TextBoxes
            Txt_Id.Enabled = false;
            Txt_Vehiculo.Enabled = false;
            Txt_FchEmision.Enabled = false;
            Txt_FchTraslado.Enabled = false;
            Txt_NombreProd.Enabled = false;
            Txt_PesoProd.Enabled = false;
            Txt_Stock.Enabled = false;
            Txt_PrecioU.Enabled = false;
            Lbl_CostoTProd.Enabled = true;

           

        }
        //*************************************************************************************************************


        /// INSTRUCCION PARA CARGAR LOS CODIGOS EN EL Cbo_CodigoProd ******************************************************
        private void CargarCodigosProductos()
        {
            try
            {
                List<int> codigosProductos = controlador.ObtenerCodigosProductos(); // Llama al método en el controlador
                Cbo_CodigoProd.Items.Clear();

                // Establece el modo de autocompletado
                Cbo_CodigoProd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                Cbo_CodigoProd.AutoCompleteSource = AutoCompleteSource.ListItems;


                foreach (int codigo in codigosProductos)
                {
                    Cbo_CodigoProd.Items.Add(codigo); // Agrega cada código de producto al ComboBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar códigos de productos: " + ex.Message);
            }
        }

        //Llamar a CargarCodigosProductos en el Load del formulario
        private void TrasladoDeProductos_Load(object sender, EventArgs e)
        {
            // Llama al método para cargar los códigos de productos en el ComboBox
            CargarCodigosProductos();
        }



        /// EVENTO PARA MOSTRAR EL nombreProducto ******************************************************
        private void Cbo_CodigoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //METODOS_________________*****************************************
                // Obtener y mostrar nombreProducto
                string nombreProducto = controlador.ObtenerNombreProductoPorCodigo((int)Cbo_CodigoProd.SelectedItem);
                Txt_NombreProd.Text = nombreProducto;

                // Obtener y mostrar pesoProducto como texto
                string pesoProducto = controlador.ObtenerPesoProductoPorCodigo((int)Cbo_CodigoProd.SelectedItem);
                Txt_PesoProd.Text = pesoProducto;

                // Obtener y mostrar stock
                int stockProducto = controlador.ObtenerStockProductoPorCodigo((int)Cbo_CodigoProd.SelectedItem);
                Txt_Stock.Text = stockProducto.ToString(); // Muestra el stock en el TextBox

                // Obtener y mostrar precio
                decimal precioProducto = controlador.ObtenerPrecioProductoPorCodigo((int)Cbo_CodigoProd.SelectedItem);
                Txt_PrecioU.Text = precioProducto.ToString("F2"); // Muestra el precio con 2 decimales
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el nombre del producto: " + ex.Message);
            }
        }

                                         //CALCULO DE "COSTO TOTAL"*****************************************************



        // Definir un ancho máximo para el Label  
        private const int MaxLabelWidth = 50; // Ajusta este valor según sea necesario  


        // Evento para recalcular el costo total al cambiar la cantidad

        private void Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
            // Verificar si ambos valores son válidos antes de calcular  
            if (decimal.TryParse(Txt_Cantidad.Text, out decimal cantidad) &&
                decimal.TryParse(Txt_PrecioU.Text, out decimal precioUnitario))
            {
                // Calcular el costo total  
                decimal costoTotal = cantidad * precioUnitario;

                // Mostrar el costo total en Lbl_CostoTProd, aplicando formato  
                string costoTotalText = costoTotal.ToString("F2"); // Formato de dos decimales  

                // Truncar el texto si excede el ancho máximo  
                if (TextRenderer.MeasureText(costoTotalText, Lbl_CostoTProd.Font).Width > MaxLabelWidth)
                {
                    costoTotalText = costoTotalText.Substring(0, Math.Min(costoTotalText.Length, 7)); // Ajusta el número según sea necesario  
                }

                // Asignar el texto al Label  
                Lbl_CostoTProd.Text = costoTotalText;
            }
            else
            {
                // Si la cantidad o el precio unitario no son válidos, limpiar el campo de costo total  
                //Lbl_CostoTProd.Text = string.Empty;

                // Si la cantidad o el precio unitario no son válidos, asignar "0.00" al campo de costo total  
                Lbl_CostoTProd.Text = "0.00";
            }
        }















        //*************************************************************************************************************
        /// INSTRUCCION PARA CARGAR INFORMACION EN EL Cbo_Destino ******************************************************
        private void CargarDestinos()
        {
            try
            {
                List<string> destinos = modelo.ObtenerDestinos(); // Llama al método ObtenerDestinos
                Cbo_Destino.Items.Clear();
                foreach (string codigoProducto in destinos)
                {
                    Cbo_Destino.Items.Add(codigoProducto); // Agrega cada destino al ComboBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar destinos: " + ex.Message);
            }
        }

        /// EVENTO PARA MOSTRAR EL ID AL SELECCIONAR UN DESTINO ******************************************************
        private void Cbo_Destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //METODOS_________________*****************************************
                // Obtener y mostrar el ID de guía
                string destinoSeleccionado = Cbo_Destino.SelectedItem.ToString();
                int idGuia = controlador.ObtenerIdGuiaPorDestino(destinoSeleccionado); // Llama al método en el controlador
                Txt_Id.Text = idGuia.ToString(); // Muestra el ID en el TextBox


                // Obtener y mostrar la marca del vehículo
                string marcaVehiculo = modelo.ObtenerMarcaVehiculoPorDestino(destinoSeleccionado);
                Txt_Vehiculo.Text = marcaVehiculo;

                // Obtener y mostrar la fecha de emisión
                DateTime? fechaEmision = controlador.ObtenerFechaEmisionPorDestino(destinoSeleccionado);
                if (fechaEmision.HasValue)
                {
                    //MessageBox.Show("Fecha obtenida: " + fechaEmision.Value.ToString("yyyy-MM-dd"));
                    Txt_FchEmision.Text = fechaEmision.Value.ToString("yyyy-MM-dd");
                }
                else
                {
                    MessageBox.Show("No se encontró una fecha de emisión para el destino seleccionado.");
                    Txt_FchEmision.Text = string.Empty; // Limpiar si no hay fecha
                }

                // Obtener y mostrar la fecha de traslado
                DateTime? fechaTraslado = controlador.ObtenerFechaTrasladoPorDestino(destinoSeleccionado);
                if (fechaTraslado.HasValue)
                {
                    Txt_FchTraslado.Text = fechaTraslado.Value.ToString("yyyy-MM-dd");
                }
                else
                {
                    Txt_FchTraslado.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del destino: " + ex.Message);
            }
        }


        /// INSTRUCCIONES BOTON GUARDAR ******************************************************
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
           
        }



       

        private void Btn_Aceptar_click(object sender, EventArgs e)
        {
            try
            {
                // Validar la cantidad ingresada y que sea mayor a cero
                if (!int.TryParse(Txt_Cantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida y mayor a cero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que el stock ingresado sea válido y que la cantidad no lo exceda
                if (!int.TryParse(Txt_Stock.Text, out int stock) || cantidad > stock)
                {
                    MessageBox.Show("La cantidad ingresada excede el stock disponible o es inválida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar que un producto y un destino estén seleccionados
                if (Cbo_CodigoProd.SelectedItem == null || string.IsNullOrEmpty(Cbo_Destino.Text))
                {
                    MessageBox.Show("Seleccione un producto y un destino.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar el precio unitario
                if (!decimal.TryParse(Txt_PrecioU.Text, out decimal precioUnitario))
                {
                    MessageBox.Show("El precio unitario no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calcular el costo total
                decimal costoTotal = cantidad * precioUnitario;

                // Obtener ID del producto y otros datos necesarios para el traslado
                int idProducto = (int)Cbo_CodigoProd.SelectedItem;
                string destino = Cbo_Destino.Text;
                DateTime fecha = DateTime.Now;
                int idGuia = controlador.ObtenerIdGuiaPorDestino(destino);
                

                // Realizar el traslado a través del controlador
                controlador.RealizarTraslado(destino, fecha, costoTotal, costoTotal, precioUnitario, idProducto, idGuia);


                // Mostrar mensaje de éxito
                MessageBox.Show("Traslado realizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el traslado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }






    }
}
