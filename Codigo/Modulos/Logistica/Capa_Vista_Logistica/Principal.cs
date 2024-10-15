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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Btn_Chofer_Click(object sender, EventArgs e)
        {
            Chofer chofer = new Chofer();
            chofer.MdiParent = this;
            chofer.Show();
        }

        private void Btn_Transporte_Click(object sender, EventArgs e)
        {
            Transporte transporte = new Transporte();
            transporte.MdiParent = this;
            transporte.Show();
        }

        private void Btn_TransporteVeh_Click(object sender, EventArgs e)
        {
            Transporte_Vehiculos transporte_veh = new Transporte_Vehiculos();
            transporte_veh.MdiParent = this;
            transporte_veh.Show();
        }

        private void Btn_TrasladoDProd_Click(object sender, EventArgs e)
        {
            TrasladoDProductos trasladodprod = new TrasladoDProductos();
            trasladodprod.MdiParent = this;
            trasladodprod.Show();
        }

        private void Btn_Mantenimiento_Click(object sender, EventArgs e)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            mantenimiento.MdiParent = this;
            mantenimiento.Show();
        }

        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            Movimiento_de_Inventario movimientoinv = new Movimiento_de_Inventario();
            movimientoinv.MdiParent = this;
            movimientoinv.Show();
        }

        private void Btn_AdminLotes_Click(object sender, EventArgs e)
        {
            Administración_de_Lotes adminlote = new Administración_de_Lotes();
            adminlote.MdiParent = this;
            adminlote.Show();
        }

        private void Btn_MonitoreoAlm_Click(object sender, EventArgs e)
        {
            MonitoreoAlmacen monitoralm = new MonitoreoAlmacen();
            monitoralm.MdiParent = this;
            monitoralm.Show();
        }
    }
}
