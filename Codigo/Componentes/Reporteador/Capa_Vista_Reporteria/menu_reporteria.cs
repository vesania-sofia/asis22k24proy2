using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Reporteria
{
    public partial class menu_reporteria : Form
    {
        public menu_reporteria()
        {
            InitializeComponent();
        }

        private void Btn_RepUsuario_Click(object sender, EventArgs e)
        {
            reporteria_usuario rep = new reporteria_usuario();
            rep.MdiParent = this;
            rep.Show();
        }

        private void Btn_RepAdmin_Click(object sender, EventArgs e)
        {
            Inicio rep = new Inicio();
            rep.MdiParent = this;
            rep.Show();
        }
    }
}
