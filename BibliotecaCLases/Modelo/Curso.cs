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
        private int _medioTiempo = 2;
        private int _tiempoCompleto = 4;
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

        public Curso(string nombre, string codigo, string descripcion, string cupoMaximo)
        {
            _nombre = nombre;
            _codigo = codigo;
            _descripcion = descripcion;
            _cuposDisponibles = _cupoMaximo;
            _activo = true;

            if (int.TryParse(cupoMaximo, out int cupoMaximoValor))
            {
                _cupoMaximo = cupoMaximoValor;
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

        public dias Dias
        {
            get { return _dias; }
            set { _dias = value; }
        }
        public dias[] TodosLsDias
        {
            get { return (dias[])Enum.GetValues(typeof(dias)); }
        }
        public horarios Horarios
        {
            get { return _horarios; }
            set { _horarios = value; }
        }
        public horarios[] TodosLosHorarios
        {
            get { return (horarios[])Enum.GetValues(typeof(horarios)); }
        }
        public aulas Aulas
        {
            get { return _aulas; }
            set { _aulas = value; }
        }
        public aulas[] TodasLasAulas
        {
            get { return (aulas[])Enum.GetValues(typeof(aulas)); }
        }
    }
}
