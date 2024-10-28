using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Presupuesto
{
    public partial class Incremento : Form
    {
        public int iDato;
        public bool bIncrementar;
        public bool bAnual;
        public bool bMes;
        public string sMesSelec;
        public string sLlenado;
        ToolTip toolTip = new ToolTip();
        public Incremento()
        {
            InitializeComponent();
            toolTip.SetToolTip(Btn_Aceptar, "Haz clic para aceptar");
            toolTip.SetToolTip(Btn_cancelar, "Haz clic para cancelar");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancelar la entrada del carácter
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txtbx_incremento.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detenemos la ejecución si el campo está vacío
            }

            iDato = Convert.ToInt32(Txtbx_incremento.Text);
            bIncrementar = Chb_todos.Checked;
            bAnual = Chb_anual.Checked;

            if (!bIncrementar && !bAnual)
            {
                if (Cb_meses.SelectedItem != null)
                {
                    sMesSelec = Cb_meses.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Por favor selecciona una opcion.");
                    return;
                }
            }

            // Establecemos el resultado como Aceptado
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Chb_todos.Checked == true)
            {
                Cb_meses.Enabled = false;
                Chb_mes.Checked = false;
                Chb_anual.Checked = false;
            }
        }

        private void Chb_anual_CheckedChanged(object sender, EventArgs e)
        {
            if (Chb_anual.Checked == true)
            {
                Cb_meses.Enabled = false;
                Chb_mes.Checked = false;
                Chb_todos.Checked = false;
            }
        }

        private void Chb_mes_CheckedChanged(object sender, EventArgs e)
        {
            if (Chb_mes.Checked == true)
            {
                Cb_meses.Enabled = true;
                Chb_anual.Checked = false;
                Chb_todos.Checked = false;
            }
        }

        private void Incremento_Load(object sender, EventArgs e)
        {
            switch (sLlenado)
            {
                case "Mensual":
                    Chb_anual.Enabled = false;
                    Chb_anual.Visible = false;
                    break;
                case "Anual":
                    Chb_mes.Enabled = false;
                    Chb_mes.Visible = false;
                    Chb_todos.Enabled = false;
                    Chb_todos.Visible = false;
                    Cb_meses.Enabled = false;
                    Cb_meses.Visible = false;
                    break;
            }
            Cb_meses.Enabled = false;
        }
    }
}
