using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BibliotecaCLases
{
    public class Validacion
    {
        /// <summary>
        /// corrobora si es un correo valido
        /// </summary>
        /// <param name="correo"></param>
        /// <returns>bool</returns>
        public static bool EsCorreoValido(String correo)
        {
            if (string.IsNullOrEmpty(correo))
            {
                return false;
            }
            string patronCorreo = @"^[\w\.-]+@[\w\.-]+\.\w+$";
            Regex regex = new Regex(patronCorreo);

            return regex.IsMatch(correo);

        }
        /// <summary>
        /// corrobora si es una nombre valido con un max de 10 caracteres
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>bool</returns>
        public static bool EsNombreValido(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                return false;
            }
            string patronNombre = @"^[A-Za-z\s]{1,10}$";
            Regex regex = new Regex(patronNombre);

            return regex.IsMatch(nombre);
        }



        public bool ValidarString(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
 
        }
        public bool ValidarDigit(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
