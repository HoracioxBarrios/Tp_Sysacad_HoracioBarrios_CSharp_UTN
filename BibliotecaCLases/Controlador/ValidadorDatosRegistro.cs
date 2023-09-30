using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    public class ValidadorDatosRegistro
    {
        string nombre;
        string apellido;
        string dni;
        string correo;
        string direccion;
        string telefono;
        string claveProvisional;
        // va a hacer uso de ValidarUsuario

        //
        public ValidadorDatosRegistro(string nombre_ingresado, string apellido_ingresado, string dni_ingresado, string correo_ingresado, string direccion_ingresado, string telefono_ingresado, string claveProvisional_ingresado)
        {
            nombre = nombre_ingresado;
            apellido = apellido_ingresado;
            dni = dni_ingresado;
            correo = correo_ingresado;
            direccion = direccion_ingresado;
            telefono = telefono_ingresado;
            claveProvisional = claveProvisional_ingresado;
        }
        public bool Validar(out string mensajeError)
        {
            mensajeError = string.Empty; // Inicializa el mensaje de error como cadena vacía

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

            if (string.IsNullOrEmpty(claveProvisional))
            {
                mensajeError = "La contraseña provisional no puede estar vacía.";
                return false;
            }

            // Si todos los campos son válidos, devuelve true
            return true;
        }
    }


}
