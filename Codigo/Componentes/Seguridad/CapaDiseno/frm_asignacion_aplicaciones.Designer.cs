namespace CapaDiseno
{
    partial class frm_asignacion_aplicaciones
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
            this.Cbo_usuarios = new System.Windows.Forms.ComboBox();
            this.Cbo_aplicaciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_asignaciones = new System.Windows.Forms.DataGridView();
            this.Usuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingresar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Consultar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Imprimir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.Cbo_modulos = new System.Windows.Forms.ComboBox();
            this.lbl_modulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Gbp_datos2 = new System.Windows.Forms.GroupBox();
            this.Dgv_aplicaciones_asignados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignaciones)).BeginInit();
            this.Gpb_datos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Gbp_datos2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aplicaciones_asignados)).BeginInit();
            this.SuspendLayout();
            // 
            // Cbo_usuarios
            // 
            this.Cbo_usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Cbo_usuarios.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_usuarios.FormattingEnabled = true;
            this.Cbo_usuarios.Location = new System.Drawing.Point(41, 47);
            this.Cbo_usuarios.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_usuarios.Name = "Cbo_usuarios";
            this.Cbo_usuarios.Size = new System.Drawing.Size(160, 30);
            this.Cbo_usuarios.TabIndex = 0;
            // 
            // Cbo_aplicaciones
            // 
            this.Cbo_aplicaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Cbo_aplicaciones.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_aplicaciones.FormattingEnabled = true;
            this.Cbo_aplicaciones.Location = new System.Drawing.Point(536, 46);
            this.Cbo_aplicaciones.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_aplicaciones.Name = "Cbo_aplicaciones";
            this.Cbo_aplicaciones.Size = new System.Drawing.Size(160, 30);
            this.Cbo_aplicaciones.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aplicaciones";
            // 
            // Dgv_asignaciones
            // 
            this.Dgv_asignaciones.AllowUserToAddRows = false;
            this.Dgv_asignaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Dgv_asignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asignaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuarios,
            this.Aplicacion,
            this.Ingresar,
            this.Consultar,
            this.Modificar,
            this.Eliminar,
            this.Imprimir});
            this.Dgv_asignaciones.Location = new System.Drawing.Point(107, 345);
            this.Dgv_asignaciones.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_asignaciones.Name = "Dgv_asignaciones";
            this.Dgv_asignaciones.RowHeadersWidth = 51;
            this.Dgv_asignaciones.Size = new System.Drawing.Size(739, 232);
            this.Dgv_asignaciones.TabIndex = 4;
            this.Dgv_asignaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_asignaciones_CellContentClick);
            // 
            // Usuarios
            // 
            this.Usuarios.FillWeight = 117.8203F;
            this.Usuarios.HeaderText = "Usuario";
            this.Usuarios.MinimumWidth = 6;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Width = 148;
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
            this.Gpb_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gpb_datos.Controls.Add(this.Cbo_modulos);
            this.Gpb_datos.Controls.Add(this.lbl_modulo);
            this.Gpb_datos.Controls.Add(this.Cbo_usuarios);
            this.Gpb_datos.Controls.Add(this.Cbo_aplicaciones);
            this.Gpb_datos.Controls.Add(this.label1);
            this.Gpb_datos.Controls.Add(this.label2);
            this.Gpb_datos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datos.Location = new System.Drawing.Point(107, 227);
            this.Gpb_datos.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Size = new System.Drawing.Size(739, 101);
            this.Gpb_datos.TabIndex = 12;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // Cbo_modulos
            // 
            this.Cbo_modulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Cbo_modulos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_modulos.FormattingEnabled = true;
            this.Cbo_modulos.Location = new System.Drawing.Point(279, 47);
            this.Cbo_modulos.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_modulos.Name = "Cbo_modulos";
            this.Cbo_modulos.Size = new System.Drawing.Size(160, 30);
            this.Cbo_modulos.TabIndex = 12;
            this.Cbo_modulos.SelectedIndexChanged += new System.EventHandler(this.Cbo_modulos_SelectedIndexChanged);
            // 
            // lbl_modulo
            // 
            this.lbl_modulo.AutoSize = true;
            this.lbl_modulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modulo.Location = new System.Drawing.Point(312, 26);
            this.lbl_modulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_modulo.Name = "lbl_modulo";
            this.lbl_modulo.Size = new System.Drawing.Size(96, 27);
            this.lbl_modulo.TabIndex = 11;
            this.lbl_modulo.Text = "Modulos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Haettenschweiler", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(158, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(952, 54);
            this.label3.TabIndex = 15;
            this.label3.Text = "A s i g n a c i ó n   d e   A p l i c a c i o n e s   a   U s u a r i o s";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_limpiar, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_buscar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_agregar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_salir, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_eliminar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_guardar, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 137);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 42);
            this.tableLayoutPanel1.TabIndex = 264;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.BackgroundImage = global::CapaDiseno.Properties.Resources.cancelar;
            this.Btn_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_limpiar.FlatAppearance.BorderSize = 0;
            this.Btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_limpiar.Location = new System.Drawing.Point(492, 0);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(120, 42);
            this.Btn_limpiar.TabIndex = 260;
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.btn_remover_Click_1);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackgroundImage = global::CapaDiseno.Properties.Resources.buscar1;
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_buscar.FlatAppearance.BorderSize = 0;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Location = new System.Drawing.Point(369, 0);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(120, 42);
            this.Btn_buscar.TabIndex = 259;
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click_1);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackgroundImage = global::CapaDiseno.Properties.Resources.agregar1;
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Location = new System.Drawing.Point(0, 0);
            this.Btn_agregar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(120, 42);
            this.Btn_agregar.TabIndex = 258;
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click_1);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackgroundImage = global::CapaDiseno.Properties.Resources.salir1;
            this.Btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_salir.FlatAppearance.BorderSize = 0;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Location = new System.Drawing.Point(615, 0);
            this.Btn_salir.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(120, 42);
            this.Btn_salir.TabIndex = 262;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_eliminar.BackgroundImage = global::CapaDiseno.Properties.Resources.borrar11;
            this.Btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Location = new System.Drawing.Point(123, 0);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(123, 42);
            this.Btn_eliminar.TabIndex = 290;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackgroundImage = global::CapaDiseno.Properties.Resources.guardar1;
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Location = new System.Drawing.Point(246, 0);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(123, 42);
            this.Btn_guardar.TabIndex = 261;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_ayuda.BackgroundImage = global::CapaDiseno.Properties.Resources.ayuda1;
            this.Btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Location = new System.Drawing.Point(776, 137);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(124, 42);
            this.Btn_ayuda.TabIndex = 263;
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            this.Btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click_1);
            // 
            // Gbp_datos2
            // 
            this.Gbp_datos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Gbp_datos2.Controls.Add(this.Dgv_aplicaciones_asignados);
            this.Gbp_datos2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbp_datos2.Location = new System.Drawing.Point(887, 345);
            this.Gbp_datos2.Margin = new System.Windows.Forms.Padding(4);
            this.Gbp_datos2.Name = "Gbp_datos2";
            this.Gbp_datos2.Padding = new System.Windows.Forms.Padding(4);
            this.Gbp_datos2.Size = new System.Drawing.Size(499, 232);
            this.Gbp_datos2.TabIndex = 266;
            this.Gbp_datos2.TabStop = false;
            this.Gbp_datos2.Text = "Consulta de Aplicaciones a Usuarios";
            // 
            // Dgv_aplicaciones_asignados
            // 
            this.Dgv_aplicaciones_asignados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Dgv_aplicaciones_asignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_aplicaciones_asignados.Location = new System.Drawing.Point(11, 41);
            this.Dgv_aplicaciones_asignados.Name = "Dgv_aplicaciones_asignados";
            this.Dgv_aplicaciones_asignados.RowHeadersWidth = 62;
            this.Dgv_aplicaciones_asignados.RowTemplate.Height = 28;
            this.Dgv_aplicaciones_asignados.Size = new System.Drawing.Size(481, 184);
            this.Dgv_aplicaciones_asignados.TabIndex = 0;
            // 
            // frm_asignacion_aplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1362, 621);
            this.Controls.Add(this.Gbp_datos2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gpb_datos);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Dgv_asignaciones);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_asignacion_aplicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Frm_asignacion_aplicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignaciones)).EndInit();
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Gbp_datos2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aplicaciones_asignados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Cbo_aplicaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_asignaciones;
        private System.Windows.Forms.GroupBox Gpb_datos;
        public System.Windows.Forms.ComboBox Cbo_usuarios;
        public System.Windows.Forms.ComboBox Cbo_modulos;
        private System.Windows.Forms.Label lbl_modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aplicacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ingresar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Consultar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Modificar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Imprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.GroupBox Gbp_datos2;
        private System.Windows.Forms.DataGridView Dgv_aplicaciones_asignados;
    }
}