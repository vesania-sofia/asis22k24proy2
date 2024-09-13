using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeLogica;
using CapaDatos;

namespace CapaDeDiseno
{
    public partial class Navegador : UserControl
    {
        Validaciones v = new Validaciones();
        logicaNav logic = new logicaNav();
        Form cerrar;
        int correcto = 0;
        string tabla = "def";
        string otratabla = "def";
        string tabla2 = "def";
        string nomForm;
        int pos = 8;
		string idRepo = "";
		
		int[] modoCampoCombo = new int[40];
		int noCampos = 1;
        int x = 30;
        int y = 30;
        int activar = 0;    //Variable para reconocer que funcion realizara el boton de guardar (1. Ingresar, 2. Modificar, 3. Eliminar)
        string[] aliasC = new string[40];
        string[] tipoCampo = new string[30];//
        string[] tablaCombo = new string[30];
        string[] campoCombo = new string[30];
        string[] listaItems = new string[30];
        string[] campoDisplayCombo = new string[30];

        string tablarelacionada = "";
        string campodescriptivo="";
        string columnaprimararelacionada="";
        string columnaForanea = "";

        int posCombo = 10;
        int noCombo = 0;
        int noComboAux = 0;
        int estado = 1;
        Color Cfuente = Color.White;
        Color nuevoColor = Color.White;
        bool presionado = false;
        sentencia sn = new sentencia(); //objeto del componente de seguridad para obtener el método de la bitácora
        string idUsuario = "";
        string idAplicacion = "";
        //las siguientes dos variables son para el método botonesYPermisos();
        //string userActivo = ""; //1
        //string aplActivo = "";  //2
        string idyuda;
        string AsRuta;
        string AsIndice;
        string Asayuda;
        // string rutaa;
        Font fuente = new Font("Century Gothic", 13.0f, FontStyle.Regular, GraphicsUnit.Pixel); //objeto para definir el tipo y tamaño de fuente de los labels
        ToolTip ayuda_tp = new ToolTip();
        private string idFactura;
        private string monto;
        private string nombreCliente;
        

