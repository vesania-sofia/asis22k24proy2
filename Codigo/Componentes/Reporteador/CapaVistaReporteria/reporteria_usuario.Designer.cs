
namespace CapaVistaReporteria
{
    partial class reporteria_usuario
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
            this.Nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_VerReporte = new System.Windows.Forms.Button();
            this.tbl_regreporteria = new System.Windows.Forms.DataGridView();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_regreporteria)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(56, 9);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(65, 20);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(129, 9);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(268, 26);
            this.txt_nombre.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_VerReporte
            // 
            this.btn_VerReporte.Enabled = false;
            this.btn_VerReporte.Location = new System.Drawing.Point(732, 9);
            this.btn_VerReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_VerReporte.Name = "btn_VerReporte";
            this.btn_VerReporte.Size = new System.Drawing.Size(112, 35);
            this.btn_VerReporte.TabIndex = 3;
            this.btn_VerReporte.Text = "Ver reporte";
            this.btn_VerReporte.UseVisualStyleBackColor = true;
            this.btn_VerReporte.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbl_regreporteria
            // 
            this.tbl_regreporteria.AllowUserToAddRows = false;
            this.tbl_regreporteria.AllowUserToDeleteRows = false;
            this.tbl_regreporteria.AllowUserToOrderColumns = true;
            this.tbl_regreporteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_regreporteria.Location = new System.Drawing.Point(60, 53);
            this.tbl_regreporteria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbl_regreporteria.Name = "tbl_regreporteria";
            this.tbl_regreporteria.ReadOnly = true;
            this.tbl_regreporteria.RowHeadersWidth = 62;
            this.tbl_regreporteria.Size = new System.Drawing.Size(888, 523);
            this.tbl_regreporteria.TabIndex = 8;
            this.tbl_regreporteria.DoubleClick += new System.EventHandler(this.tabla_registro_DoubleClick);
            // 
            // txt_ruta
            // 
            this.txt_ruta.Location = new System.Drawing.Point(524, 12);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.Size = new System.Drawing.Size(201, 26);
            this.txt_ruta.TabIndex = 9;
            // 
            // reporteria_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1024, 615);
            this.Controls.Add(this.txt_ruta);
            this.Controls.Add(this.tbl_regreporteria);
            this.Controls.Add(this.btn_VerReporte);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.Nombre);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "reporteria_usuario";
            this.Text = "reporteria_usuario";
            this.Load += new System.EventHandler(this.reporteria_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_regreporteria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_VerReporte;
        private System.Windows.Forms.DataGridView tbl_regreporteria;
        private System.Windows.Forms.TextBox txt_ruta;
    }
}