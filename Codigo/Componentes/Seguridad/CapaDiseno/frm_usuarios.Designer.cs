namespace CapaDiseno
{
    partial class frm_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuarios));
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.Gpb_datospersonalesclave = new System.Windows.Forms.GroupBox();
            this.cmb_Pregunta = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_pregunta = new System.Windows.Forms.Label();
            this.rb_inhabilitado = new System.Windows.Forms.RadioButton();
            this.rb_habilitado = new System.Windows.Forms.RadioButton();
            this.txt_respuesta = new System.Windows.Forms.TextBox();
            this.lbl_respuesta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_estadousuario = new System.Windows.Forms.TextBox();
            this.Gpb_datospersonales = new System.Windows.Forms.GroupBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nomb = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_apellido = new System.Windows.Forms.Label();
            this.Gpb_datosusuario = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.Lbl_id = new System.Windows.Forms.Label();
            this.Lbl_username = new System.Windows.Forms.Label();
            this.txt_nombreusername = new System.Windows.Forms.TextBox();
            this.Lbl_contraseña = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.Dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.Gpb_datospersonalesclave.SuspendLayout();
            this.Gpb_datospersonales.SuspendLayout();
            this.Gpb_datosusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(558, 117);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(111, 35);
            this.btn_guardar.TabIndex = 233;
            this.btn_guardar.Tag = "5";
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(984, 117);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(79, 35);
            this.btn_salir.TabIndex = 234;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(457, 29);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(98, 35);
            this.btn_buscar.TabIndex = 237;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(847, 117);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(115, 35);
            this.Btn_eliminar.TabIndex = 238;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_buscar);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btn_buscar);
            this.groupBox3.Location = new System.Drawing.Point(458, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(563, 79);
            this.groupBox3.TabIndex = 239;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modificar";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(166, 29);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(283, 26);
            this.txt_buscar.TabIndex = 240;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 238;
            this.label2.Text = "Buscar Id";
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Location = new System.Drawing.Point(693, 117);
            this.Btn_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(131, 35);
            this.Btn_modificar.TabIndex = 240;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.UseVisualStyleBackColor = true;
            this.Btn_modificar.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(427, 117);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(103, 35);
            this.btn_nuevo.TabIndex = 241;
            this.btn_nuevo.Tag = "0";
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Image = global::CapaDiseno.Properties.Resources.icons8_ayuda_30;
            this.btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ayuda.Location = new System.Drawing.Point(1049, 10);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(86, 36);
            this.btn_ayuda.TabIndex = 252;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Gpb_datospersonalesclave
            // 
            this.Gpb_datospersonalesclave.Controls.Add(this.cmb_Pregunta);
            this.Gpb_datospersonalesclave.Controls.Add(this.textBox1);
            this.Gpb_datospersonalesclave.Controls.Add(this.lbl_pregunta);
            this.Gpb_datospersonalesclave.Controls.Add(this.rb_inhabilitado);
            this.Gpb_datospersonalesclave.Controls.Add(this.rb_habilitado);
            this.Gpb_datospersonalesclave.Controls.Add(this.txt_respuesta);
            this.Gpb_datospersonalesclave.Controls.Add(this.lbl_respuesta);
            this.Gpb_datospersonalesclave.Controls.Add(this.label8);
            this.Gpb_datospersonalesclave.Controls.Add(this.txt_estadousuario);
            this.Gpb_datospersonalesclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datospersonalesclave.Location = new System.Drawing.Point(984, 194);
            this.Gpb_datospersonalesclave.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datospersonalesclave.Name = "Gpb_datospersonalesclave";
            this.Gpb_datospersonalesclave.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datospersonalesclave.Size = new System.Drawing.Size(476, 231);
            this.Gpb_datospersonalesclave.TabIndex = 256;
            this.Gpb_datospersonalesclave.TabStop = false;
            this.Gpb_datospersonalesclave.Text = "Datos Personales";
            // 
            // cmb_Pregunta
            // 
            this.cmb_Pregunta.FormattingEnabled = true;
            this.cmb_Pregunta.Location = new System.Drawing.Point(171, 135);
            this.cmb_Pregunta.Name = "cmb_Pregunta";
            this.cmb_Pregunta.Size = new System.Drawing.Size(297, 28);
            this.cmb_Pregunta.TabIndex = 262;
            this.cmb_Pregunta.SelectedIndexChanged += new System.EventHandler(this.cmb_Pregunta_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(414, 137);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(16, 26);
            this.textBox1.TabIndex = 261;
            this.textBox1.Tag = "3";
            // 
            // lbl_pregunta
            // 
            this.lbl_pregunta.AutoSize = true;
            this.lbl_pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pregunta.Location = new System.Drawing.Point(32, 137);
            this.lbl_pregunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pregunta.Name = "lbl_pregunta";
            this.lbl_pregunta.Size = new System.Drawing.Size(76, 20);
            this.lbl_pregunta.TabIndex = 260;
            this.lbl_pregunta.Text = "Pregunta";
            // 
            // rb_inhabilitado
            // 
            this.rb_inhabilitado.AutoSize = true;
            this.rb_inhabilitado.Location = new System.Drawing.Point(231, 63);
            this.rb_inhabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.rb_inhabilitado.Name = "rb_inhabilitado";
            this.rb_inhabilitado.Size = new System.Drawing.Size(87, 24);
            this.rb_inhabilitado.TabIndex = 231;
            this.rb_inhabilitado.TabStop = true;
            this.rb_inhabilitado.Text = "Inactivo";
            this.rb_inhabilitado.UseVisualStyleBackColor = true;
            // 
            // rb_habilitado
            // 
            this.rb_habilitado.AutoSize = true;
            this.rb_habilitado.Location = new System.Drawing.Point(94, 63);
            this.rb_habilitado.Margin = new System.Windows.Forms.Padding(4);
            this.rb_habilitado.Name = "rb_habilitado";
            this.rb_habilitado.Size = new System.Drawing.Size(76, 24);
            this.rb_habilitado.TabIndex = 230;
            this.rb_habilitado.TabStop = true;
            this.rb_habilitado.Text = "Activo";
            this.rb_habilitado.UseVisualStyleBackColor = true;
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_respuesta.Location = new System.Drawing.Point(171, 190);
            this.txt_respuesta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(297, 26);
            this.txt_respuesta.TabIndex = 229;
            this.txt_respuesta.Tag = "4";
            // 
            // lbl_respuesta
            // 
            this.lbl_respuesta.AutoSize = true;
            this.lbl_respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_respuesta.Location = new System.Drawing.Point(32, 189);
            this.lbl_respuesta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_respuesta.Name = "lbl_respuesta";
            this.lbl_respuesta.Size = new System.Drawing.Size(89, 20);
            this.lbl_respuesta.TabIndex = 228;
            this.lbl_respuesta.Text = "Respuesta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(131, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 205;
            this.label8.Text = "Estado Usuario";
            // 
            // txt_estadousuario
            // 
            this.txt_estadousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estadousuario.Location = new System.Drawing.Point(436, 135);
            this.txt_estadousuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estadousuario.Name = "txt_estadousuario";
            this.txt_estadousuario.Size = new System.Drawing.Size(16, 26);
            this.txt_estadousuario.TabIndex = 227;
            this.txt_estadousuario.Tag = "3";
            this.txt_estadousuario.TextChanged += new System.EventHandler(this.txt_estadousuario_TextChanged);
            // 
            // Gpb_datospersonales
            // 
            this.Gpb_datospersonales.Controls.Add(this.txt_correo);
            this.Gpb_datospersonales.Controls.Add(this.Lbl_correo);
            this.Gpb_datospersonales.Controls.Add(this.txt_apellido);
            this.Gpb_datospersonales.Controls.Add(this.txt_nomb);
            this.Gpb_datospersonales.Controls.Add(this.Lbl_nombre);
            this.Gpb_datospersonales.Controls.Add(this.Lbl_apellido);
            this.Gpb_datospersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datospersonales.Location = new System.Drawing.Point(505, 194);
            this.Gpb_datospersonales.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datospersonales.Name = "Gpb_datospersonales";
            this.Gpb_datospersonales.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datospersonales.Size = new System.Drawing.Size(457, 231);
            this.Gpb_datospersonales.TabIndex = 255;
            this.Gpb_datospersonales.TabStop = false;
            this.Gpb_datospersonales.Text = "Datos Personales";
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(125, 149);
            this.txt_correo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(308, 26);
            this.txt_correo.TabIndex = 229;
            this.txt_correo.Tag = "4";
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_correo.Location = new System.Drawing.Point(8, 149);
            this.Lbl_correo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(60, 20);
            this.Lbl_correo.TabIndex = 228;
            this.Lbl_correo.Text = "Correo";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(125, 94);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(308, 26);
            this.txt_apellido.TabIndex = 226;
            this.txt_apellido.Tag = "4";
            // 
            // txt_nomb
            // 
            this.txt_nomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomb.Location = new System.Drawing.Point(206, 39);
            this.txt_nomb.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nomb.Name = "txt_nomb";
            this.txt_nomb.Size = new System.Drawing.Size(227, 26);
            this.txt_nomb.TabIndex = 226;
            this.txt_nomb.Tag = "1";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(8, 43);
            this.Lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(68, 20);
            this.Lbl_nombre.TabIndex = 205;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Lbl_apellido
            // 
            this.Lbl_apellido.AutoSize = true;
            this.Lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_apellido.Location = new System.Drawing.Point(8, 97);
            this.Lbl_apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_apellido.Name = "Lbl_apellido";
            this.Lbl_apellido.Size = new System.Drawing.Size(68, 20);
            this.Lbl_apellido.TabIndex = 193;
            this.Lbl_apellido.Text = "Apellido";
            // 
            // Gpb_datosusuario
            // 
            this.Gpb_datosusuario.Controls.Add(this.txt_id);
            this.Gpb_datosusuario.Controls.Add(this.Lbl_id);
            this.Gpb_datosusuario.Controls.Add(this.Lbl_username);
            this.Gpb_datosusuario.Controls.Add(this.txt_nombreusername);
            this.Gpb_datosusuario.Controls.Add(this.Lbl_contraseña);
            this.Gpb_datosusuario.Controls.Add(this.txt_clave);
            this.Gpb_datosusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosusuario.Location = new System.Drawing.Point(25, 194);
            this.Gpb_datosusuario.Margin = new System.Windows.Forms.Padding(4);
            this.Gpb_datosusuario.Name = "Gpb_datosusuario";
            this.Gpb_datosusuario.Padding = new System.Windows.Forms.Padding(4);
            this.Gpb_datosusuario.Size = new System.Drawing.Size(455, 231);
            this.Gpb_datosusuario.TabIndex = 254;
            this.Gpb_datosusuario.TabStop = false;
            this.Gpb_datosusuario.Text = "Datos Usuario";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(146, 44);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(227, 26);
            this.txt_id.TabIndex = 254;
            this.txt_id.Tag = "1";
            // 
            // Lbl_id
            // 
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Location = new System.Drawing.Point(14, 42);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(26, 20);
            this.Lbl_id.TabIndex = 228;
            this.Lbl_id.Text = "ID";
            // 
            // Lbl_username
            // 
            this.Lbl_username.AutoSize = true;
            this.Lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_username.Location = new System.Drawing.Point(14, 93);
            this.Lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_username.Name = "Lbl_username";
            this.Lbl_username.Size = new System.Drawing.Size(86, 20);
            this.Lbl_username.TabIndex = 205;
            this.Lbl_username.Text = "Username";
            // 
            // txt_nombreusername
            // 
            this.txt_nombreusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreusername.Location = new System.Drawing.Point(146, 93);
            this.txt_nombreusername.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreusername.Name = "txt_nombreusername";
            this.txt_nombreusername.Size = new System.Drawing.Size(283, 26);
            this.txt_nombreusername.TabIndex = 227;
            this.txt_nombreusername.Tag = "3";
            // 
            // Lbl_contraseña
            // 
            this.Lbl_contraseña.AutoSize = true;
            this.Lbl_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_contraseña.Location = new System.Drawing.Point(8, 141);
            this.Lbl_contraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_contraseña.Name = "Lbl_contraseña";
            this.Lbl_contraseña.Size = new System.Drawing.Size(100, 20);
            this.Lbl_contraseña.TabIndex = 193;
            this.Lbl_contraseña.Text = " Contraseña";
            // 
            // txt_clave
            // 
            this.txt_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clave.Location = new System.Drawing.Point(146, 141);
            this.txt_clave.Margin = new System.Windows.Forms.Padding(4);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Size = new System.Drawing.Size(283, 26);
            this.txt_clave.TabIndex = 227;
            this.txt_clave.Tag = "2";
            // 
            // Dgv_usuarios
            // 
            this.Dgv_usuarios.AllowUserToAddRows = false;
            this.Dgv_usuarios.AllowUserToDeleteRows = false;
            this.Dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_usuarios.Location = new System.Drawing.Point(25, 445);
            this.Dgv_usuarios.Name = "Dgv_usuarios";
            this.Dgv_usuarios.ReadOnly = true;
            this.Dgv_usuarios.RowHeadersWidth = 72;
            this.Dgv_usuarios.RowTemplate.Height = 31;
            this.Dgv_usuarios.Size = new System.Drawing.Size(1436, 239);
            this.Dgv_usuarios.TabIndex = 258;
            this.Dgv_usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_usuarios_CellContentClick);
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 747);
            this.Controls.Add(this.Dgv_usuarios);
            this.Controls.Add(this.Gpb_datospersonalesclave);
            this.Controls.Add(this.Gpb_datospersonales);
            this.Controls.Add(this.Gpb_datosusuario);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_guardar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Usuarios";
            this.Load += new System.EventHandler(this.Frm_usuarios_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Gpb_datospersonalesclave.ResumeLayout(false);
            this.Gpb_datospersonalesclave.PerformLayout();
            this.Gpb_datospersonales.ResumeLayout(false);
            this.Gpb_datospersonales.PerformLayout();
            this.Gpb_datosusuario.ResumeLayout(false);
            this.Gpb_datosusuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.GroupBox Gpb_datospersonalesclave;
        private System.Windows.Forms.TextBox txt_respuesta;
        private System.Windows.Forms.Label lbl_respuesta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_estadousuario;
        private System.Windows.Forms.GroupBox Gpb_datospersonales;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nomb;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_apellido;
        private System.Windows.Forms.GroupBox Gpb_datosusuario;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label Lbl_id;
        private System.Windows.Forms.Label Lbl_username;
        private System.Windows.Forms.TextBox txt_nombreusername;
        private System.Windows.Forms.Label Lbl_contraseña;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.RadioButton rb_inhabilitado;
        private System.Windows.Forms.RadioButton rb_habilitado;
        private System.Windows.Forms.DataGridView Dgv_usuarios;
        private System.Windows.Forms.ComboBox cmb_Pregunta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_pregunta;
    }
}