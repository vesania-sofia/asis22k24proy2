
namespace Capa_Vista_Reporteria
{
    partial class Inicio
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_ver_reporte = new System.Windows.Forms.Button();
            this.tbl_regreporteria = new System.Windows.Forms.DataGridView();
            this.txt_aplicacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.idReporte = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_regreporteria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes Generales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ruta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_examinar
            // 
            this.btn_examinar.Location = new System.Drawing.Point(546, 69);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(105, 29);
            this.btn_examinar.TabIndex = 2;
            this.btn_examinar.Text = "Examinar";
            this.btn_examinar.UseVisualStyleBackColor = true;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // txt_ruta
            // 
            this.txt_ruta.Location = new System.Drawing.Point(158, 74);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.Size = new System.Drawing.Size(382, 20);
            this.txt_ruta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Archivo";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(142, 115);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(182, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aplicacion";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(31, 160);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(105, 45);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(156, 160);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(105, 45);
            this.btn_modificar.TabIndex = 9;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(288, 160);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(105, 45);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_ver_reporte
            // 
            this.btn_ver_reporte.Location = new System.Drawing.Point(546, 160);
            this.btn_ver_reporte.Name = "btn_ver_reporte";
            this.btn_ver_reporte.Size = new System.Drawing.Size(105, 45);
            this.btn_ver_reporte.TabIndex = 12;
            this.btn_ver_reporte.Text = "Ver Reporte";
            this.btn_ver_reporte.UseVisualStyleBackColor = true;
            this.btn_ver_reporte.Click += new System.EventHandler(this.btn_ver_reporte_Click);
            // 
            // tbl_regreporteria
            // 
            this.tbl_regreporteria.AllowUserToAddRows = false;
            this.tbl_regreporteria.AllowUserToDeleteRows = false;
            this.tbl_regreporteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_regreporteria.Location = new System.Drawing.Point(31, 242);
            this.tbl_regreporteria.Name = "tbl_regreporteria";
            this.tbl_regreporteria.ReadOnly = true;
            this.tbl_regreporteria.RowHeadersWidth = 62;
            this.tbl_regreporteria.Size = new System.Drawing.Size(620, 177);
            this.tbl_regreporteria.TabIndex = 13;
            this.tbl_regreporteria.DoubleClick += new System.EventHandler(this.tabla_registro_DoubleClick);
            // 
            // txt_aplicacion
            // 
            this.txt_aplicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_aplicacion.Location = new System.Drawing.Point(401, 115);
            this.txt_aplicacion.Name = "txt_aplicacion";
            this.txt_aplicacion.Size = new System.Drawing.Size(85, 21);
            this.txt_aplicacion.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Estado";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(420, 160);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(105, 45);
            this.btn_actualizar.TabIndex = 17;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID";
            // 
            // idReporte
            // 
            this.idReporte.Enabled = false;
            this.idReporte.Location = new System.Drawing.Point(64, 74);
            this.idReporte.Name = "idReporte";
            this.idReporte.Size = new System.Drawing.Size(52, 20);
            this.idReporte.TabIndex = 19;
            // 
            // txt_estado
            // 
            this.txt_estado.FormattingEnabled = true;
            this.txt_estado.Items.AddRange(new object[] {
            "No_visible",
            "Visible"});
            this.txt_estado.Location = new System.Drawing.Point(546, 112);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(87, 21);
            this.txt_estado.TabIndex = 16;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(674, 466);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.idReporte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_aplicacion);
            this.Controls.Add(this.tbl_regreporteria);
            this.Controls.Add(this.btn_ver_reporte);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ruta);
            this.Controls.Add(this.btn_examinar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_regreporteria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.TextBox txt_ruta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_ver_reporte;
        private System.Windows.Forms.DataGridView tbl_regreporteria;
        private System.Windows.Forms.ComboBox txt_aplicacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idReporte;
        private System.Windows.Forms.ComboBox txt_estado;
    }
}