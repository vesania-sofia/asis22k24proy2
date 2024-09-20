﻿namespace CapaDiseno
{
    partial class frm_asignacion_aplicaciones_perfiles
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
            this.dgv_asignacionesperfiles = new System.Windows.Forms.DataGridView();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingresar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Consultar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Imprimir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.cbo_modulos = new System.Windows.Forms.ComboBox();
            this.lbl_modulo = new System.Windows.Forms.Label();
            this.cbo_perfiles = new System.Windows.Forms.ComboBox();
            this.cbo_aplicaciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignacionesperfiles)).BeginInit();
            this.Gpb_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_asignacionesperfiles
            // 
            this.dgv_asignacionesperfiles.AllowUserToAddRows = false;
            this.dgv_asignacionesperfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asignacionesperfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Perfil,
            this.Aplicacion,
            this.Ingresar,
            this.Consultar,
            this.Modificar,
            this.Eliminar,
            this.Imprimir});
            this.dgv_asignacionesperfiles.Location = new System.Drawing.Point(125, 309);
            this.dgv_asignacionesperfiles.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_asignacionesperfiles.Name = "dgv_asignacionesperfiles";
            this.dgv_asignacionesperfiles.RowHeadersWidth = 51;
            this.dgv_asignacionesperfiles.Size = new System.Drawing.Size(739, 212);
            this.dgv_asignacionesperfiles.TabIndex = 4;
            this.dgv_asignacionesperfiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_asignacionesperfiles_CellContentClick);
            // 
            // Perfil
            // 
            this.Perfil.FillWeight = 117.8203F;
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.MinimumWidth = 6;
            this.Perfil.Name = "Perfil";
            this.Perfil.Width = 148;
            // 
            // Aplicacion
            // 
            this.Aplicacion.FillWeight = 115.2093F;
            this.Aplicacion.HeaderText = "Aplicacion";
            this.Aplicacion.MinimumWidth = 6;
            this.Aplicacion.Name = "Aplicacion";
            this.Aplicacion.Width = 149;
            // 
            // Ingresar
            // 
            this.Ingresar.FalseValue = "0";
            this.Ingresar.FillWeight = 85.63838F;
            this.Ingresar.HeaderText = "Ingresar";
            this.Ingresar.MinimumWidth = 6;
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.TrueValue = "1";
            this.Ingresar.Width = 72;
            // 
            // Consultar
            // 
            this.Consultar.FalseValue = "0";
            this.Consultar.FillWeight = 88.13612F;
            this.Consultar.HeaderText = "Consultar";
            this.Consultar.MinimumWidth = 6;
            this.Consultar.Name = "Consultar";
            this.Consultar.TrueValue = "1";
            this.Consultar.Width = 75;
            // 
            // Modificar
            // 
            this.Modificar.FalseValue = "0";
            this.Modificar.FillWeight = 90.35796F;
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.MinimumWidth = 6;
            this.Modificar.Name = "Modificar";
            this.Modificar.TrueValue = "1";
            this.Modificar.Width = 77;
            // 
            // Eliminar
            // 
            this.Eliminar.FalseValue = "0";
            this.Eliminar.FillWeight = 92.33439F;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.TrueValue = "1";
            this.Eliminar.Width = 78;
            // 
            // Imprimir
            // 
            this.Imprimir.FalseValue = "0";
            this.Imprimir.FillWeight = 94.09251F;
            this.Imprimir.HeaderText = "Imprimir";
            this.Imprimir.MinimumWidth = 6;
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.TrueValue = "1";
            this.Imprimir.Width = 80;
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.Controls.Add(this.cbo_modulos);
            this.Gpb_datos.Controls.Add(this.lbl_modulo);
            this.Gpb_datos.Controls.Add(this.cbo_perfiles);
            this.Gpb_datos.Controls.Add(this.cbo_aplicaciones);
            this.Gpb_datos.Controls.Add(this.label1);
            this.Gpb_datos.Controls.Add(this.label2);
            this.Gpb_datos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datos.Location = new System.Drawing.Point(125, 200);
            this.Gpb_datos.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Size = new System.Drawing.Size(739, 101);
            this.Gpb_datos.TabIndex = 24;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // cbo_modulos
            // 
            this.cbo_modulos.FormattingEnabled = true;
            this.cbo_modulos.Location = new System.Drawing.Point(300, 51);
            this.cbo_modulos.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_modulos.Name = "cbo_modulos";
            this.cbo_modulos.Size = new System.Drawing.Size(160, 29);
            this.cbo_modulos.TabIndex = 14;
            this.cbo_modulos.SelectedIndexChanged += new System.EventHandler(this.Cbo_modulos_SelectedIndexChanged);
            // 
            // lbl_modulo
            // 
            this.lbl_modulo.AutoSize = true;
            this.lbl_modulo.Location = new System.Drawing.Point(348, 26);
            this.lbl_modulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_modulo.Name = "lbl_modulo";
            this.lbl_modulo.Size = new System.Drawing.Size(81, 21);
            this.lbl_modulo.TabIndex = 13;
            this.lbl_modulo.Text = "Modulos";
            // 
            // cbo_perfiles
            // 
            this.cbo_perfiles.FormattingEnabled = true;
            this.cbo_perfiles.Location = new System.Drawing.Point(96, 51);
            this.cbo_perfiles.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_perfiles.Name = "cbo_perfiles";
            this.cbo_perfiles.Size = new System.Drawing.Size(160, 29);
            this.cbo_perfiles.TabIndex = 0;
            this.cbo_perfiles.SelectedIndexChanged += new System.EventHandler(this.cbo_perfiles_SelectedIndexChanged);
            // 
            // cbo_aplicaciones
            // 
            this.cbo_aplicaciones.FormattingEnabled = true;
            this.cbo_aplicaciones.Location = new System.Drawing.Point(502, 51);
            this.cbo_aplicaciones.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_aplicaciones.Name = "cbo_aplicaciones";
            this.cbo_aplicaciones.Size = new System.Drawing.Size(160, 29);
            this.cbo_aplicaciones.TabIndex = 1;
            this.cbo_aplicaciones.SelectedIndexChanged += new System.EventHandler(this.cbo_aplicaciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Perfiles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aplicaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Haettenschweiler", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(560, 45);
            this.label3.TabIndex = 253;
            this.label3.Text = "ASIGNACION DE APLICACIONES A PERFILES";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(805, 128);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(100, 27);
            this.txt_buscar.TabIndex = 255;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackgroundImage = global::CapaDiseno.Properties.Resources.guardar1;
            this.btn_finalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_finalizar.FlatAppearance.BorderSize = 0;
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Location = new System.Drawing.Point(271, 92);
            this.btn_finalizar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(87, 87);
            this.btn_finalizar.TabIndex = 262;
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::CapaDiseno.Properties.Resources.salir1;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(504, 84);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(81, 99);
            this.btn_salir.TabIndex = 263;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::CapaDiseno.Properties.Resources.buscar1;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(705, 89);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(82, 89);
            this.btn_buscar.TabIndex = 264;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::CapaDiseno.Properties.Resources.agregar1;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Location = new System.Drawing.Point(162, 92);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(88, 87);
            this.btn_agregar.TabIndex = 265;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackgroundImage = global::CapaDiseno.Properties.Resources.ayuda1;
            this.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ayuda.FlatAppearance.BorderSize = 0;
            this.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayuda.Location = new System.Drawing.Point(597, 92);
            this.btn_ayuda.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(87, 82);
            this.btn_ayuda.TabIndex = 266;
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // btn_remover
            // 
            this.btn_remover.BackgroundImage = global::CapaDiseno.Properties.Resources.borrar1;
            this.btn_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_remover.FlatAppearance.BorderSize = 0;
            this.btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover.Location = new System.Drawing.Point(393, 92);
            this.btn_remover.Margin = new System.Windows.Forms.Padding(0);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(87, 84);
            this.btn_remover.TabIndex = 271;
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_eli_Click);
            // 
            // frm_asignacion_aplicaciones_perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 586);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_asignacionesperfiles);
            this.Controls.Add(this.Gpb_datos);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_asignacion_aplicaciones_perfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de aplicaciones a perfiles";
            this.Load += new System.EventHandler(this.Frm_asignacion_aplicaciones_perfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignacionesperfiles)).EndInit();
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_asignacionesperfiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aplicacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ingresar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Consultar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Modificar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Imprimir;
        private System.Windows.Forms.GroupBox Gpb_datos;
        public System.Windows.Forms.ComboBox cbo_modulos;
        private System.Windows.Forms.Label lbl_modulo;
        public System.Windows.Forms.ComboBox cbo_perfiles;
        private System.Windows.Forms.ComboBox cbo_aplicaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_remover;
    }
}