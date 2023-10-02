using System;
using System.Collections.Generic;
using System.IO;
using BibliotecaCLases.Modelo;
using Newtonsoft.Json;

namespace BibliotecaCLases.Utilidades
{
    public static class Serializador
    {
        public static void GuardarAJson<T>(Dictionary<int, T> objetoAGuardar, string path)
        {
            try
            {
                // Serializar el diccionario a formato JSON
                string json = JsonConvert.SerializeObject(objetoAGuardar, Newtonsoft.Json.Formatting.Indented);

                // Guardar el JSON en el archivo especificado
                File.WriteAllText(path, json);

                Console.WriteLine($"El diccionario se ha guardado correctamente como JSON en: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el diccionario como JSON: {ex.Message}");
            }
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

        public static void ActualizarJson<T>(T objetoAAgregar,int id ,string path)
        {

            try
            {
                Dictionary<string, T> objetoExistente = new Dictionary<string, T>();

                // Si el archivo ya existe, lee el contenido actual
                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    objetoExistente = JsonConvert.DeserializeObject<Dictionary<string, T>>(json);
                }
                int nuevaClave = id;
                string nuevaClaveStr = nuevaClave.ToString();

                // Agrega el nuevo objeto al diccionario existente
                objetoExistente[nuevaClaveStr] = objetoAAgregar;

                // Serializa el diccionario completo a formato JSON
                string jsonResult = JsonConvert.SerializeObject(objetoExistente, Newtonsoft.Json.Formatting.Indented);

                // Guarda el JSON en el archivo especificado
                File.WriteAllText(path, jsonResult);

                Console.WriteLine($"El último dato se ha agregado correctamente al archivo JSON en: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar el último dato al archivo JSON: {ex.Message}");
            }
        }

        public static T LeerJson<T>(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    string jsonString = File.ReadAllText(path);
                    return JsonConvert.DeserializeObject<T>(jsonString);
                }
                else
                {
                    Console.WriteLine($"El archivo JSON no existe en la ruta: {path}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
            }

            return default(T);
        }


   

        public static void EliminarJson() // Puedes implementar esto según tus necesidades.
        {
            // Implementa la lógica de eliminación si es necesario.
        }
    }
}
