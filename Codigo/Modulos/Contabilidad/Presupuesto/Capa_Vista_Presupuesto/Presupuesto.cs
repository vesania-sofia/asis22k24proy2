using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Presupuesto;

namespace Capa_Vista_Presupuesto
{
    public partial class Presupuesto : Form
    {
        Controlador control = new Controlador();
        Incremento frmIncremento = new Incremento();
        private string sOperacion;
        private int iIdPresupuesto;
        private string sNombre;
        private string sLlenado;
        public int idPrepLlenado;
        ToolTip toolTip = new ToolTip();

        public Presupuesto(string sOperacion, int iIdPresupuesto, string sNombre, string sLlenado)
        {
            InitializeComponent();
            ConfigurarColumnas();
            this.sOperacion = sOperacion;
            this.iIdPresupuesto = iIdPresupuesto;
            this.sNombre = sNombre;
            this.sLlenado = sLlenado;
            toolTip.SetToolTip(Btn_modificar, "Haz click para guardar el presupuesto");
            toolTip.SetToolTip(Btn_eliminar, "Haz click para eliminar el presupuesto");
            toolTip.SetToolTip(Btn_Informe, "Haz click para ver el informe de presupuesto: PENDIENTE");
            toolTip.SetToolTip(Btn_incremento, "Haz click para incrementar");
            toolTip.SetToolTip(Btn_ajustar, "Haz click para ajustar el presupuesto");
            toolTip.SetToolTip(Btn_Salir, "Haz click para salir");
            toolTip.SetToolTip(Btn_ayuda, "Haz click para ver ayuda : PENDIENTE");

        }
        private void Presupuesto_Load(object sender, EventArgs e)
        {
            txt_NombrePresupuesto.Text = sNombre; //Cambiar
            MessageBox.Show(Convert.ToString(iIdPresupuesto)); //Bandera
            //Operacion
            switch (sOperacion)
            {
                case "crear":
                    CargarCuentasNuevas();
                    control.GuardarPresupuesto(iIdPresupuesto, Dgv_presupuesto);
                    control.ActualizarTblPresupuesto(iIdPresupuesto);
                    MessageBox.Show("Crear");
                    break;
                case "modificar":
                    CargarDetalles(iIdPresupuesto);
                    MessageBox.Show("Modificar");
                    break;
                case "ver":
                    CargarDetalles(iIdPresupuesto);
                    BloquearTextBox();
                    BloquearBotones();
                    Txtbx_anual.Enabled = false;

                    break;
                case "crearPlantilla":
                    CargarDetalles(idPrepLlenado);
                    control.GuardarPresupuesto(iIdPresupuesto, Dgv_presupuesto);
                    control.ActualizarTblPresupuesto(iIdPresupuesto);
                    break;
            }
            //Llenado
            switch (sLlenado)
            {
                case "Mensual":
                    Txtbx_anual.Enabled = false;
                    frmIncremento.sLlenado = this.sLlenado;
                    break;
                case "Anual":
                    BloquearTextBox();
                    frmIncremento.sLlenado = this.sLlenado;
                    Btn_ajustar.Visible = true; //Cambiar O nome
                    break;
            }

            //Todo
            try
            {
                SumarColumna("Column3", txt_totalEnero);
                SumarColumna("Column4", txt_totalFebrero);
                SumarColumna("Column5", txt_totalMarzo);
                SumarColumna("Column6", txt_totalAbril);
                SumarColumna("Column7", txt_totalMayo);
                SumarColumna("Column8", txt_totalJunio);
                SumarColumna("Column9", txt_totalJulio);
                SumarColumna("Column10", txt_totalAgosto);
                SumarColumna("Column11", txt_totalSeptiembre);
                SumarColumna("Column12", txt_totalOctubre);
                SumarColumna("Column13", txt_totalNoviembre);
                SumarColumna("Column14", txt_totalDiciembre);
                SumarColumna("Column15", txt_totalAnual);// Reemplaza con la columna y label 
            }
            catch { }

            if (Dgv_presupuesto.Rows.Count > 0)
            {
                CargarFila(0);
            }

        }
        private void BloquearBotones()
        {
            Btn_ajustar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Btn_incremento.Enabled = false;
            Btn_Informe.Enabled = false;
            Btn_modificar.Enabled = false;
        }
        private void BloquearTextBox()
        {
            Txtbx_enero.Enabled = false;
            Txtbx_febrero.Enabled = false;
            Txtbx_marzo.Enabled = false;
            Txtbx_abril.Enabled = false;
            Txtbx_mayo.Enabled = false;
            Txtbx_junio.Enabled = false;
            Txtbx_julio.Enabled = false;
            Txtbx_agosto.Enabled = false;
            Txtbx_septiembre.Enabled = false;
            Txtbx_octubre.Enabled = false;
            Txtbx_noviembre.Enabled = false;
            Txtbx_diciembre.Enabled = false;
        }
        private void CargarDetalles(int iIdPresupuesto)
        {
            foreach (DataRow drFila in control.CargarDetallesPresupuesto(iIdPresupuesto).Rows)
            {
                Dgv_presupuesto.Rows.Add(
                    drFila["Fk_id_cuenta"],
                    drFila["nombre_cuenta"],
                    drFila["mes_enero"],
                    drFila["mes_febrero"],
                    drFila["mes_marzo"],
                    drFila["mes_abril"],
                    drFila["mes_mayo"],
                    drFila["mes_junio"],
                    drFila["mes_julio"],
                    drFila["mes_agosto"],
                    drFila["mes_septiembre"],
                    drFila["mes_octubre"],
                    drFila["mes_noviembre"],
                    drFila["mes_diciembre"],
                    drFila["total_cuenta"]
                    );
            }
        }

