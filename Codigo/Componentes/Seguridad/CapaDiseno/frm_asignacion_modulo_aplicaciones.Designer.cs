namespace CapaDiseno
{
    partial class frm_asignacion_modulo_aplicaciones
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
            this.cmb_modulo = new System.Windows.Forms.ComboBox();
            this.cmb_apli = new System.Windows.Forms.ComboBox();
            this.lbl_modulos = new System.Windows.Forms.Label();
            this.lbl_aplicaciones = new System.Windows.Forms.Label();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_ver = new System.Windows.Forms.Button();
            this.txt_aplicacion = new System.Windows.Forms.TextBox();
            this.txt_modulo = new System.Windows.Forms.TextBox();
            this.dgv_asignaciones_modulo_aplicacion = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignaciones_modulo_aplicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_modulo
            // 
            this.cmb_modulo.FormattingEnabled = true;
            this.cmb_modulo.Location = new System.Drawing.Point(70, 54);
            this.cmb_modulo.Name = "cmb_modulo";
            this.cmb_modulo.Size = new System.Drawing.Size(245, 24);
            this.cmb_modulo.TabIndex = 0;
            this.cmb_modulo.SelectedIndexChanged += new System.EventHandler(this.cmb_modulo_SelectedIndexChanged_1);
            // 
            // cmb_apli
            // 
            this.cmb_apli.FormattingEnabled = true;
            this.cmb_apli.Location = new System.Drawing.Point(467, 54);
            this.cmb_apli.Name = "cmb_apli";
            this.cmb_apli.Size = new System.Drawing.Size(245, 24);
            this.cmb_apli.TabIndex = 1;
            this.cmb_apli.SelectedIndexChanged += new System.EventHandler(this.cmb_apli_SelectedIndexChanged);
            // 
            // lbl_modulos
            // 
            this.lbl_modulos.AutoSize = true;
            this.lbl_modulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modulos.Location = new System.Drawing.Point(145, 16);
            this.lbl_modulos.Name = "lbl_modulos";
            this.lbl_modulos.Size = new System.Drawing.Size(72, 20);
            this.lbl_modulos.TabIndex = 2;
            this.lbl_modulos.Text = "Modulos";
            // 
            // lbl_aplicaciones
            // 
            this.lbl_aplicaciones.AutoSize = true;
            this.lbl_aplicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aplicaciones.Location = new System.Drawing.Point(552, 16);
            this.lbl_aplicaciones.Name = "lbl_aplicaciones";
            this.lbl_aplicaciones.Size = new System.Drawing.Size(104, 20);
            this.lbl_aplicaciones.TabIndex = 3;
            this.lbl_aplicaciones.Text = "Aplicaciones";
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(403, 138);
            this.btn_crear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(98, 33);
            this.btn_crear.TabIndex = 15;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_ver
            // 
            this.btn_ver.Location = new System.Drawing.Point(257, 138);
            this.btn_ver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(98, 33);
            this.btn_ver.TabIndex = 14;
            this.btn_ver.Text = "Ver";
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // txt_aplicacion
            // 
            this.txt_aplicacion.Location = new System.Drawing.Point(514, 96);
            this.txt_aplicacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_aplicacion.Name = "txt_aplicacion";
            this.txt_aplicacion.Size = new System.Drawing.Size(161, 22);
            this.txt_aplicacion.TabIndex = 13;
            // 
            // txt_modulo
            // 
            this.txt_modulo.Location = new System.Drawing.Point(87, 96);
            this.txt_modulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_modulo.Name = "txt_modulo";
            this.txt_modulo.Size = new System.Drawing.Size(161, 22);
            this.txt_modulo.TabIndex = 12;
            // 
            // dgv_asignaciones_modulo_aplicacion
            // 
            this.dgv_asignaciones_modulo_aplicacion.AllowUserToAddRows = false;
            this.dgv_asignaciones_modulo_aplicacion.AllowUserToDeleteRows = false;
            this.dgv_asignaciones_modulo_aplicacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_asignaciones_modulo_aplicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asignaciones_modulo_aplicacion.Location = new System.Drawing.Point(114, 194);
            this.dgv_asignaciones_modulo_aplicacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_asignaciones_modulo_aplicacion.Name = "dgv_asignaciones_modulo_aplicacion";
            this.dgv_asignaciones_modulo_aplicacion.ReadOnly = true;
            this.dgv_asignaciones_modulo_aplicacion.RowHeadersWidth = 72;
            this.dgv_asignaciones_modulo_aplicacion.RowTemplate.Height = 31;
            this.dgv_asignaciones_modulo_aplicacion.Size = new System.Drawing.Size(535, 375);
            this.dgv_asignaciones_modulo_aplicacion.TabIndex = 11;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(570, 599);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(79, 35);
            this.btn_salir.TabIndex = 235;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Image = global::CapaDiseno.Properties.Resources.icons8_ayuda_30;
            this.btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ayuda.Location = new System.Drawing.Point(773, 12);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(90, 36);
            this.btn_ayuda.TabIndex = 236;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // frm_asignacion_modulo_aplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 647);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.txt_aplicacion);
            this.Controls.Add(this.txt_modulo);
            this.Controls.Add(this.dgv_asignaciones_modulo_aplicacion);
            this.Controls.Add(this.lbl_aplicaciones);
            this.Controls.Add(this.lbl_modulos);
            this.Controls.Add(this.cmb_apli);
            this.Controls.Add(this.cmb_modulo);
            this.Name = "frm_asignacion_modulo_aplicaciones";
            this.Text = "Modulos a aplicaciones";
            this.Load += new System.EventHandler(this.frm_asignacion_modulo_aplicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignaciones_modulo_aplicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_modulo;
        private System.Windows.Forms.ComboBox cmb_apli;
        private System.Windows.Forms.Label lbl_modulos;
        private System.Windows.Forms.Label lbl_aplicaciones;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.TextBox txt_aplicacion;
        private System.Windows.Forms.TextBox txt_modulo;
        private System.Windows.Forms.DataGridView dgv_asignaciones_modulo_aplicacion;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_ayuda;
    }
}