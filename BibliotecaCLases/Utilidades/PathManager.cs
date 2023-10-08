using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Utilidades
{
    /// <summary>
    /// Clase que proporciona métodos para gestionar rutas de archivos y carpetas.
    /// </summary>
    public class PathManager
    {
        public string nombreArchivo;
        public string nameFolder;
        public int nivelesARetroceder;

        /// <summary>
        /// Obtiene la ruta completa de un archivo ubicado en una carpeta específica con la opción de retroceder niveles.
        /// </summary>
        /// <param name="nameFolder">Nombre de la carpeta.</param>
        /// <param name="nombreArchivo">Nombre del archivo.</param>
        /// <param name="nivelesARetroceder">Número de niveles a retroceder desde la carpeta actual.</param>
        /// <returns>La ruta completa del archivo.</returns>
        public static string ObtenerRuta(string nameFolder,string nombreArchivo, int nivelesARetroceder)
        {
            string directorioDeTrabajo = Directory.GetCurrentDirectory();
            string path = directorioDeTrabajo;
            for (int i = 0; i < nivelesARetroceder; i++)
            {
                path = Directory.GetParent(path).FullName;
            }

            path = Path.Combine(path, nameFolder);
            string rutaArchivo = Path.Combine(path, nombreArchivo);
            return rutaArchivo;

        }

        /// <summary>
        /// Obtiene la ruta completa de un archivo ubicado en una carpeta específica sin retroceder niveles.
        /// </summary>
        /// <param name="nameFolder">Nombre de la carpeta.</param>
        /// <param name="nombreArchivo">Nombre del archivo.</param>
        /// <returns>La ruta completa del archivo.</returns>
        public static string ObtenerRuta(string nameFolder, string nombreArchivo)
        { 
            int nivelesARetroceder = 4;
            string directorioDeTrabajo = Directory.GetCurrentDirectory();
                string path = directorioDeTrabajo;
            for (int i = 0; i<nivelesARetroceder; i++)
            {
                path = Directory.GetParent(path).FullName;
            }
            path = Path.Combine(path, nameFolder);
            string rutaArchivo = Path.Combine(path, nombreArchivo);
            return rutaArchivo;
        }
    }
}