        private void CargarCuentasNuevas()
        {
            // Agregar cada dato a la columna 'Column1'
            foreach (DataRow drFila in control.ObtenerCuentasNuevo().Rows)
            {
                // Creamos un array de objetos para la nueva fila
                object[] oNuevaFila = new object[15]; // 1 para ID, 1 para nombre, y 13 para 0.00

                oNuevaFila[0] = drFila["Pk_id_cuenta"]; // Columna 1: ID
                oNuevaFila[1] = drFila["nombre_cuenta"]; // Columna 2: Nombre

                // Llenamos las 13 columnas restantes con 0.00
                for (int i = 2; i < oNuevaFila.Length; i++)
                {
                    oNuevaFila[i] = 0.00m; // Valor para las columnas restantes
                }
                // Agregamos la fila al DataGridView
                Dgv_presupuesto.Rows.Add(oNuevaFila);
            }
        }
        private void ConfigurarColumnas()
        {
            Dgv_presupuesto.Columns["Column1"].ReadOnly = true;
            Dgv_presupuesto.Columns["Column2"].ReadOnly = true;
            Dgv_presupuesto.Columns["Column3"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column4"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column5"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column6"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column7"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column8"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column9"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column10"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column11"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column12"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column13"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column14"].ValueType = typeof(decimal);
            Dgv_presupuesto.Columns["Column15"].ValueType = typeof(decimal);

            for (int i = 2; i < Dgv_presupuesto.Columns.Count; i++)
            {
                Dgv_presupuesto.Columns[i].DefaultCellStyle.Format = "F2"; // Formato a dos decimales
            }

            Dgv_presupuesto.Columns["Column15"].DefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void Dgv_presupuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow DgvrFilaSeleccionada = Dgv_presupuesto.CurrentRow;
                Txtbx_Cuenta.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column1"].Value);
                Txtbx_Descripcion.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column2"].Value);
                Txtbx_enero.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column3"].Value);
                Txtbx_febrero.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column4"].Value);
                Txtbx_marzo.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column5"].Value);
                Txtbx_abril.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column6"].Value);
                Txtbx_mayo.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column7"].Value);
                Txtbx_junio.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column8"].Value);
                Txtbx_julio.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column9"].Value);
                Txtbx_agosto.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column10"].Value);
                Txtbx_septiembre.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column11"].Value);
                Txtbx_octubre.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column12"].Value);
                Txtbx_noviembre.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column13"].Value);
                Txtbx_diciembre.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column14"].Value);
                Txtbx_anual.Text = Convert.ToString(DgvrFilaSeleccionada.Cells["Column15"].Value);
            }
            catch { }//Agregar
        }

