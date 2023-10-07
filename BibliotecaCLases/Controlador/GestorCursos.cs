using System;
using BibliotecaCLases.Controlador;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;

namespace BibliotecaCLases.Controlador
{
    /// <summary>
    /// Clase que gestiona la lógica de negocios para la creación, edición y validación de cursos.
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
        /// Constructor de la clase para la creación de un nuevo curso con todos los detalles.
        /// </summary>
        /// <param name="nombre">Nombre del curso.</param>
        /// <param name="codigo">Código del curso.</param>
        /// <param name="descripcion">Descripción del curso.</param>
        /// <param name="cupoMaximo">Cupo máximo del curso.</param>
        /// <param name="dia">Día del curso.</param>
        /// <param name="horario">Horario del curso.</param>
        /// <param name="aula">Aula del curso.</param>
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
        /// Constructor de la clase para la creación de un nuevo curso básico sin detalles de día, horario y aula.
        /// </summary>
        /// <param name="nombre">Nombre del curso.</param>
        /// <param name="codigo">Código del curso.</param>
        /// <param name="descripcion">Descripción del curso.</param>
        /// <param name="cupoMaximo">Cupo máximo del curso.</param>
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
        /// Indica si los datos del curso han sido validados con éxito.
        /// </summary>
        public bool Validado
        {
            get { return _validado; }
        }

        /// <summary>
        /// Obtiene el mensaje de error en caso de que la validación haya fallado.
        /// </summary>
        public string MensajeError
        {
            get { return _mensajeError; }
        }

        /// <summary>
        /// Verifica si ya existe un curso con el mismo código.
        /// </summary>
        /// <returns>True si el código no existe, False si el código ya está registrado.</returns>
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
        /// Verifica si ya existe un curso con el mismo código nuevo.
        /// </summary>
        /// <param name="codigoNuevo">Nuevo código a verificar.</param>
        /// <returns>True si el código no existe, False si el código ya está registrado.</returns>
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

        /// <summary>
        /// Agrega un nuevo curso.
        /// </summary>
        /// <param name="nombre">Nombre del curso.</param>
        /// <param name="codigo">Código del curso.</param>
        /// <param name="descripcion">Descripción del curso.</param>
        /// <param name="cupoMaximo">Cupo máximo del curso.</param>
        /// <param name="dia">Día del curso.</param>
        /// <param name="horario">Horario del curso.</param>
        /// <param name="aula">Aula del curso.</param>
        /// <returns>Un mensaje que indica si la operación fue exitosa o si hubo un error.</returns>
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

        /// <summary>
        /// Edita un curso existente.
        /// </summary>
        /// <param name="codigo">Código del curso a editar.</param>
        /// <param name="nuevoCodigo">Nuevo código del curso.</param>
        /// <param name="nuevoNombre">Nuevo nombre del curso.</param>
        /// <param name="nuevaDescripcion">Nueva descripción del curso.</param>
        /// <param name="nuevoCupoMaximo">Nuevo cupo máximo del curso.</param>
        /// <returns>Un mensaje que indica si la operación fue exitosa o si hubo un error.</returns>
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
