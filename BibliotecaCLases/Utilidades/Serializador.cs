using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace BibliotecaCLases.Utilidades
{
    public static class Serializador
    {
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
                    return JsonConvert.DeserializeObject<List<T>>(jsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
                }
            }

            return new List<T>();
        }

        public static void ActualizarJson() // Puedes implementar esto según tus necesidades.
        {
            // Implementa la lógica de actualización si es necesario.
        }

        public static void EliminarJson() // Puedes implementar esto según tus necesidades.
        {
            // Implementa la lógica de eliminación si es necesario.
        }
    }
}
