using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejecucion
{
    public partial class Form1 : Form
    {
        string tabla;
        public Form1(String tablaseleccionada)
        {
            tabla = tablaseleccionada;
            InitializeComponent();
            if (tabla == "Venta")
            {
                string idaplicacion = "1000";
                //usuario = user;
                string[] alias = { "id_venta", "monto", "nombre_cliente", "nombre_empleado", "estado" };
                navegador1.asignarAlias(alias);
                navegador1.asignarSalida(this);
                navegador1.asignarColorFondo(Color.LightBlue);
                navegador1.asignarColorFuente(Color.BlueViolet);
                navegador1.asignarTabla("venta");
                navegador1.asignar2Tabla("factura");
                
                navegador1.asignarNombreForm("VENTAS");
            }
            else if (tabla == "Factura")
            {
                string[] alias = { "id_factura", "monto_venta", "nombre_cliente", "estado", "id_venta" };
                navegador1.asignarAlias(alias);
                navegador1.asignarSalida(this);
                navegador1.asignarColorFondo(Color.LightBlue);
                navegador1.asignarColorFuente(Color.BlueViolet);
                navegador1.asignarTabla("factura");
                navegador1.asignarComboConTabla("venta", "id_venta", "nombre_cliente", 1);
                navegador1.asignarforaneas("factura", "venta", "nombre_cliente", "id_venta", "id_venta");
                navegador1.asignarNombreForm("FACTURAS");
            }
            else if (tabla == "empleados")
            {
                string[] alias = { "codigo_empleado", "nombre_completo", "puesto","departamento", "estado" };
                navegador1.asignarAlias(alias);
                navegador1.asignarSalida(this);
                navegador1.asignarColorFondo(Color.LightBlue);
                navegador1.asignarColorFuente(Color.BlueViolet);
                navegador1.asignarTabla("empleados");
                navegador1.asignarNombreForm("EMPLEADOS");
            }
           else if (tabla == "compras")
            {
                string[] alias = { "id_compra", "nombre_cliente", "monto", "sede", "estado" };
                navegador1.asignarAlias(alias);
                navegador1.asignarSalida(this);
                navegador1.asignarColorFondo(Color.LightBlue);
                navegador1.asignarColorFuente(Color.BlueViolet);
                navegador1.asignarTabla("compra");
                navegador1.asignar2Tabla("reserva");
                navegador1.asignarNombreForm("COMPRAS");
            }
            else if (tabla == "perros")
            {
                string[] alias = { "id_perro", "nombre","id_raza", "estado" };
                navegador1.asignarAlias(alias);
                navegador1.asignarSalida(this);
                navegador1.asignarColorFondo(Color.LightBlue);
                navegador1.asignarColorFuente(Color.BlueViolet);
                navegador1.asignarTabla("perro");
                navegador1.asignarComboConTabla("razas", "id_raza", "nombre_raza", 1);
                navegador1.asignarforaneas("perro","razas","nombre_raza","id_raza","id_raza");
                navegador1.asignar2Tabla("registroperro");
                navegador1.asignarNombreForm("PERROS");
            }
            else if (tabla == "casas")
            {
                string[] alias = { "id_casa","direccion","telefono","ciudad","estado"};
                navegador1.asignarAlias(alias);
                navegador1.asignarSalida(this);
                navegador1.asignarColorFondo(Color.LightBlue);
                navegador1.asignarColorFuente(Color.BlueViolet);
                navegador1.asignarTabla("casas");
                navegador1.asignar2Tabla("registrocasas");
                navegador1.asignarNombreForm("CASAS");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            //navegador1.ObtenerIdUsuario(usuario);
            //navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);

        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
