using System;
using System.Collections.Generic;
using System.IO;
using BibliotecaCLases.Modelo;
using Newtonsoft.Json;

namespace BibliotecaCLases.Utilidades
{
    /// <summary>
    /// Clase que proporciona métodos para la serialización y deserialización de objetos en formato JSON.
    /// </summary>
    public class Serializador : Archivo
    {
        public Serializador()
        {

        }
        /// <summary>
        /// Guarda un diccionario en formato JSON en el archivo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo de los valores del diccionario.</typeparam>
        /// <param name="objetoAGuardar">Diccionario a guardar.</param>
        /// <param name="path">Ruta del archivo donde se guardará el JSON.</param>
        public override void GuardarAJson<T>(Dictionary<int, T> objetoAGuardar, string path)
        {
            try
            {
                string json = JsonConvert.SerializeObject(objetoAGuardar, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(path, json);

                Console.WriteLine($"El diccionario se ha guardado correctamente como JSON en: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el diccionario como JSON: {ex.Message}");
            }
        }

        public static void GuardarAJson(int valorAGuardar, string path)
        {
            try
            {
                string json = JsonConvert.SerializeObject(valorAGuardar, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(path, json);

                Console.WriteLine($"El valor se ha guardado correctamente como JSON en: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el valor como JSON: {ex.Message}");
            }
        }

        /// <summary>
        /// Actualiza un archivo JSON con un diccionario.
        /// </summary>
        /// <typeparam name="T">Tipo de los valores del diccionario.</typeparam>
        /// <param name="diccionario">Diccionario a actualizar.</param>
        /// <param name="path">Ruta del archivo JSON.</param>
        public override void ActualizarJson<T>(Dictionary<int, T> diccionario, string path)
        {
            try
            {
                string jsonResult = JsonConvert.SerializeObject(diccionario, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(path, jsonResult);

                Console.WriteLine($"El diccionario se ha actualizado correctamente como JSON en: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el diccionario como JSON: {ex.Message}");
            }
        }

        public static void ActualizarJson<T>(T objetoAAgregar, int id, string path)
        {
            try
            {
                Dictionary<string, T> objetoExistente = new Dictionary<string, T>();

                if (File.Exists(path))
                {
                    string json = File.ReadAllText(path);
                    objetoExistente = JsonConvert.DeserializeObject<Dictionary<string, T>>(json);
                }
                int nuevaClave = id;
                string nuevaClaveStr = nuevaClave.ToString();

                objetoExistente[nuevaClaveStr] = objetoAAgregar;

                string jsonResult = JsonConvert.SerializeObject(objetoExistente, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(path, jsonResult);

                Console.WriteLine($"El último dato se ha agregado correctamente al archivo JSON en: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar el último dato al archivo JSON: {ex.Message}");
            }
        }

        /// <summary>
        /// Lee un archivo JSON y lo deserializa en un objeto del tipo especificado.
        /// </summary>
        /// <typeparam name="T">Tipo del objeto a deserializar.</typeparam>
        /// <param name="path">Ruta del archivo JSON.</param>
        /// <returns>El objeto deserializado.</returns>
        public override T LeerJson<T>(string path)
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
    }
}
