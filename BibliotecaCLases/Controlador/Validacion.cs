﻿using System;
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

        public static bool EsTarjetaValida(string numeroTarjeta)
        {
            if (string.IsNullOrEmpty(numeroTarjeta))
            {
                return false;
            }

            string patronTarjeta = @"^\d{16}$";
            Regex regexTarjeta = new Regex(patronTarjeta);

            return regexTarjeta.IsMatch(numeroTarjeta);
        }

        public static bool EsCVValido(string cvv) 
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
