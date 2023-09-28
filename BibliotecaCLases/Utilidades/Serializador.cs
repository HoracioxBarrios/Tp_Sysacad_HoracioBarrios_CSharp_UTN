using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System.Xml;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace BibliotecaCLases.Utilidades
{
    public static class Serializador
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

            return default;
        }

        public static void GuardarAJson<T>(List<T> objetoAGuardar, string path)
        {
            try
            {
                // Serializar la lista a formato JSON
                string json = JsonConvert.SerializeObject(objetoAGuardar, Newtonsoft.Json.Formatting.Indented);

                // Guardar el JSON en el archivo especificado
                File.WriteAllText(path, json);

                Console.WriteLine($"La lista se ha guardado correctamente como JSON en: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar la lista como JSON: {ex.Message}");
            }
        }


        public static List<T> LeerJson<T>(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    string jsonString = File.ReadAllText(path);
                    return JsonSerializer.Deserialize<List<T>>(jsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
                }
            }

            return new List<T>();
        }
    }


}


