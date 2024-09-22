using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtraPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] alias = { "id_perro", "nombre", "id_raza", "estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.LightBlue);
            navegador1.asignarColorFuente(Color.BlueViolet);
            navegador1.asignarTabla("perro");
            navegador1.asignarComboConTabla("razas", "id_raza", "nombre_raza", 1);
            navegador1.asignarforaneas("perro", "razas", "nombre_raza", "id_raza", "id_raza");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario("Ismar");
            //navegador1.asignar2Tabla("registroperro");
            navegador1.asignarNombreForm("PERROS");
        }
    }
}
