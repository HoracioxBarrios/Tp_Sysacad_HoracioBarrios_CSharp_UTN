using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace BibliotecaCLases
{
    public static class DataManager
    {



        /// <summary>
        /// Guarda un objeto de tipo genérico en formato XML.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a guardar.</typeparam>
        /// <param name="objetoAGuardar">Objeto a guardar.</param>
        /// <param name="path">Ruta del archivo XML.</param>
        /// <returns>Un mensaje que indica si la operación se ha realizado con éxito.</returns>
        public static string GuardarAXml<T>(T objetoAGuardar, string path)
        {
            try
            {
                using (var writer = new StreamWriter(path))
                {
                    var xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(writer, objetoAGuardar);
                }

                return $"Se ha guardado correctamente como XML en: {path}";
            }
            catch (Exception ex)
            {
                return $"Error al guardar como XML: {ex.Message}";
            }
        }



        /// <summary>
        /// Lee un archivo XML y lo deserializa en un objeto.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a deserializar.</typeparam>
        /// <param name="path">Ruta del archivo XML.</param>
        /// <returns>El objeto deserializado o el valor predeterminado de su tipo si ocurre un error.</returns>
        public static T LeerXml<T>(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    using (var reader = new StreamReader(path))
                    {
                        var xmlSerializer = new XmlSerializer(typeof(T));
                        return (T)xmlSerializer.Deserialize(reader);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al leer el archivo XML: {ex.Message}");
                }
            }

            return default(T);
        }





        /// <summary>
        /// Guarda un objeto de tipo genérico en formato JSON.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a guardar.</typeparam>
        /// <param name="objetoAGuardar">Objeto a guardar.</param>
        /// <param name="path">Ruta del archivo JSON.</param>
        /// <returns>Un mensaje que indica si la operación se ha realizado con éxito.</returns>
        public static string GuardarAJson<T>(T objetoAGuardar, string path)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(objetoAGuardar);
                File.WriteAllText(path, jsonString);
                return $"Se ha guardado correctamente como JSON en: {path}";
            }
            catch (Exception ex)
            {
                return $"Error al guardar como JSON: {ex.Message}";
            }
        }

        /// <summary>
        /// Lee un archivo JSON y lo deserializa en un objeto.
        /// </summary>
        /// <typeparam name="T">Tipo de objeto a deserializar.</typeparam>
        /// <param name="path">Ruta del archivo JSON.</param>
        /// <returns>El objeto deserializado o el valor predeterminado de su tipo si ocurre un error.</returns>
        public static T LeerJson<T>(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    string jsonString = File.ReadAllText(path);
                    return JsonSerializer.Deserialize<T>(jsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
                }
            }

            return default(T);
        }
    }
}


