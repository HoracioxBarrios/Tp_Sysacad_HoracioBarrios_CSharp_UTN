using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Utilidades
{
    public class PathManager
    {
        public static string ObtenerRuta(string nameFolder, string nombreArchivo)
        {
            // Obtener el directorio de trabajo actual del programa
            string directorioDeTrabajo = Directory.GetCurrentDirectory();

            // Número de niveles a retroceder en la jerarquía de directorios
            int nivelesARetroceder = 4; // Cambia esto según la cantidad de niveles que desees retroceder

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
    }
}
