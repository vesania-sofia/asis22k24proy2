using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Capa_Vista_Navegador
{
    public partial class Clientes : Form
    {
        // Variable para almacenar la ruta del archivo del reporte
        string ruta = "";

        // Constructor que recibe la ruta del archivo como parámetro
        public Clientes(string path)
        {
            InitializeComponent();
            ruta = path;  // Asigna la ruta del archivo a la variable de clase
            OpenFileDialog arch = new OpenFileDialog();  // Crea un diálogo para abrir archivos (aunque no se usa en este fragmento)
        }

        // Evento que se ejecuta cuando se carga el CrystalReportViewer
        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
            // Sin implementación en este fragmento
        }

        // Evento que se ejecuta cuando se carga el formulario de reportes de clientes
        private void Frm_ReporteClientes_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument reportDocument = new ReportDocument();  // Crear un nuevo objeto ReportDocument
                string filePath = ruta;  // Asigna la ruta del archivo de reporte a una variable local
                reportDocument.Load(filePath);  // Carga el reporte desde la ruta especificada
                crystalReportViewer1.ReportSource = reportDocument;  // Asigna el reporte cargado como fuente para el visor de Crystal Reports
            }
            catch (Exception)
            {
                MessageBox.Show("Error... No se puede abrir el reporte seleccionado...");  // Muestra un mensaje de error si no se puede cargar el reporte
            }
        }

        // Evento que se ejecuta cuando se cierra el formulario de reportes de clientes
        private void Frm_ReporteClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Sin implementación en este fragmento
        }
    }
}
