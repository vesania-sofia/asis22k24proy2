using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Cambio;

namespace Capa_Vista_Cambio
{
    public partial class tipoCambio : Form
    {

        public DataTable tiposDeCambio;
        private Controlador capaControlador = new Controlador();

        public tipoCambio()
        {
            InitializeComponent();
            llenarCombo();
        }

        private void llenarCombo()
        {
            List<string> nombresMonedas = capaControlador.ObtenerNombresMonedas();
            cboMonedas.Items.Clear();
            cboMonedas.Items.Add("Seleccionar...");
            foreach (string nombreMoneda in nombresMonedas)
            {
                cboMonedas.Items.Add(nombreMoneda);
            }
            if (cboMonedas.Items.Count > 0)
            {
                cboMonedas.SelectedIndex = 0;
            }
        }

        private void tipoCambio_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
