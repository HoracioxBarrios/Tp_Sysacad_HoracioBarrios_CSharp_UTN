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

        public void AgregarCurso(string nombre, string codigo, string descripcion, string cupoMaximo)
        {
            int.TryParse(codigo, out int codigoCurso);
            Curso nuevoCurso = new Curso(nombre, codigo, descripcion, cupoMaximo);

            if (dictCursos != null)
            {
                dictCursos.Add(codigoCurso, nuevoCurso);
            }

            Serializador.ActualizarJson(nuevoCurso, codigoCurso, _path);
        }

        public string EditarCurso(string codigo, string nombreAtributo, string nuevoValor)
        {
            int.TryParse(codigo, out int codigoCurso);
            if (dictCursos.ContainsKey(codigoCurso))
            {
                Curso cursoExistente = dictCursos[codigoCurso];
                // Realizar validaciones si es necesario y modificar el curso
                switch (nombreAtributo)
                {
                    case "Nombre":
                        cursoExistente.Nombre = nuevoValor;
                        break;
                    case "Descripcion":
                        cursoExistente.Descripcion = nuevoValor;
                        break;
                    case "CupoMaximo":
                        cursoExistente.CupoMaximo = nuevoValor;
                        break;
                    default:
                        return "El nombre del atributo no es válido.";
                }
                // Actualizar el archivo JSON con el curso modificado
                Serializador.ActualizarJson(cursoExistente, codigoCurso, _path);
                return "Se modificó correctamente";
            }
            else
            {
                return "El curso no existe en el diccionario.";
            }
        }
        public string EliminarCurso(string codigo)
        {
            int.TryParse(codigo, out int codigoCurso);
            if (dictCursos.ContainsKey(codigoCurso))
            {
                // Si el curso existe en el diccionario, elimínalo
                dictCursos.Remove(codigoCurso);
                // Actualizar el archivo JSON sin el curso eliminado
                Serializador.GuardarAJson(dictCursos, _path);
                return "Se Eliminó el curso";
            }
            else
            {
                return "El curso no existe en el diccionario.";
            }
        }

        public Dictionary<int, Curso> ObtenerDictCursos()
        {
            return dictCursos;
        }
    }
}
