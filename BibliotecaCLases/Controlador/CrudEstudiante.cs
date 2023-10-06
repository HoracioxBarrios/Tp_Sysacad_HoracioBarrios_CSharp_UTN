using System.Text;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;


namespace BibliotecaCLases.Controlador
{


    /// <summary>
    /// Clase para gestionar operaciones relacionadas con estudiantes.
    /// </summary>
    public class CrudEstudiante
    {
        private static int _contadorLegajos = 1000;
        private string _path;
        public string pathUltimoLegajo;
        private int _ultimoLegajoEnArchivo;
        private CrudCurso crudCurso;
        private Dictionary<int, Estudiante> dictEstudiantesRegistrados;




        /// <summary>
        /// Constructor de la clase CrudEstudiante. Inicializa un nuevo objeto CrudEstudiante
        /// y carga datos de estudiantes registrados desde un archivo JSON si está disponible.
        /// </summary>
        public CrudEstudiante()
        {
            dictEstudiantesRegistrados = new Dictionary<int, Estudiante>();
            _path = PathManager.ObtenerRuta("Data", "DataUsuarios.json");
            dictEstudiantesRegistrados = Serializador.LeerJson<Dictionary<int, Estudiante>>(_path);
            pathUltimoLegajo = PathManager.ObtenerRuta("Data", "Legajo.json");
            _ultimoLegajoEnArchivo = Serializador.LeerJson<int>(pathUltimoLegajo);
            crudCurso = new CrudCurso();
        }




        /// <summary>
        /// Agrega un curso a la lista de cursos inscritos de un estudiante y actualiza los datos en caso de éxito.
        /// </summary>
        /// <param name="legajoEstudiante">El número de legajo del estudiante.</param>
        /// <param name="codigoCurso">El código del curso a inscribir.</param>
        /// <param name="mensajeError">
        /// Un mensaje de error si no se pudo agregar el curso (null si la operación fue exitosa).
        /// </param>
        /// <returns>
        /// true si se agregó el curso exitosamente.
        /// false si no se pudo agregar el curso (por ejemplo, el estudiante ya está inscrito en el curso).
        /// </returns>
        public bool AgregarCursoAEstudiante(int legajoEstudiante, string codigoCurso, out string mensajeError)
        {
            Estudiante estudiante = ObtenerEstudiantePorLegajo(legajoEstudiante);

            if (estudiante != null)
            {
                if (estudiante.CursosInscriptos.Contains(codigoCurso))
                {
                    mensajeError = "El estudiante ya está inscrito en este curso.";
                    return false;
                }

                string mensaje = crudCurso.InscribirEstudianteEnCurso(codigoCurso);

                if (mensaje == "Inscripción exitosa.")
                {
                    estudiante.CursosInscriptos.Add(codigoCurso);
                    string path = PathManager.ObtenerRuta("Data", "DataUsuarios.json");
                    Serializador.ActualizarJson(estudiante, estudiante.Legajo, path);
                    mensajeError = null;
                    return true;
                }
                else
                {
                    mensajeError = mensaje;
                    return false;
                }
            }

            mensajeError = "El estudiante no se encontró.";
            return false;
        }



        /// <summary>
        /// Modifica el nombre de un estudiante en el diccionario de estudiantes registrados.
        /// </summary>
        /// <param name="estudianteId">El número de legajo del estudiante que se desea modificar.</param>
        /// <param name="nuevoNombre">El nuevo nombre que se asignará al estudiante.</param>
        /// <exception cref="KeyNotFoundException">Se lanza si no se encuentra un estudiante con el número de legajo especificado.</exception>icado.</exception>
        public void ModificarEstudiante(int estudianteId, string nuevoNombre)
        {
            if (dictEstudiantesRegistrados.ContainsKey(estudianteId))
            {
                Estudiante estudianteAModificar = dictEstudiantesRegistrados[estudianteId];
                estudianteAModificar.Nombre = nuevoNombre;
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró un estudiante con el Id {estudianteId}");
            }
        }



        /// <summary>
        /// Elimina un estudiante del diccionario de estudiantes registrados si existe.
        /// </summary>
        /// <param name="estudianteId">El número de legajo del estudiante que se desea eliminar.</param>
        /// <returns>
        ///   <para>true si el estudiante se eliminó exitosamente.</para>
        ///   <para>false si el estudiante no existe en el diccionario y no se eliminó.</para>
        /// </returns>
        public void EliminarEstudiante(int estudianteId)
        {
            if (dictEstudiantesRegistrados.ContainsKey(estudianteId))
            {
                dictEstudiantesRegistrados.Remove(estudianteId);
            }
        }



