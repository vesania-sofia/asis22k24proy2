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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_modulos));
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.gbbuscar = new System.Windows.Forms.GroupBox();
            this.btn_bsucarmodulo = new System.Windows.Forms.Button();
            this.txt_buscarmodulo = new System.Windows.Forms.TextBox();
            this.Gpb_datos = new System.Windows.Forms.GroupBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.gbestado = new System.Windows.Forms.GroupBox();
            this.rbinhabilitado = new System.Windows.Forms.RadioButton();
            this.rbhabilitado = new System.Windows.Forms.RadioButton();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_codigomodulo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.Gpb_opciones = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_modif = new System.Windows.Forms.Button();
            this.gbbuscar.SuspendLayout();
            this.Gpb_datos.SuspendLayout();
            this.gbestado.SuspendLayout();
            this.Gpb_opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Image = global::CapaDiseno.Properties.Resources.icons8_ayuda_30;
            this.btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ayuda.Location = new System.Drawing.Point(706, 45);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(86, 36);
            this.btn_ayuda.TabIndex = 256;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click_1);
            // 
            // gbbuscar
            // 
            this.gbbuscar.Controls.Add(this.btn_bsucarmodulo);
            this.gbbuscar.Controls.Add(this.txt_buscarmodulo);
            this.gbbuscar.Location = new System.Drawing.Point(87, 23);
            this.gbbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.gbbuscar.Name = "gbbuscar";
            this.gbbuscar.Padding = new System.Windows.Forms.Padding(4);
            this.gbbuscar.Size = new System.Drawing.Size(606, 102);
            this.gbbuscar.TabIndex = 255;
            this.gbbuscar.TabStop = false;
            this.gbbuscar.Text = "Buscar Módulo";
            // 
            // btn_bsucarmodulo
            // 
            this.btn_bsucarmodulo.Location = new System.Drawing.Point(427, 41);
            this.btn_bsucarmodulo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bsucarmodulo.Name = "btn_bsucarmodulo";
            this.btn_bsucarmodulo.Size = new System.Drawing.Size(100, 30);
            this.btn_bsucarmodulo.TabIndex = 7;
            this.btn_bsucarmodulo.Text = "Buscar";
            this.btn_bsucarmodulo.UseVisualStyleBackColor = true;
            this.btn_bsucarmodulo.Click += new System.EventHandler(this.btn_bsucarmodulo_Click_1);
            // 
            // txt_buscarmodulo
            // 
            this.txt_buscarmodulo.Location = new System.Drawing.Point(95, 44);
            this.txt_buscarmodulo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscarmodulo.Name = "txt_buscarmodulo";
            this.txt_buscarmodulo.Size = new System.Drawing.Size(296, 26);
            this.txt_buscarmodulo.TabIndex = 6;
            // 
            // Gpb_datos
            // 
            this.Gpb_datos.Controls.Add(this.txtdesc);
            this.Gpb_datos.Controls.Add(this.txtcodigo);
            this.Gpb_datos.Controls.Add(this.gbestado);
            this.Gpb_datos.Controls.Add(this.Lbl_descripcion);
            this.Gpb_datos.Controls.Add(this.Lbl_nombre);
            this.Gpb_datos.Controls.Add(this.Lbl_codigomodulo);
            this.Gpb_datos.Controls.Add(this.txtnombre);
            this.Gpb_datos.Location = new System.Drawing.Point(15, 133);
            this.Gpb_datos.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Name = "Gpb_datos";
            this.Gpb_datos.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datos.Size = new System.Drawing.Size(648, 360);
            this.Gpb_datos.TabIndex = 254;
            this.Gpb_datos.TabStop = false;
            this.Gpb_datos.Text = "Datos";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(248, 143);
            this.txtdesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(296, 45);
            this.txtdesc.TabIndex = 2;
            this.txtdesc.Tag = "2";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(248, 54);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(132, 26);
            this.txtcodigo.TabIndex = 4;
            // 
            // gbestado
            // 
            this.gbestado.Controls.Add(this.rbinhabilitado);
            this.gbestado.Controls.Add(this.rbhabilitado);
            this.gbestado.Location = new System.Drawing.Point(72, 208);
            this.gbestado.Margin = new System.Windows.Forms.Padding(4);
            this.gbestado.Name = "gbestado";
            this.gbestado.Padding = new System.Windows.Forms.Padding(4);
            this.gbestado.Size = new System.Drawing.Size(481, 131);
            this.gbestado.TabIndex = 3;
            this.gbestado.TabStop = false;
            this.gbestado.Text = "Estado";
            // 
            // rbinhabilitado
            // 
            this.rbinhabilitado.AutoSize = true;
            this.rbinhabilitado.Location = new System.Drawing.Point(284, 69);
            this.rbinhabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.rbinhabilitado.Name = "rbinhabilitado";
            this.rbinhabilitado.Size = new System.Drawing.Size(114, 24);
            this.rbinhabilitado.TabIndex = 1;
            this.rbinhabilitado.TabStop = true;
            this.rbinhabilitado.Text = "Inhabilitado";
            this.rbinhabilitado.UseVisualStyleBackColor = true;
            // 
            // rbhabilitado
            // 
            this.rbhabilitado.AutoSize = true;
            this.rbhabilitado.Location = new System.Drawing.Point(89, 69);
            this.rbhabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.rbhabilitado.Name = "rbhabilitado";
            this.rbhabilitado.Size = new System.Drawing.Size(105, 24);
            this.rbhabilitado.TabIndex = 0;
            this.rbhabilitado.TabStop = true;
            this.rbhabilitado.Text = "Habilitado";
            this.rbhabilitado.UseVisualStyleBackColor = true;
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Location = new System.Drawing.Point(60, 146);
            this.Lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(99, 20);
            this.Lbl_descripcion.TabIndex = 2;
            this.Lbl_descripcion.Text = "Descripción";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Location = new System.Drawing.Point(60, 106);
            this.Lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(68, 20);
            this.Lbl_nombre.TabIndex = 1;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Lbl_codigomodulo
            // 
            this.Lbl_codigomodulo.AutoSize = true;
            this.Lbl_codigomodulo.Location = new System.Drawing.Point(60, 58);
            this.Lbl_codigomodulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_codigomodulo.Name = "Lbl_codigomodulo";
            this.Lbl_codigomodulo.Size = new System.Drawing.Size(143, 20);
            this.Lbl_codigomodulo.TabIndex = 0;
            this.Lbl_codigomodulo.Text = "Codigo de Modulo";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(248, 102);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(296, 26);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.Tag = "1";
            // 
            // Gpb_opciones
            // 
            this.Gpb_opciones.Controls.Add(this.btn_eliminar);
            this.Gpb_opciones.Controls.Add(this.btn_nuevo);
            this.Gpb_opciones.Controls.Add(this.btn_actualizar);
            this.Gpb_opciones.Controls.Add(this.Btn_exit);
            this.Gpb_opciones.Controls.Add(this.btn_salir);
            this.Gpb_opciones.Controls.Add(this.btn_cancel);
            this.Gpb_opciones.Controls.Add(this.btn_ingresar);
            this.Gpb_opciones.Controls.Add(this.btn_modif);
            this.Gpb_opciones.Location = new System.Drawing.Point(671, 133);
            this.Gpb_opciones.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_opciones.Name = "Gpb_opciones";
            this.Gpb_opciones.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_opciones.Size = new System.Drawing.Size(152, 360);
            this.Gpb_opciones.TabIndex = 253;
            this.Gpb_opciones.TabStop = false;
            this.Gpb_opciones.Text = "Opciones";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(21, 217);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 30);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click_1);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(21, 23);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(100, 30);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.Tag = "0";
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click_1);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(21, 115);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(100, 30);
            this.btn_actualizar.TabIndex = 6;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click_1);
            // 
            // Btn_exit
            // 
            this.Btn_exit.Location = new System.Drawing.Point(21, 309);
            this.Btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(100, 30);
            this.Btn_exit.TabIndex = 5;
            this.Btn_exit.Text = "Salir";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(581, 46);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(95, 30);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(21, 267);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 30);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(21, 68);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(100, 30);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Tag = "3";
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click_1);
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(21, 169);
            this.btn_modif.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(100, 30);
            this.btn_modif.TabIndex = 1;
            this.btn_modif.Text = "Modificar";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Click += new System.EventHandler(this.btn_modif_Click_1);
            // 
            // frm_modulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 514);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.gbbuscar);
            this.Controls.Add(this.Gpb_datos);
            this.Controls.Add(this.Gpb_opciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_modulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Modulos";
            this.Load += new System.EventHandler(this.Frm_modulos_Load);
            this.gbbuscar.ResumeLayout(false);
            this.gbbuscar.PerformLayout();
            this.Gpb_datos.ResumeLayout(false);
            this.Gpb_datos.PerformLayout();
            this.gbestado.ResumeLayout(false);
            this.gbestado.PerformLayout();
            this.Gpb_opciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.GroupBox gbbuscar;
        private System.Windows.Forms.Button btn_bsucarmodulo;
        private System.Windows.Forms.TextBox txt_buscarmodulo;
        private System.Windows.Forms.GroupBox Gpb_datos;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.GroupBox gbestado;
        private System.Windows.Forms.RadioButton rbinhabilitado;
        private System.Windows.Forms.RadioButton rbhabilitado;
        private System.Windows.Forms.Label Lbl_descripcion;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_codigomodulo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.GroupBox Gpb_opciones;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_modif;
    }
}