        public Navegador()
        {
            InitializeComponent();
            limpiarListaItems();
            //Configuración del ToolTip
            ayuda_tp.IsBalloon = true;
            ayuda_tp.AutoPopDelay = 5000; // Mantener el ToolTip visible por 5 segundos
            ayuda_tp.InitialDelay = 1000; // Retraso de 1 segundo antes de que aparezca el ToolTip
            ayuda_tp.ReshowDelay = 500;   // Retraso de medio segundo antes de reaparecer
            ayuda_tp.ShowAlways = true;   // Mostrar el ToolTip siempre, incluso cuando el control no tiene el foco
            //ToolTips
            ayuda_tp.IsBalloon = true;
            ayuda_tp.SetToolTip(Btn_Ingresar, "Agregar un nuevo registro al sistema.");
            ayuda_tp.SetToolTip(Btn_Modificar, "Modificar el registro seleccionado.");
            ayuda_tp.SetToolTip(Btn_Guardar, "Guardar los cambios realizados.");
            ayuda_tp.SetToolTip(Btn_Cancelar, "Cancelar la operación actual.");
            ayuda_tp.SetToolTip(Btn_Eliminar, "Eliminar el registro seleccionado.");
            ayuda_tp.SetToolTip(Btn_Consultar, "Acceder a las consultas avanzadas.");
            ayuda_tp.SetToolTip(Btn_Refrescar, "Actualizar los datos de la tabla.");
            ayuda_tp.SetToolTip(Btn_FlechaInicio, "Ir al primer registro.");
            ayuda_tp.SetToolTip(Btn_Anterior, "Mover al registro anterior.");
            ayuda_tp.SetToolTip(Btn_Siguiente, "Mover al siguiente registro.");
            ayuda_tp.SetToolTip(Btn_FlechaFin, "Ir al último registro.");
            ayuda_tp.SetToolTip(Btn_Ayuda, "Ver la ayuda del formulario.");
            ayuda_tp.SetToolTip(Btn_Salir, "Cerrar el formulario actual.");
        }
        private void Navegador_Load(object sender, EventArgs e)
        {
            colorDialog1.Color = nuevoColor;
            this.BackColor = colorDialog1.Color;

            if (tabla != "def")
            {
                string TablaOK = logic.TestTabla(tabla);
                if (TablaOK == "" && correcto == 0)
                {
                    string EstadoOK = logic.TestEstado(tabla);
                    if (EstadoOK == "" && correcto == 0)
                    {
                        //Asayuda = logic.verificacion("");
                        if (Asayuda == "0")
                        {
                            MessageBox.Show("No se encontró ningún registro en la tabla Ayuda");
                            Application.Exit();
                        }
                        else
                        {
                            if (numeroAlias()== logic.contarCampos(tabla))
                            {
                                int i = 0;
                                DataTable dt = logic.consultaLogica(tabla, tablarelacionada, campodescriptivo, columnaForanea, columnaprimararelacionada);
                                dataGridView1.DataSource = dt;
                                int head = 0;
                                while (head< logic.contarCampos(tabla))
                                {
                                    dataGridView1.Columns[head].HeaderText = aliasC[head];
                                    head++;
                                }
                                CreaComponentes();
								colorTitulo();
								lblTabla.ForeColor = Cfuente;
                                deshabilitarcampos_y_botones();
                                
                                Btn_Modificar.Enabled = true;
                                Btn_Eliminar.Enabled = true;

                                //habilitar y deshabilitar según Usuario FUNCION SOLO PARA INICIO                                                                                               
                                //botonesYPermisosInicial(userActivo, aplActivo);
                                //registros();
                                if (logic.TestRegistros(tabla) > 0)
                                {
									int numCombo = 0;
									foreach (Control componente in Controls)
									{
										if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
										{
											if (componente is ComboBox)
											{
												if (modoCampoCombo[numCombo] == 1)
												{
													componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());

												}
												else
												{
													componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
												}

												numCombo++;
											}
											else
											{
												componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
											}

											i++;
										}
										if (componente is Button)
										{
											string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
											if (var1 == "0")
											{
												componente.Text = "Desactivado";
												componente.BackColor = Color.Red;
											}
											if (var1 == "1")
											{
												componente.Text = "Activado";
												componente.BackColor = Color.Green;
											}
											componente.Enabled = false;

										}
									}
								}
                                else
                                {
                                    Btn_Anterior.Enabled = false;
                                    Btn_Siguiente.Enabled = false;
                                    Btn_FlechaInicio.Enabled = false;
                                    Btn_FlechaFin.Enabled = false;
                                    Btn_Modificar.Enabled = false;
                                    Btn_Eliminar.Enabled = false;
                                }
                            }
                            else
                            {
                                if (numeroAlias() < logic.contarCampos(tabla))
                                {
                                    DialogResult validacion = MessageBox.Show(EstadoOK + "El numero de Alias asignados es menor que el requerido \n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                                    if (validacion == DialogResult.OK)
                                    {
                                        Application.Exit();
                                    }
                                }
                                else
                                {
                                    if (numeroAlias() > logic.contarCampos(tabla))
                                    {
                                        DialogResult validacion = MessageBox.Show(EstadoOK + "El numero de Alias asignados es mayor que el requerido \n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                                        if (validacion == DialogResult.OK)
                                        {
                                            Application.Exit();
                                        }
                                    }
                                }
                             }                                                      
                        }
                    }
                    else
                    {
                        DialogResult validacion = MessageBox.Show(EstadoOK + "\n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                        if (validacion == DialogResult.OK)
                        {
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    DialogResult validacion = MessageBox.Show(TablaOK + "\n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                    if (validacion == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {

               // MessageBox.Show("Tabla actual: " + tabla);

                //MessageBox.Show("Tabla actual: " + tabla);

            }
            //botonesYPermisosInicial(userActivo, aplActivo);
            //registros();
        }

        //-----------------------------------------------Funciones-----------------------------------------------//
        
		void colorTitulo()
		{
			foreach (Control componente in Controls)
			{
				if (componente is Label)
				{

					componente.ForeColor = Cfuente;
				}
			}
		}
        public void ObtenerIdUsuario(string idUsuario)
        {

			this.idUsuario = idUsuario;            
        }
        public void asignarforaneas(string table, string tablarela, string campodescri, string columnafora, string columnaprimaria)
        {
            tabla = table;
            tablarelacionada =tablarela;
            campodescriptivo = campodescri;
            columnaForanea = columnafora;
            columnaprimararelacionada = columnaprimaria;

            


        }
        public void ObtenerIdAplicacion(string idAplicacion)
        {
            this.idAplicacion = idAplicacion;            
        }
        /*
        private void permisos()
        {
          sentencia s = new sentencia();
          bool permiso = s.consultarPermisos(IdUsuario,idAplicacion,5);
        } */

        private int numeroAlias()
            {
            int i = 0;
            foreach (string cad  in aliasC)
            {
                if (cad!=null && cad!="")
                {
                    i++;
                } 
            }
            return i;
            }       

        public string obtenerDatoTabla(int pos)
        {
            pos=pos - 1;
          return  dataGridView1.CurrentRow.Cells[pos].Value.ToString();
        }

        public string obtenerDatoCampos(int pos)
        {

            int i = 0;
            pos = pos - 1;
            string dato = "";
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    if (i==pos)
                    {
                        dato = componente.Text;
                    }
                    i++;
                }
            }
                return dato;
        }
        public void asignarAlias(string[] alias)
        {
            alias.CopyTo(aliasC, 0);   
        }

        public void asignarAyuda(string ayudar)
        {
            string AyudaOK = logic.TestTabla("ayuda");
            if (AyudaOK == "")
            {
                if (logic.contarRegAyuda(ayudar)>0)
                {
                    idyuda = ayudar;
                    AsRuta = logic.MRuta(idyuda);
                    AsIndice = logic.MIndice(idyuda);
                    if (AsRuta=="" || AsIndice=="" || AsRuta == null || AsIndice == null)
                    {
                        DialogResult validacion = MessageBox.Show("La Ruta o índice de la ayuda está vacía", "Verificación de requisitos", MessageBoxButtons.OK);
                        if (validacion == DialogResult.OK)
                        {
                            correcto = 1;
                        }
                    }
                }
                else
                {
                    DialogResult validacion = MessageBox.Show("Por favor verifique el id de Ayuda asignado al form", "Verificación de requisitos", MessageBoxButtons.OK);
                    if (validacion == DialogResult.OK)
                    {
                        correcto = 1;
                    }
                }
               
            }
            else
            {
                DialogResult validacion = MessageBox.Show(AyudaOK + ", Por favor incluirla", "Verificación de requisitos", MessageBoxButtons.OK);
                if (validacion == DialogResult.OK)
                {
                    correcto = 1;
                }
            }
        }

		public void asignarReporte(string repo)
		{
			idRepo = repo;
		}
		public void asignarSalida(Form salida)
        {
            cerrar = salida;
        }
        public void asignarColorFuente(Color FuenteC)
        {

            Cfuente = FuenteC;
        }
        public void asignarTabla(string table)
        {
            tabla = table;
        }
      
        public void asignar2Tabla(string table)
        {
            otratabla= table;
        }

        public void asignarNombreForm(string nom)
        {
            nomForm = nom;
            lblTabla.Text = nomForm;
        }

        public void asignarComboConTabla(string tabla, string campoClave, string campoDisplay, int modo)
        {
            // Verifica si la tabla existe
            string TablaOK = logic.TestTabla(tabla);
            if (TablaOK == "")
            {
                // Asigna los valores para el combo
                modoCampoCombo[noCombo] = modo;
                tablaCombo[noCombo] = tabla;
                campoCombo[noCombo] = campoClave; // Este será el valor subyacente (id_raza)
                campoDisplayCombo[noCombo] = campoDisplay; // Este será lo que se muestra (nombre_raza)
                noCombo++;
            }
            else
            {
                // Muestra error si la tabla o campo son incorrectos
                DialogResult validacion = MessageBox.Show(TablaOK + ", o el campo seleccionado\n para el ComboBox es incorrecto", "Verificación de requisitos", MessageBoxButtons.OK);
                if (validacion == DialogResult.OK)
                {
                    correcto = 1;
                }
            }
        }


        public void asignarColorFondo(Color nuevo)
        {
            nuevoColor = nuevo;
        }

        public void asignarComboConLista(int pos,string lista)
        {
            posCombo = pos-1;
            limpiarLista(lista);
			modoCampoCombo[noCombo] = 0;
			noCombo++;
        }

        void limpiarLista(string cadena)
        {
            limpiarListaItems();
            int contadorCadena = 0;
            int contadorArray = 0;
            string palabra = "";
            while (contadorCadena < cadena.Length)
            {
                if (cadena[contadorCadena] != '|')
                {
                    palabra += cadena[contadorCadena];
                    contadorCadena++;
                }
                else
                {

                    listaItems[contadorArray] = palabra;
                    palabra = "";
                    contadorArray++;
                    contadorCadena++;
                }
            }
        }

        void limpiarListaItems()
        {
            for (int i =0; i< listaItems.Length;i++)
            {
                listaItems[i] = "";
            }
        }


        void CreaComponentes()
        {
            string[] Campos = logic.campos(tabla);
            string[] Tipos = logic.tipos(tabla);
            string[] LLaves = logic.llaves(tabla);
            int i = 0;
            int fin = Campos.Length;
            while (i < fin)
            {
                if (noCampos == 6 || noCampos == 11 || noCampos == 16 || noCampos == 21) { pos = 8; }
                if (noCampos >= 6 && noCampos < 10) { x = 300; }
                if (noCampos >= 11 && noCampos < 15) { x = 600; }
                if (noCampos >= 16 && noCampos < 20) { x = 900; }
                if (noCampos >= 21 && noCampos < 25) { x = 900; }
                Label lb = new Label();

                lb.Text = aliasC[i];

                Point p = new Point(x + pos, y * pos);
                lb.Location = p;
                lb.Name = "lb_" + Campos[i];
                lb.Font = fuente;
                lb.ForeColor = Cfuente;
                this.Controls.Add(lb);

                if (LLaves[i]=="PRI" && i!=0)
                {
                    LLaves[i] = "MUL";
                }

                switch (Tipos[i])
                {
                    case "int":
                        tipoCampo[noCampos - 1] = "Num";
                        if (LLaves[i] != "MUL") { 
                            crearTextBoxnumerico(Campos[i]); 
                        } 
                        else { 
                            crearComboBox(Campos[i]); }
                        
                        break;
                    case "varchar":
                        tipoCampo[noCampos - 1] = "Text";

                        if (LLaves[i] != "MUL")
                        { crearTextBoxvarchar(Campos[i]);} else { crearComboBox(Campos[i]); }
                break;
                    case "date":
                        tipoCampo[noCampos - 1] = "Text";
                        if (LLaves[i] != "MUL")
                        {crearDateTimePicker(Campos[i]);} else { crearComboBox(Campos[i]); }
                        break;

                    case "datetime":
                        tipoCampo[noCampos - 1] = "Text";
                        if (LLaves[i] != "MUL")
                        { crearDateTimePicker(Campos[i]); }
                        else { crearComboBox(Campos[i]); }
                        break;

                    case "text":
                        tipoCampo[noCampos - 1] = "Text";
                        if (LLaves[i] != "MUL")
                        { crearTextBoxvarchar(Campos[i]); }
                        else { crearComboBox(Campos[i]); }
                        break;
                    case "time":
                        tipoCampo[noCampos - 1] = "Text";
                        crearcampohora(Campos[i]);
                        break;

                    case "float":
                        tipoCampo[noCampos - 1] = "Text";
                        crearcampodecimales(Campos[i]);
                        break;

                    case "decimal":
                        tipoCampo[noCampos - 1] = "Text";
                        crearcampodecimales(Campos[i]);
                        break;

                    case "double":
                        tipoCampo[noCampos - 1] = "Text";
                        crearcampodecimales(Campos[i]);
                        break;



                    case "tinyint":
                        tipoCampo[noCampos - 1] = "Num";
                        if (LLaves[i] != "MUL")
                        {
                            crearBotonEstado(Campos[i]);
                        }
                        break;

                    default:

                        if (Tipos[i]!=null && Tipos[i] != "")
                        {
                            DialogResult validacion = MessageBox.Show("La tabla "+tabla+" posee un campo "+Tipos[i]+ ", este tipo de dato no es reconocido por el navegador\n Solucione este problema...", "Verificación de requisitos", MessageBoxButtons.OK);
                            if (validacion == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                        }
                        
                        break;
                }
                noCampos++;

                i++;
            }
        }
        void func_click(object sender, EventArgs e)
        {
            foreach (Control componente in Controls)
            {
                if (componente is Button)
                {
                    if (estado == 1)
                    {
                        componente.Text = "Desactivado";
                        componente.BackColor = Color.Red;
                        //estado++;
                        estado = 0;
                    }
                    else 
                    {
                        componente.Text = "Activado";
                        componente.BackColor = Color.Green;
                        //estado++;
                        estado = 1;
                    }
                   /* else
                    {
                        componente.Text = "Desactivado";
                        componente.BackColor = Color.Red;
                        //estado--;
                        estado = 1
                    }
                    if(estado == 0)
                    {
                        componente.Text = "Activado";
                        componente.BackColor = Color.Green;
                        //estado++;
                        estado = 1;
                    }
                    else
                    {

                        componente.Text = "Activado";
                        componente.BackColor = Color.Green;
                        //estado++;
                        estado = 0;
                    }*/
                  
                }
            }
        }
        void crearBotonEstado(String nom)
        {
            Button btn = new Button();
            Point p = new Point(x + 125 + pos, y * pos);
            btn.Location = p;
            btn.Text = "Activado";
            btn.BackColor = Color.Green;
            btn.Click += new EventHandler(func_click);
            btn.Name = nom;
            btn.Enabled = false;
            this.Controls.Add(btn);
            pos++;
        }
        void crearTextBoxnumerico(String nom)
        {

          
            TextBox tb = new TextBox();
            Point p = new Point(x + 125 + pos, y * pos);
            tb.Location = p;
            tb.Name = nom;
            this.Controls.Add(tb);
            tb.KeyPress += Paravalidarnumeros_KeyPress;
            this.KeyPress += Paravalidarnumeros_KeyPress;
            //+= new System.Windows.Forms.KeyPressEventHandler(this.Txt_telefono_KeyPress);
            pos++;

        }

        void crearTextBoxvarchar(String nom)
        {

  
            TextBox tb = new TextBox();
            Point p = new Point(x + 125 + pos, y * pos);
            tb.Location = p;
            tb.Name = nom;
            this.Controls.Add(tb);
            tb.KeyPress += Paravalidarvarchar_KeyPress;
            this.KeyPress += Paravalidarvarchar_KeyPress;      
            pos++;

        }
        void crearTextBoxtexto(String nom)
        {

            TextBox tb = new TextBox();
            Point p = new Point(x + 125 + pos, y * pos);
            tb.Location = p;
            tb.Name = nom;
            this.Controls.Add(tb);
            tb.KeyPress += Paravalidartexto_KeyPress;
            this.KeyPress += Paravalidartexto_KeyPress;          
            pos++;

        }

        void crearcampohora(String nom)
        {
            TextBox tb = new TextBox();
            Point p = new Point(x + 125 + pos, y * pos);
            tb.Location = p;
            tb.Name = nom;
            this.Controls.Add(tb);
            tb.KeyPress += Paravalidarhora_KeyPress;
            this.KeyPress += Paravalidarhora_KeyPress;
            //+= new System.Windows.Forms.KeyPressEventHandler(this.Txt_telefono_KeyPress);
            pos++;
        }

       
        void crearcampodecimales(String nom)
        {
            TextBox tb = new TextBox();
            Point p = new Point(x + 125 + pos, y * pos);
            tb.Location = p;
            tb.Name = nom;
            this.Controls.Add(tb);
            tb.KeyPress += Paravalidardecimales_KeyPress;
            this.KeyPress += Paravalidardecimales_KeyPress;
            //+= new System.Windows.Forms.KeyPressEventHandler(this.Txt_telefono_KeyPress);
            pos++;


        }

        private void Paravalidardecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Camposdecimales(e);
        }

        private void Paravalidarnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposNumericos(e);
        }

        private void Paravalidarhora_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposHora(e);
        }

        private void Paravalidarvarchar_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposVchar(e);
        }
        private void Paravalidartexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposLetras(e);
        }
        private void Paravalidacombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Combobox(e);
        }

