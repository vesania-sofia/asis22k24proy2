using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebareport
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
            Application.Run(new CapaDiseno.frm_login());
<<<<<<< HEAD:Codigo/Componentes/Navegador/ejecucion/ejecucion/Program.cs

            //Application.Run(new Capa_Vista_Reporteria.menu_reporteria());
=======
           
>>>>>>> 901d4e4319f7562d6e6f463ea9dc79aa06863c65:Codigo/Componentes/Navegador/pruebareport/pruebareport/Program.cs
        }
    }
}
