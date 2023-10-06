using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;





namespace BibliotecaCLases.Controlador
{


    /// <summary>
    /// Clase que gestiona la operación CRUD (Crear, Leer, Actualizar, Eliminar) de cursos.
    /// </summary>
    public class CrudCurso
    {
        private Dictionary<int, Curso> dictCursos;
        private string _path;



        /// <summary>
        /// Constructor de la clase CrudCurso.
        /// </summary>
        public CrudCurso()
        {
            _path = PathManager.ObtenerRuta("Data", "DictCurso.json");
            dictCursos = Serializador.LeerJson<Dictionary<int, Curso>>(_path);
        }




        /// <summary>
        /// Agrega un nuevo curso al diccionario de cursos.
        /// </summary>
        /// <param name="nombre">Nombre del curso.</param>
        /// <param name="codigo">Código del curso.</param>
        /// <param name="descripcion">Descripción del curso.</param>
        /// <param name="cupoMaximo">Cupo máximo del curso.</param>
        /// <param name="dia">Día del curso.</param>
        /// <param name="horario">Horario del curso.</param>
        /// <param name="aula">Aula del curso.</param>
        public void AgregarCurso(string nombre, string codigo, string descripcion, string cupoMaximo, string dia, string horario, string aula)
        {
            int.TryParse(codigo, out int codigoCurso);
            Curso nuevoCurso = new Curso(nombre, codigo, descripcion, cupoMaximo, dia, horario, aula);

            if (dictCursos != null)
            {
                dictCursos.Add(codigoCurso, nuevoCurso);
                Serializador.ActualizarJson(nuevoCurso, codigoCurso, _path);
            }
        }


        /// <summary>
        /// Edita un curso existente en el diccionario de cursos.
        /// </summary>
        /// <param name="codigo">Código del curso a editar.</param>
        /// <param name="nuevoCodigo">Nuevo código del curso.</param>
        /// <param name="nuevoNombre">Nuevo nombre del curso.</param>
        /// <param name="nuevaDescripcion">Nueva descripción del curso.</param>
        /// <param name="nuevoCupoMaximo">Nuevo cupo máximo del curso.</param>
        /// <returns>Un mensaje que indica si la edición fue exitosa o si ocurrió un error.</returns>
        public string EditarCurso(string codigo, string nuevoCodigo, string nuevoNombre, string nuevaDescripcion, string nuevoCupoMaximo)
        {
            int.TryParse(codigo, out int codigoCurso);
            int.TryParse(nuevoCodigo, out int nuevoCodigoCurso);

            try
            {
                if (dictCursos.ContainsKey(codigoCurso))
                {
                    Curso cursoExistente = dictCursos[codigoCurso];

                    if (codigoCurso != nuevoCodigoCurso)
                    {
                        dictCursos.Remove(codigoCurso);
                    }

                    cursoExistente.Codigo = nuevoCodigo;
                    cursoExistente.Nombre = nuevoNombre;
                    cursoExistente.Descripcion = nuevaDescripcion;
                    cursoExistente.CupoMaximo = int.Parse(nuevoCupoMaximo);
                    if (cursoExistente.CuposDisponibles > cursoExistente.CupoMaximo)
                    {
                        cursoExistente.CuposDisponibles = int.Parse(nuevoCupoMaximo);
                    }

                    dictCursos[nuevoCodigoCurso] = cursoExistente;

                    Serializador.ActualizarJson(dictCursos, _path);
                    return "Se modificó correctamente";
                }
                else
                {
                    return "El curso no existe en el diccionario.";
                }
            }
            catch (Exception ex)
            {
                return "Error al guardar los cambios: " + ex.Message;
            }
        }




        /// <summary>
        /// Elimina un curso de forma lógica, marcándolo como inactivo en el diccionario de cursos.
        /// </summary>
        /// <param name="curso">El curso a eliminar.</param>
        /// <returns>Un mensaje que indica si la eliminación fue exitosa o si ocurrió un error.</returns>
        public string EliminarCurso(Curso curso)
        {
            int.TryParse(curso.Codigo, out int codigoCurso);

            if (dictCursos.ContainsKey(codigoCurso))
            {
                Curso cursoAEliminar = dictCursos[codigoCurso];

                cursoAEliminar.Activo = false;

                Serializador.ActualizarJson(dictCursos, _path);

                return "Se realizó la eliminación lógica del curso";
            }
            else
            {
                return "El curso no existe en el diccionario.";
            }
        }






        /// <summary>
        /// Verifica si un código de curso existe en el diccionario de cursos.
        /// </summary>
        /// <param name="codigo">El código de curso a verificar.</param>
        /// <returns>1 si el código de curso existe, 0 si no existe.</returns>
        public int VerificarCodigoCurso(string codigo)
        {
            if (dictCursos != null)
            {
                if (dictCursos.Any(kv => kv.Value.Codigo == codigo))
                {
                    return 1;
                }
            }

            return 0;
        }




        /// <summary>
        /// Inscribe un estudiante en un curso si hay cupos disponibles.
        /// </summary>
        /// <param name="codigo">El código del curso en el que inscribir al estudiante.</param>
        /// <returns>Un mensaje que indica si la inscripción fue exitosa o si no hay cupos disponibles.</returns>
        public string InscribirEstudianteEnCurso(string codigo)
        {
            if (dictCursos != null)
            {
                int.TryParse(codigo, out int codigoCurso);
                if (dictCursos.ContainsKey(codigoCurso))
                {
                    Curso curso = dictCursos[codigoCurso];

                    if (curso.CuposDisponibles > 0)
                    {
                        curso.CuposDisponibles--;
                        Serializador.ActualizarJson(dictCursos, _path);
                        return "Inscripción exitosa.";
                    }
                    else
                    {
                        return "No hay cupos disponibles para este curso.";
                    }
                }
                else
                {
                    return "El curso no existe en el diccionario.";
                }
            }
            else
            {
                return "No se encontraron cursos.";
            }
        }




        /// <summary>
        /// Obtiene el diccionario de cursos completo.
        /// </summary>
        /// <returns>El diccionario de cursos.</returns>
        public Dictionary<int, Curso> ObtenerDictCursos()
        {
            dictCursos = Serializador.LeerJson<Dictionary<int, Curso>>(_path);
            return dictCursos;
        }




        /// <summary>
        /// Obtiene un curso por su código.
        /// </summary>
        /// <param name="codigo">El código del curso a obtener.</param>
        /// <returns>El curso correspondiente o un nuevo objeto Curso si no se encuentra.</returns>
        public Curso ObtenerCursoPorCodigo(string codigo)
        {
            int.TryParse(codigo, out int codigoCurso);

            if (dictCursos.ContainsKey(codigoCurso))
            {
                return dictCursos[codigoCurso];
            }
            else
            {
                return new Curso("", "", "", "");
            }
        }


        /// <summary>
        /// Propiedad para obtener o establecer la ruta del archivo JSON de datos.
        /// </summary>
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
    }
}
