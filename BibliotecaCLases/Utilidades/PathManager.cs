using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Utilidades
{
    public class PathManager
    {
        public static string ObtenerRuta(string nombreCarpeta, string nombreArchivo)
        {
            string directorioActual = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(directorioActual, nombreCarpeta);

            if (!Directory.Exists(nombreCarpeta))
            {
                // Puedes manejar la situación en la que la carpeta no exista, lanzar una excepción o realizar otra acción.
                throw new DirectoryNotFoundException($"La carpeta '{nombreCarpeta}' no existe en '{directorioActual}'.");
            }

            string rutaArchivo = Path.Combine(nombreCarpeta, nombreArchivo);
            return rutaArchivo;
        }
    }
}
