using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_ControladorConsultas;

//comentado por javier juarez
namespace Capa_VistaConsultas
{
    // Josue Amaya 0901-19-12421
    // Busqueda Simple Usuario 
    public partial class Busqueda_Simple : Form
    {
        csControldor csn = new csControldor();

        public String tableN1 = "";
        String datobuscar = "";
        String buscaren = "";
        String cadenaB = "";
        String operador = "";
       
        //Pasa la tabla del navegador
        public void setTable(string tbl)
        {
            tableN1 = tbl;
        }
        public Busqueda_Simple()
        {
            InitializeComponent();
            panelResultado.Visible = true;
            panelResultado.Enabled = true;
            this.llenarCombo();
            cmboperadores.DataSource = operadores;

        }

        //Lenar combobox con las columnas de la tabla
        public void llenarCombo()
        {
            List<string> db_columns = csn.obtenerColumbasPorTabla(tableN1);
            foreach (string mycolumn in db_columns)
            {
                cbox_columnas.Items.Add(mycolumn);
            }
        }

        //Llenar combobox con operador lógico
        List<string> operadores = new List<string>
        {
            "=",
            ">",
            "<",
            ">=",
            "<=" 
        };

        //Boton salir
        private void btn_SalirBA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Boton para cancelar la busqueda
        private void btn_CancelarBA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelResultado_Paint(object sender, PaintEventArgs e)
        {
            CargarColumnas(cbox_columnas, tableN1);
        }


        //Metodo para buscar dato y cargarlo en la tabla N1
        private void bnt_buscaPor_Click(object sender, EventArgs e)
        {
            if (cmboperadores.Enabled == false)
            {
                datobuscar = txt_BuscaPor.Text;
                buscaren = cbox_columnas.Text;

                BuscaPor(datobuscar, buscaren, tableN1);
                CargarColumnas(cbox_columnas, tableN1);
                cadenaB = "";
            }
            else
            {
                datobuscar = txt_BuscaPor.Text;
                buscaren = cbox_columnas.Text;
                operador = cmboperadores.Text;

                BuscaPor2(datobuscar, buscaren, operador, tableN1);
                CargarColumnas(cbox_columnas, tableN1);
                cadenaB = "";
                cmboperadores.Enabled = false;
                txt_BuscaPor.Text = "";
            }
        }
        //Metodo para obtener datos que se cargaran a la tabla N1
        public void CargarColumnas(ComboBox cbox_columnas, String tableN1)
        {
            int ndgv = dgvDato.Columns.Count;

            for (int i = 0; i < ndgv; i++)
            {
                String nameC;
                nameC = dgvDato.Columns[i].HeaderText;
                int ncbx = cbox_columnas.Items.Count;
                if (ncbx < ndgv)
                {
                    cbox_columnas.Items.Add(nameC);
                }
            }
        }
        //Metodo para buscar un dato por medio de un atributo especifico
        private void BuscaPor(string datobuscar, string buscaren, string tableN)
        {
            DataTable dt = new DataTable();
            csn.BuscarPor(datobuscar, buscaren, tableN, dt, lbl_cadena);

            if (dt.Rows.Count > 0)
            {
                panelResultado.Visible = true;
                dgvDato.DataSource = dt;
                cadenaB = "";
                datobuscar = "";
                buscaren = "";
                txt_BuscaPor.Text = "";
            }
        }

        private void BuscaPor2(string datobuscar, string buscaren,string operador, string tableN)
        {
            DataTable dt = new DataTable();
            csn.BuscarPor2(datobuscar, buscaren,operador, tableN, dt, lbl_cadena);

            if (dt.Rows.Count > 0)
            {
                panelResultado.Visible = true;
                dgvDato.DataSource = dt;
                cadenaB = "";
                datobuscar = "";
                buscaren = "";
                txt_BuscaPor.Text = "";
                operador = "";
            }
        }

        private void dgvDato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbo_buscaren_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbox_columnas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cbox_columnas.SelectedItem.ToString();
            // Llamar a la capa controlador para hacer una consulta a la capa modelo
            string consultaTipo = csn.ObtenerTipoDeDato(seleccion, tableN1);
            Console.WriteLine(consultaTipo);

            if(consultaTipo.Equals("double")||consultaTipo.Equals("decimal"))
            {

                cmboperadores.Enabled = true;
            }
            else
            {
                cmboperadores.Enabled = false;
            }
        }

        private void cmboperadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

