using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    /// <summary>
    /// Clase que realiza la validación de datos de un registro genérico, como el de un usuario.
    /// </summary>
    public class ValidadorDatosRegistro
    {
        string nombre;
        string apellido;
        string dni;
        string correo;
        string direccion;
        string telefono;

        /// <summary>
        /// Constructor de la clase ValidadorDatosRegistro.
        /// </summary>
        /// <param name="nombre_ingresado">Nombre ingresado.</param>
        /// <param name="apellido_ingresado">Apellido ingresado.</param>
        /// <param name="dni_ingresado">DNI ingresado.</param>
        /// <param name="correo_ingresado">Correo electrónico ingresado.</param>
        /// <param name="direccion_ingresado">Dirección ingresada.</param>
        /// <param name="telefono_ingresado">Teléfono ingresado.</param>
        public ValidadorDatosRegistro(string nombre_ingresado, string apellido_ingresado, string dni_ingresado, string correo_ingresado, string direccion_ingresado, string telefono_ingresado)
        {
            nombre = nombre_ingresado;
            apellido = apellido_ingresado;
            dni = dni_ingresado;
            correo = correo_ingresado;
            direccion = direccion_ingresado;
            telefono = telefono_ingresado;
          
        }

        /// <summary>
        /// Realiza la validación de los datos de un registro genérico.
        /// </summary>
        /// <param name="mensajeError">Mensaje de error en caso de que la validación falle.</param>
        /// <returns>True si los datos son válidos; de lo contrario, false.</returns>
        public bool Validar(out string mensajeError)
        {
            mensajeError = string.Empty;

            if (!Validacion.EsNombreValido(nombre))
            {
                mensajeError = "El nombre no es válido.";
                return false;
            }

            if (!Validacion.EsApellidoValido(apellido))
            {
                mensajeError = "El apellido no es válido.";
                return false;
            }

            if (!Validacion.ValidarDigit(dni))
            {
                mensajeError = "El DNI no es válido.";
                return false;
            }

            if (!Validacion.EsCorreoValido(correo))
            {
                mensajeError = "El correo electrónico no es válido.";
                return false;
            }

            if (string.IsNullOrEmpty(direccion))
            {
                mensajeError = "La dirección no puede estar vacía.";
                return false;
            }

            if (!Validacion.ValidarDigit(telefono))
            {
                mensajeError = "El teléfono no es válido.";
                return false;
            }

    
            return true;
        }
    }


}
