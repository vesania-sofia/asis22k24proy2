using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejecuciontransaccional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] alias = { "ID", "Fecha", "Cliente", "Monto", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.LightBlue);
            navegador1.asignarColorFuente(Color.BlueViolet);
            navegador1.asignarTabla("factura");
            List<string> tablas = new List<string> { "detallefactura", "pago" };
            navegador1.asignarTablas(tablas);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario("1");
            navegador1.asignarAyuda("1");
            navegador1.asignarNombreForm("VENTAS");
        }
    }
}
