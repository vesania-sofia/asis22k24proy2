
namespace Capa_Vista_Presupuesto
{
    partial class Incremento
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
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Txtbx_incremento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Chb_todos = new System.Windows.Forms.CheckBox();
            this.Cb_meses = new System.Windows.Forms.ComboBox();
            this.Chb_anual = new System.Windows.Forms.CheckBox();
            this.Chb_mes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Location = new System.Drawing.Point(58, 226);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Aceptar.TabIndex = 0;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Location = new System.Drawing.Point(180, 226);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelar.TabIndex = 1;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Txtbx_incremento
            // 
            this.Txtbx_incremento.Location = new System.Drawing.Point(110, 48);
            this.Txtbx_incremento.Name = "Txtbx_incremento";
            this.Txtbx_incremento.Size = new System.Drawing.Size(100, 20);
            this.Txtbx_incremento.TabIndex = 2;
            this.Txtbx_incremento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cuanto % desea incrementar?";
            // 
            // Chb_todos
            // 
            this.Chb_todos.AutoSize = true;
            this.Chb_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_todos.Location = new System.Drawing.Point(104, 106);
            this.Chb_todos.Name = "Chb_todos";
            this.Chb_todos.Size = new System.Drawing.Size(119, 19);
            this.Chb_todos.TabIndex = 4;
            this.Chb_todos.Text = "Todos los Meses";
            this.Chb_todos.UseVisualStyleBackColor = true;
            this.Chb_todos.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Cb_meses
            // 
            this.Cb_meses.FormattingEnabled = true;
            this.Cb_meses.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre",
            ""});
            this.Cb_meses.Location = new System.Drawing.Point(104, 161);
            this.Cb_meses.Name = "Cb_meses";
            this.Cb_meses.Size = new System.Drawing.Size(121, 21);
            this.Cb_meses.TabIndex = 5;
            // 
            // Chb_anual
            // 
            this.Chb_anual.AutoSize = true;
            this.Chb_anual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_anual.Location = new System.Drawing.Point(104, 83);
            this.Chb_anual.Name = "Chb_anual";
            this.Chb_anual.Size = new System.Drawing.Size(57, 19);
            this.Chb_anual.TabIndex = 6;
            this.Chb_anual.Text = "Anual";
            this.Chb_anual.UseVisualStyleBackColor = true;
            this.Chb_anual.CheckedChanged += new System.EventHandler(this.Chb_anual_CheckedChanged);
            // 
            // Chb_mes
            // 
            this.Chb_mes.AutoSize = true;
            this.Chb_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chb_mes.Location = new System.Drawing.Point(104, 130);
            this.Chb_mes.Name = "Chb_mes";
            this.Chb_mes.Size = new System.Drawing.Size(50, 19);
            this.Chb_mes.TabIndex = 7;
            this.Chb_mes.Text = "Mes";
            this.Chb_mes.UseVisualStyleBackColor = true;
            this.Chb_mes.CheckedChanged += new System.EventHandler(this.Chb_mes_CheckedChanged);
            // 
            // Incremento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(152)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(308, 290);
            this.Controls.Add(this.Chb_mes);
            this.Controls.Add(this.Chb_anual);
            this.Controls.Add(this.Cb_meses);
            this.Controls.Add(this.Chb_todos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtbx_incremento);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Name = "Incremento";
            this.Text = "Incremento";
            this.Load += new System.EventHandler(this.Incremento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.TextBox Txtbx_incremento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Chb_todos;
        private System.Windows.Forms.ComboBox Cb_meses;
        private System.Windows.Forms.CheckBox Chb_anual;
        private System.Windows.Forms.CheckBox Chb_mes;
    }
}