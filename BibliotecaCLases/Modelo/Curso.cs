using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Modelo
{
    public class Curso
    {
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private string _cupoMaximo;

        public Curso(string nombre, string codigo, string descripcion, string cupoMaximo) 
        { 
            _nombre = nombre;   
            _codigo = codigo;
            _descripcion = descripcion;
            _cupoMaximo = cupoMaximo;

        }
        public override string ToString()
        {
            return $"{Codigo,-19} {Nombre,-15} {Descripcion,-18} {CupoMaximo,9} cupos";
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

        public string CupoMaximo
        {
            get { return _cupoMaximo; }
            set { _cupoMaximo = value; }
        }


    }
}
