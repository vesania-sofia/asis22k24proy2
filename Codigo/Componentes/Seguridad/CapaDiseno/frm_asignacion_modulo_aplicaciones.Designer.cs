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
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_ver = new System.Windows.Forms.Button();
            this.txt_aplicacion = new System.Windows.Forms.TextBox();
            this.txt_modulo = new System.Windows.Forms.TextBox();
            this.dgv_asignaciones_modulo_aplicacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_asignaciones_modulo_aplicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_modulo
            // 
            this.cmb_modulo.FormattingEnabled = true;
            this.cmb_modulo.Location = new System.Drawing.Point(96, 135);
            this.cmb_modulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_modulo.Name = "cmb_modulo";
            this.cmb_modulo.Size = new System.Drawing.Size(335, 32);
            this.cmb_modulo.TabIndex = 0;
            this.cmb_modulo.SelectedIndexChanged += new System.EventHandler(this.cmb_modulo_SelectedIndexChanged_1);
            // 
            // cmb_apli
            // 
            this.cmb_apli.FormattingEnabled = true;
            this.cmb_apli.Location = new System.Drawing.Point(642, 135);
            this.cmb_apli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_apli.Name = "cmb_apli";
            this.cmb_apli.Size = new System.Drawing.Size(335, 32);
            this.cmb_apli.TabIndex = 1;
            this.cmb_apli.SelectedIndexChanged += new System.EventHandler(this.cmb_apli_SelectedIndexChanged);
            // 
            // lbl_modulos
            // 
            this.lbl_modulos.AutoSize = true;
            this.lbl_modulos.Location = new System.Drawing.Point(199, 78);
            this.lbl_modulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_modulos.Name = "lbl_modulos";
            this.lbl_modulos.Size = new System.Drawing.Size(87, 25);
            this.lbl_modulos.TabIndex = 2;
            this.lbl_modulos.Text = "Modulos";
            // 
            // lbl_aplicaciones
            // 
            this.lbl_aplicaciones.AutoSize = true;
            this.lbl_aplicaciones.Location = new System.Drawing.Point(759, 78);
            this.lbl_aplicaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_aplicaciones.Name = "lbl_aplicaciones";
            this.lbl_aplicaciones.Size = new System.Drawing.Size(123, 25);
            this.lbl_aplicaciones.TabIndex = 3;
            this.lbl_aplicaciones.Text = "Aplicaciones";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(740, 287);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(135, 49);
            this.btn_eliminar.TabIndex = 17;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(569, 287);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(135, 49);
            this.btn_modificar.TabIndex = 16;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(387, 287);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(135, 49);
            this.btn_crear.TabIndex = 15;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_ver
            // 
            this.btn_ver.Location = new System.Drawing.Point(185, 287);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(135, 49);
            this.btn_ver.TabIndex = 14;
            this.btn_ver.Text = "Ver";
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // txt_aplicacion
            // 
            this.txt_aplicacion.Location = new System.Drawing.Point(707, 214);
            this.txt_aplicacion.Name = "txt_aplicacion";
            this.txt_aplicacion.Size = new System.Drawing.Size(220, 29);
            this.txt_aplicacion.TabIndex = 13;
            // 
            // txt_modulo
            // 
            this.txt_modulo.Location = new System.Drawing.Point(120, 214);
            this.txt_modulo.Name = "txt_modulo";
            this.txt_modulo.Size = new System.Drawing.Size(220, 29);
            this.txt_modulo.TabIndex = 12;
            // 
            // dgv_asignaciones_modulo_aplicacion
            // 
            this.dgv_asignaciones_modulo_aplicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_asignaciones_modulo_aplicacion.Location = new System.Drawing.Point(157, 369);
            this.dgv_asignaciones_modulo_aplicacion.Name = "dgv_asignaciones_modulo_aplicacion";
            this.dgv_asignaciones_modulo_aplicacion.RowHeadersWidth = 72;
            this.dgv_asignaciones_modulo_aplicacion.RowTemplate.Height = 31;
            this.dgv_asignaciones_modulo_aplicacion.Size = new System.Drawing.Size(736, 619);
            this.dgv_asignaciones_modulo_aplicacion.TabIndex = 11;
            // 
            // frm_asignacion_modulo_aplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 970);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.txt_aplicacion);
            this.Controls.Add(this.txt_modulo);
            this.Controls.Add(this.dgv_asignaciones_modulo_aplicacion);
            this.Controls.Add(this.lbl_aplicaciones);
            this.Controls.Add(this.lbl_modulos);
            this.Controls.Add(this.cmb_apli);
            this.Controls.Add(this.cmb_modulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.TextBox txt_aplicacion;
        private System.Windows.Forms.TextBox txt_modulo;
        private System.Windows.Forms.DataGridView dgv_asignaciones_modulo_aplicacion;
    }
}