using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_CompraVenta;

namespace Capa_Vista_CompraVenta
{
    public partial class Frm_MDI_general_CompraVenta : Form
    {

        string idUsuario;
        public Frm_MDI_general_CompraVenta(string idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuCatalogosOpcion1_Click(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_proveedores(idUsuario));
        }

        private void btnMenuProcesosOpcion1_Click(object sender, EventArgs e)
        {
            Frm_clientes Prov = new Frm_clientes(idUsuario);
            Prov.MdiParent = this;
            Prov.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_vendedores Prov = new Frm_vendedores(idUsuario);
            Prov.MdiParent = this;
            Prov.Show();
        }
    }
}
