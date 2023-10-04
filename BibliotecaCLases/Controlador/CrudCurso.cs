using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    public class CrudCurso
    {
        private Dictionary<string, Curso> dictCursos;
        private string _path;

        public CrudCurso()
        {
            dictCursos = new Dictionary<string, Curso>();
            _path = PathManager.ObtenerRuta("Data", "DictCurso.json");

            // Leer el diccionario desde el archivo JSON
            dictCursos = Serializador.LeerJson<Dictionary<string, Curso>>(_path);
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public string AgregarCurso(string nombre, string codigo, string descripcion, string cupoMaximo)
        {
            if (!dictCursos.ContainsKey(codigo))
            {
                Curso nuevoCurso = new Curso(nombre.ToUpper(), codigo, descripcion, cupoMaximo);
                dictCursos.Add(codigo, nuevoCurso);

                // Actualizar el archivo JSON con el nuevo curso
                Serializador.ActualizarJson(nuevoCurso, codigo, _path);

                return "Se Agregó correctamente";
            }
            else
            {
                return "El código ya existe en el diccionario.";
            }
        }

        public string EditarCurso(string codigo, string nombreAtributo, string nuevoValor)
        {
            if (dictCursos.ContainsKey(codigo))
            {
                Curso cursoExistente = dictCursos[codigo];

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
                Serializador.ActualizarJson(cursoExistente, codigo, _path);
                return "Se modificó correctamente";
            }
            else
            {
                return "El curso no existe en el diccionario.";
            }
        }

        public string EliminarCurso(string codigo)
        {
            if (dictCursos.ContainsKey(codigo))
            {
                // Si el curso existe en el diccionario, elimínalo
                dictCursos.Remove(codigo);

                // Actualizar el archivo JSON sin el curso eliminado
                Serializador.GuardarAJson(dictCursos, _path);

                return "Se Eliminó el curso";
            }
            else
            {
                return "El curso no existe en el diccionario.";
            }
        }
    }
}
