using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace ejecucion
{
    public class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CapaDatos.sentencia s = new CapaDatos.sentencia();

            Application.Run(new CapaDiseno.MDI_Seguridad("admin"));
            //Application.Run(new Capa_Vista_Reporteria.menu_reporteria());

        }
    }
}
