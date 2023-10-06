using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BibliotecaCLases.Controlador
{
    public class Validacion
    {
        /// <summary>
        /// corrobora si es un correo valido
        /// </summary>
        /// <param name="correo"></param>
        /// <returns>bool</returns>
        public static bool EsCorreoValido(string correo)
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
            if (string.IsNullOrEmpty(nombre))
            {
                return false;
            }
            string patronNombre = @"^[A-Za-z\s]{1,15}$";
            Regex regex = new Regex(patronNombre);

            return regex.IsMatch(nombre);
        }
        public static bool EsApellidoValido(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return false;
            }
            string patronNombre = @"^[A-Za-z\s]{1,10}$";
            Regex regex = new Regex(patronNombre);

            return regex.IsMatch(nombre);
        }



        public static bool ValidarAlphanumeric(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;

        }
        public static bool ValidarDigit(string value)
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
