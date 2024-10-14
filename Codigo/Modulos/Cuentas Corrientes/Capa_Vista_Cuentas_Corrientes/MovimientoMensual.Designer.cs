
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class MovimientoMensual
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
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.LblFecha = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Dgv_movimiento = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.Txt_documento = new System.Windows.Forms.TextBox();
            this.Lbl_documento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(679, 63);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(92, 31);
            this.Btn_buscar.TabIndex = 0;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Location = new System.Drawing.Point(73, 72);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(40, 13);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 85);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // Dgv_movimiento
            // 
            this.Dgv_movimiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Dgv_movimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_movimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Pago,
            this.Cliente,
            this.Movimiento});
            this.Dgv_movimiento.Location = new System.Drawing.Point(222, 212);
            this.Dgv_movimiento.Name = "Dgv_movimiento";
            this.Dgv_movimiento.Size = new System.Drawing.Size(540, 139);
            this.Dgv_movimiento.TabIndex = 3;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Column1";
            this.Fecha.Name = "Fecha";
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Column1";
            this.Pago.Name = "Pago";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Column1";
            this.Cliente.Name = "Cliente";
            // 
            // Movimiento
            // 
            this.Movimiento.HeaderText = "Column1";
            this.Movimiento.Name = "Movimiento";
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Location = new System.Drawing.Point(347, 51);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(271, 20);
            this.Txt_fecha.TabIndex = 4;
            // 
            // Txt_documento
            // 
            this.Txt_documento.Location = new System.Drawing.Point(347, 85);
            this.Txt_documento.Name = "Txt_documento";
            this.Txt_documento.Size = new System.Drawing.Size(271, 20);
            this.Txt_documento.TabIndex = 5;
            // 
            // Lbl_documento
            // 
            this.Lbl_documento.AutoSize = true;
            this.Lbl_documento.Location = new System.Drawing.Point(231, 88);
            this.Lbl_documento.Name = "Lbl_documento";
            this.Lbl_documento.Size = new System.Drawing.Size(105, 13);
            this.Lbl_documento.TabIndex = 6;
            this.Lbl_documento.Text = "No. De Documento: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha: ";
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Location = new System.Drawing.Point(408, 397);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.Btn_imprimir.TabIndex = 8;
            this.Btn_imprimir.Text = "Imprimir";
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // MovimientoMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_imprimir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_documento);
            this.Controls.Add(this.Txt_documento);
            this.Controls.Add(this.Txt_fecha);
            this.Controls.Add(this.Dgv_movimiento);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.Btn_buscar);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "MovimientoMensual";
            this.Text = "MovimientoMensual";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_movimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView Dgv_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movimiento;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.TextBox Txt_documento;
        private System.Windows.Forms.Label Lbl_documento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}