        void crearComboBox(String nom)
        {
            // Obtener los items para el ComboBox (una lista de objetos clave-valor)
            Dictionary<string, string> items;
            if (tablaCombo[noComboAux] != null)
            {
                items = logic.items(tablaCombo[noComboAux], campoCombo[noComboAux], campoDisplayCombo[noComboAux]);
                if (noCombo > noComboAux) { noComboAux++; }
            }
            else
            {
                items = logic.items("Peliculas", "idPelicula", "nombrePelicula");
                if (noCombo > noComboAux) { noComboAux++; }
            }

            ComboBox cb = new ComboBox();
            Point p = new Point(x + 125 + pos, y * pos);
            cb.Location = p;
            cb.Name = nom;

            // Asignar el DataSource usando un BindingSource
            BindingSource bs = new BindingSource();
            bs.DataSource = items;

            cb.DataSource = bs;  // Asignar el DataSource al ComboBox
            cb.DisplayMember = "Value";  // Mostrar el nombre
            cb.ValueMember = "Key";      // Guardar el ID

            this.Controls.Add(cb);
            pos++;
        }




        void crearDateTimePicker(String nom)
        {
            DateTimePicker dtp = new DateTimePicker();
            Point p = new Point(x + 125 + pos, y * pos);
            dtp.Location = p;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "yyyy-MM-dd";
            dtp.Width = 100;
            dtp.Name = nom;
            this.Controls.Add(dtp);
            pos++;
        }