        private void Dgv_presupuesto_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void SumaDeValores()
        {
            decimal deSuma = 0;

            try
            {
                deSuma += Convert.ToDecimal(Txtbx_enero.Text);
                deSuma += Convert.ToDecimal(Txtbx_febrero.Text);
                deSuma += Convert.ToDecimal(Txtbx_marzo.Text);
                deSuma += Convert.ToDecimal(Txtbx_abril.Text);
                deSuma += Convert.ToDecimal(Txtbx_mayo.Text);
                deSuma += Convert.ToDecimal(Txtbx_junio.Text);
                deSuma += Convert.ToDecimal(Txtbx_julio.Text);
                deSuma += Convert.ToDecimal(Txtbx_agosto.Text);
                deSuma += Convert.ToDecimal(Txtbx_septiembre.Text);
                deSuma += Convert.ToDecimal(Txtbx_octubre.Text);
                deSuma += Convert.ToDecimal(Txtbx_noviembre.Text);
                deSuma += Convert.ToDecimal(Txtbx_diciembre.Text);

                deSuma = Math.Round(deSuma, 2);

                Txtbx_anual.Text = deSuma.ToString("F2");
            }
            catch (FormatException)
            {
                //MessageBox.Show("Asegúrate de ingresar solo valores numéricos.", "Error de Formato");
            }

        }
        private void CambioDinamico(string sColumna, TextBox tbTextxbox)
        {
            try
            {
                DataGridViewRow DgvrFilaSeleccionada = Dgv_presupuesto.CurrentRow;
                //filaSeleccionada.Cells[sColumna].Value = tbTextxbox.Text; // Actualiza la celda correspondiente
                try
                {
                    DgvrFilaSeleccionada.Cells[sColumna].Value = Math.Round(Convert.ToDecimal(tbTextxbox.Text), 2);
                }
                catch (FormatException) { }
            }
            catch { }
        }