        /// <summary>
        /// Verifica si existen datos de un estudiante con un correo o DNI específico en el diccionario de estudiantes registrados.
        /// </summary>
        /// <param name="correo">El correo a verificar.</param>
        /// <param name="dni">El DNI a verificar.</param>
        /// <returns>
        ///   <para>1 si se encuentra un estudiante con el correo especificado.</para>
        ///   <para>2 si se encuentra un estudiante con el DNI especificado.</para>
        ///   <para>0 si no se encuentra ningún estudiante con el correo ni el DNI especificados.</para>
        /// </returns>
        public int VerificarDatosEstudiante(string correo, string dni)
        {
            if (dictEstudiantesRegistrados != null)
            {

                if (dictEstudiantesRegistrados.Any(kv => kv.Value.Correo == correo))
                {
                    return 1;
                }
                if (dictEstudiantesRegistrados.Values.Any(est => est.Dni == dni))
                {
                    return 2;
                }
            }

            return 0;
        }



        /// <summary>
        /// Incrementa y obtiene el último legajo disponible, actualizando el valor en el archivo json correspondiente.
        /// </summary>
        /// <returns>El último legajo disponible.</returns>
        private int ObtieneLegajo()
        {
            _ultimoLegajoEnArchivo++;
            string pathLegajo = PathManager.ObtenerRuta("Data", "Legajo.json");
            Serializador.GuardarAJson(_ultimoLegajoEnArchivo, pathLegajo);

            return _ultimoLegajoEnArchivo;
        }



        /// <summary>
        /// Genera una contraseña aleatoria con la longitud especificada y caracteres permitidos.
        /// </summary>
        /// <param name="longitudMinima">La longitud mínima de la contraseña.</param>
        /// <param name="longitudMaxima">La longitud máxima de la contraseña.</param>
        /// <returns>Una contraseña aleatoria.</returns>
        static string GenerarContrasenaAleatoria(int longitudMinima, int longitudMaxima)
        {
            const string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_+=<>?";

            Random random = new Random();
            int longitud = random.Next(longitudMinima, longitudMaxima + 1); 
            StringBuilder contrasena = new StringBuilder();

            for (int i = 0; i < longitud; i++)
            {
                int indice = random.Next(caracteresPermitidos.Length);
                char caracterAleatorio = caracteresPermitidos[indice];
                contrasena.Append(caracterAleatorio);
            }

            return contrasena.ToString(); // Puedes omitir ToString() aquí
        }





        /// <summary>
        /// Registra un nuevo estudiante con la información proporcionada y lo agrega al diccionario de estudiantes registrados.
        /// </summary>
        /// <param name="nombre">El nombre del estudiante.</param>
        /// <param name="apellido">El apellido del estudiante.</param>
        /// <param name="dni">El DNI del estudiante.</param>
        /// <param name="correo">El correo del estudiante.</param>
        /// <param name="direccion">La dirección del estudiante.</param>
        /// <param name="telefono">El teléfono del estudiante.</param>      
        /// <param name="debeCambiar">Indica si el estudiante debe cambiar la clave.</param>
        /// <returns>Un mensaje de confirmación del registro.</returns>
        public string RegistrarEstudiante(string nombre, string apellido, string dni, string correo, string direccion, string telefono, bool debeCambiar)
        {
            int legajo = ObtieneLegajo();

            string claveProvisional = GenerarContrasenaAleatoria(7, 12);
            string mensaje = Email.SendMessageSmtp(correo, claveProvisional);
            String contrasena = PasswordHashing.GetHash(claveProvisional.ToString());
            Estudiante nuevoEstudiante = new(nombre, apellido, dni, correo, direccion, telefono, contrasena, debeCambiar);
            nuevoEstudiante.Legajo = legajo;

            dictEstudiantesRegistrados.Add(nuevoEstudiante.Legajo, nuevoEstudiante);

            Serializador.ActualizarJson(nuevoEstudiante, nuevoEstudiante.Legajo, _path);
            return mensaje;

        }




        /// <summary>
        /// Obtiene el diccionario de estudiantes registrados.
        /// </summary>
        /// <returns>Un diccionario que contiene a los estudiantes registrados, donde la clave es el número de legajo y el valor es el objeto Estudiante.</returns>
        public Dictionary<int, Estudiante> ObtenerEstudiantesRegistrados()
        {
            return dictEstudiantesRegistrados;
        }





        /// <summary>
        /// Obtiene un estudiante del diccionario de estudiantes registrados por su número de legajo.
        /// </summary>
        /// <param name="legajo">El número de legajo del estudiante a buscar.</param>
        /// <returns>
        /// Un objeto Estudiante si se encuentra un estudiante con el número de legajo especificado.
        /// Null si no se encuentra ningún estudiante con ese número de legajo.
        /// </returns>
        public Estudiante ObtenerEstudiantePorLegajo(int legajo)
        {
            if (dictEstudiantesRegistrados.ContainsKey(legajo))
            {
                return dictEstudiantesRegistrados[legajo];
            }
            else
            {
                return null;
            }
        }






        /// <summary>
        /// Obtiene o establece la ruta del archivo donde se almacenan los datos de estudiantes.
        /// </summary>
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        /// <summary>
        /// Obtiene o establece el contador de legajos para asignar legajos únicos a los estudiantes.
        /// </summary>
        public int ContadorLegajos
        {
            get { return _contadorLegajos; }
            set { _contadorLegajos = value; }

        }
    }
}
