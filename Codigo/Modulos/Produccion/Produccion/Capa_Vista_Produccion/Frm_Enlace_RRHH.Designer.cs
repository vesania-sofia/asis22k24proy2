
namespace Capa_Vista_Produccion
{
    partial class Frm_Enlace_RRHH
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
            this.Txt_id_RRHH_prod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_empleados = new System.Windows.Forms.DataGridView();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Total_Dias = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Horas = new System.Windows.Forms.TextBox();
            this.txt_Total_Horas = new System.Windows.Forms.TextBox();
            this.txt_Total_Horas_Extras = new System.Windows.Forms.TextBox();
            this.txt_Total_Mano_de_Obra = new System.Windows.Forms.TextBox();
            this.cbo_Empleado = new System.Windows.Forms.ComboBox();
            this.txt_Dias = new System.Windows.Forms.TextBox();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.txt_horas_extras = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enlace a Recursos Humanos";
            // 
            // Txt_id_RRHH_prod
            // 
            this.Txt_id_RRHH_prod.Location = new System.Drawing.Point(118, 134);
            this.Txt_id_RRHH_prod.Name = "Txt_id_RRHH_prod";
            this.Txt_id_RRHH_prod.Size = new System.Drawing.Size(121, 22);
            this.Txt_id_RRHH_prod.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID_RRHH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salario";
            // 
            // dgv_empleados
            // 
            this.dgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleados.Location = new System.Drawing.Point(12, 344);
            this.dgv_empleados.Name = "dgv_empleados";
            this.dgv_empleados.RowHeadersWidth = 51;
            this.dgv_empleados.RowTemplate.Height = 24;
            this.dgv_empleados.Size = new System.Drawing.Size(625, 154);
            this.dgv_empleados.TabIndex = 11;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(192, 62);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(90, 39);
            this.btn_Guardar.TabIndex = 12;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(327, 62);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(96, 39);
            this.btn_Modificar.TabIndex = 14;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(462, 62);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(85, 39);
            this.btn_Eliminar.TabIndex = 15;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total Pago";
            // 
            // txt_Total_Dias
            // 
            this.txt_Total_Dias.Location = new System.Drawing.Point(118, 273);
            this.txt_Total_Dias.Name = "txt_Total_Dias";
            this.txt_Total_Dias.Size = new System.Drawing.Size(121, 22);
            this.txt_Total_Dias.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Horas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Total Horas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Horas Extras";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Total Horas Extras";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 276);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Total Mano de Obra";
            // 
            // txt_Horas
            // 
            this.txt_Horas.Location = new System.Drawing.Point(429, 136);
            this.txt_Horas.Name = "txt_Horas";
            this.txt_Horas.Size = new System.Drawing.Size(140, 22);
            this.txt_Horas.TabIndex = 24;
            // 
            // txt_Total_Horas
            // 
            this.txt_Total_Horas.Location = new System.Drawing.Point(429, 168);
            this.txt_Total_Horas.Name = "txt_Total_Horas";
            this.txt_Total_Horas.Size = new System.Drawing.Size(140, 22);
            this.txt_Total_Horas.TabIndex = 25;
            // 
            // txt_Total_Horas_Extras
            // 
            this.txt_Total_Horas_Extras.Location = new System.Drawing.Point(429, 241);
            this.txt_Total_Horas_Extras.Name = "txt_Total_Horas_Extras";
            this.txt_Total_Horas_Extras.Size = new System.Drawing.Size(140, 22);
            this.txt_Total_Horas_Extras.TabIndex = 27;
            // 
            // txt_Total_Mano_de_Obra
            // 
            this.txt_Total_Mano_de_Obra.Location = new System.Drawing.Point(429, 276);
            this.txt_Total_Mano_de_Obra.Name = "txt_Total_Mano_de_Obra";
            this.txt_Total_Mano_de_Obra.Size = new System.Drawing.Size(140, 22);
            this.txt_Total_Mano_de_Obra.TabIndex = 28;
            // 
            // cbo_Empleado
            // 
            this.cbo_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Empleado.FormattingEnabled = true;
            this.cbo_Empleado.Location = new System.Drawing.Point(118, 163);
            this.cbo_Empleado.Name = "cbo_Empleado";
            this.cbo_Empleado.Size = new System.Drawing.Size(121, 24);
            this.cbo_Empleado.TabIndex = 29;
            // 
            // txt_Dias
            // 
            this.txt_Dias.Location = new System.Drawing.Point(118, 242);
            this.txt_Dias.Name = "txt_Dias";
            this.txt_Dias.Size = new System.Drawing.Size(121, 22);
            this.txt_Dias.TabIndex = 32;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(46, 62);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(85, 39);
            this.btn_Nuevo.TabIndex = 33;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(118, 202);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(121, 22);
            this.txt_salario.TabIndex = 34;
            // 
            // txt_horas_extras
            // 
            this.txt_horas_extras.Location = new System.Drawing.Point(429, 205);
            this.txt_horas_extras.Name = "txt_horas_extras";
            this.txt_horas_extras.Size = new System.Drawing.Size(140, 22);
            this.txt_horas_extras.TabIndex = 35;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(590, 194);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(77, 39);
            this.btn_Calcular.TabIndex = 36;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // Frm_Enlace_RRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 510);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_horas_extras);
            this.Controls.Add(this.txt_salario);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.txt_Dias);
            this.Controls.Add(this.cbo_Empleado);
            this.Controls.Add(this.txt_Total_Mano_de_Obra);
            this.Controls.Add(this.txt_Total_Horas_Extras);
            this.Controls.Add(this.txt_Total_Horas);
            this.Controls.Add(this.txt_Horas);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Total_Dias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.dgv_empleados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_id_RRHH_prod);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Enlace_RRHH";
            this.Text = "Frm_Enlace_RRHH";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_id_RRHH_prod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_empleados;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Total_Dias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Horas;
        private System.Windows.Forms.TextBox txt_Total_Horas;
        private System.Windows.Forms.TextBox txt_Total_Horas_Extras;
        private System.Windows.Forms.TextBox txt_Total_Mano_de_Obra;
        private System.Windows.Forms.ComboBox cbo_Empleado;
        private System.Windows.Forms.TextBox txt_Dias;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.TextBox txt_horas_extras;
        private System.Windows.Forms.Button btn_Calcular;
    }
}