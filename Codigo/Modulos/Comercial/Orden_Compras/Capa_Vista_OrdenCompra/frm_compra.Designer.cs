
namespace Capa_Vista_OrdenCompra
{
    partial class frm_compra
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
            this.Btn_cancearEncDet = new System.Windows.Forms.Button();
            this.Btn_guardarEcnDet = new System.Windows.Forms.Button();
            this.Dgv_ordenesGenerar = new System.Windows.Forms.DataGridView();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Txt_stock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Txt_roveedor2 = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.Btn_reporteOC = new System.Windows.Forms.Button();
            this.Btn_salirOC = new System.Windows.Forms.Button();
            this.Btn_ayudaOC = new System.Windows.Forms.Button();
            this.dateTime_enc = new System.Windows.Forms.DateTimePicker();
            this.Btn_generarOrden = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ordenesGenerar)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(395, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 32);
            this.label10.TabIndex = 30;
            this.label10.Text = "Compras";
            // 
            // Btn_cancearEncDet
            // 
            this.Btn_cancearEncDet.BackColor = System.Drawing.Color.Transparent;
            this.Btn_cancearEncDet.FlatAppearance.BorderSize = 0;
            this.Btn_cancearEncDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancearEncDet.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.cancelar;
            this.Btn_cancearEncDet.Location = new System.Drawing.Point(501, 86);
            this.Btn_cancearEncDet.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cancearEncDet.Name = "Btn_cancearEncDet";
            this.Btn_cancearEncDet.Size = new System.Drawing.Size(78, 77);
            this.Btn_cancearEncDet.TabIndex = 238;
            this.Btn_cancearEncDet.UseVisualStyleBackColor = false;
            this.Btn_cancearEncDet.Click += new System.EventHandler(this.Btn_cancearEncDet_Click);
            // 
            // Btn_guardarEcnDet
            // 
            this.Btn_guardarEcnDet.BackColor = System.Drawing.Color.Transparent;
            this.Btn_guardarEcnDet.FlatAppearance.BorderSize = 0;
            this.Btn_guardarEcnDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardarEcnDet.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.guardar;
            this.Btn_guardarEcnDet.Location = new System.Drawing.Point(415, 86);
            this.Btn_guardarEcnDet.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardarEcnDet.Name = "Btn_guardarEcnDet";
            this.Btn_guardarEcnDet.Size = new System.Drawing.Size(78, 77);
            this.Btn_guardarEcnDet.TabIndex = 237;
            this.Btn_guardarEcnDet.UseVisualStyleBackColor = false;
            this.Btn_guardarEcnDet.Click += new System.EventHandler(this.Btn_guardarEcnDet_Click);
            // 
            // Dgv_ordenesGenerar
            // 
            this.Dgv_ordenesGenerar.AllowUserToAddRows = false;
            this.Dgv_ordenesGenerar.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_ordenesGenerar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ordenesGenerar.Location = new System.Drawing.Point(46, 268);
            this.Dgv_ordenesGenerar.Name = "Dgv_ordenesGenerar";
            this.Dgv_ordenesGenerar.RowHeadersWidth = 62;
            this.Dgv_ordenesGenerar.RowTemplate.Height = 28;
            this.Dgv_ordenesGenerar.Size = new System.Drawing.Size(815, 285);
            this.Dgv_ordenesGenerar.TabIndex = 239;
            this.Dgv_ordenesGenerar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ordenesGenerar_CellClick);
            this.Dgv_ordenesGenerar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ordenesGenerar_CellContentClick);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_buscar.FlatAppearance.BorderSize = 0;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.buscar;
            this.Btn_buscar.Location = new System.Drawing.Point(315, 86);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(78, 77);
            this.Btn_buscar.TabIndex = 240;
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(46, 111);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(262, 26);
            this.Txt_buscar.TabIndex = 241;
            // 
            // Txt_stock
            // 
            this.Txt_stock.Location = new System.Drawing.Point(741, 227);
            this.Txt_stock.Name = "Txt_stock";
            this.Txt_stock.Size = new System.Drawing.Size(120, 26);
            this.Txt_stock.TabIndex = 242;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 243;
            this.label1.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 247;
            this.label3.Text = "Fecha Entrega";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 572);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 249;
            this.label4.Text = "Total";
            // 
            // Txt_Total
            // 
            this.Txt_Total.Location = new System.Drawing.Point(741, 566);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(120, 26);
            this.Txt_Total.TabIndex = 248;
            // 
            // Txt_roveedor2
            // 
            this.Txt_roveedor2.AutoSize = true;
            this.Txt_roveedor2.Location = new System.Drawing.Point(142, 201);
            this.Txt_roveedor2.Name = "Txt_roveedor2";
            this.Txt_roveedor2.Size = new System.Drawing.Size(85, 20);
            this.Txt_roveedor2.TabIndex = 255;
            this.Txt_roveedor2.Text = "Proveedor:";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(104, 224);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(251, 26);
            this.Txt_nombre.TabIndex = 254;
            // 
            // Txt_id
            // 
            this.Txt_id.Location = new System.Drawing.Point(39, 224);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(66, 26);
            this.Txt_id.TabIndex = 253;
            // 
            // Btn_reporteOC
            // 
            this.Btn_reporteOC.BackColor = System.Drawing.Color.Transparent;
            this.Btn_reporteOC.FlatAppearance.BorderSize = 0;
            this.Btn_reporteOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reporteOC.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.reporte;
            this.Btn_reporteOC.Location = new System.Drawing.Point(587, 82);
            this.Btn_reporteOC.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_reporteOC.Name = "Btn_reporteOC";
            this.Btn_reporteOC.Size = new System.Drawing.Size(77, 81);
            this.Btn_reporteOC.TabIndex = 258;
            this.Btn_reporteOC.UseVisualStyleBackColor = false;
            // 
            // Btn_salirOC
            // 
            this.Btn_salirOC.BackColor = System.Drawing.Color.Transparent;
            this.Btn_salirOC.FlatAppearance.BorderSize = 0;
            this.Btn_salirOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salirOC.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.salir;
            this.Btn_salirOC.Location = new System.Drawing.Point(768, 82);
            this.Btn_salirOC.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_salirOC.Name = "Btn_salirOC";
            this.Btn_salirOC.Size = new System.Drawing.Size(77, 81);
            this.Btn_salirOC.TabIndex = 257;
            this.Btn_salirOC.UseVisualStyleBackColor = false;
            this.Btn_salirOC.Click += new System.EventHandler(this.Btn_salirOC_Click);
            // 
            // Btn_ayudaOC
            // 
            this.Btn_ayudaOC.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ayudaOC.FlatAppearance.BorderSize = 0;
            this.Btn_ayudaOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayudaOC.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.ayuda;
            this.Btn_ayudaOC.Location = new System.Drawing.Point(672, 82);
            this.Btn_ayudaOC.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ayudaOC.Name = "Btn_ayudaOC";
            this.Btn_ayudaOC.Size = new System.Drawing.Size(77, 81);
            this.Btn_ayudaOC.TabIndex = 256;
            this.Btn_ayudaOC.UseVisualStyleBackColor = false;
            // 
            // dateTime_enc
            // 
            this.dateTime_enc.Location = new System.Drawing.Point(377, 224);
            this.dateTime_enc.Name = "dateTime_enc";
            this.dateTime_enc.Size = new System.Drawing.Size(322, 26);
            this.dateTime_enc.TabIndex = 259;
            // 
            // Btn_generarOrden
            // 
            this.Btn_generarOrden.Location = new System.Drawing.Point(39, 592);
            this.Btn_generarOrden.Name = "Btn_generarOrden";
            this.Btn_generarOrden.Size = new System.Drawing.Size(269, 38);
            this.Btn_generarOrden.TabIndex = 260;
            this.Btn_generarOrden.Text = "Generar Orden De Compra";
            this.Btn_generarOrden.UseVisualStyleBackColor = true;
            this.Btn_generarOrden.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(933, 668);
            this.Controls.Add(this.Btn_generarOrden);
            this.Controls.Add(this.dateTime_enc);
            this.Controls.Add(this.Btn_reporteOC);
            this.Controls.Add(this.Btn_salirOC);
            this.Controls.Add(this.Btn_ayudaOC);
            this.Controls.Add(this.Txt_roveedor2);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.Txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_stock);
            this.Controls.Add(this.Txt_buscar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Dgv_ordenesGenerar);
            this.Controls.Add(this.Btn_cancearEncDet);
            this.Controls.Add(this.Btn_guardarEcnDet);
            this.Controls.Add(this.label10);
            this.Name = "frm_compra";
            this.Text = "frm_compra";
            this.Load += new System.EventHandler(this.frm_compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ordenesGenerar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_cancearEncDet;
        private System.Windows.Forms.Button Btn_guardarEcnDet;
        private System.Windows.Forms.DataGridView Dgv_ordenesGenerar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.TextBox Txt_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.Label Txt_roveedor2;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Button Btn_reporteOC;
        private System.Windows.Forms.Button Btn_salirOC;
        private System.Windows.Forms.Button Btn_ayudaOC;
        private System.Windows.Forms.DateTimePicker dateTime_enc;
        private System.Windows.Forms.Button Btn_generarOrden;
    }
}