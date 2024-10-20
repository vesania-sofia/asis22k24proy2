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
            MantenimientoNav mantenimiento = new MantenimientoNav("9006");
            mantenimiento.MdiParent = this;
            mantenimiento.Show();
        }

        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            Movimientos movimientoinv = new Movimientos("9005");
            movimientoinv.MdiParent = this;
            movimientoinv.Show();
        }

        private void Btn_AdminLotes_Click(object sender, EventArgs e)
        {
            Locales adminlote = new Locales("9004");
            adminlote.MdiParent = this;
            adminlote.Show();
        }

        private void Btn_MonitoreoAlm_Click(object sender, EventArgs e)
        {
            Almacenes monitoralm = new Almacenes("9003");
            monitoralm.MdiParent = this;
            monitoralm.Show();
        }
    }
}
