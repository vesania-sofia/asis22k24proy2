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
        // Caracteres especiales utilizados en las validaciones
        char coma = (char)44;
        char guion = (char)45;
        char guionb = (char)95;
        char punto = (char)46;
        char bs = (char)8;
        char dosp = (char)58;
        int contador;
        int contadordp = 0;

        //******************************************** CODIGO HECHO POR JOEL LOPEZ *****************************
        /// <summary>
        /// Valida que solo se ingresen números en un campo.
        /// </summary>
        /// <param name="e">Evento de KeyPress</param>
        public void CamposNumericos(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar)) // Permite números
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar)) // Permite teclas de control (backspace, delete, etc.)
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar)) // No permite separadores (espacios)
                {
                    e.Handled = true;
                }
                else if (char.IsPunctuation(e.KeyChar)) // No permite signos de puntuación
                {
                    e.Handled = true;
                }
                else // No permite ningún otro tipo de carácter
                {
                    e.Handled = true;
                }
            }
            catch
            {
                // Manejo de excepciones, se puede implementar un logging o manejo más detallado si es necesario
            }
        }
        //******************************************** CODIGO HECHO POR JOEL LOPEZ ***************************** 


        //******************************************** CODIGO HECHO POR JOSUE CACAO ***************************** 
        /// <summary>
        /// Valida que solo se ingresen números y letras en un campo.
        /// </summary>
        /// <param name="e">Evento de KeyPress</param>
        public void CamposNumerosYLetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar)) // Permite números
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar)) // Permite teclas de control
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar)) // Permite separadores (espacios)
                {
                    e.Handled = false;
                }
                else if (char.IsLetter(e.KeyChar)) // Permite letras
                {
                    e.Handled = false;
                }
                else // No permite ningún otro tipo de carácter
                {
                    e.Handled = true;
                }
            }
            catch
            {
                // Manejo de excepciones, se puede implementar un logging o manejo más detallado si es necesario
            }
        }
        //******************************************** CODIGO HECHO POR JOSUE CACAO ***************************** 


        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS ***************************** 


        //******************************************** CODIGO HECHO POR EMANUEL BARAHONA ***************************** 
        /// <summary>
        /// Valida la entrada en un ComboBox, permitiendo solo ciertos caracteres.
        /// </summary>
        /// <param name="e">Evento de KeyPress</param>
        public void Combobox(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar)) // No permite números
                {
                    e.Handled = true;
                }
                else if (char.IsControl(e.KeyChar)) // Permite teclas de control
                {
                    e.Handled = false;
                }
                else if (char.IsLetter(e.KeyChar)) // No permite letras
                {
                    e.Handled = true;
                }
                else if (char.IsSeparator(e.KeyChar)) // No permite separadores (espacios)
                {
                    e.Handled = true;
                }
                else if (char.IsPunctuation(e.KeyChar)) // No permite signos de puntuación
                {
                    e.Handled = true;
                }
                else // No permite ningún otro tipo de carácter
                {
                    e.Handled = true;
                }
            }
            catch
            {
                // Manejo de excepciones, se puede implementar un logging o manejo más detallado si es necesario
            }
        }
        //******************************************** CODIGO HECHO POR EMANUEL BARAHONA ***************************** 


        //******************************************** CODIGO HECHO POR ANIKA ESCOTO ***************************** 
        /// <summary>
        /// Valida que solo se ingresen letras en un campo.
        /// </summary>
        /// <param name="e">Evento de KeyPress</param>
        public void CamposVchar(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar)) // Permite letras
                {
                    e.Handled = false;
                }
            }
            catch
            {
                // Manejo de excepciones, se puede implementar un logging o manejo más detallado si es necesario
            }
        }

        /// <summary>
        /// Valida que solo se ingresen letras y algunos caracteres especiales en un campo de texto.
        /// </summary>
        /// <param name="e">Evento de KeyPress</param>
        public void CamposLetrasTexto(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar)) // Permite letras
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar)) // Permite teclas de control
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar)) // Permite separadores (espacios)
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == guionb || e.KeyChar == guion || e.KeyChar == punto || e.KeyChar == coma) // Permite ciertos caracteres especiales
                {
                    e.Handled = false;
                }
                else // No permite ningún otro tipo de carácter
                {
                    e.Handled = true;
                }
            }
            catch
            {
                // Manejo de excepciones, se puede implementar un logging o manejo más detallado si es necesario
            }
        }
        //******************************************** CODIGO HECHO POR ANIKA ESCOTO***************************** 


        //******************************************** CODIGO HECHO POR MATY MANCILLA ***************************** 
        /// <summary>
        /// Valida que solo se ingresen letras en un campo.
        /// </summary>
        /// <param name="e">Evento de KeyPress</param>
        public void CamposLetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar)) // Permite letras
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar)) // Permite teclas de control
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar)) // Permite separadores (espacios)
                {
                    e.Handled = false;
                }
                else // No permite ningún otro tipo de carácter
                {
                    e.Handled = true;
                }
            }
            catch
            {
                // Manejo de excepciones, se puede implementar un logging o manejo más detallado si es necesario
            }
        }
        //******************************************** CODIGO HECHO POR MATY MANCILLA ***************************** 


        //******************************************** CODIGO HECHO POR SEBASTIAN LETONA ***************************** 
        /// <summary>
        /// Valida que solo se ingresen números y un solo punto decimal en un campo.
        /// </summary>
        /// <param name="e">Evento de KeyPress</param>
        public void Camposdecimales(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar)) // Permite números
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == punto) // Permite un solo punto decimal
                {
                    contador++;
                    e.Handled = false;

                    if (contador >= 2) // Si ya hay un punto decimal, no permite otro
                    {
                        e.Handled = true;
                        contador = 2; // Se asegura de que el contador no supere 2
                    }
                }
                else if (e.KeyChar == bs) // Maneja el backspace para ajustar el contador
                {
                    contador = 0; // Resetea el contador al borrar
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar)) // Permite teclas de control
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar)) // No permite separadores (espacios)
                {
                    e.Handled = true;
                }
                else // No permite ningún otro tipo de carácter
                {
                    e.Handled = true;
                }
            }
            catch
            {
                // Manejo de excepciones, se puede implementar un logging o manejo más detallado si es necesario
            }
        }
        //******************************************** CODIGO HECHO POR SEBASTIAN LETONA ***************************** 


        //******************************************** CODIGO HECHO POR JORGE AVILA ***************************** 
        /// <summary>
        /// Valida que solo se ingresen números y un solo carácter de dos puntos (:) en un campo de hora.
        /// </summary>
        /// <param name="e">Evento de KeyPress</param>
        public void CamposHora(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar)) // Permite números
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == dosp) // Permite un solo carácter de dos puntos (:)
                {
                    contadordp++;
                    e.Handled = false;

                    if (contadordp >= 2) // Si ya hay un carácter de dos puntos, no permite otro
                    {
                        e.Handled = true;
                    }
                }
                else if (e.KeyChar == bs) // Maneja el backspace para ajustar el contador
                {
                    contadordp = 0; // Resetea el contador al borrar
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar)) // Permite teclas de control
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar)) // No permite separadores (espacios)
                {
                    e.Handled = true;
                }
                else // No permite ningún otro tipo de carácter
                {
                    e.Handled = true;
                }
            }
            catch
            {
                // Manejo de excepciones, se puede implementar un logging o manejo más detallado si es necesario
            }
        }
        //******************************************** CODIGO HECHO POR JORGE AVILA ***************************** 
    }
}
