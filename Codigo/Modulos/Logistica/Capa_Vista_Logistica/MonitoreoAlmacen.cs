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
    public partial class MonitoreoAlmacen : Form
    {
        private string idBodega; // Campo para almacenar el ID de la bodega

        // Constructor que recibe el ID de la bodega
        public MonitoreoAlmacen(string idBodega)
        {
            InitializeComponent();
            this.idBodega = idBodega;

            // Aquí puedes implementar la lógica para cargar información relacionada con la bodega usando el ID
            CargarInformacionBodega(idBodega);
        }

        private void CargarInformacionBodega(string idBodega)
        {
            // Lógica para cargar información de la bodega según el ID
            // Por ejemplo, puedes mostrarlo en un Label o en un TextBox
            MessageBox.Show("ID de Bodega seleccionado: " + idBodega);
            // O puedes realizar una consulta a la base de datos para obtener más información
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
