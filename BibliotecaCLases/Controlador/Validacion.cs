using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BibliotecaCLases.Controlador
{
    /// <summary>
    /// Clase de utilidad para validar diferentes tipos de datos, como correos, nombres, apellidos, etc.
    /// </summary>
    public class Validacion
    {

        /// <summary>
        /// Corrobora si una cadena de texto es un correo electrónico válido.
        /// </summary>
        /// <param name="correo">La cadena que se va a validar como correo electrónico.</param>
        /// <returns>True si es un correo válido, de lo contrario False.</returns>
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
        /// Corrobora si una cadena de texto es un nombre válido con un máximo de 15 caracteres.
        /// </summary>
        /// <param name="nombre">La cadena que se va a validar como nombre.</param>
        /// <returns>True si es un nombre válido, de lo contrario False.</returns>
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

        /// <summary>
        /// Corrobora si una cadena de texto es un apellido válido con un máximo de 10 caracteres.
        /// </summary>
        /// <param name="apellido">La cadena que se va a validar como apellido.</param>
        /// <returns>True si es un apellido válido, de lo contrario False.</returns>
        public static bool EsApellidoValido(string apellido)
        {
            if (string.IsNullOrEmpty(apellido))
            {
                return false;
            }
            string patronNombre = @"^[A-Za-z\s]{1,10}$";
            Regex regex = new Regex(patronNombre);

            return regex.IsMatch(apellido);
        }

        /// <summary>
        /// Corrobora si una cadena de texto contiene solo caracteres alfanuméricos.
        /// </summary>
        /// <param name="valor">La cadena que se va a validar como alfanumérica.</param>
        /// <returns>True si la cadena contiene solo caracteres alfanuméricos, de lo contrario False.</returns>
        public static bool ValidarAlphanumeric(string valor)
        {
            foreach (char c in valor)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;

        }

        /// <summary>
        /// Corrobora si una cadena de texto contiene solo dígitos.
        /// </summary>
        /// <param name="valor">La cadena que se va a validar como dígitos.</param>
        /// <returns>True si la cadena contiene solo dígitos, de lo contrario False.</returns>
        public static bool ValidarDigit(string valor)
        {
            foreach (char c in valor)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Corrobora si una cadena de texto representa una fecha válida en formato MM/YY (mes/año).
        /// </summary>
        /// <param name="fechaVencimiento">La cadena que se va a validar como fecha de vencimiento.</param>
        /// <returns>True si es una fecha válida en formato MM/YY, de lo contrario False.</returns>
        public static bool EsFechaValida(string fechaVencimiento)
        {
            if (string.IsNullOrEmpty(fechaVencimiento))
            {
                return false;
            }

            string patronFechaVencimiento = @"^(0[1-9]|1[0-2])\/\d{2}$"; // MM/YY
            Regex regexFechaVencimiento = new Regex(patronFechaVencimiento);

            return regexFechaVencimiento.IsMatch(fechaVencimiento);
        }

        /// <summary>
        /// Corrobora si una cadena de texto representa un número de tarjeta de crédito válido con 16 dígitos.
        /// </summary>
        /// <param name="numeroTarjeta">La cadena que se va a validar como número de tarjeta de crédito.</param>
        /// <returns>True si es un número de tarjeta de crédito válido, de lo contrario False.</returns>
        public static bool EsNumeroValido(string numeroTarjeta,int cantidadNumeroRecibido)
        {
            int cantidadNumero = cantidadNumeroRecibido;
            if (string.IsNullOrEmpty(numeroTarjeta))
            {
                return false;
            }

            string patronTarjeta = @$"^\d{{{cantidadNumeroRecibido}}}$";
            Regex regexTarjeta = new Regex(patronTarjeta);

            return regexTarjeta.IsMatch(numeroTarjeta);
        }

        /// <summary>
        /// Corrobora si una cadena de texto representa un código de verificación de tarjeta de crédito válido con 3 dígitos.
        /// </summary>
        /// <param name="cvv">La cadena que se va a validar como código de verificación de tarjeta de crédito.</param>
        /// <returns>True si es un código de verificación de tarjeta de crédito válido, de lo contrario False.</returns>
        public static bool EsCVVValido(string cvv) 
        {
            if (string.IsNullOrEmpty(cvv))
            {
                return false;
            }

            string patronCVV = @"^\d{3}$";
            Regex regexCVV = new Regex(patronCVV);

            return regexCVV.IsMatch(cvv);
        }
    }
}
