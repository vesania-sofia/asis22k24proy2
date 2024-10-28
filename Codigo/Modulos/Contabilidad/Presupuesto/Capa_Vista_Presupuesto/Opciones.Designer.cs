
namespace Capa_Vista_Presupuesto
{
    partial class Opciones
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
            this.Btn_crear = new System.Windows.Forms.Button();
            this.cb_ejercicio = new System.Windows.Forms.ComboBox();
            this.Txtbx_nombre = new System.Windows.Forms.TextBox();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Cb_modificar = new System.Windows.Forms.ComboBox();
            this.Btn_ver = new System.Windows.Forms.Button();
            this.Cb_Ver = new System.Windows.Forms.ComboBox();
            this.Cb_LlenadoMod = new System.Windows.Forms.ComboBox();
            this.Cb_Base = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Chb_plantilla = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cb_LlenadoCrear = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_crear
            // 
            this.Btn_crear.Location = new System.Drawing.Point(120, 123);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(75, 23);
            this.Btn_crear.TabIndex = 6;
            this.Btn_crear.Text = "Crear";
            this.Btn_crear.UseVisualStyleBackColor = true;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // cb_ejercicio
            // 
            this.cb_ejercicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ejercicio.FormattingEnabled = true;
            this.cb_ejercicio.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this.cb_ejercicio.Location = new System.Drawing.Point(8, 86);
            this.cb_ejercicio.Name = "cb_ejercicio";
            this.cb_ejercicio.Size = new System.Drawing.Size(121, 21);
            this.cb_ejercicio.TabIndex = 2;
            // 
            // Txtbx_nombre
            // 
            this.Txtbx_nombre.Location = new System.Drawing.Point(8, 36);
            this.Txtbx_nombre.Name = "Txtbx_nombre";
            this.Txtbx_nombre.Size = new System.Drawing.Size(121, 20);
            this.Txtbx_nombre.TabIndex = 1;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(120, 69);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Modificar.TabIndex = 9;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Cb_modificar
            // 
            this.Cb_modificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_modificar.FormattingEnabled = true;
            this.Cb_modificar.Location = new System.Drawing.Point(183, 42);
            this.Cb_modificar.Name = "Cb_modificar";
            this.Cb_modificar.Size = new System.Drawing.Size(134, 21);
            this.Cb_modificar.TabIndex = 8;
            // 
            // Btn_ver
            // 
            this.Btn_ver.Location = new System.Drawing.Point(120, 70);
            this.Btn_ver.Name = "Btn_ver";
            this.Btn_ver.Size = new System.Drawing.Size(75, 23);
            this.Btn_ver.TabIndex = 11;
            this.Btn_ver.Text = "Ver";
            this.Btn_ver.UseVisualStyleBackColor = true;
            this.Btn_ver.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cb_Ver
            // 
            this.Cb_Ver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Ver.FormattingEnabled = true;
            this.Cb_Ver.Location = new System.Drawing.Point(100, 43);
            this.Cb_Ver.Name = "Cb_Ver";
            this.Cb_Ver.Size = new System.Drawing.Size(121, 21);
            this.Cb_Ver.TabIndex = 10;
            // 
            // Cb_LlenadoMod
            // 
            this.Cb_LlenadoMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_LlenadoMod.FormattingEnabled = true;
            this.Cb_LlenadoMod.Items.AddRange(new object[] {
            "Mensual",
            "Anual"});
            this.Cb_LlenadoMod.Location = new System.Drawing.Point(10, 42);
            this.Cb_LlenadoMod.Name = "Cb_LlenadoMod";
            this.Cb_LlenadoMod.Size = new System.Drawing.Size(121, 21);
            this.Cb_LlenadoMod.TabIndex = 7;
            // 
            // Cb_Base
            // 
            this.Cb_Base.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Base.FormattingEnabled = true;
            this.Cb_Base.Location = new System.Drawing.Point(187, 36);
            this.Cb_Base.Name = "Cb_Base";
            this.Cb_Base.Size = new System.Drawing.Size(130, 21);
            this.Cb_Base.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ejercicio del presupuesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Forma de trabajar";
            // 
            // Chb_plantilla
            // 
            this.Chb_plantilla.AutoSize = true;
            this.Chb_plantilla.Location = new System.Drawing.Point(187, 19);
            this.Chb_plantilla.Name = "Chb_plantilla";
            this.Chb_plantilla.Size = new System.Drawing.Size(76, 17);
            this.Chb_plantilla.TabIndex = 3;
            this.Chb_plantilla.Text = "Prellenado";
            this.Chb_plantilla.UseVisualStyleBackColor = true;
            this.Chb_plantilla.CheckedChanged += new System.EventHandler(this.Chb_plantilla_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Cb_LlenadoCrear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Chb_plantilla);
            this.groupBox1.Controls.Add(this.Txtbx_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cb_Base);
            this.groupBox1.Controls.Add(this.cb_ejercicio);
            this.groupBox1.Controls.Add(this.Btn_crear);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 157);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Presupuesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Cb_modificar);
            this.groupBox2.Controls.Add(this.Btn_Modificar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Cb_LlenadoMod);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 111);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Presupuesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Presupuesto a modificar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Cb_Ver);
            this.groupBox3.Controls.Add(this.Btn_ver);
            this.groupBox3.Location = new System.Drawing.Point(12, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ver presupuesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Presupuesto a ver";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Forma de trabajar";
            // 
            // Cb_LlenadoCrear
            // 
            this.Cb_LlenadoCrear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_LlenadoCrear.FormattingEnabled = true;
            this.Cb_LlenadoCrear.Items.AddRange(new object[] {
            "Mensual",
            "Anual"});
            this.Cb_LlenadoCrear.Location = new System.Drawing.Point(187, 86);
            this.Cb_LlenadoCrear.Name = "Cb_LlenadoCrear";
            this.Cb_LlenadoCrear.Size = new System.Drawing.Size(130, 21);
            this.Cb_LlenadoCrear.TabIndex = 5;
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(152)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(366, 397);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Opciones";
            this.Text = "Opciones de Presupuesto";
            this.Load += new System.EventHandler(this.Opciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.ComboBox cb_ejercicio;
        private System.Windows.Forms.TextBox Txtbx_nombre;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.ComboBox Cb_modificar;
        private System.Windows.Forms.Button Btn_ver;
        private System.Windows.Forms.ComboBox Cb_Ver;
        private System.Windows.Forms.ComboBox Cb_LlenadoMod;
        private System.Windows.Forms.ComboBox Cb_Base;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Chb_plantilla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cb_LlenadoCrear;
    }
}