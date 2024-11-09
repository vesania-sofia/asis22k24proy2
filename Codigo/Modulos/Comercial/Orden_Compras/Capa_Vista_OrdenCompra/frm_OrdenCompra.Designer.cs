
namespace Capa_Vista_OrdenCompra
{
    partial class frm_OrdenCompra
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
            this.Dgv_OrdenesGeneradas = new System.Windows.Forms.DataGridView();
            this.Btn_agregarOC = new System.Windows.Forms.Button();
            this.Btn_ayudaOC = new System.Windows.Forms.Button();
            this.Btn_salirOC = new System.Windows.Forms.Button();
            this.Btn_reporteOC = new System.Windows.Forms.Button();
            this.Btn_actualizarOC = new System.Windows.Forms.Button();
            this.Btn_modificarOC = new System.Windows.Forms.Button();
            this.Btn_eliminarOC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_OrdenesGeneradas)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(290, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 32);
            this.label10.TabIndex = 29;
            this.label10.Text = "Orden de Compras";
            // 
            // Dgv_OrdenesGeneradas
            // 
            this.Dgv_OrdenesGeneradas.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_OrdenesGeneradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_OrdenesGeneradas.Location = new System.Drawing.Point(84, 215);
            this.Dgv_OrdenesGeneradas.Name = "Dgv_OrdenesGeneradas";
            this.Dgv_OrdenesGeneradas.RowHeadersWidth = 62;
            this.Dgv_OrdenesGeneradas.RowTemplate.Height = 28;
            this.Dgv_OrdenesGeneradas.Size = new System.Drawing.Size(679, 344);
            this.Dgv_OrdenesGeneradas.TabIndex = 31;
            this.Dgv_OrdenesGeneradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_OrdenesGeneradas_CellContentClick_1);
            // 
            // Btn_agregarOC
            // 
            this.Btn_agregarOC.BackColor = System.Drawing.Color.Transparent;
            this.Btn_agregarOC.FlatAppearance.BorderSize = 0;
            this.Btn_agregarOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregarOC.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.agregar;
            this.Btn_agregarOC.Location = new System.Drawing.Point(84, 116);
            this.Btn_agregarOC.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_agregarOC.Name = "Btn_agregarOC";
            this.Btn_agregarOC.Size = new System.Drawing.Size(77, 81);
            this.Btn_agregarOC.TabIndex = 238;
            this.Btn_agregarOC.UseVisualStyleBackColor = false;
            this.Btn_agregarOC.Click += new System.EventHandler(this.Btn_agregarOC_Click);
            // 
            // Btn_ayudaOC
            // 
            this.Btn_ayudaOC.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ayudaOC.FlatAppearance.BorderSize = 0;
            this.Btn_ayudaOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayudaOC.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.ayuda;
            this.Btn_ayudaOC.Location = new System.Drawing.Point(590, 116);
            this.Btn_ayudaOC.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ayudaOC.Name = "Btn_ayudaOC";
            this.Btn_ayudaOC.Size = new System.Drawing.Size(77, 81);
            this.Btn_ayudaOC.TabIndex = 239;
            this.Btn_ayudaOC.UseVisualStyleBackColor = false;
            // 
            // Btn_salirOC
            // 
            this.Btn_salirOC.BackColor = System.Drawing.Color.Transparent;
            this.Btn_salirOC.FlatAppearance.BorderSize = 0;
            this.Btn_salirOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salirOC.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.salir;
            this.Btn_salirOC.Location = new System.Drawing.Point(686, 116);
            this.Btn_salirOC.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_salirOC.Name = "Btn_salirOC";
            this.Btn_salirOC.Size = new System.Drawing.Size(77, 81);
            this.Btn_salirOC.TabIndex = 240;
            this.Btn_salirOC.UseVisualStyleBackColor = false;
            this.Btn_salirOC.Click += new System.EventHandler(this.Btn_salirOC_Click);
            // 
            // Btn_reporteOC
            // 
            this.Btn_reporteOC.BackColor = System.Drawing.Color.Transparent;
            this.Btn_reporteOC.FlatAppearance.BorderSize = 0;
            this.Btn_reporteOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reporteOC.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.reporte;
            this.Btn_reporteOC.Location = new System.Drawing.Point(505, 116);
            this.Btn_reporteOC.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_reporteOC.Name = "Btn_reporteOC";
            this.Btn_reporteOC.Size = new System.Drawing.Size(77, 81);
            this.Btn_reporteOC.TabIndex = 241;
            this.Btn_reporteOC.UseVisualStyleBackColor = false;
            // 
            // Btn_actualizarOC
            // 
            this.Btn_actualizarOC.BackColor = System.Drawing.Color.Transparent;
            this.Btn_actualizarOC.FlatAppearance.BorderSize = 0;
            this.Btn_actualizarOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizarOC.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.actualizar;
            this.Btn_actualizarOC.Location = new System.Drawing.Point(254, 116);
            this.Btn_actualizarOC.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_actualizarOC.Name = "Btn_actualizarOC";
            this.Btn_actualizarOC.Size = new System.Drawing.Size(77, 81);
            this.Btn_actualizarOC.TabIndex = 242;
            this.Btn_actualizarOC.UseVisualStyleBackColor = false;
            this.Btn_actualizarOC.Click += new System.EventHandler(this.Btn_actualizarOC_Click);
            // 
            // Btn_modificarOC
            // 
            this.Btn_modificarOC.BackColor = System.Drawing.Color.Transparent;
            this.Btn_modificarOC.FlatAppearance.BorderSize = 0;
            this.Btn_modificarOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificarOC.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.modificar;
            this.Btn_modificarOC.Location = new System.Drawing.Point(169, 116);
            this.Btn_modificarOC.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_modificarOC.Name = "Btn_modificarOC";
            this.Btn_modificarOC.Size = new System.Drawing.Size(77, 81);
            this.Btn_modificarOC.TabIndex = 243;
            this.Btn_modificarOC.UseVisualStyleBackColor = false;
            this.Btn_modificarOC.Click += new System.EventHandler(this.Btn_modificarOC_Click);
            // 
            // Btn_eliminarOC
            // 
            this.Btn_eliminarOC.BackColor = System.Drawing.Color.Transparent;
            this.Btn_eliminarOC.FlatAppearance.BorderSize = 0;
            this.Btn_eliminarOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminarOC.Image = global::Capa_Vista_OrdenCompra.Properties.Resources.eliminar;
            this.Btn_eliminarOC.Location = new System.Drawing.Point(339, 116);
            this.Btn_eliminarOC.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminarOC.Name = "Btn_eliminarOC";
            this.Btn_eliminarOC.Size = new System.Drawing.Size(77, 81);
            this.Btn_eliminarOC.TabIndex = 244;
            this.Btn_eliminarOC.UseVisualStyleBackColor = false;
            this.Btn_eliminarOC.Click += new System.EventHandler(this.Btn_eliminarOC_Click);
            // 
            // frm_OrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(865, 600);
            this.Controls.Add(this.Btn_eliminarOC);
            this.Controls.Add(this.Btn_modificarOC);
            this.Controls.Add(this.Btn_actualizarOC);
            this.Controls.Add(this.Btn_reporteOC);
            this.Controls.Add(this.Btn_salirOC);
            this.Controls.Add(this.Btn_ayudaOC);
            this.Controls.Add(this.Btn_agregarOC);
            this.Controls.Add(this.Dgv_OrdenesGeneradas);
            this.Controls.Add(this.label10);
            this.Name = "frm_OrdenCompra";
            this.Text = "frm_OrdenCompra";
            this.Load += new System.EventHandler(this.frm_OrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_OrdenesGeneradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView Dgv_OrdenesGeneradas;
        private System.Windows.Forms.Button Btn_agregarOC;
        private System.Windows.Forms.Button Btn_ayudaOC;
        private System.Windows.Forms.Button Btn_salirOC;
        private System.Windows.Forms.Button Btn_reporteOC;
        private System.Windows.Forms.Button Btn_actualizarOC;
        private System.Windows.Forms.Button Btn_modificarOC;
        private System.Windows.Forms.Button Btn_eliminarOC;
    }
}