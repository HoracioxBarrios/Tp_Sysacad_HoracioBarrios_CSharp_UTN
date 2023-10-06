using System;
using BibliotecaCLases.Controlador;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;

namespace BibliotecaCLases.Controlador
{

    /// <summary>
    /// Clase que gestiona la lógica relacionada con los cursos.
    /// </summary>
    public class GestorCursos
    {
        private CrudCurso crudCurso;
        private bool _validado;
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private string _cupoMaximo;
        private string _cuposDisponibles;
        private string _dia;
        private string _horario;
        private string _aula;
        private string _mensajeError;


        /// <summary>
        /// Constructor para un curso con todos los datos.
        /// </summary>
        public GestorCursos(string nombre, string codigo, string descripcion, string cupoMaximo, string dia, string horario, string aula)
        {
            ValidadorDatosCurso validadorDatosCurso = new ValidadorDatosCurso(nombre, codigo, descripcion, cupoMaximo, dia, aula, horario);

            _validado = validadorDatosCurso.ValidarCurso(out string mensajeError);
            if (_validado)
            {
                crudCurso = new CrudCurso();
                _nombre = nombre;
                _codigo = codigo;
                _descripcion = descripcion;
                _cupoMaximo = cupoMaximo;
                _dia = dia;
                _horario = horario;
                _aula = aula;
            }
            else
            {
                _mensajeError = mensajeError;
            }
        }


        /// <summary>
        /// Constructor para un curso con datos mínimos. ( SOBRECARGA CONSTRUCTOR )
        /// </summary>
        public GestorCursos(string nombre, string codigo, string descripcion, string cupoMaximo)
        {
            ValidadorDatosCurso validadorDatosCurso = new ValidadorDatosCurso(nombre, codigo, descripcion, cupoMaximo, "", "", "");

            _validado = validadorDatosCurso.ValidarCurso(out string mensajeError);
            if (_validado)
            {
                crudCurso = new CrudCurso();
                _nombre = nombre;
                _codigo = codigo;
                _descripcion = descripcion;
                _cupoMaximo = cupoMaximo;
                _dia = "";
                _horario = "";
                _aula = "";
            }
            else
            {
                _mensajeError = mensajeError;
            }
        }





        /// <summary>
        /// Método para verificar si un curso con el mismo código ya existe.
        /// </summary>
        /// <returns>True si el código no existe, False si ya existe.</returns>
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


        /// <summary>
        /// Sobrecarga del método para verificar si un curso con un código nuevo ya existe.
        /// ( sobrecarga )
        /// </summary>
        /// <param name="codigoNuevo">Código a verificar.</param>
        /// <returns>True si el código no existe, False si ya existe.</returns>
        public bool verificarDatosExistentes(string codigoNuevo)
        {
            int numeroError = crudCurso.VerificarCodigoCurso(codigoNuevo);

            if (numeroError == 1)
            {
                _mensajeError = "Error: El código ya está registrado.";
                return false;
            }

            return true;
        }




        public string AgregarCurso(string nombre, string codigo, string descripcion, string cupoMaximo, string dia, string horario, string aula)
        {
            try
            {
                crudCurso.AgregarCurso(nombre, codigo, descripcion, cupoMaximo, dia, horario, aula);
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



        public bool Validado
        {
            get { return _validado; }
        }

        public string MensajeError
        {
            get { return _mensajeError; }
        }

    }
}
