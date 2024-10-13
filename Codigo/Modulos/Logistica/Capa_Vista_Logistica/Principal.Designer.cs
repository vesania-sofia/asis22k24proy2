
namespace Capa_Vista_Logistica
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Pic_Foto = new System.Windows.Forms.PictureBox();
            this.Pic_2 = new System.Windows.Forms.PictureBox();
            this.Btn_Transporte = new System.Windows.Forms.Button();
            this.Btn_Chofer = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_TransporteVeh = new System.Windows.Forms.Button();
            this.Btn_TrasladoDProd = new System.Windows.Forms.Button();
            this.Btn_Mantenimiento = new System.Windows.Forms.Button();
            this.Btn_Inventario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pic_Foto
            // 
            this.Pic_Foto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pic_Foto.Location = new System.Drawing.Point(3, 551);
            this.Pic_Foto.Name = "Pic_Foto";
            this.Pic_Foto.Size = new System.Drawing.Size(182, 141);
            this.Pic_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Foto.TabIndex = 4;
            this.Pic_Foto.TabStop = false;
            // 
            // Pic_2
            // 
            this.Pic_2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pic_2.Image = ((System.Drawing.Image)(resources.GetObject("Pic_2.Image")));
            this.Pic_2.Location = new System.Drawing.Point(3, 435);
            this.Pic_2.Name = "Pic_2";
            this.Pic_2.Size = new System.Drawing.Size(182, 110);
            this.Pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_2.TabIndex = 3;
            this.Pic_2.TabStop = false;
            // 
            // Btn_Transporte
            // 
            this.Btn_Transporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Transporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Transporte.FlatAppearance.BorderSize = 2;
            this.Btn_Transporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Transporte.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Transporte.Location = new System.Drawing.Point(3, 115);
            this.Btn_Transporte.Name = "Btn_Transporte";
            this.Btn_Transporte.Size = new System.Drawing.Size(180, 58);
            this.Btn_Transporte.TabIndex = 1;
            this.Btn_Transporte.Text = "Transporte";
            this.Btn_Transporte.UseVisualStyleBackColor = true;
            this.Btn_Transporte.Click += new System.EventHandler(this.Btn_Transporte_Click);
            // 
            // Btn_Chofer
            // 
            this.Btn_Chofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Chofer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Chofer.FlatAppearance.BorderSize = 2;
            this.Btn_Chofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Chofer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Btn_Chofer.Location = new System.Drawing.Point(3, 51);
            this.Btn_Chofer.Name = "Btn_Chofer";
            this.Btn_Chofer.Size = new System.Drawing.Size(180, 58);
            this.Btn_Chofer.TabIndex = 0;
            this.Btn_Chofer.Text = "Chofer";
            this.Btn_Chofer.UseVisualStyleBackColor = true;
            this.Btn_Chofer.Click += new System.EventHandler(this.Btn_Chofer_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Ayuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ayuda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(3, 3);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(44, 42);
            this.Btn_Ayuda.TabIndex = 3;
            this.Btn_Ayuda.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(177)))), ((int)(((byte)(252)))));
            this.flowLayoutPanel1.Controls.Add(this.Btn_Ayuda);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Chofer);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Transporte);
            this.flowLayoutPanel1.Controls.Add(this.Btn_TransporteVeh);
            this.flowLayoutPanel1.Controls.Add(this.Btn_TrasladoDProd);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Mantenimiento);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Inventario);
            this.flowLayoutPanel1.Controls.Add(this.Pic_2);
            this.flowLayoutPanel1.Controls.Add(this.Pic_Foto);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(185, 705);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Btn_TransporteVeh
            // 
            this.Btn_TransporteVeh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TransporteVeh.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_TransporteVeh.FlatAppearance.BorderSize = 2;
            this.Btn_TransporteVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TransporteVeh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Btn_TransporteVeh.Location = new System.Drawing.Point(3, 179);
            this.Btn_TransporteVeh.Name = "Btn_TransporteVeh";
            this.Btn_TransporteVeh.Size = new System.Drawing.Size(180, 58);
            this.Btn_TransporteVeh.TabIndex = 5;
            this.Btn_TransporteVeh.Text = "Transporte de vehículos";
            this.Btn_TransporteVeh.UseVisualStyleBackColor = true;
            this.Btn_TransporteVeh.Click += new System.EventHandler(this.Btn_TransporteVeh_Click);
            // 
            // Btn_TrasladoDProd
            // 
            this.Btn_TrasladoDProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_TrasladoDProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_TrasladoDProd.FlatAppearance.BorderSize = 2;
            this.Btn_TrasladoDProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TrasladoDProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Btn_TrasladoDProd.Location = new System.Drawing.Point(3, 243);
            this.Btn_TrasladoDProd.Name = "Btn_TrasladoDProd";
            this.Btn_TrasladoDProd.Size = new System.Drawing.Size(180, 58);
            this.Btn_TrasladoDProd.TabIndex = 6;
            this.Btn_TrasladoDProd.Text = "Traslado de productos";
            this.Btn_TrasladoDProd.UseVisualStyleBackColor = true;
            this.Btn_TrasladoDProd.Click += new System.EventHandler(this.Btn_TrasladoDProd_Click);
            // 
            // Btn_Mantenimiento
            // 
            this.Btn_Mantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Mantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Mantenimiento.FlatAppearance.BorderSize = 2;
            this.Btn_Mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Mantenimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Btn_Mantenimiento.Location = new System.Drawing.Point(3, 307);
            this.Btn_Mantenimiento.Name = "Btn_Mantenimiento";
            this.Btn_Mantenimiento.Size = new System.Drawing.Size(180, 58);
            this.Btn_Mantenimiento.TabIndex = 7;
            this.Btn_Mantenimiento.Text = "Mantenimientos";
            this.Btn_Mantenimiento.UseVisualStyleBackColor = true;
            this.Btn_Mantenimiento.Click += new System.EventHandler(this.Btn_Mantenimiento_Click);
            // 
            // Btn_Inventario
            // 
            this.Btn_Inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Inventario.FlatAppearance.BorderSize = 2;
            this.Btn_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Inventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Btn_Inventario.Location = new System.Drawing.Point(3, 371);
            this.Btn_Inventario.Name = "Btn_Inventario";
            this.Btn_Inventario.Size = new System.Drawing.Size(180, 58);
            this.Btn_Inventario.TabIndex = 8;
            this.Btn_Inventario.Text = "Inventario";
            this.Btn_Inventario.UseVisualStyleBackColor = true;
            this.Btn_Inventario.Click += new System.EventHandler(this.Btn_Inventario_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 705);
            this.Controls.Add(this.flowLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Foto;
        private System.Windows.Forms.PictureBox Pic_2;
        private System.Windows.Forms.Button Btn_Transporte;
        private System.Windows.Forms.Button Btn_Chofer;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Btn_TransporteVeh;
        private System.Windows.Forms.Button Btn_TrasladoDProd;
        private System.Windows.Forms.Button Btn_Mantenimiento;
        private System.Windows.Forms.Button Btn_Inventario;
    }
}