
namespace Capa_Vista_Consulta
{
    partial class ConsultaSimple
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
            this.dgvConsultar2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuery2 = new System.Windows.Forms.TextBox();
            this.btnCancelarSimple2 = new System.Windows.Forms.Button();
            this.btnAgregarConsultaSimple2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNuevo2 = new System.Windows.Forms.Button();
            this.txtAlias2 = new System.Windows.Forms.TextBox();
            this.cboCampos2 = new System.Windows.Forms.ComboBox();
            this.cboTabla2 = new System.Windows.Forms.ComboBox();
            this.chbTodosCampos2 = new System.Windows.Forms.CheckBox();
            this.txtNombreConsulta2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar2 = new System.Windows.Forms.Button();
            this.txtQueryFinal2 = new System.Windows.Forms.TextBox();
            this.btnCancelar2 = new System.Windows.Forms.Button();
            this.btnCrear2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultar2
            // 
            this.dgvConsultar2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar2.Location = new System.Drawing.Point(438, 276);
            this.dgvConsultar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvConsultar2.Name = "dgvConsultar2";
            this.dgvConsultar2.RowHeadersWidth = 51;
            this.dgvConsultar2.RowTemplate.Height = 24;
            this.dgvConsultar2.Size = new System.Drawing.Size(365, 270);
            this.dgvConsultar2.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuery2);
            this.groupBox1.Controls.Add(this.btnCancelarSimple2);
            this.groupBox1.Controls.Add(this.btnAgregarConsultaSimple2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnNuevo2);
            this.groupBox1.Controls.Add(this.txtAlias2);
            this.groupBox1.Controls.Add(this.cboCampos2);
            this.groupBox1.Controls.Add(this.cboTabla2);
            this.groupBox1.Controls.Add(this.chbTodosCampos2);
            this.groupBox1.Controls.Add(this.txtNombreConsulta2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(951, 247);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General-Consulta Simple";
            // 
            // txtQuery2
            // 
            this.txtQuery2.Location = new System.Drawing.Point(583, 76);
            this.txtQuery2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuery2.Multiline = true;
            this.txtQuery2.Name = "txtQuery2";
            this.txtQuery2.Size = new System.Drawing.Size(231, 118);
            this.txtQuery2.TabIndex = 14;
            // 
            // btnCancelarSimple2
            // 
            this.btnCancelarSimple2.Location = new System.Drawing.Point(840, 128);
            this.btnCancelarSimple2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarSimple2.Name = "btnCancelarSimple2";
            this.btnCancelarSimple2.Size = new System.Drawing.Size(85, 66);
            this.btnCancelarSimple2.TabIndex = 13;
            this.btnCancelarSimple2.Text = "Cancelar";
            this.btnCancelarSimple2.UseVisualStyleBackColor = true;
            this.btnCancelarSimple2.Click += new System.EventHandler(this.btnCancelarSimple2_Click);
            // 
            // btnAgregarConsultaSimple2
            // 
            this.btnAgregarConsultaSimple2.Location = new System.Drawing.Point(840, 46);
            this.btnAgregarConsultaSimple2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarConsultaSimple2.Name = "btnAgregarConsultaSimple2";
            this.btnAgregarConsultaSimple2.Size = new System.Drawing.Size(85, 66);
            this.btnAgregarConsultaSimple2.TabIndex = 11;
            this.btnAgregarConsultaSimple2.Text = "Agregar Campos";
            this.btnAgregarConsultaSimple2.UseVisualStyleBackColor = true;
            this.btnAgregarConsultaSimple2.Click += new System.EventHandler(this.btnAgregarConsultaSimple2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(580, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Campos Seleccionados";
            // 
            // btnNuevo2
            // 
            this.btnNuevo2.Location = new System.Drawing.Point(423, 82);
            this.btnNuevo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo2.Name = "btnNuevo2";
            this.btnNuevo2.Size = new System.Drawing.Size(85, 66);
            this.btnNuevo2.TabIndex = 9;
            this.btnNuevo2.Text = "Agregar";
            this.btnNuevo2.UseVisualStyleBackColor = true;
            this.btnNuevo2.Click += new System.EventHandler(this.btnNuevo2_Click);
            // 
            // txtAlias2
            // 
            this.txtAlias2.Location = new System.Drawing.Point(184, 208);
            this.txtAlias2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlias2.Name = "txtAlias2";
            this.txtAlias2.Size = new System.Drawing.Size(217, 22);
            this.txtAlias2.TabIndex = 8;
            // 
            // cboCampos2
            // 
            this.cboCampos2.FormattingEnabled = true;
            this.cboCampos2.Location = new System.Drawing.Point(184, 126);
            this.cboCampos2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCampos2.Name = "cboCampos2";
            this.cboCampos2.Size = new System.Drawing.Size(217, 24);
            this.cboCampos2.TabIndex = 7;
            // 
            // cboTabla2
            // 
            this.cboTabla2.FormattingEnabled = true;
            this.cboTabla2.Location = new System.Drawing.Point(184, 82);
            this.cboTabla2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTabla2.Name = "cboTabla2";
            this.cboTabla2.Size = new System.Drawing.Size(217, 24);
            this.cboTabla2.TabIndex = 6;
            // 
            // chbTodosCampos2
            // 
            this.chbTodosCampos2.AutoSize = true;
            this.chbTodosCampos2.Location = new System.Drawing.Point(184, 174);
            this.chbTodosCampos2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbTodosCampos2.Name = "chbTodosCampos2";
            this.chbTodosCampos2.Size = new System.Drawing.Size(145, 21);
            this.chbTodosCampos2.TabIndex = 5;
            this.chbTodosCampos2.Text = "Todos los campos";
            this.chbTodosCampos2.UseVisualStyleBackColor = true;
            // 
            // txtNombreConsulta2
            // 
            this.txtNombreConsulta2.Location = new System.Drawing.Point(184, 36);
            this.txtNombreConsulta2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreConsulta2.Name = "txtNombreConsulta2";
            this.txtNombreConsulta2.Size = new System.Drawing.Size(217, 22);
            this.txtNombreConsulta2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Campos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tabla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Consulta";
            // 
            // btnConsultar2
            // 
            this.btnConsultar2.Location = new System.Drawing.Point(825, 375);
            this.btnConsultar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar2.Name = "btnConsultar2";
            this.btnConsultar2.Size = new System.Drawing.Size(115, 66);
            this.btnConsultar2.TabIndex = 7;
            this.btnConsultar2.Text = "Consultar";
            this.btnConsultar2.UseVisualStyleBackColor = true;
            this.btnConsultar2.Click += new System.EventHandler(this.btnConsultar2_Click);
            // 
            // txtQueryFinal2
            // 
            this.txtQueryFinal2.Location = new System.Drawing.Point(15, 319);
            this.txtQueryFinal2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQueryFinal2.Multiline = true;
            this.txtQueryFinal2.Name = "txtQueryFinal2";
            this.txtQueryFinal2.Size = new System.Drawing.Size(391, 85);
            this.txtQueryFinal2.TabIndex = 35;
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.Location = new System.Drawing.Point(295, 424);
            this.btnCancelar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(85, 66);
            this.btnCancelar2.TabIndex = 34;
            this.btnCancelar2.Text = "Cancelar";
            this.btnCancelar2.UseVisualStyleBackColor = true;
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar2_Click);
            // 
            // btnCrear2
            // 
            this.btnCrear2.Location = new System.Drawing.Point(44, 424);
            this.btnCrear2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear2.Name = "btnCrear2";
            this.btnCrear2.Size = new System.Drawing.Size(85, 66);
            this.btnCrear2.TabIndex = 33;
            this.btnCrear2.Text = "Crear";
            this.btnCrear2.UseVisualStyleBackColor = true;
            this.btnCrear2.Click += new System.EventHandler(this.btnCrear2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 287);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "Cadena Generada";
            // 
            // ConsultaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 557);
            this.Controls.Add(this.txtQueryFinal2);
            this.Controls.Add(this.btnCancelar2);
            this.Controls.Add(this.btnCrear2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnConsultar2);
            this.Controls.Add(this.dgvConsultar2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultaSimple";
            this.Text = "ConsultaSimple";
            this.Load += new System.EventHandler(this.ConsultaSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultar2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuery2;
        private System.Windows.Forms.Button btnCancelarSimple2;
        private System.Windows.Forms.Button btnAgregarConsultaSimple2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevo2;
        private System.Windows.Forms.TextBox txtAlias2;
        private System.Windows.Forms.ComboBox cboCampos2;
        private System.Windows.Forms.ComboBox cboTabla2;
        private System.Windows.Forms.CheckBox chbTodosCampos2;
        private System.Windows.Forms.TextBox txtNombreConsulta2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar2;
        private System.Windows.Forms.TextBox txtQueryFinal2;
        private System.Windows.Forms.Button btnCancelar2;
        private System.Windows.Forms.Button btnCrear2;
        private System.Windows.Forms.Label label14;
    }
}