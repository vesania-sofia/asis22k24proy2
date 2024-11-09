
namespace Capa_Vista_OrdenCompra
{
    partial class frm_generarOrdenParaCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_CostoC = new System.Windows.Forms.TextBox();
            this.Cbo_ProDetOrCom = new System.Windows.Forms.ComboBox();
            this.Txt_Cantidad_DetOrCom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_roveedor2 = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_agregarDet = new System.Windows.Forms.Button();
            this.Btn_eliminarDet = new System.Windows.Forms.Button();
            this.Cbo_proveedor = new System.Windows.Forms.ComboBox();
            this.dateTime_enc = new System.Windows.Forms.DateTimePicker();
            this.Txt_no_orCom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_proveedor1 = new System.Windows.Forms.Label();
            this.Dgv_ordenesGenerar = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Btn_cancelarEncDet = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_salirOC = new System.Windows.Forms.Button();
            this.Btn_actualizarDET = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ordenesGenerar)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(441, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 32);
            this.label10.TabIndex = 15;
            this.label10.Text = "Orden de Compras";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Precio Unitario";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Txt_CostoC
            // 
            this.Txt_CostoC.Location = new System.Drawing.Point(215, 66);
            this.Txt_CostoC.Name = "Txt_CostoC";
            this.Txt_CostoC.Size = new System.Drawing.Size(145, 26);
            this.Txt_CostoC.TabIndex = 14;
            // 
            // Cbo_ProDetOrCom
            // 
            this.Cbo_ProDetOrCom.FormattingEnabled = true;
            this.Cbo_ProDetOrCom.Location = new System.Drawing.Point(64, 66);
            this.Cbo_ProDetOrCom.Name = "Cbo_ProDetOrCom";
            this.Cbo_ProDetOrCom.Size = new System.Drawing.Size(145, 28);
            this.Cbo_ProDetOrCom.TabIndex = 9;
            this.Cbo_ProDetOrCom.SelectedIndexChanged += new System.EventHandler(this.Cbo_ProDetOrCom_SelectedIndexChanged);
            // 
            // Txt_Cantidad_DetOrCom
            // 
            this.Txt_Cantidad_DetOrCom.Location = new System.Drawing.Point(366, 66);
            this.Txt_Cantidad_DetOrCom.Name = "Txt_Cantidad_DetOrCom";
            this.Txt_Cantidad_DetOrCom.Size = new System.Drawing.Size(145, 26);
            this.Txt_Cantidad_DetOrCom.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Código Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cantidad";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.Txt_roveedor2);
            this.groupBox1.Controls.Add(this.Txt_nombre);
            this.groupBox1.Controls.Add(this.Txt_id);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Cbo_proveedor);
            this.groupBox1.Controls.Add(this.dateTime_enc);
            this.groupBox1.Controls.Add(this.Txt_no_orCom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_proveedor1);
            this.groupBox1.Location = new System.Drawing.Point(21, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 308);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado ";
            // 
            // Txt_roveedor2
            // 
            this.Txt_roveedor2.AutoSize = true;
            this.Txt_roveedor2.Location = new System.Drawing.Point(400, 23);
            this.Txt_roveedor2.Name = "Txt_roveedor2";
            this.Txt_roveedor2.Size = new System.Drawing.Size(85, 20);
            this.Txt_roveedor2.TabIndex = 19;
            this.Txt_roveedor2.Text = "Proveedor:";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(362, 46);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(251, 26);
            this.Txt_nombre.TabIndex = 18;
            // 
            // Txt_id
            // 
            this.Txt_id.Location = new System.Drawing.Point(297, 46);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(66, 26);
            this.Txt_id.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_agregarDet);
            this.groupBox2.Controls.Add(this.Btn_eliminarDet);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Txt_CostoC);
            this.groupBox2.Controls.Add(this.Txt_Cantidad_DetOrCom);
            this.groupBox2.Controls.Add(this.Cbo_ProDetOrCom);
            this.groupBox2.Location = new System.Drawing.Point(63, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(909, 130);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // Btn_agregarDet
            // 
            this.Btn_agregarDet.BackColor = System.Drawing.Color.Khaki;
            this.Btn_agregarDet.FlatAppearance.BorderSize = 0;
            this.Btn_agregarDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregarDet.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.agregar;
            this.Btn_agregarDet.Location = new System.Drawing.Point(616, 26);
            this.Btn_agregarDet.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_agregarDet.Name = "Btn_agregarDet";
            this.Btn_agregarDet.Size = new System.Drawing.Size(77, 81);
            this.Btn_agregarDet.TabIndex = 237;
            this.Btn_agregarDet.UseVisualStyleBackColor = false;
            this.Btn_agregarDet.Click += new System.EventHandler(this.Btn_agregarDet_Click);
            // 
            // Btn_eliminarDet
            // 
            this.Btn_eliminarDet.BackColor = System.Drawing.Color.Transparent;
            this.Btn_eliminarDet.FlatAppearance.BorderSize = 0;
            this.Btn_eliminarDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminarDet.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.eliminar;
            this.Btn_eliminarDet.Location = new System.Drawing.Point(727, 26);
            this.Btn_eliminarDet.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminarDet.Name = "Btn_eliminarDet";
            this.Btn_eliminarDet.Size = new System.Drawing.Size(77, 81);
            this.Btn_eliminarDet.TabIndex = 237;
            this.Btn_eliminarDet.UseVisualStyleBackColor = false;
            this.Btn_eliminarDet.Click += new System.EventHandler(this.Btn_eliminarDet_Click);
            // 
            // Cbo_proveedor
            // 
            this.Cbo_proveedor.FormattingEnabled = true;
            this.Cbo_proveedor.Location = new System.Drawing.Point(404, 46);
            this.Cbo_proveedor.Name = "Cbo_proveedor";
            this.Cbo_proveedor.Size = new System.Drawing.Size(196, 28);
            this.Cbo_proveedor.TabIndex = 10;
            this.Cbo_proveedor.SelectedIndexChanged += new System.EventHandler(this.Cbo_proveedor_SelectedIndexChanged);
            // 
            // dateTime_enc
            // 
            this.dateTime_enc.Location = new System.Drawing.Point(692, 46);
            this.dateTime_enc.Name = "dateTime_enc";
            this.dateTime_enc.Size = new System.Drawing.Size(322, 26);
            this.dateTime_enc.TabIndex = 9;
            // 
            // Txt_no_orCom
            // 
            this.Txt_no_orCom.Location = new System.Drawing.Point(172, 48);
            this.Txt_no_orCom.Name = "Txt_no_orCom";
            this.Txt_no_orCom.Size = new System.Drawing.Size(100, 26);
            this.Txt_no_orCom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de Orden:";
            // 
            // Txt_proveedor1
            // 
            this.Txt_proveedor1.AutoSize = true;
            this.Txt_proveedor1.Location = new System.Drawing.Point(313, 49);
            this.Txt_proveedor1.Name = "Txt_proveedor1";
            this.Txt_proveedor1.Size = new System.Drawing.Size(85, 20);
            this.Txt_proveedor1.TabIndex = 0;
            this.Txt_proveedor1.Text = "Proveedor:";
            // 
            // Dgv_ordenesGenerar
            // 
            this.Dgv_ordenesGenerar.AllowUserToAddRows = false;
            this.Dgv_ordenesGenerar.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_ordenesGenerar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ordenesGenerar.Location = new System.Drawing.Point(21, 422);
            this.Dgv_ordenesGenerar.Name = "Dgv_ordenesGenerar";
            this.Dgv_ordenesGenerar.RowHeadersWidth = 62;
            this.Dgv_ordenesGenerar.RowTemplate.Height = 28;
            this.Dgv_ordenesGenerar.Size = new System.Drawing.Size(756, 285);
            this.Dgv_ordenesGenerar.TabIndex = 32;
            this.Dgv_ordenesGenerar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ordenesGenerar_CellContentClick);
            this.Dgv_ordenesGenerar.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dgv_ordenesGenerar_CellPainting);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 738);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "TOTAL: ";
            // 
            // Txt_Total
            // 
            this.Txt_Total.Location = new System.Drawing.Point(632, 732);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(145, 26);
            this.Txt_Total.TabIndex = 16;
            this.Txt_Total.TextChanged += new System.EventHandler(this.Txt_Total_TextChanged);
            // 
            // Btn_cancelarEncDet
            // 
            this.Btn_cancelarEncDet.BackColor = System.Drawing.Color.Transparent;
            this.Btn_cancelarEncDet.FlatAppearance.BorderSize = 0;
            this.Btn_cancelarEncDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelarEncDet.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.cancelar;
            this.Btn_cancelarEncDet.Location = new System.Drawing.Point(969, 511);
            this.Btn_cancelarEncDet.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cancelarEncDet.Name = "Btn_cancelarEncDet";
            this.Btn_cancelarEncDet.Size = new System.Drawing.Size(78, 77);
            this.Btn_cancelarEncDet.TabIndex = 236;
            this.Btn_cancelarEncDet.UseVisualStyleBackColor = false;
            this.Btn_cancelarEncDet.Click += new System.EventHandler(this.Btn_cancelarEncDet_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.guardar;
            this.Btn_guardar.Location = new System.Drawing.Point(883, 511);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(78, 77);
            this.Btn_guardar.TabIndex = 235;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_salirOC
            // 
            this.Btn_salirOC.BackColor = System.Drawing.Color.Transparent;
            this.Btn_salirOC.FlatAppearance.BorderSize = 0;
            this.Btn_salirOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salirOC.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.salir;
            this.Btn_salirOC.Location = new System.Drawing.Point(939, 707);
            this.Btn_salirOC.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_salirOC.Name = "Btn_salirOC";
            this.Btn_salirOC.Size = new System.Drawing.Size(78, 77);
            this.Btn_salirOC.TabIndex = 237;
            this.Btn_salirOC.UseVisualStyleBackColor = false;
            this.Btn_salirOC.Click += new System.EventHandler(this.Btn_salirOC_Click);
            // 
            // Btn_actualizarDET
            // 
            this.Btn_actualizarDET.BackColor = System.Drawing.Color.Transparent;
            this.Btn_actualizarDET.FlatAppearance.BorderSize = 0;
            this.Btn_actualizarDET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizarDET.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.actualizar;
            this.Btn_actualizarDET.Location = new System.Drawing.Point(797, 511);
            this.Btn_actualizarDET.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_actualizarDET.Name = "Btn_actualizarDET";
            this.Btn_actualizarDET.Size = new System.Drawing.Size(78, 77);
            this.Btn_actualizarDET.TabIndex = 238;
            this.Btn_actualizarDET.UseVisualStyleBackColor = false;
            this.Btn_actualizarDET.Click += new System.EventHandler(this.Btn_actualizarDET_Click_1);
            // 
            // frm_generarOrdenParaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1070, 797);
            this.Controls.Add(this.Btn_actualizarDET);
            this.Controls.Add(this.Btn_salirOC);
            this.Controls.Add(this.Btn_cancelarEncDet);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dgv_ordenesGenerar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_generarOrdenParaCompra";
            this.Text = "frm_generarOrdenParaCompra";
            this.Load += new System.EventHandler(this.frm_generarOrdenParaCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ordenesGenerar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Cbo_ProDetOrCom;
        private System.Windows.Forms.TextBox Txt_Cantidad_DetOrCom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTime_enc;
        private System.Windows.Forms.TextBox Txt_no_orCom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Txt_proveedor1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_CostoC;
        private System.Windows.Forms.DataGridView Dgv_ordenesGenerar;
        private System.Windows.Forms.ComboBox Cbo_proveedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelarEncDet;
        private System.Windows.Forms.Button Btn_eliminarDet;
        private System.Windows.Forms.Button Btn_agregarDet;
        private System.Windows.Forms.Button Btn_salirOC;
        private System.Windows.Forms.Button Btn_actualizarDET;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label Txt_roveedor2;
    }
}