using System;
using static BibliotecaCLases.Modelo.Curso;

namespace BibliotecaCLases.Modelo
{
    /// <summary>
    /// Clase que representa un curso.
    /// </summary>
    public class Curso
    {
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private int _cupoMaximo;
        private int _cuposDisponibles;
        private bool _activo;
        private string _aula;
        private string _dia;
        private string _horario;

        /// <summary>
        /// Enumeración que define los días de la semana.
        /// </summary>
        public enum dias
        {
            Lunes = 0,
            Martes = 1,
            Miercoles = 2,
            Jueves = 3,
            Viernes = 4
        }

        /// <summary>
        /// Enumeración que define los días de la semana.
        /// </summary>
        public enum aulas
        {
            Aula206 = 0,
            Aula207 = 1,
            Aula208 = 2,
            Aula306 = 3,
            Aula307 = 4,
            Aula308 = 5,
        }

        /// <summary>
        /// Enumeración que define los horarios disponibles.
        /// </summary>
        public enum horarios
        {
            Mañana = 0,
            Tarde = 1,
            Noche = 2
        }

        /// <summary>
        /// Constructor de la clase Curso.
        /// </summary>
        /// <param name="nombre">Nombre del curso.</param>
        /// <param name="codigo">Código del curso.</param>
        /// <param name="descripcion">Descripción del curso.</param>
        /// <param name="cupoMaximo">Cupo máximo del curso.</param>
        /// <param name="dia">Día del curso.</param>
        /// <param name="horario">Horario del curso.</param>
        /// <param name="aula">Aula del curso.</param>
        public Curso(string nombre, string codigo, string descripcion, string cupoMaximo, string dia, string horario, string aula)
        {
            _nombre = nombre;
            _codigo = codigo;
            _descripcion = descripcion;
            _activo = true;
            _aula = aula;
            _horario = horario;
            _dia = dia;

            if (int.TryParse(cupoMaximo, out int cupoMaximoValor))
            {
                _cupoMaximo = cupoMaximoValor;
                _cuposDisponibles = _cupoMaximo;
            }
            else
            {
                _cupoMaximo = 0;
            }
        }

        /// <summary>
        /// Devuelve una representación en formato de cadena del curso.
        /// </summary>
        public override string ToString()
        {
            return $"{Codigo,-19} {Nombre,-15} {Descripcion,-18} {CupoMaximo,9} cupos {CuposDisponibles,15} cupos disponibles";
        }

        /// <summary>
        /// Propiedad que obtiene o establece el nombre del curso.
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        /// <summary>
        /// Propiedad que obtiene o establece el código del curso.
        /// </summary>
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        /// <summary>
        /// Propiedad que obtiene o establece la descripción del curso.
        /// </summary>
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        /// <summary>
        /// Propiedad que obtiene o establece el cupo máximo del curso.
        /// </summary>
        public int CupoMaximo
        {
            get { return _cupoMaximo; }
            set { _cupoMaximo = value; }
        }

        /// <summary>
        /// Propiedad que obtiene o establece el número de cupos disponibles en el curso.
        /// </summary>
        public int CuposDisponibles
        {
            get { return _cuposDisponibles; }
            set { _cuposDisponibles = value; }
        }

        /// <summary>
        /// Propiedad que obtiene o establece el estado activo o inactivo del curso.
        /// </summary>
        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        /// <summary>
        /// Propiedad que obtiene o establece el día de la semana del curso.
        /// </summary>
        public string Dia
        {
            get { return _dia; }
            set { _dia = value; }
        }

        /// <summary>
        /// Propiedad que obtiene o establece el horario del curso.
        /// </summary>
        public string Horario
        {
            get { return _horario; }
            set { _horario = value; }
        }

        /// <summary>
        /// Propiedad que obtiene o establece el aula del curso.
        /// </summary>
        public string Aula
        {
            get { return _aula; }
            set { _aula = value; }
        }
    }
}