        public void deshabilitarcampos_y_botones()
        {
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    componente.Enabled = false; //De esta menera bloqueamos todos los textbox por si solo quiere ver los registros

                }

            }
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = false;

        }

        public void habilitarcampos_y_botones()
        {
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    componente.Enabled = true; //De esta menera bloqueamos todos los textbox por si solo quiere ver los registros

                }

            }
            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true;
            Btn_Guardar.Enabled = true;
            Btn_Cancelar.Enabled = true;

        }

        public void actualizardatagriew()
        {

            DataTable dt = logic.consultaLogica(tabla,tablarelacionada,campodescriptivo, columnaForanea, columnaprimararelacionada);

            
            dataGridView1.DataSource = dt;
            int head = 0;
            while (head < logic.contarCampos(tabla))
            {
                dataGridView1.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }

        string crearDelete()// crea el query de delete
        {
            //Cambiar el estadoPelicula por estado
            string query = "UPDATE " + tabla + " SET estado=0";
            string whereQuery = " WHERE  ";
            int posCampo = 0;
			int i = 0;
            string campos = "";

            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    if (posCampo == 0)
                    {
                        switch (tipoCampo[posCampo])
                        {
                            case "Text":
								if (componente is ComboBox)
								{

									if (modoCampoCombo[i] == 1)
									{
										whereQuery += componente.Name + " = '" + logic.llaveCampolo(tablaCombo[i], campoCombo[i], componente.Text) + "' , ";
									}
									else
									{
										whereQuery += componente.Name + " = '" + componente.Text + "' , ";
									}

									i++;
								}
								else
								{
									whereQuery += componente.Name + " = '" + componente.Text + "' , ";
								}

								
                                break;
                            case "Num":
								if (componente is ComboBox)
								{

									if (modoCampoCombo[i] == 1)
									{
										whereQuery += componente.Name + " = " + logic.llaveCampolo(tablaCombo[i], campoCombo[i], componente.Text);
										 
									}
									else
									{
										whereQuery += componente.Name + " = " + componente.Text;
									}

									i++;
								}
								else
								{
									whereQuery += componente.Name + " = " + componente.Text;
								}
								
                                break;
                        }
						
                    }
                    posCampo++;
                }

            }
            campos = campos.TrimEnd(' ');
            campos = campos.TrimEnd(',');
			whereQuery = whereQuery.TrimEnd(' ');
			whereQuery = whereQuery.TrimEnd(',');
			//query += campos + whereQuery + ";";
			query += whereQuery + ";";
			Console.Write(query);
            //sn.insertarBitacora(idUsuario, "Se eliminó un registro", tabla);
            return query;
        }

        string crearInsert(string nombretabla)
        {
            string query = "INSERT INTO " + nombretabla + " (";
            string valores = "VALUES (";

            int posCampo = 0;
            string campos = "";
            string valoresCampos = "";

            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    string nombreCampo = logic.campos(nombretabla)[posCampo];
                    string valorCampo = string.Empty;

                    // Si el control es un ComboBox
                    if (componente is ComboBox cb)
                    {
                        // Obtener el valor seleccionado (ID) del ComboBox
                        valorCampo = cb.SelectedValue.ToString();  // Aquí se obtiene el ID en lugar del nombre
                    }
                    else
                    {
                        valorCampo = componente.Text;  // Para otros controles (TextBox, DateTimePicker, etc.)
                    }

                    // Agregar campo y valor si no está vacío
                    if (!string.IsNullOrEmpty(valorCampo))
                    {
                        campos += nombreCampo + ", ";
                        valoresCampos += "'" + valorCampo + "', ";
                    }

                    posCampo++;
                }
            }

            // Eliminar las últimas comas y cerrar las instrucciones
            campos = campos.TrimEnd(' ', ',');
            valoresCampos = valoresCampos.TrimEnd(' ', ',');

            query += campos + ") " + valores + valoresCampos + ");";

            return query;
        }





        string crearUpdate()
        {
            // Inicialización de la consulta UPDATE y la cláusula WHERE
            string query = "UPDATE " + tabla + " SET ";
            string whereQuery = " WHERE ";
            int posCampo = 0;
            int i = 0;
            string campos = "";

            // Recorre los controles del formulario
            foreach (Control componente in Controls)
            {
                // Verifica si el componente es un campo relevante (TextBox, DateTimePicker, ComboBox)
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    // Para los campos que no son claves primarias
                    if (posCampo > 0)
                    {
                        string valorCampo = "";
                        string nombreCampo = componente.Name;

                        if (componente is ComboBox comboBox)
                        {
                            // Si es un ComboBox, manejar si tiene un valor o es una llave foránea
                            if (modoCampoCombo[i] == 1)
                            {
                                valorCampo = logic.llaveCampolo(tablaCombo[i], campoCombo[i], comboBox.Text);
                            }
                            else
                            {
                                valorCampo = comboBox.SelectedValue?.ToString() ?? "";
                            }
                        }
                        else
                        {
                            // Si es un TextBox o DateTimePicker, obtener el texto
                            valorCampo = componente.Text;
                        }

                        // Validar si es numérico o texto
                        if (tipoCampo[posCampo] == "Num")
                        {
                            campos += $"{nombreCampo} = {valorCampo}, ";
                        }
                        else
                        {
                            campos += $"{nombreCampo} = '{valorCampo}', ";
                        }

                        i++;
                    }
                    // Para la clave primaria (posición 0)
                    else
                    {
                        string valorClavePrimaria = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        string nombreClavePrimaria = componente.Name;

                        if (tipoCampo[0] == "Num")
                        {
                            whereQuery += $"{nombreClavePrimaria} = {valorClavePrimaria}";
                        }
                        else
                        {
                            whereQuery += $"{nombreClavePrimaria} = '{valorClavePrimaria}'";
                        }
                    }

                    posCampo++;
                }

                // Manejo de botones (ej. activado/desactivado)
                if (componente is Button)
                {
                    if (tipoCampo[posCampo] == "Num")
                    {
                        string estadoButton = estado.ToString();
                        campos += $"{componente.Name} = {estadoButton}, ";
                    }

                    posCampo++;
                }
            }

            // Eliminar cualquier coma final sobrante en la cadena de campos
            campos = campos.TrimEnd(' ', ',');

            // Construcción final de la consulta
            query += campos + whereQuery + ";";

            // Mostrar la consulta para depurar (opcional)
            Console.WriteLine("Query generado para el UPDATE: " + query);

            return query;
        }



        public void guardadoforsozo()
        {
            logic.nuevoQuery(crearInsert(tabla));
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    componente.Enabled = true;
                    componente.Text = "";

                }

            }
            actualizardatagriew();
        }

        public void habilitarallbotones()//habilita todos los botnes
        {
            Btn_Guardar.Enabled = true;
            Btn_Ingresar.Enabled = true;
            Btn_Modificar.Enabled = true;
            Btn_Cancelar.Enabled = false;
            Btn_Eliminar.Enabled = true;

        }




        //-----------------------------------------------Funcionalidad de Botones-----------------------------------------------//

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            string[] Tipos = logic.tipos(tabla);

            bool tipoInt = false;
            bool ExtraAI = false;
            string auxId = "";
            int auxLastId = 0;

            // Verificar si el primer campo de la tabla es de tipo entero y autoincremental
            if (Tipos[0] == "int")
            {
                tipoInt = true;

                // Obtener el último ID insertado en la tabla si el campo es autoincrementable
                auxId = logic.lastID(tabla);

                // Verificar si el ID existe o la tabla está vacía
                if (!string.IsNullOrEmpty(auxId))
                {
                    auxLastId = Int32.Parse(auxId);
                }
                else
                {
                    auxLastId = 0; // Si no hay registros previos, inicializamos el ID en 0
                }

                ExtraAI = true; // Suponemos que el campo es autoincremental
            }

            activar = 2;
            habilitarcampos_y_botones();

            foreach (Control componente in Controls)
            {
                if (componente is TextBox && tipoInt && ExtraAI)
                {
                    // Incrementar el último ID para el nuevo registro
                    auxLastId += 1;
                    componente.Text = auxLastId.ToString();
                    componente.Enabled = false; // Deshabilitar el campo autoincremental para que no sea editable
                    tipoInt = false;
                    ExtraAI = false;
                }
                else if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    componente.Enabled = true;
                    componente.Text = "";
                }
                else if (componente is Button)
                {
                    componente.Enabled = true;
                }

                Btn_Ingresar.Enabled = false;
                Btn_Modificar.Enabled = false;
                Btn_Eliminar.Enabled = false;
                Btn_Cancelar.Enabled = true;
            }

            // Habilitar y deshabilitar botones según usuario
            botonesYPermisos();
            Btn_Ingresar.Enabled = false;
            Btn_Guardar.Enabled = true;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Cancelar.Enabled = true;
            Btn_Consultar.Enabled = false;
            Btn_Refrescar.Enabled = false;
        }


        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar un mensaje de confirmación antes de proceder con la operación de modificación
                DialogResult result = MessageBox.Show(
                    "Está a punto de modificar un registro existente.\n\n" +
                    "Asegúrese de que todos los datos sean correctos antes de continuar.\n\n" +
                    "¿Desea proceder con la modificación de este registro?",
                    "Confirmación de Modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, // Icono de advertencia para hacerlo más formal
                    MessageBoxDefaultButton.Button2 // Por defecto, la opción seleccionada será 'No'
                );

                // Si el usuario selecciona "No", se cancela la operación
                if (result == DialogResult.No)
                {
                    return;
                }

                // Habilitar campos para edición
                habilitarcampos_y_botones();
                activar = 1;
                int i = 0;

                string[] Tipos = logic.tipos(tabla);
                int numCombo = 0;

                // Recorrer los controles para habilitar la edición
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        // Deshabilitar el campo del ID si es entero (autoincremental)
                        if (i == 0 && Tipos[0] == "int")
                        {
                            componente.Enabled = false; // Deshabilitar el ID para que no sea modificable
                        }
                        else
                        {
                            // Si es un ComboBox, recuperar el valor adecuado
                            if (componente is ComboBox)
                            {
                                if (modoCampoCombo[numCombo] == 1)
                                {
                                    componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());
                                }
                                else
                                {
                                    componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                                }
                                numCombo++;
                            }
                            else
                            {
                                // Asignar el valor del campo al componente
                                componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                            }
                        }

                        i++;
                    }

                    if (componente is Button)
                    {
                        componente.Enabled = true;
                        string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();

                        if (var1 == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                            estado = 0;
                        }
                        else if (var1 == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                            estado = 1;
                        }
                        componente.Enabled = true;
                    }
                }

                // Habilitar y deshabilitar botones según el usuario
                botonesYPermisos();

                Btn_Ingresar.Enabled = false;
                Btn_Eliminar.Enabled = false;
                Btn_Modificar.Enabled = false;
                Btn_Consultar.Enabled = false;
                Btn_Refrescar.Enabled = false;
            }
            catch (Exception ex)
            {
                // Manejo de errores y mostrar un mensaje más profesional
                MessageBox.Show(
                    "Ocurrió un error durante la modificación del registro.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error en la Modificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error // Icono de error para hacer el mensaje más claro
                );
            }
        }



        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                sn.insertarBitacora(idUsuario, "Se presiono el boton cancelar en " + tabla, tabla);
                // Mostrar un mensaje de confirmación antes de cancelar la operación actual
                DialogResult result = MessageBox.Show(
                    "Está a punto de cancelar los cambios no guardados.\n\n" +
                    "Cualquier dato ingresado se perderá.\n\n" +
                    "¿Desea realmente cancelar la operación?",
                    "Confirmación de Cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, // Icono de advertencia
                    MessageBoxDefaultButton.Button2 // Opción "No" predeterminada
                );

                // Si el usuario selecciona "No", se cancela la operación de cancelación
                if (result == DialogResult.No)
                {
                    return;
                }

                // Reestablecer botones y deshabilitar el que no se necesita
                Btn_Modificar.Enabled = true;
                Btn_Guardar.Enabled = false;
                Btn_Cancelar.Enabled = false;
                Btn_Ingresar.Enabled = true;
                Btn_Eliminar.Enabled = true;
                Btn_Refrescar.Enabled = true;

                // Actualizar el DataGridView y los controles a su estado original
                actualizardatagriew();
                if (logic.TestRegistros(tabla) > 0)
                {
                    int i = 0;
                    int numCombo = 0;
                    foreach (Control componente in Controls)
                    {
                        if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                        {
                            if (componente is ComboBox)
                            {
                                if (modoCampoCombo[numCombo] == 1)
                                {
                                    componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());
                                }
                                else
                                {
                                    componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                                }
                                numCombo++;
                            }
                            else
                            {
                                componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                            }
                            componente.Enabled = false;
                            i++;
                        }
                        if (componente is Button)
                        {
                            string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                            if (var1 == "0")
                            {
                                componente.Text = "Desactivado";
                                componente.BackColor = Color.Red;
                            }
                            if (var1 == "1")
                            {
                                componente.Text = "Activado";
                                componente.BackColor = Color.Green;
                            }
                            componente.Enabled = false;
                        }
                    }
                }

                // Habilitar/deshabilitar según los permisos del usuario
                botonesYPermisos();
            }
            catch (Exception ex)
            {
                // Manejo de errores con un mensaje más profesional
                MessageBox.Show(
                    "Ocurrió un error durante el proceso de cancelación.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error en Cancelación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error // Icono de error
                );
            }
        }


        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!presionado)
                {
                    // Habilitar y deshabilitar botones según el estado de eliminación
                    Btn_Guardar.Enabled = false;
                    Btn_Modificar.Enabled = false;
                    Btn_Eliminar.Enabled = true;
                    Btn_Cancelar.Enabled = true;
                    Btn_Ingresar.Enabled = false;
                    presionado = true;
                }
                else
                {
                    // Mostrar un mensaje de confirmación antes de proceder con la eliminación
                    DialogResult respuestaEliminar = MessageBox.Show(
                        "Está a punto de eliminar permanentemente este registro del sistema.\n\n" +
                        "Esta operación no se puede deshacer. ¿Está seguro de que desea continuar?",
                        "Confirmación de Eliminación - " + nomForm,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2 // Opción "No" predeterminada
                    );

                    if (respuestaEliminar == DialogResult.Yes)
                    {
                        // Proceder con la eliminación
                        logic.nuevoQuery(crearDelete());
                        actualizardatagriew();

                        // Mostrar un mensaje de éxito tras la eliminación
                        MessageBox.Show(
                            "El registro ha sido eliminado correctamente.",
                            "Eliminación Exitosa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information

                        );

                        // Restablecer el estado de los botones
                        Btn_Modificar.Enabled = true;
                        Btn_Guardar.Enabled = false;
                        Btn_Cancelar.Enabled = false;
                        Btn_Eliminar.Enabled = true;
                        Btn_Ingresar.Enabled = true;
                        presionado = false;
                    }
                    else if (respuestaEliminar == DialogResult.No)
                    {
                        // Si el usuario cancela la operación de eliminación
                        MessageBox.Show(
                            "La eliminación ha sido cancelada.",
                            "Operación Cancelada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        // Mantener el estado de los botones
                        Btn_Guardar.Enabled = false;
                        Btn_Modificar.Enabled = false;
                        Btn_Eliminar.Enabled = true;
                        Btn_Cancelar.Enabled = true;
                        Btn_Ingresar.Enabled = false;
                        presionado = true;
                    }
                }

                // Habilitar/deshabilitar botones según los permisos del usuario
                botonesYPermisos();
                presionado = true;
                sn.insertarBitacora(idUsuario, "Se actualizo el estado en " + tabla, tabla);
            }
            catch (Exception ex)
            {
                // Manejo de errores con un mensaje más profesional
                MessageBox.Show(
                    "Ocurrió un error durante el proceso de eliminación del registro.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error en la Eliminación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /*
                private void Btn_Consultar_Click(object sender, EventArgs e)
                {
                    //DLL DE CONSULTAS
                    sentencia con = new sentencia();
                    bool per1 = con.consultarPermisos(idUsuario, idAplicacion, 1);
                    bool per2 = con.consultarPermisos(idUsuario, idAplicacion, 2);
                    bool per3 = con.consultarPermisos(idUsuario, idAplicacion, 3);
                    bool per4 = con.consultarPermisos(idUsuario, idAplicacion, 4);
                    bool per5 = con.consultarPermisos(idUsuario, idAplicacion, 5);

                    if (per1==true && per2 == true && per3 == true && per4 == true && per5 == true)
                    {
                        Compleja nuevo = new Compleja(idUsuario);
                        nuevo.Show();
                    }
                    else
                    {
                         Simple nueva = new Simple(idUsuario);
                        nueva.Show();
                    }

                    //habilitar y deshabilitar según Usuario
                    botonesYPermisos();
                }
        */
        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
			//DLL DE IMPRESION, FORATO DE REPORTES.
			string llave = "";
			if (idRepo!="")
			{
				llave= logic.ObtenerIdReporte(idRepo);
				
			}
			else
			{
				MessageBox.Show("No se asigno ningun reporte....");
			}
			
			if (llave!="")
			{
				Clientes cl = new Clientes(llave);
				cl.Show();
			}
			else
			{
				MessageBox.Show("El Id Asignado es incorrecto");
			}
			
            //habilitar y deshabilitar según Usuario
            botonesYPermisos();
        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            try
            {
                // Refrescar la DataGridView y actualizar los controles
                actualizardatagriew();

                // Iterar sobre los controles y actualizar sus valores con los datos del DataGridView
                int i = 0;
                int numCombo = 0;
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            if (modoCampoCombo[numCombo] == 1)
                            {
                                componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());
                            }
                            else
                            {
                                componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                            }
                            numCombo++;
                        }
                        else
                        {
                            componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                        }

                        i++;
                    }
                    if (componente is Button)
                    {
                        string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                        if (var1 == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (var1 == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;
                    }
                }

                // Habilitar y deshabilitar botones según permisos del usuario
                botonesYPermisos();

                // Mostrar mensaje de éxito al refrescar los datos
                MessageBox.Show(
                    "Los datos han sido actualizados correctamente.",
                    "Refrescado Exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                // Manejo de errores y mostrar un mensaje más profesional
                MessageBox.Show(
                    "Ocurrió un error al refrescar los datos.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error al Refrescar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }



        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] Campos = logic.campos(tabla);

            int fila = dataGridView1.SelectedRows[0].Index;
            if (fila > 0)
            {
                dataGridView1.Rows[fila - 1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[fila - 1].Cells[0];

				int numCombo = 0;
				foreach (Control componente in Controls)
				{
					if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
					{
						if (componente is ComboBox)
						{
							if (modoCampoCombo[numCombo] == 1)
							{
								componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());

							}
							else
							{
								componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
							}

							numCombo++;
						}
						else
						{
							componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
						}

						i++;
					}
					if (componente is Button)
					{
						string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
						if (var1 == "0")
						{
							componente.Text = "Desactivado";
							componente.BackColor = Color.Red;
						}
						if (var1 == "1")
						{
							componente.Text = "Activado";
							componente.BackColor = Color.Green;
						}
						componente.Enabled = false;

					}
				}
			}            
        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            int i = 0;
                string[] Campos = logic.campos(tabla);

                int fila = dataGridView1.SelectedRows[0].Index;
                if (fila < dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.Rows[fila + 1].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[fila + 1].Cells[0];

				int numCombo = 0;
				foreach (Control componente in Controls)
				{
					if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
					{
						if (componente is ComboBox)
						{
							if (modoCampoCombo[numCombo] == 1)
							{
								componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());

							}
							else
							{
								componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
							}

							numCombo++;
						}
						else
						{
							componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
						}

						i++;
					}
					if (componente is Button)
					{
						string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
						if (var1 == "0")
						{
							componente.Text = "Desactivado";
							componente.BackColor = Color.Red;
						}
						if (var1 == "1")
						{
							componente.Text = "Activado";
							componente.BackColor = Color.Green;
						}
						componente.Enabled = false;

					}
				}

			}
        }

        private void Btn_FlechaFin_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0];

            int i = 0;
            string[] Campos = logic.campos(tabla);

            int fila = dataGridView1.SelectedRows[0].Index;
            if (fila < dataGridView1.Rows.Count - 1)
            {
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0];

				int numCombo = 0;
				foreach (Control componente in Controls)
				{
					if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
					{
						if (componente is ComboBox)
						{
							if (modoCampoCombo[numCombo] == 1)
							{
								componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());

							}
							else
							{
								componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
							}

							numCombo++;
						}
						else
						{
							componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
						}

						i++;
					}
					if (componente is Button)
					{
						string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
						if (var1 == "0")
						{
							componente.Text = "Desactivado";
							componente.BackColor = Color.Red;
						}
						if (var1 == "1")
						{
							componente.Text = "Activado";
							componente.BackColor = Color.Green;
						}
						componente.Enabled = false;

					}
				}

			}
        }

        private void Btn_FlechaInicio_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];

            int i = 0;
            string[] Campos = logic.campos(tabla);

            int fila = dataGridView1.SelectedRows[0].Index;
            if (fila < dataGridView1.Rows.Count - 1)
            {
                dataGridView1.Rows[0].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];


				int numCombo = 0;
				foreach (Control componente in Controls)
				{
					if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
					{
						if (componente is ComboBox)
						{
							if (modoCampoCombo[numCombo] == 1)
							{
								componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());

							}
							else
							{
								componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
							}

							numCombo++;
						}
						else
						{
							componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
						}

						i++;
					}
					if (componente is Button)
					{
						string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
						if (var1 == "0")
						{
							componente.Text = "Desactivado";
							componente.BackColor = Color.Red;
						}
						if (var1 == "1")
						{
							componente.Text = "Activado";
							componente.BackColor = Color.Green;
						}
						componente.Enabled = false;

					}
				}


			}

        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {                    
            Help.ShowHelp(this, AsRuta, AsIndice);//Abre el menu de ayuda HTML            
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                // Opción cuando se está guardando y se quiere salir sin finalizar
                if (Btn_Guardar.Enabled == true && Btn_Cancelar.Enabled == true && Btn_Eliminar.Enabled == false && Btn_Modificar.Enabled == false && Btn_Ingresar.Enabled == false)
                {
                    foreach (Control componente in Controls)
                    {
                        if (componente.Text != "" && componente is TextBox)
                        {
                            // Mostrar un mensaje si el usuario intenta salir sin guardar
                            DialogResult respuestaGuardar = MessageBox.Show(
                                "Se ha detectado una operación de guardado en curso.\n\n" +
                                "¿Desea guardar los cambios antes de salir?",
                                "Confirmación de Salida - " + nomForm,
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Warning
                            );

                            if (respuestaGuardar == DialogResult.Yes)
                            {
                                guardadoforsozo();
                                cerrar.Visible = false; // Cierra el formulario después de guardar
                            }
                            else if (respuestaGuardar == DialogResult.No)
                            {
                                cerrar.Visible = false; // Cierra el formulario sin guardar
                            }
                            else if (respuestaGuardar == DialogResult.Cancel)
                            {
                                return; // Cancela la salida y permanece en el formulario
                            }
                        }
                    }
                }

                // Opción cuando se está modificando y se quiere salir sin finalizar
                if (Btn_Modificar.Enabled == true && Btn_Guardar.Enabled == true && Btn_Cancelar.Enabled == true && Btn_Ingresar.Enabled == false)
                {
                    foreach (Control componente in Controls)
                    {
                        if (componente.Text != "" && componente is TextBox)
                        {
                            DialogResult respuestaModificar = MessageBox.Show(
                                "Se ha detectado una operación de modificación en curso.\n\n" +
                                "¿Desea regresar y finalizar la operación antes de salir?",
                                "Confirmación de Salida - " + nomForm,
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Warning
                            );

                            if (respuestaModificar == DialogResult.Yes)
                            {
                                return; // El usuario decide regresar al formulario
                            }
                            else if (respuestaModificar == DialogResult.No)
                            {
                                cerrar.Visible = false; // Cierra el formulario sin finalizar la modificación
                            }
                            else if (respuestaModificar == DialogResult.Cancel)
                            {
                                return; // Cancela la salida y permanece en el formulario
                            }
                        }
                    }
                }

                // Opción cuando se está eliminando y se quiere salir sin finalizar
                if (Btn_Eliminar.Enabled == true && Btn_Cancelar.Enabled == true && Btn_Modificar.Enabled == false && Btn_Guardar.Enabled == false && Btn_Ingresar.Enabled == false)
                {
                    foreach (Control componente in Controls)
                    {
                        if (componente.Text != "" && componente is TextBox)
                        {
                            DialogResult respuestaEliminar = MessageBox.Show(
                                "Se ha detectado una operación de eliminación en curso.\n\n" +
                                "¿Desea regresar y finalizar la operación antes de salir?",
                                "Confirmación de Salida - " + nomForm,
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Warning
                            );

                            if (respuestaEliminar == DialogResult.Yes)
                            {
                                return; // El usuario decide regresar al formulario
                            }
                            else if (respuestaEliminar == DialogResult.No)
                            {
                                cerrar.Visible = false; // Cierra el formulario sin finalizar la eliminación
                            }
                            else if (respuestaEliminar == DialogResult.Cancel)
                            {
                                return; // Cancela la salida y permanece en el formulario
                            }
                        }
                    }
                }

                // Confirmación final antes de cerrar el formulario si no hay operaciones pendientes
                DialogResult confirmacionFinal = MessageBox.Show(
                    "¿Está seguro de que desea salir del formulario?",
                    "Confirmación de Salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacionFinal == DialogResult.Yes)
                {
                    cerrar.Visible = false; // Cierra el formulario si el usuario confirma la salida
                }
                else
                {
                    return; // El usuario decide quedarse en el formulario
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores con un mensaje profesional
                MessageBox.Show(
                    "Ocurrió un error al intentar salir del formulario.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error al Salir",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }



        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar un mensaje de confirmación antes de proceder con la operación
                DialogResult result = MessageBox.Show(
                    "Está a punto de guardar un nuevo registro en el sistema.\n\n" +
                    "Asegúrese de que toda la información ingresada sea correcta.\n\n" +
                    "¿Desea continuar con el guardado?",
                    "Confirmación de Guardado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Si el usuario selecciona "No", se cancela la operación
                if (result == DialogResult.No)
                {
                    return;
                }

                bool lleno = true;

                // Verificar si todos los controles tienen valores
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (string.IsNullOrEmpty(componente.Text))
                        {
                            lleno = false;
                            break;
                        }
                    }
                }

                if (lleno)
                {
                    switch (activar)
                    {
                        case 1:
                            // Si está en modo de actualización
                            logic.nuevoQuery(crearUpdate());
                            MessageBox.Show(
                                "El registro ha sido actualizado correctamente.",
                                "Actualización Exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information

                            );
                            sn.insertarBitacora(idUsuario, "Actualizo un registro en " + tabla, tabla);
                            break;

                        case 2:
                            // Crear query para la primera tabla
                         
                                string queryPrimeraTabla = crearInsert(tabla);
                            
                            // Iniciar la lista de queries para la transacción
                            List<string> queries = new List<string>();
                           logic.nuevoQuery(queryPrimeraTabla);
                            sn.insertarBitacora(idUsuario, "Se inserto en " + tabla, tabla);
                            string ultimoIdPrimeraTabla = logic.lastID(tabla);
                            Console.WriteLine(ultimoIdPrimeraTabla);
                            if (!string.IsNullOrEmpty(otratabla))
                            {
                                // Obtener las columnas de la segunda tabla
                                List<(string nombreColumna, bool esAutoIncremental, bool esClaveForanea)> columnasSegundaTabla = logic.obtenerColumnasYPropiedadesLogica(otratabla);


                                // Crear los valores para la segunda tabla
                                List<string> valoresSegundaTabla = new List<string>();
                                int pos = 1;

                                foreach (var columna in columnasSegundaTabla)
                                {
                                    string valorCampo;
                                    if (columna.esAutoIncremental)
                                    {
                                        continue;
                                    }
                                    if (columna.esClaveForanea)
                                    {
                                        // Usar el ID de la tabla relacionada
                                         valorCampo = ultimoIdPrimeraTabla.ToString();  // Asignar el último ID insertado
                                    }
                                    else
                                    {
                                        // Usar el valor obtenido del control
                                         valorCampo = obtenerDatoCampos(pos);  // Obtener el valor del control correspondiente
                                    }

                                    // Si es la clave foránea, usar el último ID insertado
                                    valoresSegundaTabla.Add($"'{valorCampo}'");
                                    pos++;
                                }

                                // Crear el query de inserción para la segunda tabla
                                string camposQuery = string.Join(", ", columnasSegundaTabla.Where(c => !c.esAutoIncremental).Select(c => c.nombreColumna));
                                string valoresQuery = string.Join(", ", valoresSegundaTabla);
                                string querySegundaTabla = $"INSERT INTO {otratabla} ({camposQuery}) VALUES ({valoresQuery});";

                                // Añadir a la lista de queries
                                queries.Add(querySegundaTabla);

                                // Ejecutar las queries dentro de una transacción
                                logic.insertarDatosEnDosTablas(queries);

                                sn.insertarBitacora(idUsuario, "Se inserto en " + otratabla, otratabla);
                            }

                            MessageBox.Show("El registro ha sido guardado correctamente.", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            break;

                        default:
                            MessageBox.Show("Opción no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                    // Actualizar DataGridView después de la inserción
                    actualizardatagriew();

                    // Cargar los datos en los controles si hay registros en la tabla
                    if (logic.TestRegistros(tabla) > 0)
                    {
                        int i = 0;
                        foreach (Control componente in Controls)
                        {
                            if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                            {
                                componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                                componente.Enabled = false;
                                i++;
                            }
                        }
                    }

                    // Deshabilitar campos y botones
                    deshabilitarcampos_y_botones();

                    // Habilitar/deshabilitar botones según sea necesario
                    Btn_Guardar.Enabled = false;
                    Btn_Eliminar.Enabled = true;
                    Btn_Cancelar.Enabled = false;
                    Btn_Modificar.Enabled = true;
                    Btn_Ingresar.Enabled = true;
                    Btn_Refrescar.Enabled = true;

                    // Configurar permisos según el usuario
                    botonesYPermisos();
                }
                else
                {
                    MessageBox.Show(
                        "Por favor, complete todos los campos antes de guardar.\n\n" +
                        "El registro no se puede guardar mientras existan campos vacíos.",
                        "Campos Vacíos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores y mostrar un mensaje más profesional
                MessageBox.Show(
                    "Ocurrió un error durante el guardado del registro.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error en el Guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Aquí está la función crearInsertFactura
       

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                    i++;
                }
                if (componente is Button)
                {
                    string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                    if (var1 == "0")
                    {
                        componente.Text = "Desactivado";
                        componente.BackColor = Color.Red;
                    }
                    if (var1 == "1")
                    {
                        componente.Text = "Activado";
                        componente.BackColor = Color.Green;
                    }
                }

            }
        }

        private void Contenido_Click(object sender, EventArgs e)
        {

        }

         /*
                try
                {
                    sentencia sen = new sentencia();                                        
                    if (sen.consultarPermisos(idUsuario, idAplicacion, 1) == true)
                    {
                        Btn_Ingresar.Enabled = true;
                    }
                    else
                    {
                        Btn_Ingresar.Enabled = false;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error en el Void Registros. Favor llamar Administrador. Error: " + ex);
                } 
            if (logic.TestRegistros(tabla)<=0)
            {                
                Btn_Anterior.Enabled = false;
                Btn_Siguiente.Enabled = false;
                Btn_FlechaInicio.Enabled = false;
                Btn_FlechaFin.Enabled = false;
                Btn_Ingresar.Enabled = false;
                Btn_Modificar.Enabled = false;
                Btn_Eliminar.Enabled = false; 
            }
            else
            {
                Btn_Anterior.Enabled = true;
                Btn_Siguiente.Enabled = true;
                Btn_FlechaInicio.Enabled = true;
                Btn_FlechaFin.Enabled = true;
                Btn_Modificar.Enabled = true;
                Btn_Eliminar.Enabled = true;                
            } */

        public void botonesYPermisos()
        {
            try
            {
                if (logic.TestRegistros(tabla) <= 0)
                {                    
                    Btn_Ingresar.Enabled = false;
                    Btn_Modificar.Enabled = false;
                    Btn_Guardar.Enabled = false;
                    Btn_Cancelar.Enabled = false;
                    Btn_Eliminar.Enabled = false;
                    Btn_Consultar.Enabled = false;
                  
                    Btn_Refrescar.Enabled = false;
                    Btn_FlechaInicio.Enabled = false;
                    Btn_Anterior.Enabled = false;
                    Btn_Siguiente.Enabled = false;                    
                    Btn_FlechaFin.Enabled = false;
                    MessageBox.Show("Tabla Vacía! Debe ingresa registros!");
                    try
                    {
                       // sentencia sent = new sentencia();
                        /*if (sent.consultarPermisos(idUsuario, idAplicacion, 1) == true)
                        {
                            MessageBox.Show("Si tiene permisos para ingresar");
                            Btn_Ingresar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("NO tiene permisos paraINGRESAR");
                        }*/
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show("Estamos en Tabla Vacía! Determinanos si el usuario Activo puede ingresar! ERROR: " + exx);
                    }
                }
                else
                {
                    //validamos con TRY CATCH por si llegará a existir un problema 
                   /* try
                    {
                        //sentencia sen = new sentencia();
                        string[] permisosText = { "INGRESAR", "CONSULTAR", "MODIFICAR", "ELIMINAR", "IMPRIMIR" };
                        for (int i = 1; i < 6; i++)
                        {
                            if (sen.consultarPermisos(idUsuario, idAplicacion, i) == true)
                            {
                                //mostramos un mensaje para indicar que si tiene permiso
                                //MessageBox.Show("Tiene permiso para " + permisosText[i - 1]);
                                //bloqueamos botones
                                switch (permisosText[i - 1])
                                {
                                    case "INGRESAR":
                                        Btn_Ingresar.Enabled = true; break;
                                    case "CONSULTAR":
                                        Btn_Consultar.Enabled = true; break;
                                    case "MODIFICAR":
                                        Btn_Modificar.Enabled = true; break;
                                    case "ELIMINAR":
                                        Btn_Eliminar.Enabled = true; break;
                                    case "IMPRIMIR":
                                     break;
                                    default:
                                        MessageBox.Show("Entro al case default! TIENE PERMISO! Por favor hablar con Administrador!"); break;
                                }
                            }
                            else
                            {
                                //MessageBox.Show("No tiene permiso para " + permisosText[i - 1]);
                                switch (permisosText[i - 1])
                                {
                                    case "INGRESAR":
                                        Btn_Ingresar.Enabled = false; break;
                                    case "CONSULTAR":
                                        Btn_Consultar.Enabled = false; break;
                                    case "MODIFICAR":
                                        Btn_Modificar.Enabled = false; break;
                                    case "ELIMINAR":
                                        Btn_Eliminar.Enabled = false; break;
                                    case "IMPRIMIR":
                                        break;
                                    default:
                                        MessageBox.Show("Entro al case default! NO TIENE PERMISO! Por favor hablar con Administrador!"); break;
                                }
                            }
                            // 1 ingresar - 2 consultar - 3 modificar - 4 eliminar - 5 imprimir 
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Surgió el siguiente problema: " + ex);
                    }*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error General en Botones y Permisos. ERROR: " + ex);
            }
        }

        public void botonesYPermisosInicial(string userActivo, string appActivo)
        {
            try
            {
                if (logic.TestRegistros(tabla) <= 0)
                {
                    Btn_Ingresar.Enabled = false;
                    Btn_Modificar.Enabled = false;
                    Btn_Guardar.Enabled = false;
                    Btn_Cancelar.Enabled = false;
                    Btn_Eliminar.Enabled = false;
                    Btn_Consultar.Enabled = false;
                
                    Btn_Refrescar.Enabled = false;
                    Btn_FlechaInicio.Enabled = false;
                    Btn_Anterior.Enabled = false;
                    Btn_Siguiente.Enabled = false;
                    Btn_FlechaFin.Enabled = false;
                    MessageBox.Show("Tabla Vacía! Debe ingresar un registro!");
                   /* try
                    {
                        sentencia sent = new sentencia();
                        if (sent.consultarPermisos(userActivo, appActivo, 1) == true)
                        {
                            MessageBox.Show("Tabla Vacía! SI puede INGRESAR");
                            Btn_Ingresar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Tabla Vacía! NO puede INGRESAR");
                        }
                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show("Estamos en Tabla Vacía! Determinanos si el usuario Activo puede ingresar! ERROR: " + exx);
                    }*/
                }
                else
                {
                    //validamos con TRY CATCH por si llegará a existir un problema 
                    try
                    {
                        //sentencia sen = new sentencia();
                        string[] permisosText = { "INGRESAR", "CONSULTAR", "MODIFICAR", "ELIMINAR", "IMPRIMIR" };
                        for (int i = 1; i < 6; i++)
                        {
                           /* if (sen.consultarPermisos(userActivo, appActivo, i) == true)
                            {
                                //mostramos un mensaje para indicar que si tiene permiso
                                //MessageBox.Show("Tiene permiso para " + permisosText[i - 1]);
                                //bloqueamos botones
                                switch (permisosText[i - 1])
                                {
                                    case "INGRESAR":
                                        Btn_Ingresar.Enabled = true; break;
                                    case "CONSULTAR":
                                        Btn_Consultar.Enabled = true; break;
                                    case "MODIFICAR":
                                        Btn_Modificar.Enabled = true; break;
                                    case "ELIMINAR":
                                        Btn_Eliminar.Enabled = true; break;
                                    case "IMPRIMIR":
                                        break;
                                    default:
                                        MessageBox.Show("Entro al case default! TIENE PERMISO! Por favor hablar con Administrador!"); break;
                                }
                            }
                            else
                            {
                                //MessageBox.Show("No tiene permiso para " + permisosText[i - 1]);
                                switch (permisosText[i - 1])
                                {
                                    case "INGRESAR":
                                        Btn_Ingresar.Enabled = false; break;
                                    case "CONSULTAR":
                                        Btn_Consultar.Enabled = false; break;
                                    case "MODIFICAR":
                                        Btn_Modificar.Enabled = false; break;
                                    case "ELIMINAR":
                                        Btn_Eliminar.Enabled = false; break;
                                    case "IMPRIMIR":
                                        break;
                                    default:
                                        MessageBox.Show("Entro al case default! NO TIENE PERMISO! Por favor hablar con Administrador!"); break;
                                }
                            }
                            // 1 ingresar - 2 consultar - 3 modificar - 4 eliminar - 5 imprimir 
                           */
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Surgió el siguiente problema: " + ex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error General en Botones y Permisos Inicial. ERROR: " + ex);
            }

        }

        private void Btn_Ayuda_Click_1(object sender, EventArgs e)
        {
            // Construir la ruta completa manualmente
            string helpFilePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\AyudaHTML\AyudaNavegador.chm";

            // Normaliza la ruta para obtener la absoluta correctamente
            helpFilePath = System.IO.Path.GetFullPath(helpFilePath);

            // Verifica si el archivo existe antes de intentar abrirlo
            if (System.IO.File.Exists(helpFilePath))
            {
                Help.ShowHelp(this, helpFilePath, "AyudaNav.html");
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de ayuda: " + helpFilePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void Btn_MasAyuda_Click(object sender, EventArgs e)
        {
            string AyudaOK = logic.TestTabla("ayuda");
            if (AyudaOK == "")
            {
                Ayudas nuevo = new Ayudas();
                nuevo.Show();
            }
            else
            {
                DialogResult validacion = MessageBox.Show(AyudaOK +" \n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                if (validacion == DialogResult.OK)
                {
                    
                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LblTabla_Click(object sender, EventArgs e)
        {

        }

        private void xd_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, AsRuta, AsIndice); Abre el menu de ayuda HTML     
            Help.ShowHelp(this, "/AyudaHTML/AyudaNavegador.chm", "AyudaNav.html");//Abre el menu de ayuda HTML 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_Imprimir_Click_1(object sender, EventArgs e)
        {
            //aca va el paso al formalrio de reporteria
            //añadan su capa vista y hagan el paso
        }
    }
}
