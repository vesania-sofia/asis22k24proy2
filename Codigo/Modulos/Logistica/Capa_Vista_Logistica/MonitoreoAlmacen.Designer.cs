
namespace Capa_Vista_Logistica
{
    partial class MonitoreoAlmacen
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.Lbl_Producto = new System.Windows.Forms.Label();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.Lbl_Bodega = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCargarExistencias = new System.Windows.Forms.Button();
            this.dgvExistencias = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProductoAuditoria = new System.Windows.Forms.ComboBox();
            this.btnRealizarAuditoria = new System.Windows.Forms.Button();
            this.dgvAuditorias = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBodegaAuditoria = new System.Windows.Forms.ComboBox();
            this.txtCantidadRegistrada = new System.Windows.Forms.TextBox();
            this.txtCantidadFisica = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaAuditoria = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkDiscrepanciaDetectada = new System.Windows.Forms.CheckBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "MONITOREO DE STOCK EN ALMACÉN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(326, 137);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(189, 28);
            this.cmbProducto.TabIndex = 10;
            // 
            // Lbl_Producto
            // 
            this.Lbl_Producto.AutoSize = true;
            this.Lbl_Producto.Location = new System.Drawing.Point(175, 137);
            this.Lbl_Producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Producto.Name = "Lbl_Producto";
            this.Lbl_Producto.Size = new System.Drawing.Size(73, 20);
            this.Lbl_Producto.TabIndex = 9;
            this.Lbl_Producto.Text = "Producto";
            // 
            // cmbBodega
            // 
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(326, 99);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(189, 28);
            this.cmbBodega.TabIndex = 6;
            // 
            // Lbl_Bodega
            // 
            this.Lbl_Bodega.AutoSize = true;
            this.Lbl_Bodega.Location = new System.Drawing.Point(175, 102);
            this.Lbl_Bodega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Bodega.Name = "Lbl_Bodega";
            this.Lbl_Bodega.Size = new System.Drawing.Size(69, 20);
            this.Lbl_Bodega.TabIndex = 3;
            this.Lbl_Bodega.Text = "Bodega:";
            this.Lbl_Bodega.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lbl_Producto);
            this.groupBox2.Controls.Add(this.cmbProducto);
            this.groupBox2.Controls.Add(this.btnCargarExistencias);
            this.groupBox2.Controls.Add(this.dgvExistencias);
            this.groupBox2.Controls.Add(this.Lbl_Bodega);
            this.groupBox2.Controls.Add(this.cmbBodega);
            this.groupBox2.Location = new System.Drawing.Point(62, 168);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(890, 658);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Existencias en Bodega";
            // 
            // btnCargarExistencias
            // 
            this.btnCargarExistencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(137)))));
            this.btnCargarExistencias.Location = new System.Drawing.Point(563, 99);
            this.btnCargarExistencias.Name = "btnCargarExistencias";
            this.btnCargarExistencias.Size = new System.Drawing.Size(109, 77);
            this.btnCargarExistencias.TabIndex = 15;
            this.btnCargarExistencias.Text = "Cargar Existencias";
            this.btnCargarExistencias.UseVisualStyleBackColor = false;
            // 
            // dgvExistencias
            // 
            this.dgvExistencias.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistencias.Location = new System.Drawing.Point(33, 261);
            this.dgvExistencias.Name = "dgvExistencias";
            this.dgvExistencias.RowHeadersWidth = 62;
            this.dgvExistencias.RowTemplate.Height = 28;
            this.dgvExistencias.Size = new System.Drawing.Size(792, 378);
            this.dgvExistencias.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1306, 569);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unidades Disponibles:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGenerarReporte);
            this.groupBox3.Controls.Add(this.chkDiscrepanciaDetectada);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtpFechaAuditoria);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtObservaciones);
            this.groupBox3.Controls.Add(this.txtCantidadFisica);
            this.groupBox3.Controls.Add(this.txtCantidadRegistrada);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbProductoAuditoria);
            this.groupBox3.Controls.Add(this.btnRealizarAuditoria);
            this.groupBox3.Controls.Add(this.dgvAuditorias);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbBodegaAuditoria);
            this.groupBox3.Location = new System.Drawing.Point(998, 168);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(926, 658);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auditoria de Existencias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Producto";
            // 
            // cmbProductoAuditoria
            // 
            this.cmbProductoAuditoria.FormattingEnabled = true;
            this.cmbProductoAuditoria.Location = new System.Drawing.Point(219, 135);
            this.cmbProductoAuditoria.Name = "cmbProductoAuditoria";
            this.cmbProductoAuditoria.Size = new System.Drawing.Size(200, 28);
            this.cmbProductoAuditoria.TabIndex = 10;
            // 
            // btnRealizarAuditoria
            // 
            this.btnRealizarAuditoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(137)))));
            this.btnRealizarAuditoria.Location = new System.Drawing.Point(775, 45);
            this.btnRealizarAuditoria.Name = "btnRealizarAuditoria";
            this.btnRealizarAuditoria.Size = new System.Drawing.Size(109, 77);
            this.btnRealizarAuditoria.TabIndex = 15;
            this.btnRealizarAuditoria.Text = "Realizar Auditoria";
            this.btnRealizarAuditoria.UseVisualStyleBackColor = false;
            // 
            // dgvAuditorias
            // 
            this.dgvAuditorias.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAuditorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditorias.Location = new System.Drawing.Point(57, 245);
            this.dgvAuditorias.Name = "dgvAuditorias";
            this.dgvAuditorias.RowHeadersWidth = 62;
            this.dgvAuditorias.RowTemplate.Height = 28;
            this.dgvAuditorias.Size = new System.Drawing.Size(836, 378);
            this.dgvAuditorias.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bodega:";
            // 
            // cmbBodegaAuditoria
            // 
            this.cmbBodegaAuditoria.FormattingEnabled = true;
            this.cmbBodegaAuditoria.Location = new System.Drawing.Point(219, 94);
            this.cmbBodegaAuditoria.Name = "cmbBodegaAuditoria";
            this.cmbBodegaAuditoria.Size = new System.Drawing.Size(200, 28);
            this.cmbBodegaAuditoria.TabIndex = 6;
            // 
            // txtCantidadRegistrada
            // 
            this.txtCantidadRegistrada.Location = new System.Drawing.Point(634, 62);
            this.txtCantidadRegistrada.Name = "txtCantidadRegistrada";
            this.txtCantidadRegistrada.Size = new System.Drawing.Size(89, 26);
            this.txtCantidadRegistrada.TabIndex = 16;
            // 
            // txtCantidadFisica
            // 
            this.txtCantidadFisica.Location = new System.Drawing.Point(634, 94);
            this.txtCantidadFisica.Name = "txtCantidadFisica";
            this.txtCantidadFisica.Size = new System.Drawing.Size(89, 26);
            this.txtCantidadFisica.TabIndex = 17;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(219, 175);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(504, 26);
            this.txtObservaciones.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Observaciones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha de Auditoria:";
            // 
            // dtpFechaAuditoria
            // 
            this.dtpFechaAuditoria.Location = new System.Drawing.Point(219, 62);
            this.dtpFechaAuditoria.Name = "dtpFechaAuditoria";
            this.dtpFechaAuditoria.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaAuditoria.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cantidad Registrada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cantidad Física";
            // 
            // chkDiscrepanciaDetectada
            // 
            this.chkDiscrepanciaDetectada.AutoSize = true;
            this.chkDiscrepanciaDetectada.Location = new System.Drawing.Point(448, 137);
            this.chkDiscrepanciaDetectada.Name = "chkDiscrepanciaDetectada";
            this.chkDiscrepanciaDetectada.Size = new System.Drawing.Size(203, 24);
            this.chkDiscrepanciaDetectada.TabIndex = 24;
            this.chkDiscrepanciaDetectada.Text = "Discrepancia detectada";
            this.chkDiscrepanciaDetectada.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(137)))));
            this.btnGenerarReporte.Location = new System.Drawing.Point(775, 137);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(109, 77);
            this.btnGenerarReporte.TabIndex = 25;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            // 
            // MonitoreoAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1953, 873);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MonitoreoAlmacen";
            this.Text = "MonitoreoAlmacen";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Bodega;
        private System.Windows.Forms.ComboBox cmbBodega;
        private System.Windows.Forms.Label Lbl_Producto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvExistencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargarExistencias;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.CheckBox chkDiscrepanciaDetectada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaAuditoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtCantidadFisica;
        private System.Windows.Forms.TextBox txtCantidadRegistrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProductoAuditoria;
        private System.Windows.Forms.Button btnRealizarAuditoria;
        private System.Windows.Forms.DataGridView dgvAuditorias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBodegaAuditoria;
    }
}