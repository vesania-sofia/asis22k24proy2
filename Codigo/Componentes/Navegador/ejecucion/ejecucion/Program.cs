using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            

<<<<<<< HEAD
            Application.Run(new CapaDiseno.MDI_Seguridad("admin"));
=======
            Application.Run(new CapaDiseno.frm_login());
>>>>>>> 7453dffb9a1fd864c63b5a1642661cebc9141aab
            //Application.Run(new Capa_Vista_Reporteria.menu_reporteria());

        }
    }
}
