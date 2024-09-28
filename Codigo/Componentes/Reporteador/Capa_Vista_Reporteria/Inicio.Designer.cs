
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
            this.Btn_Examinar = new System.Windows.Forms.Button();
            this.Txt_Ruta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_NombreA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_VerReporte = new System.Windows.Forms.Button();
            this.Dgv_Regreporteria = new System.Windows.Forms.DataGridView();
            this.Cbo_Aplicacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_IDReporte = new System.Windows.Forms.TextBox();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Cbo_Modulo = new System.Windows.Forms.ComboBox();
            this.Lbl_Modulos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Regreporteria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes Generales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ruta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Btn_Examinar
            // 
            this.Btn_Examinar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Examinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Examinar.Location = new System.Drawing.Point(765, 81);
            this.Btn_Examinar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Examinar.Name = "Btn_Examinar";
            this.Btn_Examinar.Size = new System.Drawing.Size(140, 36);
            this.Btn_Examinar.TabIndex = 2;
            this.Btn_Examinar.Text = "Examinar";
            this.Btn_Examinar.UseVisualStyleBackColor = true;
            this.Btn_Examinar.Click += new System.EventHandler(this.Btn_Examinar_Click);
            // 
            // Txt_Ruta
            // 
            this.Txt_Ruta.Location = new System.Drawing.Point(229, 91);
            this.Txt_Ruta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Ruta.Name = "Txt_Ruta";
            this.Txt_Ruta.Size = new System.Drawing.Size(528, 22);
            this.Txt_Ruta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Archivo";
            // 
            // Txt_NombreA
            // 
            this.Txt_NombreA.Location = new System.Drawing.Point(135, 138);
            this.Txt_NombreA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_NombreA.Name = "Txt_NombreA";
            this.Txt_NombreA.Size = new System.Drawing.Size(161, 22);
            this.Txt_NombreA.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aplicacion";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Location = new System.Drawing.Point(41, 197);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(140, 55);
            this.Btn_Guardar.TabIndex = 8;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Modificar.Enabled = false;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Location = new System.Drawing.Point(229, 197);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(140, 55);
            this.Btn_Modificar.TabIndex = 9;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Eliminar.Enabled = false;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(408, 197);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(140, 55);
            this.Btn_Eliminar.TabIndex = 10;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_VerReporte
            // 
            this.Btn_VerReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_VerReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VerReporte.Location = new System.Drawing.Point(753, 197);
            this.Btn_VerReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_VerReporte.Name = "Btn_VerReporte";
            this.Btn_VerReporte.Size = new System.Drawing.Size(140, 55);
            this.Btn_VerReporte.TabIndex = 12;
            this.Btn_VerReporte.Text = "Ver Reporte";
            this.Btn_VerReporte.UseVisualStyleBackColor = true;
            this.Btn_VerReporte.Click += new System.EventHandler(this.Btn_VerReporte_Click);
            // 
            // Dgv_Regreporteria
            // 
            this.Dgv_Regreporteria.AllowUserToAddRows = false;
            this.Dgv_Regreporteria.AllowUserToDeleteRows = false;
            this.Dgv_Regreporteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Regreporteria.Location = new System.Drawing.Point(16, 298);
            this.Dgv_Regreporteria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dgv_Regreporteria.Name = "Dgv_Regreporteria";
            this.Dgv_Regreporteria.ReadOnly = true;
            this.Dgv_Regreporteria.RowHeadersWidth = 62;
            this.Dgv_Regreporteria.Size = new System.Drawing.Size(889, 218);
            this.Dgv_Regreporteria.TabIndex = 13;
            this.Dgv_Regreporteria.DoubleClick += new System.EventHandler(this.tabla_registro_DoubleClick);
            // 
            // Cbo_Aplicacion
            // 
            this.Cbo_Aplicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Aplicacion.Location = new System.Drawing.Point(396, 138);
            this.Cbo_Aplicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_Aplicacion.Name = "Cbo_Aplicacion";
            this.Cbo_Aplicacion.Size = new System.Drawing.Size(112, 24);
            this.Cbo_Aplicacion.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Estado";
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.Location = new System.Drawing.Point(587, 197);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(140, 55);
            this.Btn_Actualizar.TabIndex = 17;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "ID";
            // 
            // Txt_IDReporte
            // 
            this.Txt_IDReporte.Enabled = false;
            this.Txt_IDReporte.Location = new System.Drawing.Point(85, 91);
            this.Txt_IDReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_IDReporte.Name = "Txt_IDReporte";
            this.Txt_IDReporte.Size = new System.Drawing.Size(68, 22);
            this.Txt_IDReporte.TabIndex = 19;
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Items.AddRange(new object[] {
            "No_visible",
            "Visible"});
            this.Cbo_Estado.Location = new System.Drawing.Point(587, 138);
            this.Cbo_Estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(115, 24);
            this.Cbo_Estado.TabIndex = 16;
            // 
            // Cbo_Modulo
            // 
            this.Cbo_Modulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Modulo.Location = new System.Drawing.Point(793, 138);
            this.Cbo_Modulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cbo_Modulo.Name = "Cbo_Modulo";
            this.Cbo_Modulo.Size = new System.Drawing.Size(112, 24);
            this.Cbo_Modulo.TabIndex = 21;
            // 
            // Lbl_Modulos
            // 
            this.Lbl_Modulos.AutoSize = true;
            this.Lbl_Modulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modulos.Location = new System.Drawing.Point(711, 142);
            this.Lbl_Modulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Modulos.Name = "Lbl_Modulos";
            this.Lbl_Modulos.Size = new System.Drawing.Size(72, 20);
            this.Lbl_Modulos.TabIndex = 20;
            this.Lbl_Modulos.Text = "Módulos";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(177)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(937, 574);
            this.Controls.Add(this.Cbo_Modulo);
            this.Controls.Add(this.Lbl_Modulos);
            this.Controls.Add(this.Cbo_Estado);
            this.Controls.Add(this.Txt_IDReporte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cbo_Aplicacion);
            this.Controls.Add(this.Dgv_Regreporteria);
            this.Controls.Add(this.Btn_VerReporte);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_NombreA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Ruta);
            this.Controls.Add(this.Btn_Examinar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Regreporteria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Examinar;
        private System.Windows.Forms.TextBox Txt_Ruta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_NombreA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_VerReporte;
        private System.Windows.Forms.DataGridView Dgv_Regreporteria;
        private System.Windows.Forms.ComboBox Cbo_Aplicacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_IDReporte;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.ComboBox Cbo_Modulo;
        private System.Windows.Forms.Label Lbl_Modulos;
    }
}