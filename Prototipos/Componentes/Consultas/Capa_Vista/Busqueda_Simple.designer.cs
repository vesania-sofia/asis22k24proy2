
namespace Capa_VistaConsultas
{
    partial class Busqueda_Simple
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
            this.dgvDato = new System.Windows.Forms.DataGridView();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmboperadores = new System.Windows.Forms.ComboBox();
            this.lbl_cadena = new System.Windows.Forms.Label();
            this.cbox_columnas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_BuscaPor = new System.Windows.Forms.TextBox();
            this.bnt_buscaPor = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SalirBA = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDato)).BeginInit();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDato
            // 
            this.dgvDato.AllowUserToAddRows = false;
            this.dgvDato.AllowUserToDeleteRows = false;
            this.dgvDato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDato.Location = new System.Drawing.Point(18, 188);
            this.dgvDato.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDato.Name = "dgvDato";
            this.dgvDato.RowHeadersWidth = 51;
            this.dgvDato.Size = new System.Drawing.Size(945, 181);
            this.dgvDato.TabIndex = 0;
            this.dgvDato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDato_CellContentClick);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.panelResultado.Controls.Add(this.label2);
            this.panelResultado.Controls.Add(this.cmboperadores);
            this.panelResultado.Controls.Add(this.lbl_cadena);
            this.panelResultado.Controls.Add(this.cbox_columnas);
            this.panelResultado.Controls.Add(this.label5);
            this.panelResultado.Controls.Add(this.txt_BuscaPor);
            this.panelResultado.Controls.Add(this.bnt_buscaPor);
            this.panelResultado.Controls.Add(this.label1);
            this.panelResultado.Controls.Add(this.btn_SalirBA);
            this.panelResultado.Controls.Add(this.label3);
            this.panelResultado.Controls.Add(this.dgvDato);
            this.panelResultado.Location = new System.Drawing.Point(16, 15);
            this.panelResultado.Margin = new System.Windows.Forms.Padding(4);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(1011, 497);
            this.panelResultado.TabIndex = 11;
            this.panelResultado.Visible = false;
            this.panelResultado.Paint += new System.Windows.Forms.PaintEventHandler(this.panelResultado_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 42;
            // 
            // cmboperadores
            // 
            this.cmboperadores.Enabled = false;
            this.cmboperadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboperadores.FormattingEnabled = true;
            this.cmboperadores.Location = new System.Drawing.Point(410, 124);
            this.cmboperadores.Name = "cmboperadores";
            this.cmboperadores.Size = new System.Drawing.Size(121, 28);
            this.cmboperadores.TabIndex = 41;
            this.cmboperadores.SelectedIndexChanged += new System.EventHandler(this.cmboperadores_SelectedIndexChanged);
            // 
            // lbl_cadena
            // 
            this.lbl_cadena.AutoSize = true;
            this.lbl_cadena.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadena.Location = new System.Drawing.Point(17, 393);
            this.lbl_cadena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cadena.Name = "lbl_cadena";
            this.lbl_cadena.Size = new System.Drawing.Size(103, 21);
            this.lbl_cadena.TabIndex = 40;
            this.lbl_cadena.Text = "Buscando :";
            // 
            // cbox_columnas
            // 
            this.cbox_columnas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_columnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_columnas.FormattingEnabled = true;
            this.cbox_columnas.Location = new System.Drawing.Point(146, 122);
            this.cbox_columnas.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_columnas.Name = "cbox_columnas";
            this.cbox_columnas.Size = new System.Drawing.Size(155, 28);
            this.cbox_columnas.TabIndex = 38;
            this.cbox_columnas.SelectedIndexChanged += new System.EventHandler(this.cbox_columnas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Buscar Por :";
            // 
            // txt_BuscaPor
            // 
            this.txt_BuscaPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscaPor.Location = new System.Drawing.Point(689, 125);
            this.txt_BuscaPor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BuscaPor.Name = "txt_BuscaPor";
            this.txt_BuscaPor.Size = new System.Drawing.Size(146, 26);
            this.txt_BuscaPor.TabIndex = 36;
            // 
            // bnt_buscaPor
            // 
            this.bnt_buscaPor.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bnt_buscaPor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.bnt_buscaPor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bnt_buscaPor.IconSize = 60;
            this.bnt_buscaPor.Location = new System.Drawing.Point(879, 73);
            this.bnt_buscaPor.Margin = new System.Windows.Forms.Padding(4);
            this.bnt_buscaPor.Name = "bnt_buscaPor";
            this.bnt_buscaPor.Size = new System.Drawing.Size(85, 84);
            this.bnt_buscaPor.TabIndex = 34;
            this.bnt_buscaPor.Text = "Buscar";
            this.bnt_buscaPor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bnt_buscaPor.UseVisualStyleBackColor = true;
            this.bnt_buscaPor.Click += new System.EventHandler(this.bnt_buscaPor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(595, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Buscar :";
            // 
            // btn_SalirBA
            // 
            this.btn_SalirBA.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowRight;
            this.btn_SalirBA.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btn_SalirBA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SalirBA.IconSize = 60;
            this.btn_SalirBA.Location = new System.Drawing.Point(879, 402);
            this.btn_SalirBA.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SalirBA.Name = "btn_SalirBA";
            this.btn_SalirBA.Size = new System.Drawing.Size(85, 80);
            this.btn_SalirBA.TabIndex = 34;
            this.btn_SalirBA.Text = "Salir";
            this.btn_SalirBA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SalirBA.UseVisualStyleBackColor = true;
            this.btn_SalirBA.Click += new System.EventHandler(this.btn_SalirBA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Busqueda Simple Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Busqueda_Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1046, 525);
            this.Controls.Add(this.panelResultado);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Busqueda_Simple";
            this.Text = "Consulta Usuario Simple";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDato)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDato;
        private System.Windows.Forms.Panel panelResultado;
        private FontAwesome.Sharp.IconButton btn_SalirBA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BuscaPor;
        private FontAwesome.Sharp.IconButton bnt_buscaPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_columnas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_cadena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboperadores;
    }
}