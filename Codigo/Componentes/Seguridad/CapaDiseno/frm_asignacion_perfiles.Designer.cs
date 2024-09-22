namespace CapaDiseno
{
    partial class frm_asignacion_perfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_asignacion_perfiles));
            this.dgv_asignacion_perfiles = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_consultaperfilesusuarios = new System.Windows.Forms.GroupBox();
            this.dgv_perfiles_asignados = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.gpb_perfilesusuarios = new System.Windows.Forms.GroupBox();
            this.Lbl_perfiles = new System.Windows.Forms.Label();
            this.cbo_perfiles = new System.Windows.Forms.ComboBox();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.cbo_usuario = new System.Windows.Forms.ComboBox();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.Lbl_asignacionperfiles = new System.Windows.Forms.Label();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.Gpb_opciones = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignacion_perfiles)).BeginInit();
            this.gpb_consultaperfilesusuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_perfiles_asignados)).BeginInit();
            this.gpb_perfilesusuarios.SuspendLayout();
            this.Gpb_opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_asignacion_perfiles
            // 
            this.dgv_asignacion_perfiles.AllowUserToAddRows = false;
            this.dgv_asignacion_perfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asignacion_perfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.NombrePerfil});
            this.dgv_asignacion_perfiles.Location = new System.Drawing.Point(242, 24);
            this.dgv_asignacion_perfiles.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_asignacion_perfiles.Name = "dgv_asignacion_perfiles";
            this.dgv_asignacion_perfiles.RowHeadersWidth = 51;
            this.dgv_asignacion_perfiles.Size = new System.Drawing.Size(325, 148);
            this.dgv_asignacion_perfiles.TabIndex = 1;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 140;
            // 
            // NombrePerfil
            // 
            this.NombrePerfil.HeaderText = "Perfil";
            this.NombrePerfil.MinimumWidth = 6;
            this.NombrePerfil.Name = "NombrePerfil";
            this.NombrePerfil.Width = 140;
            // 
            // gpb_consultaperfilesusuarios
            // 
            this.gpb_consultaperfilesusuarios.Controls.Add(this.dgv_perfiles_asignados);
            this.gpb_consultaperfilesusuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_consultaperfilesusuarios.Location = new System.Drawing.Point(44, 291);
            this.gpb_consultaperfilesusuarios.Margin = new System.Windows.Forms.Padding(4);
            this.gpb_consultaperfilesusuarios.Name = "gpb_consultaperfilesusuarios";
            this.gpb_consultaperfilesusuarios.Padding = new System.Windows.Forms.Padding(4);
            this.gpb_consultaperfilesusuarios.Size = new System.Drawing.Size(586, 210);
            this.gpb_consultaperfilesusuarios.TabIndex = 4;
            this.gpb_consultaperfilesusuarios.TabStop = false;
            this.gpb_consultaperfilesusuarios.Text = "Consulta de Perfiles de Usuarios";
            // 
            // dgv_perfiles_asignados
            // 
            this.dgv_perfiles_asignados.AllowUserToAddRows = false;
            this.dgv_perfiles_asignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_perfiles_asignados.Location = new System.Drawing.Point(125, 24);
            this.dgv_perfiles_asignados.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_perfiles_asignados.Name = "dgv_perfiles_asignados";
            this.dgv_perfiles_asignados.RowHeadersWidth = 51;
            this.dgv_perfiles_asignados.Size = new System.Drawing.Size(355, 175);
            this.dgv_perfiles_asignados.TabIndex = 8;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(34, 207);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(79, 35);
            this.btn_Buscar.TabIndex = 251;
            this.btn_Buscar.Tag = "5";
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // gpb_perfilesusuarios
            // 
            this.gpb_perfilesusuarios.Controls.Add(this.Lbl_perfiles);
            this.gpb_perfilesusuarios.Controls.Add(this.cbo_perfiles);
            this.gpb_perfilesusuarios.Controls.Add(this.Lbl_usuario);
            this.gpb_perfilesusuarios.Controls.Add(this.cbo_usuario);
            this.gpb_perfilesusuarios.Controls.Add(this.dgv_asignacion_perfiles);
            this.gpb_perfilesusuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_perfilesusuarios.Location = new System.Drawing.Point(44, 84);
            this.gpb_perfilesusuarios.Margin = new System.Windows.Forms.Padding(4);
            this.gpb_perfilesusuarios.Name = "gpb_perfilesusuarios";
            this.gpb_perfilesusuarios.Padding = new System.Windows.Forms.Padding(4);
            this.gpb_perfilesusuarios.Size = new System.Drawing.Size(586, 188);
            this.gpb_perfilesusuarios.TabIndex = 5;
            this.gpb_perfilesusuarios.TabStop = false;
            this.gpb_perfilesusuarios.Text = "Asignacion de Perfiles a Usuarios";
            // 
            // Lbl_perfiles
            // 
            this.Lbl_perfiles.AutoSize = true;
            this.Lbl_perfiles.Location = new System.Drawing.Point(80, 92);
            this.Lbl_perfiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_perfiles.Name = "Lbl_perfiles";
            this.Lbl_perfiles.Size = new System.Drawing.Size(65, 21);
            this.Lbl_perfiles.TabIndex = 7;
            this.Lbl_perfiles.Text = "Perfiles";
            // 
            // cbo_perfiles
            // 
            this.cbo_perfiles.FormattingEnabled = true;
            this.cbo_perfiles.Location = new System.Drawing.Point(11, 127);
            this.cbo_perfiles.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_perfiles.Name = "cbo_perfiles";
            this.cbo_perfiles.Size = new System.Drawing.Size(199, 29);
            this.cbo_perfiles.TabIndex = 6;
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Location = new System.Drawing.Point(80, 28);
            this.Lbl_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(70, 21);
            this.Lbl_usuario.TabIndex = 5;
            this.Lbl_usuario.Text = "Usuario";
            // 
            // cbo_usuario
            // 
            this.cbo_usuario.FormattingEnabled = true;
            this.cbo_usuario.Location = new System.Drawing.Point(11, 54);
            this.cbo_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_usuario.Name = "cbo_usuario";
            this.cbo_usuario.Size = new System.Drawing.Size(199, 29);
            this.cbo_usuario.TabIndex = 4;
            this.cbo_usuario.SelectedIndexChanged += new System.EventHandler(this.Cbo_usuario_SelectedIndexChanged);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Location = new System.Drawing.Point(34, 152);
            this.btn_quitar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(79, 36);
            this.btn_quitar.TabIndex = 9;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.Btn_quitar_Click);
            // 
            // Lbl_asignacionperfiles
            // 
            this.Lbl_asignacionperfiles.AutoSize = true;
            this.Lbl_asignacionperfiles.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_asignacionperfiles.Location = new System.Drawing.Point(246, 18);
            this.Lbl_asignacionperfiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_asignacionperfiles.Name = "Lbl_asignacionperfiles";
            this.Lbl_asignacionperfiles.Size = new System.Drawing.Size(437, 33);
            this.Lbl_asignacionperfiles.TabIndex = 6;
            this.Lbl_asignacionperfiles.Text = "Asignacion de perfiles a Usuarios";
            this.Lbl_asignacionperfiles.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Image = global::CapaDiseno.Properties.Resources.icons8_ayuda_30;
            this.btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ayuda.Location = new System.Drawing.Point(731, 6);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(86, 36);
            this.btn_ayuda.TabIndex = 252;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Gpb_opciones
            // 
            this.Gpb_opciones.Controls.Add(this.btn_Buscar);
            this.Gpb_opciones.Controls.Add(this.btn_cancel);
            this.Gpb_opciones.Controls.Add(this.btn_quitar);
            this.Gpb_opciones.Controls.Add(this.button5);
            this.Gpb_opciones.Controls.Add(this.btn_nuevo);
            this.Gpb_opciones.Controls.Add(this.btn_ingresar);
            this.Gpb_opciones.Location = new System.Drawing.Point(653, 84);
            this.Gpb_opciones.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_opciones.Name = "Gpb_opciones";
            this.Gpb_opciones.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_opciones.Size = new System.Drawing.Size(144, 326);
            this.Gpb_opciones.TabIndex = 258;
            this.Gpb_opciones.TabStop = false;
            this.Gpb_opciones.Text = "Opciones";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(34, 265);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(79, 34);
            this.btn_cancel.TabIndex = 254;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(581, 46);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(34, 92);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(79, 33);
            this.btn_nuevo.TabIndex = 253;
            this.btn_nuevo.Tag = "0";
            this.btn_nuevo.Text = "Guardar";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(34, 31);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(79, 35);
            this.btn_ingresar.TabIndex = 250;
            this.btn_ingresar.Tag = "5";
            this.btn_ingresar.Text = "Agregar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // frm_asignacion_perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 514);
            this.Controls.Add(this.Gpb_opciones);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.Lbl_asignacionperfiles);
            this.Controls.Add(this.gpb_perfilesusuarios);
            this.Controls.Add(this.gpb_consultaperfilesusuarios);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_asignacion_perfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de Perfiles a Usuarios";
            this.Load += new System.EventHandler(this.Frm_asignacion_perfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignacion_perfiles)).EndInit();
            this.gpb_consultaperfilesusuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_perfiles_asignados)).EndInit();
            this.gpb_perfilesusuarios.ResumeLayout(false);
            this.gpb_perfilesusuarios.PerformLayout();
            this.Gpb_opciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_asignacion_perfiles;
        private System.Windows.Forms.GroupBox gpb_consultaperfilesusuarios;
        private System.Windows.Forms.GroupBox gpb_perfilesusuarios;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Label Lbl_perfiles;
        private System.Windows.Forms.ComboBox cbo_perfiles;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.ComboBox cbo_usuario;
        private System.Windows.Forms.Label Lbl_asignacionperfiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePerfil;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.GroupBox Gpb_opciones;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dgv_perfiles_asignados;
    }
}