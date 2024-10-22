using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfac_V3           
{
    static class Program
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
            //Application.Run(new FormPrincipal());
            Application.Run(new FormPrincipal());
           //Application.Run(new splash());
=======
            Application.Run(new splash());
            //Application.Run(new FormModulos());
            //Application.Run(new Capa_Vista_Seguridad.frm_login());

>>>>>>> 850a0fbc55317fb0ca47c0d8199f06901bf79472
        }
    }
}
