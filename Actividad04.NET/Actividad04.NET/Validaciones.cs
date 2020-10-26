using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Actividad04.NET
{
    public class Validaciones
    {
        public bool validacionVacio (TextBox textBox, ErrorProvider errorProvider)
        {
            bool vacio = false;
            if(string.IsNullOrWhiteSpace(textBox.Text) == true)
            {
                errorProvider.Clear();
                errorProvider.SetError(textBox,"Debe ingresar datos en este campo");
                vacio = true;
            }
            return vacio;
        }

        public bool ValidarTipo( TextBox textBox, ErrorProvider errorProvider, string TipoDato)
        {
            bool errado = false;
            Regex formatoNumero = new Regex("[0-9]{1,9}(\\.[0-9]{0,2})?$");
            Regex formatoLetra = new Regex("^[a-zA-Z+ñ ]*$");
            Regex formatoCorreo = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");

            if (validacionVacio(textBox, errorProvider) == true)
            {
                return true;
            }
            else
            {
                switch (TipoDato)
                {
                    case "num":
                        if (formatoNumero.IsMatch(textBox.Text) == false)
                        {
                            errorProvider.Clear();
                            errorProvider.SetError(textBox, "Solo puede ingresar números en este campo");
                            errado = true;
                        }
                        else
                            errorProvider.Clear();
                        break;

                    case "let":
                        if (formatoLetra.IsMatch(textBox.Text) == false)
                        {
                            errorProvider.Clear();
                            errorProvider.SetError(textBox, "Solo puede ingresar letras en este campo");
                            errado = true;
                        }
                        else if((textBox.Text).Count(char.IsWhiteSpace) < 2 || (textBox.Text).Substring((textBox.Text).Length - 1, 1) == " ")
                        {
                            errorProvider.Clear();
                            errorProvider.SetError(textBox, "Debe ingresar el nombre completo");
                            errado = true;
                        }
                        else
                            errorProvider.Clear();
                        break;

                    case "cor":
                        if (formatoCorreo.IsMatch(textBox.Text) == false)
                        {
                            errorProvider.Clear();
                            errorProvider.SetError(textBox, "Correo con formato incorrecto");
                            errado = true;
                        }
                        else
                            errorProvider.Clear();
                        break;
                }
                return errado;
            }
        }
    }
}
