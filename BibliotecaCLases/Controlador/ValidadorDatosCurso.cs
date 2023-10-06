using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    public class ValidadorDatosCurso : ValidadorDatosRegistro
    {
        string nombre;
        string codigo;
        string descripcion;
        string cupoMaximo;
        private string _dia;
        private string _horario;
        private string _aula;

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

            //if (Validacion.ValidarAlphanumeric(_horario))
            //{
            //    mensajeError = "El horario del curso no es válido.";
            //    return false;
            //}

            //if (Validacion.ValidarAlphanumeric(_dia))
            //{
            //    mensajeError = "El horario del curso no es válido.";
            //    return false;
            //}

            return true;
        }
    }
}
