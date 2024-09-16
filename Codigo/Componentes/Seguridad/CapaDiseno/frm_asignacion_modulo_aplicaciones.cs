using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class frm_asignacion_modulo_aplicaciones : Form
    {
        /******************************Ismar Leonel Cortez Sanchez*******************************************************/
        logica logica2;

        public frm_asignacion_modulo_aplicaciones(String idUsuario)
        {
            InitializeComponent();
            logica2 = new logica(idUsuario); // Inicializa logica2 con idUsuario
            string tabla = "tbl_modulos";
            string campo1 = "Pk_id_modulos";
            string campo2 = "nombre_modulo";

            string tablaApli = "tbl_aplicaciones";
            string campo1Apli = "Pk_id_aplicacion";
            string campo2Apli = "nombre_aplicacion";


            // Llama al método para llenar el ComboBox
            llenarseModulos(tabla, campo1, campo2);
            llenarseApli(tablaApli, campo1Apli, campo2Apli);

            // Asocia el evento SelectedIndexChanged después de poblar el ComboBox
            cmb_modulo.SelectedIndexChanged += new EventHandler(cmb_modulo_SelectedIndexChanged);
            cmb_apli.SelectedIndexChanged += new EventHandler(cmb_apli_SelectedIndexChanged2);
        }

        public frm_asignacion_modulo_aplicaciones() { }

        private void frm_asignacion_modulo_aplicaciones_Load(object sender, EventArgs e) { }


        /*********************************Ismar Leonel Cortez Sanchez -0901-21-560*****************************************/
        /**************************************Combo box inteligente 1*****************************************************/

        public void llenarseModulos(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = logica2.enviar(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            cmb_modulo.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                cmb_modulo.Items.Add(new ComboBoxItem
                {
                    Value = row[campo1].ToString(),
                    Display = row[campo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            cmb_modulo.AutoCompleteCustomSource = coleccion;
            cmb_modulo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_modulo.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

        private void cmb_modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_modulo.SelectedItem != null)
            {
                // Obtener el valor del ValueMember seleccionado
                var selectedItem = (ComboBoxItem)cmb_modulo.SelectedItem;
                string valorSeleccionado = selectedItem.Value;
                // Mostrar el valor en un MessageBox
                MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            }
        }
        /***************************************************************************************************/



        /*********************************Ismar Leonel Cortez Sanchez -0901-21-560*****************************************/
        /**************************************Combo box inteligente 2*****************************************************/

        public void llenarseApli(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt2 = logica2.enviar2(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            cmb_apli.Items.Clear();

            foreach (DataRow row in dt2.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                cmb_apli.Items.Add(new ComboBoxItem
                {
                    Value = row[campo1].ToString(),
                    Display = row[campo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion2 = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion2.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion2.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            cmb_apli.AutoCompleteCustomSource = coleccion2;
            cmb_apli.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb_apli.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Clase auxiliar para almacenar Value y Display
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

        private void cmb_apli_SelectedIndexChanged2(object sender, EventArgs e)
        {
            if (cmb_modulo.SelectedItem != null)
            {
                // Obtener el valor del ValueMember seleccionado
                var selectedItem = (ComboBoxItem)cmb_apli.SelectedItem;
                string valorSeleccionado = selectedItem.Value;
                // Mostrar el valor en un MessageBox
                MessageBox.Show($"Valor seleccionado: {valorSeleccionado}", "Valor Seleccionado");
            }
        }
        /***************************************************************************************************/




        /*****************************************************************************************************/
    }
}
