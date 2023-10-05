using System;
using System.Collections.Generic;
using System.IO;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;
using Newtonsoft.Json;

namespace BibliotecaCLases.Controlador
{
    public class CrudCurso
    {
        private Dictionary<int, Curso> dictCursos;
        private string _path;

        public CrudCurso()
        {
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
                Serializador.ActualizarJson(nuevoCurso, codigoCurso, _path);
            }
        }

        public string EditarCurso(string codigo, string nuevoNombre, string nuevaDescripcion, string nuevoCupoMaximo)
        {
            int.TryParse(codigo, out int codigoCurso);

            try
            {
                if (dictCursos.ContainsKey(codigoCurso))
                {
                    Curso cursoExistente = dictCursos[codigoCurso];

                    cursoExistente.Nombre = nuevoNombre;
                    cursoExistente.Descripcion = nuevaDescripcion;
                    cursoExistente.CupoMaximo = int.Parse(nuevoCupoMaximo);

                    Serializador.ActualizarJson(dictCursos, _path);
                    return "Se modificó correctamente";
                }
                else
                {
                    return "El curso no existe en el diccionario.";
                }
            }
            catch (Exception ex)
            {
                return "Error al guardar los cambios: " + ex.Message;
            }
        }

        public Curso ObtenerCursoPorCodigo(string codigo)
        {
            int.TryParse(codigo, out int codigoCurso);

            if (dictCursos.ContainsKey(codigoCurso))
            {
                return dictCursos[codigoCurso];
            }
            else
            {
                return new Curso("", "", "", "");
            }
        }

        public string EliminarCurso(Curso curso)
        {
            int.TryParse(curso.Codigo, out int codigoCurso);

            if (dictCursos.ContainsKey(codigoCurso))
            {
                Curso cursoAEliminar = dictCursos[codigoCurso];

                cursoAEliminar.Activo = false;

                Serializador.ActualizarJson(dictCursos, _path);

                return "Se realizó la eliminación lógica del curso";
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
