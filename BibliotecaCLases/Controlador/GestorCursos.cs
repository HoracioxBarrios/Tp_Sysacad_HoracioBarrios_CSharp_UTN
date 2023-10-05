using System;
using BibliotecaCLases.Controlador;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;

namespace BibliotecaCLases.Controlador
{
    public class GestorCursos
    {
        private CrudCurso crudCurso;
        private bool _validado;
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private string _cuposDisponibles;
        private string _mensajeError;

        public GestorCursos(string nombre, string codigo, string descripcion, string cuposDisponibles)
        {
            // Asigna el resultado de la creación de ValidadorDatosCurso al miembro de la clase
            ValidadorDatosCurso validadorDatosCurso = new ValidadorDatosCurso(nombre, codigo, descripcion, cuposDisponibles);

            _validado = validadorDatosCurso.ValidarCurso(out string mensajeError);
            if (_validado)
            {
                crudCurso = new CrudCurso();
                _nombre = nombre;
                _codigo = codigo;
                _descripcion = descripcion;
                _cuposDisponibles = cuposDisponibles;
            }
            else
            {
                _mensajeError = mensajeError;
            }
        }

        public bool Validado
        {
            get { return _validado; }
        }

        public string MensajeError
        {
            get { return _mensajeError; }
        }

        public bool verificarDatosExistentes()
        {
            int numeroError = crudCurso.VerificarCodigoCurso(_codigo);

            if (numeroError == 1)
            {
                _mensajeError = "Error: El código ya está registrado.";
                return false;
            }

            return true;
        }

        public string AgregarCurso(string nombre, string codigo, string descripcion, string cupoMaximo)
        {
            try
            {
                crudCurso.AgregarCurso(nombre, codigo, descripcion, cupoMaximo);
                return "Curso agregado correctamente.";
            }
            catch (Exception ex)
            {
                // Aquí puedes manejar la excepción de acuerdo a tus necesidades.
                // Por ejemplo, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                // También puedes lanzar una nueva excepción personalizada si es necesario.
                return "Error al agregar el curso: " + ex.Message;
            }
        }

        public string EditarCurso(string nombre, string codigo, string nombreAtributo, string nuevoValor)
        {
            try
            {
                string resultadoEdicion = crudCurso.EditarCurso(nombre, codigo, nombreAtributo, nuevoValor);
                return resultadoEdicion;
            }
            catch (Exception ex)
            {
                // Aquí puedes manejar la excepción de acuerdo a tus necesidades.
                // Por ejemplo, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                // También puedes lanzar una nueva excepción personalizada si es necesario.
                return "Error al editar el curso: " + ex.Message;
            }
        }
    }
}
