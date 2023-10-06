using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    public class ValidadorDatosRegistro
    {
       private string _nombre;
        private string _apellido;
        private string _dni;
        private string _correo;
        private string _direccion;
        private string _telefono;
       

        public ValidadorDatosRegistro(string nombre_ingresado, string apellido_ingresado, string dni_ingresado, string correo_ingresado, string direccion_ingresado, string telefono_ingresado)
        {
            _nombre = nombre_ingresado;
            _apellido = apellido_ingresado;
            _dni = dni_ingresado;
            _correo = correo_ingresado;
            _direccion = direccion_ingresado;
            _telefono = telefono_ingresado;
          
        }
        public bool Validar(out string mensajeError)
        {
            mensajeError = string.Empty;

            if (!Validacion.EsNombreValido(_nombre))
            {
                mensajeError = "El nombre no es válido.";
                return false;
            }

            if (!Validacion.EsApellidoValido(_apellido))
            {
                mensajeError = "El apellido no es válido.";
                return false;
            }

            if (!Validacion.ValidarDigit(_dni))
            {
                mensajeError = "El DNI no es válido.";
                return false;
            }

            if (!Validacion.EsCorreoValido(_correo))
            {
                mensajeError = "El correo electrónico no es válido.";
                return false;
            }

            if (string.IsNullOrEmpty(_direccion))
            {
                mensajeError = "La dirección no puede estar vacía.";
                return false;
            }

            if (!Validacion.ValidarDigit(_telefono))
            {
                mensajeError = "El teléfono no es válido.";
                return false;
            }

    
            return true;
        }
    }


}
