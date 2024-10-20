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
    public partial class Mantenimiento : Form
    {
        private string Pk_id_Mantenimiento;

        public Mantenimiento(string Pk_id_Mantenimiento)
        {
            InitializeComponent();
            this.Pk_id_Mantenimiento = Pk_id_Mantenimiento;
            CargarInformacionMantenimiento(Pk_id_Mantenimiento);
        }
        private void CargarInformacionMantenimiento(string Pk_id_Mantenimiento)
        {
            MessageBox.Show("ID de mantenimiento seleccionado: " + Pk_id_Mantenimiento);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
