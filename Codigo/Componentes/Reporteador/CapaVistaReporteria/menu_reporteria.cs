using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaReporteria
{
    public partial class menu_reporteria : Form
    {
        public menu_reporteria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                 Inicio rep = new Inicio();
                 rep.MdiParent = this;
                 rep.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                reporteria_usuario rep = new reporteria_usuario();
                rep.MdiParent = this;
                rep.Show();
        }
    }
}
