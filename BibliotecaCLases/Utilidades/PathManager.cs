using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Utilidades
{
    public class PathManager
    {
        public string nombreArchivo;
        public string nameFolder;

        // Número de niveles a retroceder en la jerarquía de directorios
        public int nivelesARetroceder; //Cambia esto según la cantidad de niveles que desees retroceder (4 para hubicar la carpeta Data)
        public static string ObtenerRuta(string nameFolder,string nombreArchivo, int nivelesARetroceder)
        {
            
            // Obtener el directorio de trabajo actual del programa
            string directorioDeTrabajo = Directory.GetCurrentDirectory();
            // Retroceder los niveles especificados
            string path = directorioDeTrabajo;
            for (int i = 0; i < nivelesARetroceder; i++)
            {
                path = Directory.GetParent(path).FullName;
            }

            // Agregar el nombre de la carpeta a la ruta
            path = Path.Combine(path, nameFolder);
            // Combinar la ruta con el nombre del archivo
            string rutaArchivo = Path.Combine(path, nombreArchivo);
            return rutaArchivo;

        }
        public static string ObtenerRuta(string nameFolder, string nombreArchivo)
        { 
            int nivelesARetroceder = 4;
            // Obtener el directorio de trabajo actual del programa
            string directorioDeTrabajo = Directory.GetCurrentDirectory();
            // Retroceder los niveles especificados
                string path = directorioDeTrabajo;
            for (int i = 0; i<nivelesARetroceder; i++)
            {
                path = Directory.GetParent(path).FullName;
            }
            // Agregar el nombre de la carpeta a la ruta
            path = Path.Combine(path, nameFolder);
            // Combinar la ruta con el nombre del archivo
            string rutaArchivo = Path.Combine(path, nombreArchivo);
            return rutaArchivo;
        }

internal void ObtenerRuta(string v1, object value, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
