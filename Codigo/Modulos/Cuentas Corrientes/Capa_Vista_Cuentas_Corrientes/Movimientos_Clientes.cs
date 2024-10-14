using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Cuentas_Corrientes
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void creacionClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormaPago.Show();
        }

        private void nuevosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ClienteNuevo.Show(); ESTO ME DA ERROR AL MOMENTO DE LLAMAR EL FORMULARIO
        }

        private void mensualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MovimientoMensual.Show();
        }

        private void mensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // SaldoCliente.Show();
        }

        private void mensualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //CreditoCliente.Show();
        }
    }
}
