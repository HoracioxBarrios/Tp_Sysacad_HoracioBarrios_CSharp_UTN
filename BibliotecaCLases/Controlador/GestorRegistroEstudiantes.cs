using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;

namespace BibliotecaCLases.Controlador
{
    public class GestorRegistroEstudiantes
    {
        private CrudEstudiante crudEstudiante;
        private bool _validado;
        public string _nombre;
        public string _apellido;
        public string _correo;
        public string _dni;
        public string _direccion;
        public string _telefono;
        public string _claveProvisional;
        public ValidadorDatosRegistro validadorDatosRegistro;
        private string _mensajeError;

        /// <summary>
        /// Crea una instancia de la clase GestorRegistroEstudiantes para gestionar el registro de un estudiante.
        /// </summary>
        /// <param name="nombre">El nombre del estudiante.</param>
        /// <param name="apellido">El apellido del estudiante.</param>
        /// <param name="dni">El DNI del estudiante.</param>
        /// <param name="correo">El correo del estudiante.</param>
        /// <param name="direccion">La dirección del estudiante.</param>
        /// <param name="telefono">El teléfono del estudiante.</param>
        /// <param name="claveProvisional">La clave provisional del estudiante.</param>
        public GestorRegistroEstudiantes(string nombre ,string apellido ,string dni, string correo, string direccion,string telefono , string claveProvisional)
        {
            // aca tener todos los datos mientras vemos si son correctos 
             validadorDatosRegistro =  new ValidadorDatosRegistro(nombre, apellido,dni, correo, direccion, telefono, claveProvisional);

            _validado = validadorDatosRegistro.Validar(out string mensajeError);
         
            if (this.Validado)
            {
                crudEstudiante = new CrudEstudiante();
                _nombre = nombre;
                _apellido = apellido;
                _dni = dni;
                _correo = correo;
                _direccion = direccion;
                _telefono = telefono;
                _claveProvisional = claveProvisional;
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

        /// <summary>
        /// Verifica si los datos del estudiante ya existen en el sistema a través del correo electrónico y el número de identificación (DNI).
        /// </summary>
        /// <returns>
        ///   <para>true si los datos no existen previamente en el sistema y pueden ser registrados.</para>
        ///   <para>false si el correo electrónico o el DNI ya están registrados, en cuyo caso se establece un mensaje de error.</para>
        /// </returns>
        public bool verificarDatosExistentes()
        {
            int numeroError = crudEstudiante.VerificarDatosEstudiante(_correo, _dni);

            if (numeroError == 1)
            {
                _mensajeError = "Error: El correo electrónico ya está registrado.";
                return false;
            }
            else if (numeroError == 2)
            {
                _mensajeError = "Error: El número de identificación (DNI) ya está registrado.";
                return false;
            }

            return true;
        }
        /// <summary>
        /// Registra un nuevo estudiante utilizando el objeto CrudEstudiante.
        /// </summary>
        /// <param name="nombre">El nombre del estudiante.</param>
        /// <param name="apellido">El apellido del estudiante.</param>
        /// <param name="dni">El DNI del estudiante.</param>
        /// <param name="correo">El correo del estudiante.</param>
        /// <param name="direccion">La dirección del estudiante.</param>
        /// <param name="telefono">El teléfono del estudiante.</param>
        /// <param name="claveProvisional">La clave provisional del estudiante.</param>
        /// <param name="debeCambiar">Indica si el estudiante debe cambiar la clave.</param>
        public void RegistrarEstudiante(string nombre, string apellido,  string dni, string correo, string direccion, string telefono, string claveProvisional, bool debeCambiar)
        {
            
            crudEstudiante.RegistrarEstudiante(nombre, apellido, dni, correo, direccion, telefono, claveProvisional, debeCambiar);
        }

        /// <summary>
        /// Obtiene un diccionario que contiene a los estudiantes registrados utilizando el objeto CrudEstudiante.
        /// </summary>
        /// <returns>Un diccionario que contiene a los estudiantes registrados, donde la clave es el número de legajo y el valor es el objeto Estudiante.</returns>
        public Dictionary<int, Estudiante> ObtenerEstudiantesRegistrados()
        {
            return crudEstudiante.ObtenerEstudiantesRegistrados();
        }

        /// <summary>
        /// Modifica el nombre de un estudiante utilizando el objeto CrudEstudiante.
        /// </summary>
        /// <param name="estudiante">El número de legajo del estudiante que se desea modificar.</param>
        /// <param name="nuevoNombre">El nuevo nombre que se asignará al estudiante.</param>
        public void ModificarEstudiante(int estudiante, string nuevoNombre)
        {          
            crudEstudiante.ModificarEstudiante(estudiante, nuevoNombre);
        }

        /// <summary>
        /// Elimina un estudiante utilizando el objeto CrudEstudiante.
        /// </summary>
        /// <param name="estudiante">El número de legajo del estudiante que se desea eliminar.</param>
        public void EliminarEstudiante(int estudiante)
        {          
            crudEstudiante.EliminarEstudiante(estudiante);
        }

    }
}
