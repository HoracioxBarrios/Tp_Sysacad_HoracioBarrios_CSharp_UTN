using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    public class CrudCurso
    {
        private Dictionary<int, Curso> dictCursos;
        private string _path;

        public CrudCurso()
        {
            dictCursos = new Dictionary<int, Curso>();
            _path = PathManager.ObtenerRuta("Data", "DictCurso.json");
            dictCursos = Serializador.LeerJson<Dictionary<int, Curso>>(_path);
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public void AgregarCurso(string nombre, string codigo, string descripcion, string cupoMaximo)
        {
            if (int.TryParse(codigo, out int codigoCurso))
            {
                if (!dictCursos.ContainsKey(codigoCurso))
                {
                    Curso nuevoCurso = new Curso(nombre, codigo, descripcion, cupoMaximo);

                    if (dictCursos != null)
                    {
                        dictCursos.Add(codigoCurso, nuevoCurso);
                    }

                    Serializador.ActualizarJson(nuevoCurso, codigoCurso, _path);
                }
                else
                {
                    Console.WriteLine("El código ya existe en el diccionario.");
                }
            }
            else
            {
                Console.WriteLine("El código no es válido como número entero.");
            }
        }

        public void ModificarCurso(int codigo, string nombre, string descripcion, string cupoMaximo)
        {
        }

        public void EliminarCurso(int codigo)
        {
        }

        public Dictionary<int, Curso> ObtenerDictCursos()
        {
            return dictCursos;
        }
    }
}
