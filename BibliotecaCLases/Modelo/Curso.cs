using System;
using static BibliotecaCLases.Modelo.Curso;

namespace BibliotecaCLases.Modelo
{
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
        public enum dias
        {
            Lunes = 0,
            Martes = 1,
            Miercoles = 2,
            Jueves = 3,
            Viernes = 4
        }
        private dias _dias;
        public enum aulas
        {
            Aula206 = 0,
            Aula207 = 1,
            Aula208 = 2,
            Aula306 = 3,
            Aula307 = 4,
            Aula308 = 5,
        }
        private aulas _aulas;
        public enum horarios
        {
            Mañana = 0,
            Tarde = 1,
            Noche = 2
        }
        private horarios _horarios;

        public Curso()
        {

        }

        public Curso(string nombre, string codigo, string descripcion, string cupoMaximo)
        {
            _nombre = nombre;
            _codigo = codigo;
            _descripcion = descripcion;
            _activo = true;

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

        public override string ToString()
        {
            return $"{Codigo,-19} {Nombre,-15} {Descripcion,-18} {CupoMaximo,9} cupos {CuposDisponibles,15} cupos disponibles";
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public int CupoMaximo
        {
            get { return _cupoMaximo; }
            set { _cupoMaximo = value; }
        }

        public int CuposDisponibles
        {
            get { return _cuposDisponibles; }
            set { _cuposDisponibles = value; }
        }

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public string DiaGetSet
        {
            get { return _dia; }
            set { _dia = value; }
        }

        public string HorarioGetSet
        {
            get { return _horario; }
            set { _horario = value; }
        }

        public string AulaGetSet
        {
            get { return _aula; }
            set { _aula = value; }
        }


        public dias Dias
        {
            get { return _dias; }
            set { _dias = value; }
        }
        public horarios Horarios
        {
            get { return _horarios; }
            set { _horarios = value; }
        }
        public aulas Aulas
        {
            get { return _aulas; }
            set { _aulas = value; }
        }
    }
}
