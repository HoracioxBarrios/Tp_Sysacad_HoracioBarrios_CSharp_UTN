using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    /// <summary>
    /// Clase que realiza la validación de datos para un curso.
    /// </summary>
    public class ValidadorDatosCurso : ValidadorDatosRegistro
    {
        string nombre;
        string codigo;
        string descripcion;
        string cupoMaximo;
        private string _dia;
        private string _horario;
        private string _aula;

        /// <summary>
        /// Constructor de la clase ValidadorDatosCurso.
        /// </summary>
        /// <param name="nombreIngresado">Nombre del curso ingresado.</param>
        /// <param name="codigoIngresado">Código del curso ingresado.</param>
        /// <param name="descripcionIngresada">Descripción del curso ingresada.</param>
        /// <param name="cupoMaximoIngresado">Cupo máximo del curso ingresado.</param>
        /// <param name="diaIngresado">Día del curso ingresado.</param>
        /// <param name="aulaIngresada">Aula del curso ingresada.</param>
        /// <param name="horarioIngresado">Horario del curso ingresado.</param>
        public ValidadorDatosCurso(string nombreIngresado, string codigoIngresado, string descripcionIngresada, string cupoMaximoIngresado, string diaIngresado, string aulaIngresada, string horarioIngresado)
            : base(nombreIngresado, "", "", "", "", "")
        {
            nombre = nombreIngresado;
            codigo = codigoIngresado;
            descripcion = descripcionIngresada;
            cupoMaximo = cupoMaximoIngresado;
            _dia = diaIngresado;
            _horario = horarioIngresado;
            _aula = aulaIngresada;
        }

        /// <summary>
        /// Realiza la validación de los datos de un curso.
        /// </summary>
        /// <param name="mensajeError">Mensaje de error en caso de que la validación falle.</param>
        /// <returns>True si los datos son válidos; de lo contrario, false.</returns>
        public bool ValidarCurso(out string mensajeError)
        {
            mensajeError = string.Empty;

            if (!Validacion.EsNombreValido(nombre))
            {
                mensajeError = "El nombre del curso no es válido.";
                return false;
            }

            if (!Validacion.ValidarDigit(codigo))
            {
                mensajeError = "El código del curso no es válido.";
                return false;
            }

            if (string.IsNullOrEmpty(descripcion))
            {
                mensajeError = "La descripción del curso no puede estar vacía.";
                return false;
            }

            if (!Validacion.ValidarDigit(cupoMaximo))
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
