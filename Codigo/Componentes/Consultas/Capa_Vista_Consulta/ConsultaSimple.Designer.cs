
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaSimple));
            this.dgvConsultar2 = new System.Windows.Forms.DataGridView();
            this.btnCancelar2 = new System.Windows.Forms.Button();
            this.btnConsultar2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboOperador = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultar2
            // 
            this.dgvConsultar2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultar2.Location = new System.Drawing.Point(25, 99);
            this.dgvConsultar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvConsultar2.Name = "dgvConsultar2";
            this.dgvConsultar2.RowHeadersWidth = 51;
            this.dgvConsultar2.RowTemplate.Height = 24;
            this.dgvConsultar2.Size = new System.Drawing.Size(769, 208);
            this.dgvConsultar2.TabIndex = 35;
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.FlatAppearance.BorderSize = 0;
            this.btnCancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar2.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar2.Image")));
            this.btnCancelar2.Location = new System.Drawing.Point(669, 16);
            this.btnCancelar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(85, 66);
            this.btnCancelar2.TabIndex = 38;
            this.btnCancelar2.UseVisualStyleBackColor = true;
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar2_Click_1);
            // 
            // btnConsultar2
            // 
            this.btnConsultar2.FlatAppearance.BorderSize = 0;
            this.btnConsultar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar2.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar2.Image")));
            this.btnConsultar2.Location = new System.Drawing.Point(541, 16);
            this.btnConsultar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar2.Name = "btnConsultar2";
            this.btnConsultar2.Size = new System.Drawing.Size(93, 66);
            this.btnConsultar2.TabIndex = 36;
            this.btnConsultar2.UseVisualStyleBackColor = true;
            this.btnConsultar2.Click += new System.EventHandler(this.btnConsultar2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Campo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Operación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(346, 60);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(169, 22);
            this.txtValor.TabIndex = 42;
            // 
            // cboCampo
            // 
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(25, 58);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(146, 24);
            this.cboCampo.TabIndex = 43;
            // 
            // cboOperador
            // 
            this.cboOperador.FormattingEnabled = true;
            this.cboOperador.Location = new System.Drawing.Point(207, 58);
            this.cboOperador.Name = "cboOperador";
            this.cboOperador.Size = new System.Drawing.Size(107, 24);
            this.cboOperador.TabIndex = 44;
            // 
            // ConsultaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 324);
            this.Controls.Add(this.cboOperador);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConsultar2);
            this.Controls.Add(this.btnCancelar2);
            this.Controls.Add(this.btnConsultar2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConsultaSimple";
            this.Text = "ConsultaSimple";
            this.Load += new System.EventHandler(this.ConsultaSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultar2;
        private System.Windows.Forms.Button btnCancelar2;
        private System.Windows.Forms.Button btnConsultar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboOperador;
    }
}