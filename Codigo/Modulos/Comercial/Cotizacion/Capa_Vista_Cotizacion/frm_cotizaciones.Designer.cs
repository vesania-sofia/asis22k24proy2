
namespace Capa_Vista_Cotizacion
{
    partial class frm_cotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cotizaciones));
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_idEncezado = new System.Windows.Forms.TextBox();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Cbo_cliente = new System.Windows.Forms.ComboBox();
            this.Cbo_vendedor = new System.Windows.Forms.ComboBox();
            this.Txt_FechaVencimiento = new System.Windows.Forms.Label();
            this.Txt_Clienten = new System.Windows.Forms.Label();
            this.Txt_Vendedorn = new System.Windows.Forms.Label();
            this.Txt_idE = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dgv_cotizacion = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_cantidad = new System.Windows.Forms.NumericUpDown();
            this.Txt_precion = new System.Windows.Forms.Label();
            this.Txt_precio = new System.Windows.Forms.TextBox();
            this.Txt_cantidadn = new System.Windows.Forms.Label();
            this.Txt_totaln = new System.Windows.Forms.Label();
            this.Cbo_encabezado = new System.Windows.Forms.ComboBox();
            this.Txt_idEfk = new System.Windows.Forms.Label();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.Txt_idDetalle = new System.Windows.Forms.TextBox();
            this.Txt_idD = new System.Windows.Forms.Label();
            this.Cbo_producto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_producton = new System.Windows.Forms.Label();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Txt_subtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.Btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Btn_nuevo.Image")));
            this.Btn_nuevo.Location = new System.Drawing.Point(610, 83);
            this.Btn_nuevo.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(59, 57);
            this.Btn_nuevo.TabIndex = 301;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.Btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.Image")));
            this.Btn_cancelar.Location = new System.Drawing.Point(687, 83);
            this.Btn_cancelar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(69, 57);
            this.Btn_cancelar.TabIndex = 303;
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.groupBox1.Controls.Add(this.Txt_idEncezado);
            this.groupBox1.Controls.Add(this.Dtp_fecha);
            this.groupBox1.Controls.Add(this.Cbo_cliente);
            this.groupBox1.Controls.Add(this.Cbo_vendedor);
            this.groupBox1.Controls.Add(this.Txt_FechaVencimiento);
            this.groupBox1.Controls.Add(this.Txt_Clienten);
            this.groupBox1.Controls.Add(this.Txt_total);
            this.groupBox1.Controls.Add(this.Txt_totaln);
            this.groupBox1.Controls.Add(this.Txt_Vendedorn);
            this.groupBox1.Controls.Add(this.Txt_idE);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 130);
            this.groupBox1.TabIndex = 302;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // Txt_idEncezado
            // 
            this.Txt_idEncezado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idEncezado.Location = new System.Drawing.Point(103, 31);
            this.Txt_idEncezado.Name = "Txt_idEncezado";
            this.Txt_idEncezado.Size = new System.Drawing.Size(121, 22);
            this.Txt_idEncezado.TabIndex = 9;
            this.Txt_idEncezado.TextChanged += new System.EventHandler(this.Txt_idEncezado_TextChanged);
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha.Location = new System.Drawing.Point(335, 60);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(200, 22);
            this.Dtp_fecha.TabIndex = 6;
            this.Dtp_fecha.ValueChanged += new System.EventHandler(this.Dtp_fecha_ValueChanged);
            // 
            // Cbo_cliente
            // 
            this.Cbo_cliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cliente.FormattingEnabled = true;
            this.Cbo_cliente.Location = new System.Drawing.Point(103, 91);
            this.Cbo_cliente.Name = "Cbo_cliente";
            this.Cbo_cliente.Size = new System.Drawing.Size(121, 23);
            this.Cbo_cliente.TabIndex = 5;
            this.Cbo_cliente.SelectedIndexChanged += new System.EventHandler(this.Cbo_cliente_SelectedIndexChanged_1);
            // 
            // Cbo_vendedor
            // 
            this.Cbo_vendedor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_vendedor.FormattingEnabled = true;
            this.Cbo_vendedor.Location = new System.Drawing.Point(103, 59);
            this.Cbo_vendedor.Name = "Cbo_vendedor";
            this.Cbo_vendedor.Size = new System.Drawing.Size(121, 23);
            this.Cbo_vendedor.TabIndex = 4;
            this.Cbo_vendedor.SelectedIndexChanged += new System.EventHandler(this.Cbo_vendedor_SelectedIndexChanged_1);
            // 
            // Txt_FechaVencimiento
            // 
            this.Txt_FechaVencimiento.AutoSize = true;
            this.Txt_FechaVencimiento.Location = new System.Drawing.Point(370, 31);
            this.Txt_FechaVencimiento.Name = "Txt_FechaVencimiento";
            this.Txt_FechaVencimiento.Size = new System.Drawing.Size(123, 19);
            this.Txt_FechaVencimiento.TabIndex = 3;
            this.Txt_FechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // Txt_Clienten
            // 
            this.Txt_Clienten.AutoSize = true;
            this.Txt_Clienten.Location = new System.Drawing.Point(29, 94);
            this.Txt_Clienten.Name = "Txt_Clienten";
            this.Txt_Clienten.Size = new System.Drawing.Size(51, 19);
            this.Txt_Clienten.TabIndex = 2;
            this.Txt_Clienten.Text = "Cliente";
            // 
            // Txt_Vendedorn
            // 
            this.Txt_Vendedorn.AutoSize = true;
            this.Txt_Vendedorn.Location = new System.Drawing.Point(29, 59);
            this.Txt_Vendedorn.Name = "Txt_Vendedorn";
            this.Txt_Vendedorn.Size = new System.Drawing.Size(68, 19);
            this.Txt_Vendedorn.TabIndex = 1;
            this.Txt_Vendedorn.Text = "Vendedor";
            // 
            // Txt_idE
            // 
            this.Txt_idE.AutoSize = true;
            this.Txt_idE.Location = new System.Drawing.Point(29, 31);
            this.Txt_idE.Name = "Txt_idE";
            this.Txt_idE.Size = new System.Drawing.Size(25, 19);
            this.Txt_idE.TabIndex = 0;
            this.Txt_idE.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(137)))));
            this.groupBox2.Controls.Add(this.Txt_subtotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Dgv_cotizacion);
            this.groupBox2.Controls.Add(this.Txt_cantidad);
            this.groupBox2.Controls.Add(this.Txt_precion);
            this.groupBox2.Controls.Add(this.Txt_precio);
            this.groupBox2.Controls.Add(this.Txt_cantidadn);
            this.groupBox2.Controls.Add(this.Cbo_encabezado);
            this.groupBox2.Controls.Add(this.Txt_idEfk);
            this.groupBox2.Controls.Add(this.Txt_idDetalle);
            this.groupBox2.Controls.Add(this.Txt_idD);
            this.groupBox2.Controls.Add(this.Cbo_producto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Txt_producton);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 264);
            this.groupBox2.TabIndex = 304;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // Dgv_cotizacion
            // 
            this.Dgv_cotizacion.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dgv_cotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_cotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal});
            this.Dgv_cotizacion.Location = new System.Drawing.Point(36, 126);
            this.Dgv_cotizacion.Name = "Dgv_cotizacion";
            this.Dgv_cotizacion.Size = new System.Drawing.Size(447, 132);
            this.Dgv_cotizacion.TabIndex = 10;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // Txt_cantidad
            // 
            this.Txt_cantidad.Location = new System.Drawing.Point(582, 77);
            this.Txt_cantidad.Name = "Txt_cantidad";
            this.Txt_cantidad.Size = new System.Drawing.Size(120, 26);
            this.Txt_cantidad.TabIndex = 11;
            // 
            // Txt_precion
            // 
            this.Txt_precion.AutoSize = true;
            this.Txt_precion.Location = new System.Drawing.Point(267, 80);
            this.Txt_precion.Name = "Txt_precion";
            this.Txt_precion.Size = new System.Drawing.Size(48, 19);
            this.Txt_precion.TabIndex = 31;
            this.Txt_precion.Text = "Precio";
            // 
            // Txt_precio
            // 
            this.Txt_precio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precio.Location = new System.Drawing.Point(335, 77);
            this.Txt_precio.Name = "Txt_precio";
            this.Txt_precio.Size = new System.Drawing.Size(121, 22);
            this.Txt_precio.TabIndex = 30;
            // 
            // Txt_cantidadn
            // 
            this.Txt_cantidadn.AutoSize = true;
            this.Txt_cantidadn.Location = new System.Drawing.Point(495, 84);
            this.Txt_cantidadn.Name = "Txt_cantidadn";
            this.Txt_cantidadn.Size = new System.Drawing.Size(64, 19);
            this.Txt_cantidadn.TabIndex = 29;
            this.Txt_cantidadn.Text = "Cantidad";
            // 
            // Txt_totaln
            // 
            this.Txt_totaln.AutoSize = true;
            this.Txt_totaln.Location = new System.Drawing.Point(334, 100);
            this.Txt_totaln.Name = "Txt_totaln";
            this.Txt_totaln.Size = new System.Drawing.Size(39, 19);
            this.Txt_totaln.TabIndex = 27;
            this.Txt_totaln.Text = "Total";
            this.Txt_totaln.Click += new System.EventHandler(this.Txt_totaln_Click_1);
            // 
            // Cbo_encabezado
            // 
            this.Cbo_encabezado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_encabezado.FormattingEnabled = true;
            this.Cbo_encabezado.Location = new System.Drawing.Point(499, 25);
            this.Cbo_encabezado.Name = "Cbo_encabezado";
            this.Cbo_encabezado.Size = new System.Drawing.Size(121, 23);
            this.Cbo_encabezado.TabIndex = 18;
            // 
            // Txt_idEfk
            // 
            this.Txt_idEfk.AutoSize = true;
            this.Txt_idEfk.Location = new System.Drawing.Point(370, 24);
            this.Txt_idEfk.Name = "Txt_idEfk";
            this.Txt_idEfk.Size = new System.Drawing.Size(103, 19);
            this.Txt_idEfk.TabIndex = 17;
            this.Txt_idEfk.Text = "ID Encabezado";
            // 
            // Txt_total
            // 
            this.Txt_total.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_total.Location = new System.Drawing.Point(396, 97);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(121, 22);
            this.Txt_total.TabIndex = 26;
            // 
            // Txt_idDetalle
            // 
            this.Txt_idDetalle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idDetalle.Location = new System.Drawing.Point(173, 25);
            this.Txt_idDetalle.Name = "Txt_idDetalle";
            this.Txt_idDetalle.Size = new System.Drawing.Size(121, 22);
            this.Txt_idDetalle.TabIndex = 11;
            // 
            // Txt_idD
            // 
            this.Txt_idD.AutoSize = true;
            this.Txt_idD.Location = new System.Drawing.Point(51, 24);
            this.Txt_idD.Name = "Txt_idD";
            this.Txt_idD.Size = new System.Drawing.Size(25, 19);
            this.Txt_idD.TabIndex = 10;
            this.Txt_idD.Text = "ID";
            // 
            // Cbo_producto
            // 
            this.Cbo_producto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_producto.FormattingEnabled = true;
            this.Cbo_producto.Location = new System.Drawing.Point(103, 80);
            this.Cbo_producto.Name = "Cbo_producto";
            this.Cbo_producto.Size = new System.Drawing.Size(121, 23);
            this.Cbo_producto.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 10;
            // 
            // Txt_producton
            // 
            this.Txt_producton.AutoSize = true;
            this.Txt_producton.Location = new System.Drawing.Point(32, 80);
            this.Txt_producton.Name = "Txt_producton";
            this.Txt_producton.Size = new System.Drawing.Size(65, 19);
            this.Txt_producton.TabIndex = 9;
            this.Txt_producton.Text = "Producto";
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Haettenschweiler", 26F);
            this.Txt_titulo.Location = new System.Drawing.Point(342, 9);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(126, 37);
            this.Txt_titulo.TabIndex = 305;
            this.Txt_titulo.Text = "Cotizacion";
            // 
            // Txt_subtotal
            // 
            this.Txt_subtotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_subtotal.Location = new System.Drawing.Point(570, 183);
            this.Txt_subtotal.Name = "Txt_subtotal";
            this.Txt_subtotal.Size = new System.Drawing.Size(121, 22);
            this.Txt_subtotal.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Total";
            // 
            // frm_cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_nuevo);
            this.Name = "frm_cotizaciones";
            this.Text = "frm_cotizaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_cotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_idEncezado;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.ComboBox Cbo_cliente;
        private System.Windows.Forms.ComboBox Cbo_vendedor;
        private System.Windows.Forms.Label Txt_FechaVencimiento;
        private System.Windows.Forms.Label Txt_Clienten;
        private System.Windows.Forms.Label Txt_Vendedorn;
        private System.Windows.Forms.Label Txt_idE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Dgv_cotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.NumericUpDown Txt_cantidad;
        private System.Windows.Forms.Label Txt_precion;
        private System.Windows.Forms.TextBox Txt_precio;
        private System.Windows.Forms.Label Txt_cantidadn;
        private System.Windows.Forms.Label Txt_totaln;
        private System.Windows.Forms.ComboBox Cbo_encabezado;
        private System.Windows.Forms.Label Txt_idEfk;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.TextBox Txt_idDetalle;
        private System.Windows.Forms.Label Txt_idD;
        private System.Windows.Forms.ComboBox Cbo_producto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Txt_producton;
        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.TextBox Txt_subtotal;
        private System.Windows.Forms.Label label1;
    }
}