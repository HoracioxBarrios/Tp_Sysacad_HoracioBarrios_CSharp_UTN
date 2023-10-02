using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    public class GestorCursos
    {
        private CrudCurso crudCurso;
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private string _cuposDisponibles;

        public GestorCursos(string nombre, string codigo, string descripcion, string cuposDisponibles)
        {
            crudCurso = new CrudCurso();
            _nombre = nombre;
            _codigo = codigo;
            _descripcion = descripcion;
            _cuposDisponibles = cuposDisponibles;
        }

        public void AgregarCurso(string nombre, string codigo, string descripcion, string cupoMaximo)
        {
            crudCurso.AgregarCurso(nombre, codigo, descripcion, cupoMaximo);
        }
    }
}
