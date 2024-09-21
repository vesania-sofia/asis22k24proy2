namespace CapaDiseno
{
    partial class frm_modulos
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
            this.gbbuscar = new System.Windows.Forms.GroupBox();
            this.tbx_buscarmodulo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.gbestado = new System.Windows.Forms.GroupBox();
            this.rbinhabilitado = new System.Windows.Forms.RadioButton();
            this.rbhabilitado = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modif = new System.Windows.Forms.Button();
            this.btn_bsucarmodulo = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbbuscar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbestado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbbuscar
            // 
            this.gbbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.gbbuscar.Controls.Add(this.tbx_buscarmodulo);
            this.gbbuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbbuscar.Location = new System.Drawing.Point(169, 151);
            this.gbbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.gbbuscar.Name = "gbbuscar";
            this.gbbuscar.Padding = new System.Windows.Forms.Padding(4);
            this.gbbuscar.Size = new System.Drawing.Size(648, 98);
            this.gbbuscar.TabIndex = 255;
            this.gbbuscar.TabStop = false;
            this.gbbuscar.Text = "Buscar Módulo";
            // 
            // tbx_buscarmodulo
            // 
            this.tbx_buscarmodulo.Location = new System.Drawing.Point(37, 36);
            this.tbx_buscarmodulo.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_buscarmodulo.Name = "tbx_buscarmodulo";
            this.tbx_buscarmodulo.Size = new System.Drawing.Size(573, 26);
            this.tbx_buscarmodulo.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.groupBox2.Controls.Add(this.txtdesc);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.gbestado);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtnombre);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(169, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(648, 360);
            this.groupBox2.TabIndex = 254;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(246, 96);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(296, 26);
            this.txtdesc.TabIndex = 2;
            this.txtdesc.Tag = "2";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(246, 41);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(297, 24);
            this.txtcodigo.TabIndex = 4;
            // 
            // gbestado
            // 
            this.gbestado.Controls.Add(this.rbinhabilitado);
            this.gbestado.Controls.Add(this.rbhabilitado);
            this.gbestado.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbestado.Location = new System.Drawing.Point(102, 208);
            this.gbestado.Margin = new System.Windows.Forms.Padding(4);
            this.gbestado.Name = "gbestado";
            this.gbestado.Padding = new System.Windows.Forms.Padding(4);
            this.gbestado.Size = new System.Drawing.Size(441, 131);
            this.gbestado.TabIndex = 3;
            this.gbestado.TabStop = false;
            this.gbestado.Text = "Estado";
            // 
            // rbinhabilitado
            // 
            this.rbinhabilitado.AutoSize = true;
            this.rbinhabilitado.Location = new System.Drawing.Point(255, 58);
            this.rbinhabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.rbinhabilitado.Name = "rbinhabilitado";
            this.rbinhabilitado.Size = new System.Drawing.Size(111, 23);
            this.rbinhabilitado.TabIndex = 1;
            this.rbinhabilitado.TabStop = true;
            this.rbinhabilitado.Text = "Inhabilitado";
            this.rbinhabilitado.UseVisualStyleBackColor = true;
            // 
            // rbhabilitado
            // 
            this.rbhabilitado.AutoSize = true;
            this.rbhabilitado.Location = new System.Drawing.Point(75, 58);
            this.rbhabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.rbhabilitado.Name = "rbhabilitado";
            this.rbhabilitado.Size = new System.Drawing.Size(100, 23);
            this.rbhabilitado.TabIndex = 0;
            this.rbhabilitado.TabStop = true;
            this.rbhabilitado.Text = "Habilitado";
            this.rbhabilitado.UseVisualStyleBackColor = true;
            this.rbhabilitado.CheckedChanged += new System.EventHandler(this.rbhabilitado_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Módulo";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(245, 150);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(297, 24);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.Tag = "1";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_cancel.BackgroundImage = global::CapaDiseno.Properties.Resources.cancelar1;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(632, 86);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(93, 42);
            this.btn_cancel.TabIndex = 290;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_eliminar.BackgroundImage = global::CapaDiseno.Properties.Resources.borrar11;
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Location = new System.Drawing.Point(539, 86);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(93, 42);
            this.btn_eliminar.TabIndex = 289;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click_1);
            // 
            // btn_modif
            // 
            this.btn_modif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_modif.BackgroundImage = global::CapaDiseno.Properties.Resources.editar11;
            this.btn_modif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_modif.FlatAppearance.BorderSize = 0;
            this.btn_modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modif.Location = new System.Drawing.Point(446, 86);
            this.btn_modif.Margin = new System.Windows.Forms.Padding(0);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(93, 42);
            this.btn_modif.TabIndex = 288;
            this.btn_modif.UseVisualStyleBackColor = false;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click);
            // 
            // btn_bsucarmodulo
            // 
            this.btn_bsucarmodulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_bsucarmodulo.BackgroundImage = global::CapaDiseno.Properties.Resources.buscar12;
            this.btn_bsucarmodulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_bsucarmodulo.FlatAppearance.BorderSize = 0;
            this.btn_bsucarmodulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bsucarmodulo.Location = new System.Drawing.Point(353, 86);
            this.btn_bsucarmodulo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_bsucarmodulo.Name = "btn_bsucarmodulo";
            this.btn_bsucarmodulo.Size = new System.Drawing.Size(93, 42);
            this.btn_bsucarmodulo.TabIndex = 287;
            this.btn_bsucarmodulo.UseVisualStyleBackColor = false;
            this.btn_bsucarmodulo.Click += new System.EventHandler(this.btn_bsucarmodulo_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_actualizar.BackgroundImage = global::CapaDiseno.Properties.Resources.guardar22;
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Location = new System.Drawing.Point(260, 86);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(93, 42);
            this.btn_actualizar.TabIndex = 286;
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click_1);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_ingresar.BackgroundImage = global::CapaDiseno.Properties.Resources.guardar13;
            this.btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Location = new System.Drawing.Point(167, 86);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(93, 42);
            this.btn_ingresar.TabIndex = 285;
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click_1);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_ayuda.BackgroundImage = global::CapaDiseno.Properties.Resources.ayuda1;
            this.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ayuda.FlatAppearance.BorderSize = 0;
            this.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayuda.Location = new System.Drawing.Point(818, 86);
            this.btn_ayuda.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(93, 42);
            this.btn_ayuda.TabIndex = 284;
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_salir.BackgroundImage = global::CapaDiseno.Properties.Resources.salir1;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(725, 86);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(93, 42);
            this.btn_salir.TabIndex = 283;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btn_nuevo.BackgroundImage = global::CapaDiseno.Properties.Resources.agregar1;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Location = new System.Drawing.Point(74, 86);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(93, 42);
            this.btn_nuevo.TabIndex = 277;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Haettenschweiler", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(273, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 37);
            this.label4.TabIndex = 291;
            this.label4.Text = "M a n t e n i m i e n t o   d e   M ó d u l o s";
            // 
            // frm_modulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(973, 663);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.btn_bsucarmodulo);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.gbbuscar);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_modulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Modulos";
            this.Load += new System.EventHandler(this.Frm_modulos_Load);
            this.gbbuscar.ResumeLayout(false);
            this.gbbuscar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbestado.ResumeLayout(false);
            this.gbestado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbbuscar;
        private System.Windows.Forms.TextBox tbx_buscarmodulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.GroupBox gbestado;
        private System.Windows.Forms.RadioButton rbinhabilitado;
        private System.Windows.Forms.RadioButton rbhabilitado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_bsucarmodulo;
        private System.Windows.Forms.Button btn_modif;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label4;
    }
}