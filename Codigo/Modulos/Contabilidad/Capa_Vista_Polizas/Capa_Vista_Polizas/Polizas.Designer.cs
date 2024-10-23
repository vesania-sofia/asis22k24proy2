
namespace Capa_Vista_Polizas
{
    partial class Polizas
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.lbl_concepto = new System.Windows.Forms.Label();
            this.lbl_tipo_poliza = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.cbtipopoliza = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cboperacion = new System.Windows.Forms.ComboBox();
            this.cbCuenta = new System.Windows.Forms.ComboBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Cuenta = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dgvPolizas = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_nueva_poliza = new System.Windows.Forms.Button();
            this.btn_registar_poliza = new System.Windows.Forms.Button();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_abono = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblAbono = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Controls.Add(this.lbl_concepto);
            this.groupBox1.Controls.Add(this.lbl_tipo_poliza);
            this.groupBox1.Controls.Add(this.dtpfecha);
            this.groupBox1.Controls.Add(this.lbl_fecha);
            this.groupBox1.Controls.Add(this.cbtipopoliza);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1051, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado poliza";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(123, 97);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(894, 22);
            this.txtConcepto.TabIndex = 5;
            // 
            // lbl_concepto
            // 
            this.lbl_concepto.AutoSize = true;
            this.lbl_concepto.Location = new System.Drawing.Point(49, 97);
            this.lbl_concepto.Name = "lbl_concepto";
            this.lbl_concepto.Size = new System.Drawing.Size(68, 17);
            this.lbl_concepto.TabIndex = 4;
            this.lbl_concepto.Text = "Concepto";
            // 
            // lbl_tipo_poliza
            // 
            this.lbl_tipo_poliza.AutoSize = true;
            this.lbl_tipo_poliza.Location = new System.Drawing.Point(454, 49);
            this.lbl_tipo_poliza.Name = "lbl_tipo_poliza";
            this.lbl_tipo_poliza.Size = new System.Drawing.Size(97, 17);
            this.lbl_tipo_poliza.TabIndex = 3;
            this.lbl_tipo_poliza.Text = "Tipo de poliza";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(123, 44);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(272, 22);
            this.dtpfecha.TabIndex = 2;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(49, 44);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(47, 17);
            this.lbl_fecha.TabIndex = 1;
            this.lbl_fecha.Text = "Fecha";
            // 
            // cbtipopoliza
            // 
            this.cbtipopoliza.FormattingEnabled = true;
            this.cbtipopoliza.Location = new System.Drawing.Point(557, 46);
            this.cbtipopoliza.Name = "cbtipopoliza";
            this.cbtipopoliza.Size = new System.Drawing.Size(251, 24);
            this.cbtipopoliza.TabIndex = 0;
            this.cbtipopoliza.SelectedIndexChanged += new System.EventHandler(this.cbtipopoliza_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_aceptar);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.cboperacion);
            this.groupBox2.Controls.Add(this.cbCuenta);
            this.groupBox2.Controls.Add(this.lbl_valor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl_Cuenta);
            this.groupBox2.Location = new System.Drawing.Point(13, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1050, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(889, 21);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(127, 76);
            this.btn_aceptar.TabIndex = 6;
            this.btn_aceptar.Text = "Enviar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(688, 55);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(144, 22);
            this.txtValor.TabIndex = 5;
            // 
            // cboperacion
            // 
            this.cboperacion.FormattingEnabled = true;
            this.cboperacion.Location = new System.Drawing.Point(455, 55);
            this.cboperacion.Name = "cboperacion";
            this.cboperacion.Size = new System.Drawing.Size(176, 24);
            this.cboperacion.TabIndex = 4;
            this.cboperacion.SelectedIndexChanged += new System.EventHandler(this.cboperacion_SelectedIndexChanged);
            // 
            // cbCuenta
            // 
            this.cbCuenta.FormattingEnabled = true;
            this.cbCuenta.Location = new System.Drawing.Point(121, 57);
            this.cbCuenta.Name = "cbCuenta";
            this.cbCuenta.Size = new System.Drawing.Size(289, 24);
            this.cbCuenta.TabIndex = 3;
            this.cbCuenta.SelectedIndexChanged += new System.EventHandler(this.cbCuenta_SelectedIndexChanged);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(685, 26);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(41, 17);
            this.lbl_valor.TabIndex = 2;
            this.lbl_valor.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cargo / Abono";
            // 
            // lbl_Cuenta
            // 
            this.lbl_Cuenta.AutoSize = true;
            this.lbl_Cuenta.Location = new System.Drawing.Point(118, 26);
            this.lbl_Cuenta.Name = "lbl_Cuenta";
            this.lbl_Cuenta.Size = new System.Drawing.Size(53, 17);
            this.lbl_Cuenta.TabIndex = 0;
            this.lbl_Cuenta.Text = "Cuenta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQuitar);
            this.groupBox3.Controls.Add(this.dgvPolizas);
            this.groupBox3.Location = new System.Drawing.Point(13, 377);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1050, 374);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de movimiento";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(908, 31);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(136, 74);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dgvPolizas
            // 
            this.dgvPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Cuenta,
            this.Cargo,
            this.Abono});
            this.dgvPolizas.Location = new System.Drawing.Point(7, 31);
            this.dgvPolizas.Name = "dgvPolizas";
            this.dgvPolizas.RowHeadersWidth = 51;
            this.dgvPolizas.RowTemplate.Height = 24;
            this.dgvPolizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolizas.Size = new System.Drawing.Size(895, 327);
            this.dgvPolizas.TabIndex = 0;
            this.dgvPolizas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolizas_CellContentClick);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            this.Código.Width = 150;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 6;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Width = 150;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.Width = 150;
            // 
            // Abono
            // 
            this.Abono.HeaderText = "Abono";
            this.Abono.MinimumWidth = 6;
            this.Abono.Name = "Abono";
            this.Abono.Width = 150;
            // 
            // btn_nueva_poliza
            // 
            this.btn_nueva_poliza.Location = new System.Drawing.Point(20, 26);
            this.btn_nueva_poliza.Name = "btn_nueva_poliza";
            this.btn_nueva_poliza.Size = new System.Drawing.Size(243, 52);
            this.btn_nueva_poliza.TabIndex = 3;
            this.btn_nueva_poliza.Text = "Nueva poliza";
            this.btn_nueva_poliza.UseVisualStyleBackColor = true;
            this.btn_nueva_poliza.Click += new System.EventHandler(this.btn_nueva_poliza_Click);
            // 
            // btn_registar_poliza
            // 
            this.btn_registar_poliza.Location = new System.Drawing.Point(518, 26);
            this.btn_registar_poliza.Name = "btn_registar_poliza";
            this.btn_registar_poliza.Size = new System.Drawing.Size(243, 52);
            this.btn_registar_poliza.TabIndex = 4;
            this.btn_registar_poliza.Text = "Registrar poliza";
            this.btn_registar_poliza.UseVisualStyleBackColor = true;
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Location = new System.Drawing.Point(387, 783);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(108, 17);
            this.lbl_cargo.TabIndex = 7;
            this.lbl_cargo.Text = "TOTAL CARGO";
            // 
            // lbl_abono
            // 
            this.lbl_abono.AutoSize = true;
            this.lbl_abono.Location = new System.Drawing.Point(658, 783);
            this.lbl_abono.Name = "lbl_abono";
            this.lbl_abono.Size = new System.Drawing.Size(108, 17);
            this.lbl_abono.TabIndex = 8;
            this.lbl_abono.Text = "TOTAL ABONO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(269, 26);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(243, 52);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(521, 783);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 17);
            this.lblCargo.TabIndex = 10;
            this.lblCargo.Text = "00.00";
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.Location = new System.Drawing.Point(786, 783);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(44, 17);
            this.lblAbono.TabIndex = 11;
            this.lblAbono.Text = "00.00";
            // 
            // Polizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 834);
            this.Controls.Add(this.lblAbono);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lbl_abono);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.btn_registar_poliza);
            this.Controls.Add(this.btn_nueva_poliza);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Polizas";
            this.Text = "Polizas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label lbl_concepto;
        private System.Windows.Forms.Label lbl_tipo_poliza;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.ComboBox cbtipopoliza;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cboperacion;
        private System.Windows.Forms.ComboBox cbCuenta;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Cuenta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dgvPolizas;
        private System.Windows.Forms.Button btn_nueva_poliza;
        private System.Windows.Forms.Button btn_registar_poliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abono;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_abono;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblAbono;
    }
}