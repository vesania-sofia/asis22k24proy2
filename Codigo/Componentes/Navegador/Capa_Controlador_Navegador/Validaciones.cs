using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Controlador_Navegador
{
    public class Validaciones
    {
        char coma = (char)44;
        char guion = (char)45;
        char guionb = (char)95;
        char punto = (char)46;
        char bs = (char)8;
        char dosp = (char)58;
        int contador;
        int contadordp = 0;
        //******************************************** CODIGO HECHO POR JOEL LOPEZ ***************************** 
        public void CamposNumericos(KeyPressEventArgs e)
        {

            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }


        //******************************************** CODIGO HECHO POR JOEL LOPEZ ***************************** 



        //******************************************** CODIGO HECHO POR JOSUE CACAO ***************************** 
        public void CamposNumerosYLetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }


        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS ***************************** 


        //******************************************** CODIGO HECHO POR EMANUEL BARAHONA ***************************** 
        public void Combobox(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        //******************************************** CODIGO HECHO POR EMANUEL BARAHONA ***************************** 


        //******************************************** CODIGO HECHO POR ANIKA ESCOTO ***************************** 
        public void CamposVchar(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
            }
            catch
            {

            }
        }
        public void CamposLetrasTexto(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == guionb)
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == guion)
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == punto)
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == coma)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        //******************************************** CODIGO HECHO POR ANIKA ESCOTO***************************** 


        //******************************************** CODIGO HECHO POR MATY MANCILLA ***************************** 

        public void CamposLetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }

        //******************************************** CODIGO HECHO POR MATY MANCILLA ***************************** 


        //******************************************** CODIGO HECHO POR SEBASTIAN LETONA ***************************** 
        public void Camposdecimales(KeyPressEventArgs e)
        {

            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (e.KeyChar == punto)
                {

                    contador++;
                    e.Handled = false;

                    if (contador >= 2)
                    {

                        e.Handled = true;
                        contador = 2;
                    }

                }
                else if (e.KeyChar == bs)
                {
                    contador = contador - contador;

                    if (contador <= 1)
                    {
                        e.Handled = false;
                    }
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }

                else
                {
                    e.Handled = true;
                }

            }
            catch
            {

            }
        }

        //******************************************** CODIGO HECHO POR SEBASTIAN LETONA ***************************** 


        //******************************************** CODIGO HECHO POR JORGE  AVILA ***************************** 
        public void CamposHora(KeyPressEventArgs e)
        {

            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (e.KeyChar == dosp)
                {

                    contadordp++;
                    e.Handled = false;

                    if (contadordp >= 2)
                    {

                        e.Handled = true;

                    }

                }
                else if (e.KeyChar == bs)
                {
                    contadordp = contadordp - contadordp;

                    if (contadordp <= 1)
                    {
                        e.Handled = false;
                    }
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }

                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }
        //******************************************** CODIGO HECHO POR JORGE AVILA ***************************** 
    }
}
