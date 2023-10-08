using System;
using BibliotecaCLases.Modelo;


namespace BibliotecaCLases.Controlador
{


    /// <summary>
    /// Clase que gestiona el registro de estudiantes en el sistema.
    /// </summary>
    public class GestorRegistroEstudiantes
    {
        private CrudEstudiante crudEstudiante;
        private bool _validado;
        private string _nombre;
        private string _apellido;
        private string _correo;
        private string _dni;
        private string _direccion;
        private string _telefono;
        private string _claveProvisional;
        public ValidadorDatos validadorDatos;
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
        public GestorRegistroEstudiantes(string nombre ,string apellido ,string dni, string correo, string direccion,string telefono)
        {
            // aca tener todos los datos mientras vemos si son correctos 
             validadorDatos =  new ValidadorDatos(nombre, apellido,dni, correo, direccion, telefono);

            _validado = validadorDatos.Validar(out string mensajeError);
         
            if (Validado)
            {
                crudEstudiante = new CrudEstudiante();
                _nombre = nombre;
                _apellido = apellido;
                _dni = dni;
                _correo = correo;
                _direccion = direccion;
                _telefono = telefono;
              
            }
            else
            {
                _mensajeError = mensajeError;
            }

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
        /// <param name="debeCambiar">Indica si el estudiante debe cambiar la clave.</param>
        /// <returns>Un mensaje de éxito o error al registrar el estudiante.</returns>
        public string RegistrarEstudiante(string nombre, string apellido,  string dni, string correo, string direccion, string telefono, bool debeCambiar)
        {
            
            return crudEstudiante.RegistrarEstudiante(nombre, apellido, dni, correo, direccion, telefono, debeCambiar);
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



        /// <summary>
        /// Indica si los datos del estudiante han sido validados correctamente.
        /// </summary>
        public bool Validado
        {
            get { return _validado; }
            set { _validado = value; }
        }


        /// <summary>
        /// Obtiene o establece el mensaje de error en caso de que la validación de datos falle.
        /// </summary>
        public string MensajeError
        {
            get { return _mensajeError; }
            set { _mensajeError = value; }
        }

        /// <summary>
        /// Obtiene o establece el nombre del estudiante.
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        /// <summary>
        /// Obtiene o establece el apellido del estudiante.
        /// </summary>
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }


        /// <summary>
        /// Obtiene o establece la dirección del estudiante.
        /// </summary>
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }


        /// <summary>
        /// Obtiene o establece el teléfono del estudiante.
        /// </summary>
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }


        /// <summary>
        /// Obtiene o establece la clave provisional del estudiante.
        /// </summary>
        public string ClaveProvisional
        {
            get { return _claveProvisional; }
            set { _claveProvisional = value; }
        }

    }
}
