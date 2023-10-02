using System;
using System.Collections.Generic;
using System.Linq;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;


namespace BibliotecaCLases.Controlador
{
    public class CrudEstudiante
    {
        private Dictionary<int, Estudiante> dictEstudiantesRegistrados;
        private static int _contadorLegajos = 1000;
        private string _path;

        /// <summary>
        /// Constructor de la clase CrudEstudiante. Inicializa un nuevo objeto CrudEstudiante
        /// y carga datos de estudiantes registrados desde un archivo JSON si está disponible.
        /// </summary>
        public CrudEstudiante()
        {
            dictEstudiantesRegistrados = new Dictionary<int, Estudiante>();
            _path = PathManager.ObtenerRuta("Data", "Dict Estudiante.json");
            dictEstudiantesRegistrados = Serializador.LeerJson<Dictionary<int, Estudiante>>(_path);
        }
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        public int ContadorLegajos
        {
            get { return _contadorLegajos; }
            set { _contadorLegajos = value; }

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
        /// Encuentra el último número de legajo utilizado en el diccionario de estudiantes registrados y actualiza el contador de legajos.
        /// </summary>
        private void EncuentraUltimolegajo()
        {
            if (dictEstudiantesRegistrados != null && dictEstudiantesRegistrados.Count > 0)
            {
                // Obtén el último valor (Estudiante) del diccionario
                Estudiante ultimoEstudiante = dictEstudiantesRegistrados[dictEstudiantesRegistrados.Keys.Max()];

                int legajo = ultimoEstudiante.Legajo;
                _contadorLegajos = legajo;
            }

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
        /// <param name="claveProvisional">La clave provisional del estudiante.</param>
        /// <param name="debeCambiar">Indica si el estudiante debe cambiar la clave.</param>
        public void RegistrarEstudiante(string nombre, string apellido, string dni, string correo, string direccion, string telefono, string claveProvisional,bool debeCambiar)
        {
            this.EncuentraUltimolegajo();

            Estudiante nuevoEstudiante = new Estudiante(nombre, apellido, dni, correo, direccion, telefono, claveProvisional, debeCambiar);
            _contadorLegajos++;
            nuevoEstudiante.Legajo = _contadorLegajos;

            dictEstudiantesRegistrados.Add(nuevoEstudiante.Legajo, nuevoEstudiante);

            Serializador.ActualizarJson(nuevoEstudiante,_contadorLegajos,_path);

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
        /// Modifica el nombre de un estudiante en el diccionario de estudiantes registrados.
        /// </summary>
        /// <param name="estudianteId">El número de legajo del estudiante que se desea modificar.</param>
        /// <param name="nuevoNombre">El nuevo nombre que se asignará al estudiante.</param>
        /// <exception cref="KeyNotFoundException">Se lanza si no se encuentra un estudiante con el número de legajo especificado.</exception>
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


    }
}
