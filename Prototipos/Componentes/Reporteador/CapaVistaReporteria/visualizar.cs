using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaReporteria
{
    public partial class visualizar : Form
    {
        public visualizar()
        {
            InitializeComponent();
        }
        public visualizar(String texto)
        {
            InitializeComponent();
            direccion_reporte.Text = texto;
            mostrar();
        }

        public void mostrar()
        {
            string rutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\..\"));
            string rutaReporte = Path.Combine(rutaProyecto, "Reportes", direccion_reporte.Text);
            ReportDocument crystalrpt = new ReportDocument();
            try
            {
                crystalrpt.Load(rutaReporte);
                crystalReportViewer1.ReportSource = crystalrpt;
                crystalReportViewer1.Refresh();
            }
            catch
            {
                MessageBox.Show("Error, no se puede encontrar el reporte en su equipo, verifique la ruta");
            }
        }




    }
}
