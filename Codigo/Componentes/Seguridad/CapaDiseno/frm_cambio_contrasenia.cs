using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaDiseno
{
    // Código realizado por Brandon Boch - 0901-21-13093///////////////////////////////////////////////////////
    public partial class frm_cambio_contrasenia : Form
    {
        public string Resultado { get; private set; }
        public frm_cambio_contrasenia(string pregunta)
        {
            InitializeComponent();
            Lbl_color.Text = pregunta;
        }

        private void Btn_verificar_Click(object sender, EventArgs e)
        {
            ProcedimientoLogin_grupo5 cambioContrasenia = new ProcedimientoLogin_grupo5();


            if (Txt_pregunta.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un usuario");
            }
            else
            {
                if (Txt_color.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar su color favorito");
                }
                else
                {
                    try
                    {
                        bool bExisteUsuario = cambioContrasenia.cambioContrasenia(Txt_pregunta.Text, Txt_color.Text);
                        if (bExisteUsuario)
                        {

                            Lbl_contrasenia.Visible = true;
                            Lbl_confirmacion.Visible = true;
                            Txt_contrasenia.Visible = true;
                            Txt_confirmacion.Visible = true;
                            Btn_confirmar.Visible = true;

                        }
                        else
                        {
                            MessageBox.Show("Usuario o respuesta incorrecta", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        MessageBox.Show("No Conecto La Base de Datos", "Verificar Conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }          
        }

        private void frm_cambio_contrasenia_Load(object sender, EventArgs e)
        {

            Txt_pregunta.Height = 40; // Establece el ancho del TextBox
            Txt_pregunta.Width = 200; // Establece el ancho del TextBox
            Txt_color.Height = 40; // Establece el ancho del TextBox
            Txt_color.Width = 200;

            Lbl_contrasenia.Visible = false;
            Lbl_confirmacion.Visible = false;
            Txt_contrasenia.Visible = false;
            Txt_confirmacion.Visible = false;
            Btn_confirmar.Visible = false;

            Txt_pregunta.TabIndex = 0;
            Txt_color.TabIndex = 1;
            Btn_verificar.TabIndex = 2;
            Txt_contrasenia.TabIndex = 3;
            Txt_confirmacion.TabIndex = 4;
            Btn_confirmar.TabIndex = 5;
        }

        private void Btn_confirmar_Click(object sender, EventArgs e)
        {
            ProcedimientoLogin_grupo5 cambiarContrasenia = new ProcedimientoLogin_grupo5();

            if (Txt_contrasenia.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una contraseña");
            }
            else if (Txt_confirmacion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la confirmación");
            }
            else if (Txt_contrasenia.Text.Trim() != Txt_confirmacion.Text.Trim())
            {
                MessageBox.Show("Las contraseñas no coinciden", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    bool bCambioExitoso = cambiarContrasenia.cambiarContrasenia(Txt_pregunta.Text, Txt_confirmacion.Text);
                    if (bCambioExitoso)
                    {
                        MessageBox.Show("Se cambió la contraseña exitosamente", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cambiar la contraseña", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}/////////////////////////////////////////////////////////////////////////////////////////////////////////////
