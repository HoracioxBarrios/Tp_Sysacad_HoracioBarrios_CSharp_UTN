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
                // El archivo JSON no existe, crea un nuevo diccionario vacío
                dictCursos = new Dictionary<int, Curso>();
                Curso.SetUltimoID(0); // Establecer el último ID en 0
            }
            else
            {
                // Leer el diccionario desde el archivo JSON
                dictCursos = Serializador.LeerJson<Dictionary<int, Curso>>(_path);

                if (dictCursos == null || dictCursos.Count == 0)
                {
                    // No hay cursos en el archivo JSON o el diccionario es nulo, establecer el primer ID en "1"
                    dictCursos = new Dictionary<int, Curso>();
                    dictCursos.Add(1, new Curso("", "1", "", ""));
                    Curso.SetUltimoID(1); // Establecer el último ID en 1
                }
                else
                {
                    // Encontrar el último ID utilizado y actualizar el último ID
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
            int nuevaID = obtenerSiguienteID(); // Generar ID basado en el último ID utilizado
            Curso nuevoCurso = new Curso(nombre, codigo, descripcion, cupoMaximo, nuevaID); // Pasa el nuevo ID
            nuevoCurso.Activo = true; // Establecer el estado activo como verdadero por defecto

            if (dictCursos != null)
            {
                dictCursos.Add(nuevaID, nuevoCurso); // Usar la nuevaID como clave
                Serializador.ActualizarJson(nuevoCurso, nuevaID.ToString(), _path); // Actualizar el archivo JSON con el nuevo curso
            }
        }

        private int obtenerSiguienteID()
        {
            // Obtener el último ID utilizado y agregar 1 para el próximo curso
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

                    // Modificar los atributos del curso existente con los nuevos valores
                    cursoExistente.Nombre = nuevoNombre;
                    cursoExistente.Descripcion = nuevaDescripcion;
                    cursoExistente.CupoMaximo = int.Parse(nuevoCupoMaximo);

                    // Actualizar el archivo JSON con el diccionario completo
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
                // Manejar cualquier excepción que ocurra al actualizar el archivo JSON
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
                // En lugar de null, puedes devolver un nuevo objeto Curso vacío o manejar el caso según tus necesidades.
                return new Curso("", "", "", "");
            }
        }

        public string EliminarCurso(string codigo)
        {
            int.TryParse(codigo, out int codigoCurso);
            int claveCurso = codigoCurso;

            if (dictCursos.ContainsKey(claveCurso))
            {
                // Si el curso existe en el diccionario, elimínalo
                dictCursos.Remove(claveCurso);
                // Actualizar el archivo JSON con el diccionario completo
                Serializador.ActualizarJson(dictCursos, _path);
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
