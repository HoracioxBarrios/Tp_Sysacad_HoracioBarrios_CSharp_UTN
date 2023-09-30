using System;
using System.Collections.Generic;
using System.Linq;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;

namespace BibliotecaCLases.Controlador
{
    public class CrudEstudiante
    {
        private readonly List<Estudiante> estudiantesRegistrados;
        string nombre;
        string apellido;
        string correo;
        string dni;
        string direccion;
        string telefono;
        string claveProvisional;
        private static int contadorLegajos = 1;

        public CrudEstudiante()
        {
            estudiantesRegistrados = new List<Estudiante>();
        }
        public CrudEstudiante()
        {
            estudiantesRegistrados = new List<Estudiante>();
        }

        public string VerificarDatosEstudiante(string correo, string dni)
        {
            if (estudiantesRegistrados.Any(est => est.Correo == correo))
            {
                return "El correo electrónico ya está registrado.";
            }

            if (estudiantesRegistrados.Any(est => est.Dni == dni))
            {
                return "El número de identificación (DNI) ya está registrado.";
            }
            return "Datos son válidos";
        }

        public void RegistrarEstudiante(string nombre, string apellido, string correo, string dni, string direccion, string telefono, string claveProvisional, string pathJson)
        {
            Estudiante nuevoEstudiante = new Estudiante(nombre, apellido, correo, dni, direccion, telefono, claveProvisional);
            nuevoEstudiante.Legajo = contadorLegajos;
            contadorLegajos++;

            // Se agrega nuevoEstudiante a una lista o una base de datos de estudiantes registrados.
            estudiantesRegistrados.Add(nuevoEstudiante);

            // Serializar el nuevo estudiante a JSON y guardarlo en un archivo JSON.
            Serializador.GuardarAJson(estudiantesRegistrados, pathJson);
        }

        public List<Estudiante> ObtenerEstudiantesRegistrados()
        {
            return estudiantesRegistrados;
        }

        public void ModificarEstudiante(Estudiante estudiante)
        {
            if (estudiante is null)
            {
                throw new ArgumentNullException(nameof(estudiante));
            }
            // Realiza aquí las operaciones de modificación del estudiante.
        }

        public void EliminarEstudiante(Estudiante estudiante)
        {
            if (estudiante is null)
            {
                throw new ArgumentNullException(nameof(estudiante));
            }
            // Realiza aquí las operaciones de eliminación del estudiante.
            estudiantesRegistrados.Remove(estudiante);
        }
    }
}
