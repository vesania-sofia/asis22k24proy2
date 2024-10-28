
namespace Capa_Vista_Movimientos
{
    partial class frm_movimiento_bancario
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
            this.Txt_mov = new System.Windows.Forms.Label();
            this.Dgv_Mov = new System.Windows.Forms.DataGridView();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Txt_ID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mov)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_mov
            // 
            this.Txt_mov.AutoSize = true;
            this.Txt_mov.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_mov.Location = new System.Drawing.Point(211, 34);
            this.Txt_mov.Name = "Txt_mov";
            this.Txt_mov.Size = new System.Drawing.Size(385, 31);
            this.Txt_mov.TabIndex = 0;
            this.Txt_mov.Text = "MOVIMIENTOS BANCARIOS";
            this.Txt_mov.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dgv_Mov
            // 
            this.Dgv_Mov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Mov.Location = new System.Drawing.Point(38, 212);
            this.Dgv_Mov.Name = "Dgv_Mov";
            this.Dgv_Mov.Size = new System.Drawing.Size(735, 226);
            this.Dgv_Mov.TabIndex = 1;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(541, 172);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(108, 34);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(655, 172);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(108, 34);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Txt_ID
            // 
            this.Txt_ID.AutoSize = true;
            this.Txt_ID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ID.Location = new System.Drawing.Point(50, 87);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Size = new System.Drawing.Size(88, 15);
            this.Txt_ID.TabIndex = 4;
            this.Txt_ID.Text = "ID Movimiento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // frm_movimiento_bancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(180)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Txt_ID);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.Dgv_Mov);
            this.Controls.Add(this.Txt_mov);
            this.Name = "frm_movimiento_bancario";
            this.Text = "frm_movimiento_bancario";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_mov;
        private System.Windows.Forms.DataGridView Dgv_Mov;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label Txt_ID;
        private System.Windows.Forms.TextBox textBox1;
    }
}