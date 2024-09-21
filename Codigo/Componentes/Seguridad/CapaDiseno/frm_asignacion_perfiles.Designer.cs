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
            this.dgv_perfiles_asignados = new System.Windows.Forms.DataGridView();
            this.btn_B = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_perfiles = new System.Windows.Forms.Label();
            this.cbo_perfiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_usuario = new System.Windows.Forms.ComboBox();
            this.btn_q = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_c = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_n = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignacion_perfiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_perfiles_asignados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.dgv_asignacion_perfiles.Size = new System.Drawing.Size(325, 148);
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
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.groupBox1.Controls.Add(this.dgv_perfiles_asignados);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 426);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(669, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de Perfiles de Usuarios";
            // 
            // dgv_perfiles_asignados
            // 
            this.dgv_perfiles_asignados.AllowUserToAddRows = false;
            this.dgv_perfiles_asignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_perfiles_asignados.Location = new System.Drawing.Point(142, 24);
            this.dgv_perfiles_asignados.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_perfiles_asignados.Name = "dgv_perfiles_asignados";
            this.dgv_perfiles_asignados.Size = new System.Drawing.Size(496, 175);
            this.dgv_perfiles_asignados.TabIndex = 8;
            // 
            // btn_B
            // 
            this.btn_B.Location = new System.Drawing.Point(34, 207);
            this.btn_B.Margin = new System.Windows.Forms.Padding(4);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(79, 35);
            this.btn_B.TabIndex = 251;
            this.btn_B.Tag = "5";
            this.btn_B.Text = "Buscar";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.groupBox2.Controls.Add(this.lbl_perfiles);
            this.groupBox2.Controls.Add(this.cbo_perfiles);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbo_usuario);
            this.groupBox2.Controls.Add(this.dgv_asignacion_perfiles);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 200);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(620, 188);
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
            // btn_q
            // 
            this.btn_q.Location = new System.Drawing.Point(34, 152);
            this.btn_q.Margin = new System.Windows.Forms.Padding(4);
            this.btn_q.Name = "btn_q";
            this.btn_q.Size = new System.Drawing.Size(79, 36);
            this.btn_q.TabIndex = 9;
            this.btn_q.Text = "Quitar";
            this.btn_q.UseVisualStyleBackColor = true;
            this.btn_q.Click += new System.EventHandler(this.Btn_quitar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 6;
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_B);
            this.groupBox3.Controls.Add(this.btn_c);
            this.groupBox3.Controls.Add(this.btn_q);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.btn_n);
            this.groupBox3.Controls.Add(this.btn_1);
            this.groupBox3.Location = new System.Drawing.Point(663, 200);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(144, 326);
            this.groupBox3.TabIndex = 258;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(34, 265);
            this.btn_c.Margin = new System.Windows.Forms.Padding(4);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(79, 34);
            this.btn_c.TabIndex = 254;
            this.btn_c.Text = "Cancelar";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_cancel_Click);
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
            // btn_n
            // 
            this.btn_n.Location = new System.Drawing.Point(34, 92);
            this.btn_n.Margin = new System.Windows.Forms.Padding(4);
            this.btn_n.Name = "btn_n";
            this.btn_n.Size = new System.Drawing.Size(79, 33);
            this.btn_n.TabIndex = 253;
            this.btn_n.Tag = "0";
            this.btn_n.Text = "Guardar";
            this.btn_n.UseVisualStyleBackColor = true;
            this.btn_n.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(34, 31);
            this.btn_1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(79, 35);
            this.btn_1.TabIndex = 250;
            this.btn_1.Tag = "5";
            this.btn_1.Text = "Agregar";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Haettenschweiler", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(128, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(554, 37);
            this.label3.TabIndex = 259;
            this.label3.Text = "A s i g n a c i o n   d e  p e r f i l e s   a   U s u a r i o s";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.btn_buscar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_agregar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_salir, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_remover, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_guardar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(739, 42);
            this.tableLayoutPanel1.TabIndex = 265;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::CapaDiseno.Properties.Resources.buscar1;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(123, 0);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(120, 42);
            this.btn_buscar.TabIndex = 259;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CapaDiseno.Properties.Resources.ayuda1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(615, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 263;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = global::CapaDiseno.Properties.Resources.agregar1;
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Location = new System.Drawing.Point(0, 0);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(120, 42);
            this.btn_agregar.TabIndex = 258;
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::CapaDiseno.Properties.Resources.salir1;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(492, 0);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(120, 42);
            this.btn_salir.TabIndex = 262;
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_remover
            // 
            this.btn_remover.BackgroundImage = global::CapaDiseno.Properties.Resources.cancelar;
            this.btn_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_remover.FlatAppearance.BorderSize = 0;
            this.btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remover.Location = new System.Drawing.Point(246, 0);
            this.btn_remover.Margin = new System.Windows.Forms.Padding(0);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(120, 42);
            this.btn_remover.TabIndex = 260;
            this.btn_remover.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::CapaDiseno.Properties.Resources.guardar1;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(369, 0);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(123, 42);
            this.btn_guardar.TabIndex = 261;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // frm_asignacion_perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(829, 664);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_perfiles_asignados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_asignacion_perfiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_q;
        private System.Windows.Forms.Label lbl_perfiles;
        private System.Windows.Forms.ComboBox cbo_perfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePerfil;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_n;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.DataGridView dgv_perfiles_asignados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button button1;
    }
}