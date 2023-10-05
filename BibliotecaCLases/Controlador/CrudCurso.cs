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

            if (!File.Exists(_path))
            {
                dictCursos = new Dictionary<int, Curso>();
                Curso.SetUltimoID(0);
            }
            else
            {
                dictCursos = Serializador.LeerJson<Dictionary<int, Curso>>(_path);

                if (dictCursos == null || dictCursos.Count == 0)
                {
                    dictCursos = new Dictionary<int, Curso>();
                    dictCursos.Add(1, new Curso("", "1", "", ""));
                    Curso.SetUltimoID(1);
                }
                else
                {
                    int ultimoID = dictCursos.Keys.Max();
                    Curso.SetUltimoID(ultimoID);
                }
            }
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
                if (dictCursos.ContainsKey(int.Parse(codigo)))
                {
                    return 1;
                }
            }

            return 0;
        }

        public void AgregarCurso(string nombre, string codigo, string descripcion, string cupoMaximo)
        {
            int nuevaID = obtenerSiguienteID();
            Curso nuevoCurso = new Curso(nombre, codigo, descripcion, cupoMaximo, nuevaID);
            nuevoCurso.Activo = true;

            if (dictCursos != null)
            {
                dictCursos.Add(nuevaID, nuevoCurso);
                Serializador.ActualizarJson(nuevoCurso, nuevaID.ToString(), _path);
            }
        }

        private int obtenerSiguienteID()
        {
            int ultimoID = Curso.GetUltimoID();
            return ultimoID + 1;
        }

        public string EditarCurso(string codigo, string nuevoNombre, string nuevaDescripcion, string nuevoCupoMaximo)
        {
            int.TryParse(codigo, out int codigoCurso);

            try
            {
                int claveCurso = codigoCurso;

                if (dictCursos.ContainsKey(claveCurso))
                {
                    Curso cursoExistente = dictCursos[claveCurso];

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

            int claveCurso = codigoCurso;

            if (dictCursos.ContainsKey(claveCurso))
            {
                return dictCursos[claveCurso];
            }
            else
            {
                return new Curso("", "", "", "");
            }
        }

        public string EliminarCurso(Curso curso)
        {
            int idCursoAEliminar = curso.ID;

            if (dictCursos.ContainsKey(idCursoAEliminar))
            {
                Curso cursoAEliminar = dictCursos[idCursoAEliminar];

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