        private void Txtbx_enero_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column3", Txtbx_enero);
            VerificacionVacio(Txtbx_enero);
            SumaDeValores();
        }
        private void Txtbx_febrero_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column4", Txtbx_febrero);
            VerificacionVacio(Txtbx_febrero);
            SumaDeValores();
        }
        private void Txtbx_marzo_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column5", Txtbx_marzo);
            VerificacionVacio(Txtbx_marzo);
            SumaDeValores();
        }

        private void Txtbx_abril_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column6", Txtbx_abril);
            VerificacionVacio(Txtbx_abril);
            SumaDeValores();
        }

        private void Txtbx_mayo_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column7", Txtbx_mayo);
            VerificacionVacio(Txtbx_mayo);
            SumaDeValores();
        }

        private void Txtbx_junio_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column8", Txtbx_junio);
            VerificacionVacio(Txtbx_junio);
            SumaDeValores();
        }

        private void Txtbx_julio_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column9", Txtbx_julio);
            VerificacionVacio(Txtbx_julio);
            SumaDeValores();
        }

        private void Txtbx_agosto_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column10", Txtbx_agosto);
            VerificacionVacio(Txtbx_agosto);
            SumaDeValores();
        }

        private void Txtbx_septiembre_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column11", Txtbx_septiembre);
            VerificacionVacio(Txtbx_septiembre);
            SumaDeValores();
        }

        private void Txtbx_octubre_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column12", Txtbx_octubre);
            SumaDeValores();
        }

        private void Txtbx_noviembre_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column13", Txtbx_noviembre);
            VerificacionVacio(Txtbx_noviembre);
            SumaDeValores();
        }

        private void Txtbx_diciembre_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column14", Txtbx_diciembre);
            VerificacionVacio(Txtbx_diciembre);
            SumaDeValores();
        }

        private void Txtbx_anual_TextChanged(object sender, EventArgs e)
        {
            CambioDinamico("Column15", Txtbx_anual);
            VerificacionVacio(Txtbx_anual);
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            control.ActualizarPresupuesto(iIdPresupuesto, Dgv_presupuesto);
            MessageBox.Show("Datos guardados exitosamente.", "Éxito");

            control.ActualizarTblPresupuesto(iIdPresupuesto);
            MessageBox.Show("Datos Actualizados exitosamente.", "Éxito");
        }

        private void SumarColumna(string sNombreColumna, Label txtResultado)
        {
            decimal deSuma = 0;

            foreach (DataGridViewRow DgvrFila in Dgv_presupuesto.Rows)
            {
                if (DgvrFila.Cells[sNombreColumna].Value != null &&
                    decimal.TryParse(DgvrFila.Cells[sNombreColumna].Value.ToString(), out decimal deValor))
                {
                    deSuma += deValor;
                }
            }
            txtResultado.Text = $"{deSuma}";
        }

        private void Dgv_presupuesto_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Reemplaza con la columna y label 
                SumarColumna("Column3", txt_totalEnero);
                SumarColumna("Column4", txt_totalFebrero);
                SumarColumna("Column5", txt_totalMarzo);
                SumarColumna("Column6", txt_totalAbril);
                SumarColumna("Column7", txt_totalMayo);
                SumarColumna("Column8", txt_totalJunio);
                SumarColumna("Column9", txt_totalJulio);
                SumarColumna("Column10", txt_totalAgosto);
                SumarColumna("Column11", txt_totalSeptiembre);
                SumarColumna("Column12", txt_totalOctubre);
                SumarColumna("Column13", txt_totalNoviembre);
                SumarColumna("Column14", txt_totalDiciembre);
                SumarColumna("Column15", txt_totalAnual);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Obtener el valor del presupuesto anual y convertirlo a decimal
            decimal dePresupuestoAnual;

            if (decimal.TryParse(Txtbx_anual.Text, out dePresupuestoAnual))
            {
                // Dividir el presupuesto anual entre 12
                decimal deMontoMensual = dePresupuestoAnual / 12;

                // Asignar el monto mensual a los 12 TextBox
                Txtbx_enero.Text = deMontoMensual.ToString("F2");
                Txtbx_febrero.Text = deMontoMensual.ToString("F2");
                Txtbx_marzo.Text = deMontoMensual.ToString("F2");
                Txtbx_abril.Text = deMontoMensual.ToString("F2");
                Txtbx_mayo.Text = deMontoMensual.ToString("F2");
                Txtbx_junio.Text = deMontoMensual.ToString("F2");
                Txtbx_julio.Text = deMontoMensual.ToString("F2");
                Txtbx_agosto.Text = deMontoMensual.ToString("F2");
                Txtbx_septiembre.Text = deMontoMensual.ToString("F2");
                Txtbx_octubre.Text = deMontoMensual.ToString("F2");
                Txtbx_noviembre.Text = deMontoMensual.ToString("F2");
                Txtbx_diciembre.Text = deMontoMensual.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido en el presupuesto anual.");
            }
        }

        private void Btn_incremento_Click(object sender, EventArgs e)
        {
            var vResultado = frmIncremento.ShowDialog();
            if (vResultado == DialogResult.OK)
            {
                decimal dePorcentaje = Convert.ToDecimal(frmIncremento.iDato);

                if (frmIncremento.bIncrementar)
                {
                    IncrementarTodosLosMeses(dePorcentaje);
                }
                else if (frmIncremento.bAnual)
                {
                    IncrementarAnual(dePorcentaje);
                }
                else
                {
                    IncrementarMesEspecifico(dePorcentaje, frmIncremento.sMesSelec);
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }

        //Incremento de Meses IDK
        private void IncrementarAnual(decimal dePorcentaje)
        {
            decimal deValorAnual = Convert.ToDecimal(Txtbx_anual.Text);

            // Calcular el incremento
            decimal deIncremento = deValorAnual * (dePorcentaje / 100);
            Txtbx_anual.Text = (deValorAnual + deIncremento).ToString("F2");
            MessageBox.Show("Porfavor , ajustar el valor anual de la cuenta. ","Consejo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void IncrementarTodosLosMeses(decimal dePorcentaje)
        {
            foreach (var vMes in ObtenerTextBoxesDeMeses())
            {
                decimal deValorActual = Convert.ToDecimal(vMes.Text);
                decimal deIncremento = deValorActual * (dePorcentaje / 100);
                vMes.Text = (deValorActual + deIncremento).ToString("F2");
            }
        }

        private void IncrementarMesEspecifico(decimal dePorcentaje, string sNombreMes)
        {
            TextBox txtMesSeleccionado = ObtenerTextBoxPorNombre(sNombreMes);

            if (txtMesSeleccionado != null)
            {
                decimal deValorActual = Convert.ToDecimal(txtMesSeleccionado.Text);
                decimal deIncremento = deValorActual * (dePorcentaje / 100);
                txtMesSeleccionado.Text = (deValorActual + deIncremento).ToString("F2");
            }
        }

        private List<TextBox> ObtenerTextBoxesDeMeses()
        {
            return new List<TextBox>
            {
                Txtbx_enero, Txtbx_febrero, Txtbx_marzo, Txtbx_abril,Txtbx_mayo, Txtbx_junio, Txtbx_julio, Txtbx_agosto,Txtbx_septiembre, Txtbx_octubre, Txtbx_noviembre, Txtbx_diciembre
            };
        }

        private TextBox ObtenerTextBoxPorNombre(string sNombreMes)
        {
            string sNombreTextBox = $"Txtbx_{sNombreMes.ToLower()}";
            return ObtenerTextBoxesDeMeses().FirstOrDefault(txt => txt.Name == sNombreTextBox);
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult diaResultado = MessageBox.Show("¿Está seguro de que desea eliminar este presupuesto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (diaResultado == DialogResult.Yes)
            {
                // Llama al método del controlador para eliminar el presupuesto

                control.EliminarPresupuesto(iIdPresupuesto);


                // Notificar al usuario que la eliminación fue exitosa
                MessageBox.Show("Presupuesto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //this.Hide();
                //Opciones opciones = new Opciones();
                //opciones.Show();

                Opciones opciones = new Opciones();
                opciones.Show();
                this.Close();

                // Actualiza la interfaz
                // ActualizaDataGridView();
            }
            else
            {
                // El usuario decidió no eliminar, puedes mostrar un mensaje opcional
                MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_totalEnero_Click(object sender, EventArgs e)
        {

        }

        private void CargarFila(int iFila)
        {
            try { 
                if (iFila >= 0 && iFila < Dgv_presupuesto.Rows.Count)
                    {
                Txtbx_Cuenta.Text = Dgv_presupuesto.Rows[iFila].Cells["Column1"].Value.ToString();
                Txtbx_Descripcion.Text = Dgv_presupuesto.Rows[iFila].Cells["Column2"].Value.ToString();
                Txtbx_enero.Text = Dgv_presupuesto.Rows[iFila].Cells["Column3"].Value.ToString();
                Txtbx_febrero.Text = Dgv_presupuesto.Rows[iFila].Cells["Column4"].Value.ToString();
                Txtbx_marzo.Text = Dgv_presupuesto.Rows[iFila].Cells["Column5"].Value.ToString();
                Txtbx_abril.Text = Dgv_presupuesto.Rows[iFila].Cells["Column6"].Value.ToString();
                Txtbx_mayo.Text = Dgv_presupuesto.Rows[iFila].Cells["Column7"].Value.ToString();
                Txtbx_junio.Text = Dgv_presupuesto.Rows[iFila].Cells["Column8"].Value.ToString();
                Txtbx_julio.Text = Dgv_presupuesto.Rows[iFila].Cells["Column9"].Value.ToString();
                Txtbx_agosto.Text = Dgv_presupuesto.Rows[iFila].Cells["Column10"].Value.ToString();
                Txtbx_septiembre.Text = Dgv_presupuesto.Rows[iFila].Cells["Column11"].Value.ToString();
                Txtbx_octubre.Text = Dgv_presupuesto.Rows[iFila].Cells["Column12"].Value.ToString();
                Txtbx_noviembre.Text = Dgv_presupuesto.Rows[iFila].Cells["Column13"].Value.ToString();
                Txtbx_diciembre.Text = Dgv_presupuesto.Rows[iFila].Cells["Column14"].Value.ToString();
                Txtbx_anual.Text = Dgv_presupuesto.Rows[iFila].Cells["Column15"].Value.ToString();
                    }
            }catch{}
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Opciones opciones = new Opciones();
            opciones.Show();
            this.Close();
        }

        private void VerificacionText(KeyPressEventArgs e, TextBox tbTexto)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Cancela el evento si la entrada no es válida
            }
            if (e.KeyChar == '.' && tbTexto.Text.Contains("."))
            {
                e.Handled = true; // Cancelar si ya hay un punto
            }

        }

        private void VerificacionVacio(TextBox tbTexto)
        {
            if (string.IsNullOrWhiteSpace(tbTexto.Text))
            {
                tbTexto.Text = "0.00"; // Asignar 0 si está vacío
                tbTexto.SelectionStart = 0;
                tbTexto.SelectionLength = tbTexto.Text.Length;// Coloca el cursor al final
            }
        }

        private void Txtbx_enero_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e,Txtbx_enero);
        }

        private void Txtbx_febrero_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txtbx_febrero);
        }

        private void Txtbx_marzo_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txtbx_marzo);
        }

        private void Txtbx_abril_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txtbx_abril);
        }

        private void Txtbx_mayo_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txtbx_mayo);
        }

        private void Txtbx_junio_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txtbx_junio);
        }

        private void Txtbx_julio_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txtbx_julio);
        }

        private void Txtbx_agosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txtbx_agosto);
        }

        private void Txtbx_septiembre_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txtbx_septiembre);
        }

        private void Txtbx_octubre_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txtbx_octubre);
        }

        private void Txtbx_noviembre_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txtbx_noviembre);
        }

        private void Txtbx_diciembre_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txtbx_diciembre);
        }

        private void Txtbx_anual_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificacionText(e, Txtbx_anual);
        }
    }
}
