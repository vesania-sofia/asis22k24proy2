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
            this.dgv_asignacion_perfiles = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_perfiles = new System.Windows.Forms.Label();
            this.cbo_perfiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_usuario = new System.Windows.Forms.ComboBox();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modif = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.dgv_perfiles_asignados = new System.Windows.Forms.DataGridView();
            this.cbo_Asignacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ActualizarA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignacion_perfiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_perfiles_asignados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_asignacion_perfiles
            // 
            this.dgv_asignacion_perfiles.AllowUserToAddRows = false;
            this.dgv_asignacion_perfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asignacion_perfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.NombrePerfil});
            this.dgv_asignacion_perfiles.Location = new System.Drawing.Point(356, 24);
            this.dgv_asignacion_perfiles.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_asignacion_perfiles.Name = "dgv_asignacion_perfiles";
            this.dgv_asignacion_perfiles.Size = new System.Drawing.Size(325, 62);
            this.dgv_asignacion_perfiles.TabIndex = 1;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 140;
            // 
            // NombrePerfil
            // 
            this.NombrePerfil.HeaderText = "Perfil";
            this.NombrePerfil.Name = "NombrePerfil";
            this.NombrePerfil.Width = 140;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ActualizarA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbo_Asignacion);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.dgv_perfiles_asignados);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 279);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(755, 222);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de Perfiles de Usuarios";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(21, 39);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(79, 35);
            this.btn_Buscar.TabIndex = 251;
            this.btn_Buscar.Tag = "5";
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_perfiles);
            this.groupBox2.Controls.Add(this.cbo_perfiles);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbo_usuario);
            this.groupBox2.Controls.Add(this.dgv_asignacion_perfiles);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(44, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(755, 172);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignacion de Perfiles a Usuarios";
            // 
            // lbl_perfiles
            // 
            this.lbl_perfiles.AutoSize = true;
            this.lbl_perfiles.Location = new System.Drawing.Point(80, 92);
            this.lbl_perfiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_perfiles.Name = "lbl_perfiles";
            this.lbl_perfiles.Size = new System.Drawing.Size(51, 17);
            this.lbl_perfiles.TabIndex = 7;
            this.lbl_perfiles.Text = "Perfiles";
            // 
            // cbo_perfiles
            // 
            this.cbo_perfiles.FormattingEnabled = true;
            this.cbo_perfiles.Location = new System.Drawing.Point(11, 127);
            this.cbo_perfiles.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_perfiles.Name = "cbo_perfiles";
            this.cbo_perfiles.Size = new System.Drawing.Size(199, 25);
            this.cbo_perfiles.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // cbo_usuario
            // 
            this.cbo_usuario.FormattingEnabled = true;
            this.cbo_usuario.Location = new System.Drawing.Point(11, 54);
            this.cbo_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_usuario.Name = "cbo_usuario";
            this.cbo_usuario.Size = new System.Drawing.Size(199, 25);
            this.cbo_usuario.TabIndex = 4;
            this.cbo_usuario.SelectedIndexChanged += new System.EventHandler(this.Cbo_usuario_SelectedIndexChanged);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Location = new System.Drawing.Point(34, 127);
            this.btn_quitar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(79, 36);
            this.btn_quitar.TabIndex = 9;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Click += new System.EventHandler(this.Btn_quitar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Asignacion de perfiles a Usuarios";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Image = global::CapaDiseno.Properties.Resources.icons8_ayuda_30;
            this.btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ayuda.Location = new System.Drawing.Point(740, 6);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(86, 36);
            this.btn_ayuda.TabIndex = 252;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_cancel);
            this.groupBox3.Controls.Add(this.btn_quitar);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.btn_nuevo);
            this.groupBox3.Controls.Add(this.btn_eliminar);
            this.groupBox3.Controls.Add(this.btn_modif);
            this.groupBox3.Controls.Add(this.btn_actualizar);
            this.groupBox3.Controls.Add(this.btn_ingresar);
            this.groupBox3.Location = new System.Drawing.Point(847, 84);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(144, 389);
            this.groupBox3.TabIndex = 258;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(34, 337);
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
            this.btn_nuevo.Location = new System.Drawing.Point(34, 79);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(79, 30);
            this.btn_nuevo.TabIndex = 253;
            this.btn_nuevo.Tag = "0";
            this.btn_nuevo.Text = "Guardar";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(34, 284);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(79, 32);
            this.btn_eliminar.TabIndex = 247;
            this.btn_eliminar.Tag = "7";
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(34, 181);
            this.btn_modif.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(79, 35);
            this.btn_modif.TabIndex = 249;
            this.btn_modif.Tag = "6";
            this.btn_modif.Text = "Modificar";
            this.btn_modif.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(34, 234);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(79, 31);
            this.btn_actualizar.TabIndex = 252;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
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
            // dgv_perfiles_asignados
            // 
            this.dgv_perfiles_asignados.AllowUserToAddRows = false;
            this.dgv_perfiles_asignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_perfiles_asignados.Location = new System.Drawing.Point(356, 39);
            this.dgv_perfiles_asignados.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_perfiles_asignados.Name = "dgv_perfiles_asignados";
            this.dgv_perfiles_asignados.Size = new System.Drawing.Size(355, 175);
            this.dgv_perfiles_asignados.TabIndex = 8;
            // 
            // cbo_Asignacion
            // 
            this.cbo_Asignacion.FormattingEnabled = true;
            this.cbo_Asignacion.Location = new System.Drawing.Point(11, 136);
            this.cbo_Asignacion.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Asignacion.Name = "cbo_Asignacion";
            this.cbo_Asignacion.Size = new System.Drawing.Size(199, 25);
            this.cbo_Asignacion.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Asignaciones";
            // 
            // btn_ActualizarA
            // 
            this.btn_ActualizarA.Location = new System.Drawing.Point(240, 132);
            this.btn_ActualizarA.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ActualizarA.Name = "btn_ActualizarA";
            this.btn_ActualizarA.Size = new System.Drawing.Size(79, 31);
            this.btn_ActualizarA.TabIndex = 253;
            this.btn_ActualizarA.Text = "Actualizar";
            this.btn_ActualizarA.UseVisualStyleBackColor = true;
            this.btn_ActualizarA.Click += new System.EventHandler(this.btn_ActualizarA_Click);
            // 
            // frm_asignacion_perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 514);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_asignacion_perfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de Perfiles a Usuarios";
            this.Load += new System.EventHandler(this.Frm_asignacion_perfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignacion_perfiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_perfiles_asignados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_asignacion_perfiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Label lbl_perfiles;
        private System.Windows.Forms.ComboBox cbo_perfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePerfil;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dgv_perfiles_asignados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Asignacion;
        private System.Windows.Forms.Button btn_ActualizarA;
    }
}