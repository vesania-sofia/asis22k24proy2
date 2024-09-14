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
            // Retroceder a la carpeta raíz del proyecto y luego entrar a la carpeta "Reportes"
            string rutaProyecto = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
            string rutaReporte = Path.Combine(rutaProyecto, "Reportes", direccion_reporte.Text);

            using (ReportDocument crystalrpt = new ReportDocument())
            {
                try
                {
                    // Cargar el reporte desde la ruta especificada
                    crystalrpt.Load(rutaReporte);
                    crystalrpt.Refresh();

                    // Asignar el reporte al visor de Crystal Reports
                    crystalReportViewer1.ReportSource = crystalrpt;
                    crystalReportViewer1.Refresh();
                }
                catch (Exception ex)
                {
                    // Mostrar un mensaje de error si no se puede cargar el reporte
                    MessageBox.Show($"Error al cargar el reporte: {ex.Message}");
                }
            }
        }




    }
}
