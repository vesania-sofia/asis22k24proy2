using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejecucion
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablaSeleccionada = cbTablas.SelectedItem.ToString();

            // Crear una instancia de Form1
            Form1 form1 = new Form1(tablaSeleccionada);

            // Pasar el valor seleccionado al método RecibirTabla de Form1

            // Mostrar Form1
            form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void principal_Load(object sender, EventArgs e)
        {

        }
    }
}
