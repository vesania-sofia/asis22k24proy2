
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_Bodega = new System.Windows.Forms.Label();
            this.Cmb_Bodega = new System.Windows.Forms.ComboBox();
            this.Cmb_EstadoLote = new System.Windows.Forms.ComboBox();
            this.Lbl_EstadoLote = new System.Windows.Forms.Label();
            this.Lbl_Producto = new System.Windows.Forms.Label();
            this.Cmb_Producto = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_ProductoExistencias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_CantidadTotal = new System.Windows.Forms.TextBox();
            this.Txt_UnidadesDisponibles = new System.Windows.Forms.TextBox();
            this.Txt_LotesActivos = new System.Windows.Forms.TextBox();
            this.Dgv_ExistenciasBodega = new System.Windows.Forms.DataGridView();
            this.Btn_RefrescarDatos = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ExistenciasBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "MONITOREO DE STOCK EN ALMACÉN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cmb_Producto);
            this.groupBox1.Controls.Add(this.Lbl_Producto);
            this.groupBox1.Controls.Add(this.Lbl_EstadoLote);
            this.groupBox1.Controls.Add(this.Cmb_EstadoLote);
            this.groupBox1.Controls.Add(this.Cmb_Bodega);
            this.groupBox1.Controls.Add(this.Lbl_Bodega);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(81, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(986, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // Lbl_Bodega
            // 
            this.Lbl_Bodega.AutoSize = true;
            this.Lbl_Bodega.Location = new System.Drawing.Point(25, 39);
            this.Lbl_Bodega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Bodega.Name = "Lbl_Bodega";
            this.Lbl_Bodega.Size = new System.Drawing.Size(69, 20);
            this.Lbl_Bodega.TabIndex = 3;
            this.Lbl_Bodega.Text = "Bodega:";
            this.Lbl_Bodega.Click += new System.EventHandler(this.label2_Click);
            // 
            // Cmb_Bodega
            // 
            this.Cmb_Bodega.FormattingEnabled = true;
            this.Cmb_Bodega.Location = new System.Drawing.Point(101, 39);
            this.Cmb_Bodega.Name = "Cmb_Bodega";
            this.Cmb_Bodega.Size = new System.Drawing.Size(189, 28);
            this.Cmb_Bodega.TabIndex = 6;
            // 
            // Cmb_EstadoLote
            // 
            this.Cmb_EstadoLote.FormattingEnabled = true;
            this.Cmb_EstadoLote.Location = new System.Drawing.Point(731, 39);
            this.Cmb_EstadoLote.Name = "Cmb_EstadoLote";
            this.Cmb_EstadoLote.Size = new System.Drawing.Size(189, 28);
            this.Cmb_EstadoLote.TabIndex = 7;
            // 
            // Lbl_EstadoLote
            // 
            this.Lbl_EstadoLote.AutoSize = true;
            this.Lbl_EstadoLote.Location = new System.Drawing.Point(590, 42);
            this.Lbl_EstadoLote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_EstadoLote.Name = "Lbl_EstadoLote";
            this.Lbl_EstadoLote.Size = new System.Drawing.Size(122, 20);
            this.Lbl_EstadoLote.TabIndex = 8;
            this.Lbl_EstadoLote.Text = "Estado de Lote:";
            // 
            // Lbl_Producto
            // 
            this.Lbl_Producto.AutoSize = true;
            this.Lbl_Producto.Location = new System.Drawing.Point(302, 42);
            this.Lbl_Producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Producto.Name = "Lbl_Producto";
            this.Lbl_Producto.Size = new System.Drawing.Size(73, 20);
            this.Lbl_Producto.TabIndex = 9;
            this.Lbl_Producto.Text = "Producto";
            // 
            // Cmb_Producto
            // 
            this.Cmb_Producto.FormattingEnabled = true;
            this.Cmb_Producto.Location = new System.Drawing.Point(382, 36);
            this.Cmb_Producto.Name = "Cmb_Producto";
            this.Cmb_Producto.Size = new System.Drawing.Size(189, 28);
            this.Cmb_Producto.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Salir);
            this.groupBox2.Controls.Add(this.Btn_Modificar);
            this.groupBox2.Controls.Add(this.Btn_RefrescarDatos);
            this.groupBox2.Controls.Add(this.Dgv_ExistenciasBodega);
            this.groupBox2.Controls.Add(this.Txt_LotesActivos);
            this.groupBox2.Controls.Add(this.Txt_UnidadesDisponibles);
            this.groupBox2.Controls.Add(this.Txt_CantidadTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Txt_ProductoExistencias);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(81, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(986, 427);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Existencias en Bodega";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unidades Disponibles:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad Total:";
            // 
            // Txt_ProductoExistencias
            // 
            this.Txt_ProductoExistencias.Location = new System.Drawing.Point(204, 42);
            this.Txt_ProductoExistencias.Name = "Txt_ProductoExistencias";
            this.Txt_ProductoExistencias.Size = new System.Drawing.Size(165, 26);
            this.Txt_ProductoExistencias.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lotes Activos:";
            // 
            // Txt_CantidadTotal
            // 
            this.Txt_CantidadTotal.Location = new System.Drawing.Point(204, 86);
            this.Txt_CantidadTotal.Name = "Txt_CantidadTotal";
            this.Txt_CantidadTotal.Size = new System.Drawing.Size(165, 26);
            this.Txt_CantidadTotal.TabIndex = 12;
            // 
            // Txt_UnidadesDisponibles
            // 
            this.Txt_UnidadesDisponibles.Location = new System.Drawing.Point(204, 134);
            this.Txt_UnidadesDisponibles.Name = "Txt_UnidadesDisponibles";
            this.Txt_UnidadesDisponibles.Size = new System.Drawing.Size(165, 26);
            this.Txt_UnidadesDisponibles.TabIndex = 13;
            // 
            // Txt_LotesActivos
            // 
            this.Txt_LotesActivos.Location = new System.Drawing.Point(204, 179);
            this.Txt_LotesActivos.Name = "Txt_LotesActivos";
            this.Txt_LotesActivos.Size = new System.Drawing.Size(165, 26);
            this.Txt_LotesActivos.TabIndex = 14;
            // 
            // Dgv_ExistenciasBodega
            // 
            this.Dgv_ExistenciasBodega.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_ExistenciasBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ExistenciasBodega.Location = new System.Drawing.Point(462, 27);
            this.Dgv_ExistenciasBodega.Name = "Dgv_ExistenciasBodega";
            this.Dgv_ExistenciasBodega.RowHeadersWidth = 62;
            this.Dgv_ExistenciasBodega.RowTemplate.Height = 28;
            this.Dgv_ExistenciasBodega.Size = new System.Drawing.Size(490, 378);
            this.Dgv_ExistenciasBodega.TabIndex = 12;
            // 
            // Btn_RefrescarDatos
            // 
            this.Btn_RefrescarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(137)))));
            this.Btn_RefrescarDatos.Location = new System.Drawing.Point(33, 270);
            this.Btn_RefrescarDatos.Name = "Btn_RefrescarDatos";
            this.Btn_RefrescarDatos.Size = new System.Drawing.Size(109, 77);
            this.Btn_RefrescarDatos.TabIndex = 15;
            this.Btn_RefrescarDatos.Text = "Visualizar";
            this.Btn_RefrescarDatos.UseVisualStyleBackColor = false;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(137)))));
            this.Btn_Modificar.Location = new System.Drawing.Point(167, 270);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(109, 77);
            this.Btn_Modificar.TabIndex = 16;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(143)))), ((int)(((byte)(137)))));
            this.Btn_Salir.Location = new System.Drawing.Point(306, 270);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(109, 77);
            this.Btn_Salir.TabIndex = 17;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            // 
            // MonitoreoAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(223)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(736, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MonitoreoAlmacen";
            this.Text = "MonitoreoAlmacen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ExistenciasBodega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_Bodega;
        private System.Windows.Forms.Label Lbl_EstadoLote;
        private System.Windows.Forms.ComboBox Cmb_EstadoLote;
        private System.Windows.Forms.ComboBox Cmb_Bodega;
        private System.Windows.Forms.Label Lbl_Producto;
        private System.Windows.Forms.ComboBox Cmb_Producto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Dgv_ExistenciasBodega;
        private System.Windows.Forms.TextBox Txt_LotesActivos;
        private System.Windows.Forms.TextBox Txt_UnidadesDisponibles;
        private System.Windows.Forms.TextBox Txt_CantidadTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_ProductoExistencias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_RefrescarDatos;
    }
}