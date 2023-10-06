using System;

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
    }
}
