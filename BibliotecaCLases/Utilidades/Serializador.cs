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
        public static void AgregarUltimoAJson<T>(T objetoAAgregar, string path)
        {
            try
            {
                List<T> objetosExistentes = new List<T>();

                // Si el archivo ya existe, lee el contenido actual
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    objetosExistentes = JsonConvert.DeserializeObject<List<T>>(json);
                }

                // Agrega el último objeto a la lista existente
                objetosExistentes.Add(objetoAAgregar);

                // Serializa la lista completa a formato JSON
                string jsonResult = JsonConvert.SerializeObject(objetosExistentes, Newtonsoft.Json.Formatting.Indented);

                // Guarda el JSON en el archivo especificado
                File.WriteAllText(path, jsonResult);

                Console.WriteLine($"El último dato se ha agregado correctamente al archivo JSON en: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar el último dato al archivo JSON: {ex.Message}");
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
