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

        public ValidadorDatosCurso(string nombre_ingresado, string codigo_ingresado, string descripcion_ingresada, string cupoMaximo_ingresado)
            : base(nombre_ingresado, "", "", "", "", "", "")
        {
            nombre = nombre_ingresado;
            codigo = codigo_ingresado;
            descripcion = descripcion_ingresada;
            cupoMaximo = cupoMaximo_ingresado;
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

            return true;
        }
    }
}
