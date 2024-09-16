
namespace Capa_Vista_Reporteria
{
    partial class menu_reporteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_reporteria));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Pic_1 = new System.Windows.Forms.PictureBox();
            this.Btn_RepUsuario = new System.Windows.Forms.Button();
            this.Btn_RepAdmin = new System.Windows.Forms.Button();
            this.Pic_2 = new System.Windows.Forms.PictureBox();
            this.Pic_Foto = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Pic_1);
            this.flowLayoutPanel1.Controls.Add(this.Btn_RepUsuario);
            this.flowLayoutPanel1.Controls.Add(this.Btn_RepAdmin);
            this.flowLayoutPanel1.Controls.Add(this.Pic_2);
            this.flowLayoutPanel1.Controls.Add(this.Pic_Foto);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(185, 540);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Pic_1
            // 
            this.Pic_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pic_1.Location = new System.Drawing.Point(3, 3);
            this.Pic_1.Name = "Pic_1";
            this.Pic_1.Size = new System.Drawing.Size(182, 155);
            this.Pic_1.TabIndex = 2;
            this.Pic_1.TabStop = false;
            // 
            // Btn_RepUsuario
            // 
            this.Btn_RepUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_RepUsuario.FlatAppearance.BorderSize = 0;
            this.Btn_RepUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RepUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Btn_RepUsuario.Location = new System.Drawing.Point(3, 164);
            this.Btn_RepUsuario.Name = "Btn_RepUsuario";
            this.Btn_RepUsuario.Size = new System.Drawing.Size(185, 40);
            this.Btn_RepUsuario.TabIndex = 0;
            this.Btn_RepUsuario.Text = "Reporteria Usuarios";
            this.Btn_RepUsuario.UseVisualStyleBackColor = true;
            this.Btn_RepUsuario.Click += new System.EventHandler(this.Btn_RepUsuario_Click);
            // 
            // Btn_RepAdmin
            // 
            this.Btn_RepAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_RepAdmin.FlatAppearance.BorderSize = 0;
            this.Btn_RepAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RepAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RepAdmin.Location = new System.Drawing.Point(3, 210);
            this.Btn_RepAdmin.Name = "Btn_RepAdmin";
            this.Btn_RepAdmin.Size = new System.Drawing.Size(185, 67);
            this.Btn_RepAdmin.TabIndex = 1;
            this.Btn_RepAdmin.Text = "Reporteria Administrador";
            this.Btn_RepAdmin.UseVisualStyleBackColor = true;
            this.Btn_RepAdmin.Click += new System.EventHandler(this.Btn_RepAdmin_Click);
            // 
            // Pic_2
            // 
            this.Pic_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pic_2.Image = ((System.Drawing.Image)(resources.GetObject("Pic_2.Image")));
            this.Pic_2.Location = new System.Drawing.Point(3, 283);
            this.Pic_2.Name = "Pic_2";
            this.Pic_2.Size = new System.Drawing.Size(182, 110);
            this.Pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_2.TabIndex = 3;
            this.Pic_2.TabStop = false;
            // 
            // Pic_Foto
            // 
            this.Pic_Foto.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pic_Foto.Image = global::Capa_Vista_Reporteria.Properties.Resources.ssssss;
            this.Pic_Foto.Location = new System.Drawing.Point(3, 399);
            this.Pic_Foto.Name = "Pic_Foto";
            this.Pic_Foto.Size = new System.Drawing.Size(182, 141);
            this.Pic_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Foto.TabIndex = 4;
            this.Pic_Foto.TabStop = false;
            // 
            // menu_reporteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(961, 540);
            this.Controls.Add(this.flowLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "menu_reporteria";
            this.Text = "menu_reporteria";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Btn_RepUsuario;
        private System.Windows.Forms.Button Btn_RepAdmin;
        private System.Windows.Forms.PictureBox Pic_1;
        private System.Windows.Forms.PictureBox Pic_2;
        private System.Windows.Forms.PictureBox Pic_Foto;
    }
}