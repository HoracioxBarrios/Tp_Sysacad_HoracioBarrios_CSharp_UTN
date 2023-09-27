﻿using System;
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



        public static string GuardarAJson<T>(T objetoAGuardar, string path)
        {
            try
            {
                List<T> objetosExistente = new List<T>();

                // Verificar si el archivo ya existe y cargar sus contenidos si es así
                if (File.Exists(path))
                {
                    string jsonString = File.ReadAllText(path);
                    objetosExistente = JsonSerializer.Deserialize<List<T>>(jsonString);
                }

                // Agregar el nuevo objeto a la lista
                objetosExistente.Add(objetoAGuardar);

                // Serializar la lista completa y agregar saltos de línea entre objetos
                string jsonStringUpdated = JsonSerializer.Serialize(objetosExistente);

                // Agregar un salto de línea después de cada objeto en la lista
                jsonStringUpdated = string.Join(Environment.NewLine, jsonStringUpdated.Split('}'));

                File.WriteAllText(path, jsonStringUpdated);

                return $"Se ha guardado correctamente como JSON en: {path}";
            }
            catch (Exception ex)
            {
                return $"Error al guardar como JSON: {ex.Message}";
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

