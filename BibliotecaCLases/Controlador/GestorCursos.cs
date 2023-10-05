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
                return "Error al agregar el curso: " + ex.Message;
            }
        }

        public string EditarCurso(string codigo, string nuevoCodigo, string nuevoNombre, string nuevaDescripcion, string nuevoCupoMaximo)
        {
            try
            {
                string resultadoEdicion = crudCurso.EditarCurso(codigo, nuevoCodigo, nuevoNombre, nuevaDescripcion, nuevoCupoMaximo);
                return resultadoEdicion;
            }
            catch (Exception ex)
            {
                return "Error al editar el curso: " + ex.Message;
            }
        }
    }
}
