using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjecutarCambiosCentros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] alias = { "ID", "Fecha", "Monto", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.LightBlue);
            navegador1.asignarColorFuente(Color.BlueViolet);
            navegador1.asignarTabla("factura");
            List<string> tablas = new List<string> { "detallefactura", "pagos" };
            navegador1.asignarTablas(tablas);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.asignarAyuda("2");
            navegador1.asignarNombreForm("VENTAS");
        }
    }
}
