﻿
namespace Capa_Vista_Polizas
{
    partial class frmPolizas
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
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Gpb_encabezado = new System.Windows.Forms.GroupBox();
            this.Txt_concepto = new System.Windows.Forms.TextBox();
            this.Lbl_concepto = new System.Windows.Forms.Label();
            this.Lbl_tipo_poliza = new System.Windows.Forms.Label();
            this.Dpt_fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Cbo_tipopoliza = new System.Windows.Forms.ComboBox();
            this.Gpb_detalle = new System.Windows.Forms.GroupBox();
            this.Lbl_valor = new System.Windows.Forms.Label();
            this.Lbl_operacion = new System.Windows.Forms.Label();
            this.Txt_valor = new System.Windows.Forms.TextBox();
            this.Cbo_operacion = new System.Windows.Forms.ComboBox();
            this.Cbo_Cuenta = new System.Windows.Forms.ComboBox();
            this.Lbl_Cuenta = new System.Windows.Forms.Label();
            this.Gpb_detallemov = new System.Windows.Forms.GroupBox();
            this.Dgv_Polizas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_cargo = new System.Windows.Forms.Label();
            this.Lbl_abono = new System.Windows.Forms.Label();
            this.Lbl_CargoTot = new System.Windows.Forms.Label();
            this.Lbl_AbonoTot = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_registar_poliza = new System.Windows.Forms.Button();
            this.Btn_nueva_poliza = new System.Windows.Forms.Button();
            this.Btn_quitar = new System.Windows.Forms.Button();
            this.Btn_aceptar = new System.Windows.Forms.Button();
            this.Gpb_encabezado.SuspendLayout();
            this.Gpb_detalle.SuspendLayout();
            this.Gpb_detallemov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Polizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Maroon;
            // 
            // Gpb_encabezado
            // 
            this.Gpb_encabezado.Controls.Add(this.Txt_concepto);
            this.Gpb_encabezado.Controls.Add(this.Lbl_concepto);
            this.Gpb_encabezado.Controls.Add(this.Lbl_tipo_poliza);
            this.Gpb_encabezado.Controls.Add(this.Dpt_fecha);
            this.Gpb_encabezado.Controls.Add(this.Lbl_fecha);
            this.Gpb_encabezado.Controls.Add(this.Cbo_tipopoliza);
            this.Gpb_encabezado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_encabezado.Location = new System.Drawing.Point(12, 97);
            this.Gpb_encabezado.Name = "Gpb_encabezado";
            this.Gpb_encabezado.Size = new System.Drawing.Size(1051, 145);
            this.Gpb_encabezado.TabIndex = 0;
            this.Gpb_encabezado.TabStop = false;
            this.Gpb_encabezado.Text = "Encabezado poliza";
            // 
            // Txt_concepto
            // 
            this.Txt_concepto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_concepto.Location = new System.Drawing.Point(142, 96);
            this.Txt_concepto.Name = "Txt_concepto";
            this.Txt_concepto.Size = new System.Drawing.Size(894, 30);
            this.Txt_concepto.TabIndex = 5;
            // 
            // Lbl_concepto
            // 
            this.Lbl_concepto.AutoSize = true;
            this.Lbl_concepto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_concepto.Location = new System.Drawing.Point(51, 96);
            this.Lbl_concepto.Name = "Lbl_concepto";
            this.Lbl_concepto.Size = new System.Drawing.Size(85, 22);
            this.Lbl_concepto.TabIndex = 4;
            this.Lbl_concepto.Text = "Concepto";
            // 
            // Lbl_tipo_poliza
            // 
            this.Lbl_tipo_poliza.AutoSize = true;
            this.Lbl_tipo_poliza.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipo_poliza.Location = new System.Drawing.Point(456, 48);
            this.Lbl_tipo_poliza.Name = "Lbl_tipo_poliza";
            this.Lbl_tipo_poliza.Size = new System.Drawing.Size(125, 22);
            this.Lbl_tipo_poliza.TabIndex = 3;
            this.Lbl_tipo_poliza.Text = "Tipo de poliza";
            // 
            // Dpt_fecha
            // 
            this.Dpt_fecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dpt_fecha.Location = new System.Drawing.Point(125, 43);
            this.Dpt_fecha.Name = "Dpt_fecha";
            this.Dpt_fecha.Size = new System.Drawing.Size(272, 30);
            this.Dpt_fecha.TabIndex = 2;
            this.Dpt_fecha.ValueChanged += new System.EventHandler(this.dtpfecha_ValueChanged);
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(51, 43);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(57, 22);
            this.Lbl_fecha.TabIndex = 1;
            this.Lbl_fecha.Text = "Fecha";
            // 
            // Cbo_tipopoliza
            // 
            this.Cbo_tipopoliza.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_tipopoliza.FormattingEnabled = true;
            this.Cbo_tipopoliza.Location = new System.Drawing.Point(600, 45);
            this.Cbo_tipopoliza.Name = "Cbo_tipopoliza";
            this.Cbo_tipopoliza.Size = new System.Drawing.Size(251, 30);
            this.Cbo_tipopoliza.TabIndex = 0;
            this.Cbo_tipopoliza.SelectedIndexChanged += new System.EventHandler(this.cbtipopoliza_SelectedIndexChanged);
            // 
            // Gpb_detalle
            // 
            this.Gpb_detalle.Controls.Add(this.Lbl_valor);
            this.Gpb_detalle.Controls.Add(this.Lbl_operacion);
            this.Gpb_detalle.Controls.Add(this.Btn_aceptar);
            this.Gpb_detalle.Controls.Add(this.Txt_valor);
            this.Gpb_detalle.Controls.Add(this.Cbo_operacion);
            this.Gpb_detalle.Controls.Add(this.Cbo_Cuenta);
            this.Gpb_detalle.Controls.Add(this.Lbl_Cuenta);
            this.Gpb_detalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_detalle.Location = new System.Drawing.Point(13, 248);
            this.Gpb_detalle.Name = "Gpb_detalle";
            this.Gpb_detalle.Size = new System.Drawing.Size(1050, 114);
            this.Gpb_detalle.TabIndex = 1;
            this.Gpb_detalle.TabStop = false;
            this.Gpb_detalle.Text = "Detalle";
            // 
            // Lbl_valor
            // 
            this.Lbl_valor.AutoSize = true;
            this.Lbl_valor.BackColor = System.Drawing.Color.Beige;
            this.Lbl_valor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_valor.Location = new System.Drawing.Point(672, 28);
            this.Lbl_valor.Margin = new System.Windows.Forms.Padding(10);
            this.Lbl_valor.Name = "Lbl_valor";
            this.Lbl_valor.Padding = new System.Windows.Forms.Padding(0, 0, 55, 0);
            this.Lbl_valor.Size = new System.Drawing.Size(173, 22);
            this.Lbl_valor.TabIndex = 8;
            this.Lbl_valor.Text = "             Valor";
            this.Lbl_valor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_operacion
            // 
            this.Lbl_operacion.AutoSize = true;
            this.Lbl_operacion.BackColor = System.Drawing.Color.Beige;
            this.Lbl_operacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_operacion.Location = new System.Drawing.Point(440, 28);
            this.Lbl_operacion.Margin = new System.Windows.Forms.Padding(10);
            this.Lbl_operacion.Name = "Lbl_operacion";
            this.Lbl_operacion.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.Lbl_operacion.Size = new System.Drawing.Size(212, 22);
            this.Lbl_operacion.TabIndex = 7;
            this.Lbl_operacion.Text = "          Cargo/Abono";
            this.Lbl_operacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Txt_valor
            // 
            this.Txt_valor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_valor.Location = new System.Drawing.Point(688, 58);
            this.Txt_valor.Name = "Txt_valor";
            this.Txt_valor.Size = new System.Drawing.Size(144, 30);
            this.Txt_valor.TabIndex = 5;
            this.Txt_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // Cbo_operacion
            // 
            this.Cbo_operacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_operacion.FormattingEnabled = true;
            this.Cbo_operacion.Location = new System.Drawing.Point(455, 56);
            this.Cbo_operacion.Name = "Cbo_operacion";
            this.Cbo_operacion.Size = new System.Drawing.Size(176, 30);
            this.Cbo_operacion.TabIndex = 4;
            this.Cbo_operacion.SelectedIndexChanged += new System.EventHandler(this.cboperacion_SelectedIndexChanged);
            // 
            // Cbo_Cuenta
            // 
            this.Cbo_Cuenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Cuenta.FormattingEnabled = true;
            this.Cbo_Cuenta.Location = new System.Drawing.Point(108, 58);
            this.Cbo_Cuenta.Name = "Cbo_Cuenta";
            this.Cbo_Cuenta.Size = new System.Drawing.Size(288, 30);
            this.Cbo_Cuenta.TabIndex = 3;
            this.Cbo_Cuenta.SelectedIndexChanged += new System.EventHandler(this.cbCuenta_SelectedIndexChanged);
            // 
            // Lbl_Cuenta
            // 
            this.Lbl_Cuenta.AutoSize = true;
            this.Lbl_Cuenta.BackColor = System.Drawing.Color.Beige;
            this.Lbl_Cuenta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cuenta.Location = new System.Drawing.Point(91, 28);
            this.Lbl_Cuenta.Margin = new System.Windows.Forms.Padding(10);
            this.Lbl_Cuenta.Name = "Lbl_Cuenta";
            this.Lbl_Cuenta.Padding = new System.Windows.Forms.Padding(0, 0, 120, 0);
            this.Lbl_Cuenta.Size = new System.Drawing.Size(329, 22);
            this.Lbl_Cuenta.TabIndex = 0;
            this.Lbl_Cuenta.Text = "                             Cuenta\r\n";
            this.Lbl_Cuenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Gpb_detallemov
            // 
            this.Gpb_detallemov.Controls.Add(this.Btn_quitar);
            this.Gpb_detallemov.Controls.Add(this.Dgv_Polizas);
            this.Gpb_detallemov.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_detallemov.Location = new System.Drawing.Point(13, 377);
            this.Gpb_detallemov.Name = "Gpb_detallemov";
            this.Gpb_detallemov.Size = new System.Drawing.Size(1050, 374);
            this.Gpb_detallemov.TabIndex = 2;
            this.Gpb_detallemov.TabStop = false;
            this.Gpb_detallemov.Text = "Detalle de movimiento";
            // 
            // Dgv_Polizas
            // 
            this.Dgv_Polizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Polizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cuenta,
            this.Cargo,
            this.Abono});
            this.Dgv_Polizas.Location = new System.Drawing.Point(7, 31);
            this.Dgv_Polizas.Name = "Dgv_Polizas";
            this.Dgv_Polizas.RowHeadersWidth = 51;
            this.Dgv_Polizas.RowTemplate.Height = 24;
            this.Dgv_Polizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Polizas.Size = new System.Drawing.Size(895, 327);
            this.Dgv_Polizas.TabIndex = 0;
            this.Dgv_Polizas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolizas_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 150;
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
            // Lbl_cargo
            // 
            this.Lbl_cargo.AutoSize = true;
            this.Lbl_cargo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cargo.Location = new System.Drawing.Point(501, 783);
            this.Lbl_cargo.Name = "Lbl_cargo";
            this.Lbl_cargo.Size = new System.Drawing.Size(143, 22);
            this.Lbl_cargo.TabIndex = 7;
            this.Lbl_cargo.Text = "TOTAL CARGO";
            // 
            // Lbl_abono
            // 
            this.Lbl_abono.AutoSize = true;
            this.Lbl_abono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_abono.Location = new System.Drawing.Point(743, 783);
            this.Lbl_abono.Name = "Lbl_abono";
            this.Lbl_abono.Size = new System.Drawing.Size(143, 22);
            this.Lbl_abono.TabIndex = 8;
            this.Lbl_abono.Text = "TOTAL ABONO";
            // 
            // Lbl_CargoTot
            // 
            this.Lbl_CargoTot.AutoSize = true;
            this.Lbl_CargoTot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CargoTot.Location = new System.Drawing.Point(653, 783);
            this.Lbl_CargoTot.Name = "Lbl_CargoTot";
            this.Lbl_CargoTot.Size = new System.Drawing.Size(55, 22);
            this.Lbl_CargoTot.TabIndex = 10;
            this.Lbl_CargoTot.Text = "00.00";
            // 
            // Lbl_AbonoTot
            // 
            this.Lbl_AbonoTot.AutoSize = true;
            this.Lbl_AbonoTot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AbonoTot.Location = new System.Drawing.Point(892, 783);
            this.Lbl_AbonoTot.Name = "Lbl_AbonoTot";
            this.Lbl_AbonoTot.Size = new System.Drawing.Size(55, 22);
            this.Lbl_AbonoTot.TabIndex = 11;
            this.Lbl_AbonoTot.Text = "00.00";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Image = global::Capa_Vista_Polizas.Properties.Resources.preguntas1;
            this.Btn_ayuda.Location = new System.Drawing.Point(922, 15);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(62, 60);
            this.Btn_ayuda.TabIndex = 13;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click_1);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Image = global::Capa_Vista_Polizas.Properties.Resources.cerrar_sesion1;
            this.Btn_salir.Location = new System.Drawing.Point(1001, 16);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(62, 60);
            this.Btn_salir.TabIndex = 12;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Image = global::Capa_Vista_Polizas.Properties.Resources.cancelar;
            this.Btn_Cancelar.Location = new System.Drawing.Point(244, 13);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(64, 63);
            this.Btn_Cancelar.TabIndex = 9;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Btn_registar_poliza
            // 
            this.Btn_registar_poliza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.Btn_registar_poliza.Image = global::Capa_Vista_Polizas.Properties.Resources.ahorrar;
            this.Btn_registar_poliza.Location = new System.Drawing.Point(135, 13);
            this.Btn_registar_poliza.Name = "Btn_registar_poliza";
            this.Btn_registar_poliza.Size = new System.Drawing.Size(64, 62);
            this.Btn_registar_poliza.TabIndex = 4;
            this.Btn_registar_poliza.UseVisualStyleBackColor = false;
            this.Btn_registar_poliza.Click += new System.EventHandler(this.btn_registar_poliza_Click);
            // 
            // Btn_nueva_poliza
            // 
            this.Btn_nueva_poliza.Image = global::Capa_Vista_Polizas.Properties.Resources.agregar_archivo__4_;
            this.Btn_nueva_poliza.Location = new System.Drawing.Point(33, 12);
            this.Btn_nueva_poliza.Name = "Btn_nueva_poliza";
            this.Btn_nueva_poliza.Size = new System.Drawing.Size(63, 63);
            this.Btn_nueva_poliza.TabIndex = 3;
            this.Btn_nueva_poliza.UseVisualStyleBackColor = false;
            this.Btn_nueva_poliza.Click += new System.EventHandler(this.btn_nueva_poliza_Click);
            // 
            // Btn_quitar
            // 
            this.Btn_quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.Btn_quitar.Image = global::Capa_Vista_Polizas.Properties.Resources.boton_menos3;
            this.Btn_quitar.Location = new System.Drawing.Point(937, 31);
            this.Btn_quitar.Name = "Btn_quitar";
            this.Btn_quitar.Size = new System.Drawing.Size(98, 76);
            this.Btn_quitar.TabIndex = 1;
            this.Btn_quitar.UseVisualStyleBackColor = false;
            this.Btn_quitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // Btn_aceptar
            // 
            this.Btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.Btn_aceptar.Image = global::Capa_Vista_Polizas.Properties.Resources.lista_de_verificacion;
            this.Btn_aceptar.Location = new System.Drawing.Point(883, 21);
            this.Btn_aceptar.Name = "Btn_aceptar";
            this.Btn_aceptar.Size = new System.Drawing.Size(88, 78);
            this.Btn_aceptar.TabIndex = 6;
            this.Btn_aceptar.UseVisualStyleBackColor = false;
            this.Btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // frmPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 837);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Lbl_AbonoTot);
            this.Controls.Add(this.Lbl_CargoTot);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Lbl_abono);
            this.Controls.Add(this.Lbl_cargo);
            this.Controls.Add(this.Btn_registar_poliza);
            this.Controls.Add(this.Btn_nueva_poliza);
            this.Controls.Add(this.Gpb_detallemov);
            this.Controls.Add(this.Gpb_detalle);
            this.Controls.Add(this.Gpb_encabezado);
            this.Name = "frmPolizas";
            this.Text = "Polizas";
            this.Load += new System.EventHandler(this.Polizas_Load);
            this.Gpb_encabezado.ResumeLayout(false);
            this.Gpb_encabezado.PerformLayout();
            this.Gpb_detalle.ResumeLayout(false);
            this.Gpb_detalle.PerformLayout();
            this.Gpb_detallemov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Polizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox Gpb_encabezado;
        private System.Windows.Forms.TextBox Txt_concepto;
        private System.Windows.Forms.Label Lbl_concepto;
        private System.Windows.Forms.Label Lbl_tipo_poliza;
        private System.Windows.Forms.DateTimePicker Dpt_fecha;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.ComboBox Cbo_tipopoliza;
        private System.Windows.Forms.GroupBox Gpb_detalle;
        private System.Windows.Forms.Button Btn_aceptar;
        private System.Windows.Forms.TextBox Txt_valor;
        private System.Windows.Forms.ComboBox Cbo_operacion;
        private System.Windows.Forms.ComboBox Cbo_Cuenta;
        private System.Windows.Forms.Label Lbl_Cuenta;
        private System.Windows.Forms.GroupBox Gpb_detallemov;
        private System.Windows.Forms.Button Btn_quitar;
        private System.Windows.Forms.DataGridView Dgv_Polizas;
        private System.Windows.Forms.Button Btn_nueva_poliza;
        private System.Windows.Forms.Button Btn_registar_poliza;
        private System.Windows.Forms.Label Lbl_cargo;
        private System.Windows.Forms.Label Lbl_abono;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label Lbl_CargoTot;
        private System.Windows.Forms.Label Lbl_AbonoTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abono;
        private System.Windows.Forms.Label Lbl_valor;
        private System.Windows.Forms.Label Lbl_operacion;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}