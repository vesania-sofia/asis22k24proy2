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
            this.SuspendLayout();
            // 
            // cmb_modulo
            // 
            this.cmb_modulo.FormattingEnabled = true;
            this.cmb_modulo.Location = new System.Drawing.Point(70, 90);
            this.cmb_modulo.Name = "cmb_modulo";
            this.cmb_modulo.Size = new System.Drawing.Size(245, 24);
            this.cmb_modulo.TabIndex = 0;
            // 
            // cmb_apli
            // 
            this.cmb_apli.FormattingEnabled = true;
            this.cmb_apli.Location = new System.Drawing.Point(467, 90);
            this.cmb_apli.Name = "cmb_apli";
            this.cmb_apli.Size = new System.Drawing.Size(245, 24);
            this.cmb_apli.TabIndex = 1;
            // 
            // lbl_modulos
            // 
            this.lbl_modulos.AutoSize = true;
            this.lbl_modulos.Location = new System.Drawing.Point(145, 52);
            this.lbl_modulos.Name = "lbl_modulos";
            this.lbl_modulos.Size = new System.Drawing.Size(59, 16);
            this.lbl_modulos.TabIndex = 2;
            this.lbl_modulos.Text = "Modulos";
            // 
            // lbl_aplicaciones
            // 
            this.lbl_aplicaciones.AutoSize = true;
            this.lbl_aplicaciones.Location = new System.Drawing.Point(552, 52);
            this.lbl_aplicaciones.Name = "lbl_aplicaciones";
            this.lbl_aplicaciones.Size = new System.Drawing.Size(85, 16);
            this.lbl_aplicaciones.TabIndex = 3;
            this.lbl_aplicaciones.Text = "Aplicaciones";
            // 
            // frm_asignacion_modulo_aplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_aplicaciones);
            this.Controls.Add(this.lbl_modulos);
            this.Controls.Add(this.cmb_apli);
            this.Controls.Add(this.cmb_modulo);
            this.Name = "frm_asignacion_modulo_aplicaciones";
            this.Text = "Modulos a aplicaciones";
            this.Load += new System.EventHandler(this.frm_asignacion_modulo_aplicaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_modulo;
        private System.Windows.Forms.ComboBox cmb_apli;
        private System.Windows.Forms.Label lbl_modulos;
        private System.Windows.Forms.Label lbl_aplicaciones;
    }
}