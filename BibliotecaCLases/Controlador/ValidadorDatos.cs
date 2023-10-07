using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    /// <summary>
    /// Clase que realiza la validación de datos genéricos, como los de un curso o un registro de usuario.
    /// </summary>
    public class ValidadorDatos
    {
        private string _nombre;
        private string _apellido;
        private string _dni;
        private string _correo;
        private string _direccion;
        private string _telefono;
        private string _codigo;
        private string _descripcion;
        private string _cupoMaximo;
        private string _aula;
        private string _dia;
        private string _horario;





        /// <summary>
        /// Constructor de la clase ValidadorDatos para validar datos de registro genéricos.
        /// </summary>
        /// <param name="nombre_ingresado">Nombre ingresado.</param>
        /// <param name="apellido_ingresado">Apellido ingresado.</param>
        /// <param name="dni_ingresado">DNI ingresado.</param>
        /// <param name="correo_ingresado">Correo electrónico ingresado.</param>
        /// <param name="direccion_ingresado">Dirección ingresada.</param>
        /// <param name="telefono_ingresado">Teléfono ingresado.</param>
        public ValidadorDatos(string nombre_ingresado, string apellido_ingresado, string dni_ingresado, string correo_ingresado, string direccion_ingresado, string telefono_ingresado)
        {
            _nombre = nombre_ingresado;
            _apellido = apellido_ingresado;
            _dni = dni_ingresado;
            _correo = correo_ingresado;
            _direccion = direccion_ingresado;
            _telefono = telefono_ingresado;
        }

        /// <summary>
        /// Constructor de la clase ValidadorDatos para validar datos de un curso.
        /// </summary>
        /// <param name="nombreIngresado">Nombre del curso ingresado.</param>
        /// <param name="codigoIngresado">Código del curso ingresado.</param>
        /// <param name="descripcionIngresada">Descripción del curso ingresada.</param>
        /// <param name="cupoMaximoIngresado">Cupo máximo del curso ingresado.</param>
        /// <param name="diaIngresado">Día del curso ingresado.</param>
        /// <param name="aulaIngresada">Aula del curso ingresada.</param>
        /// <param name="horarioIngresado">Horario del curso ingresado.</param>
        public ValidadorDatos(string nombreIngresado, string codigoIngresado, string descripcionIngresada, string cupoMaximoIngresado, string diaIngresado, string aulaIngresada, string horarioIngresado)
        {
            _nombre = nombreIngresado;
            _codigo = codigoIngresado;
            _descripcion = descripcionIngresada;
            _cupoMaximo = cupoMaximoIngresado;
            _dia = diaIngresado;
            _horario = horarioIngresado;
            _aula = aulaIngresada;
        }




        /// <summary>
        /// Realiza la validación de los datos.
        /// </summary>
        /// <param name="mensajeError">Mensaje de error en caso de que la validación falle.</param>
        /// <returns>True si los datos son válidos; de lo contrario, false.</returns>
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

        /// <summary>
        /// Realiza la validación de los datos de un curso.
        /// </summary>
        /// <param name="mensajeError">Mensaje de error en caso de que la validación falle.</param>
        /// <returns>True si los datos son válidos; de lo contrario, false.</returns>
        public bool ValidarCurso(out string mensajeError)
        {
            mensajeError = string.Empty;

            if (!Validacion.EsNombreValido(_nombre))
            {
                mensajeError = "El nombre del curso no es válido.";
                return false;
            }

            if (!Validacion.ValidarDigit(_codigo))
            {
                mensajeError = "El código del curso no es válido.";
                return false;
            }

            if (string.IsNullOrEmpty(_descripcion))
            {
                mensajeError = "La descripción del curso no puede estar vacía.";
                return false;
            }

            if (!Validacion.ValidarDigit(_cupoMaximo))
            {
                mensajeError = "El cupo máximo del curso no es válido.";
                return false;
            }

            if (!Validacion.ValidarAlphanumeric(_aula))
            {
                mensajeError = "El aula del curso no es válido.";
                return false;
            }

            return true;
        }
    }
}
