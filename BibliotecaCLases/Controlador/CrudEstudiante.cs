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
        private static int contadorLegajos = 0;


        public CrudEstudiante()
        {
            estudiantesRegistrados = new List<Estudiante>();

            string path = PathManager.ObtenerRuta("Data", "Estudiante.json");
            estudiantesRegistrados = Serializador.LeerJson<Estudiante>(path);
        
        }

        public int VerificarDatosEstudiante(string correo, string dni)
        {

            if (estudiantesRegistrados.Any(est => est.Correo == correo))
            {   
                return 1;
            }
            if (estudiantesRegistrados.Any(est => est.Dni == dni))
            {   
                return 2;
            }
            return 0;

        }
        private void EncuentraUltimolegajo()
        {
            if (estudiantesRegistrados.Count > 0)
            {
                Estudiante ultimoEstudiante = estudiantesRegistrados[estudiantesRegistrados.Count - 1];
                int legajo =ultimoEstudiante.Legajo;
                contadorLegajos = legajo;
            }

        }
        public void RegistrarEstudiante(string nombre, string apellido, string dni, string correo, string direccion, string telefono, string claveProvisional)
        {
            this.EncuentraUltimolegajo();
            string pathEstudiante = PathManager.ObtenerRuta("Data","Estudiante.json");

            Estudiante nuevoEstudiante = new Estudiante(nombre, apellido, dni, correo, direccion, telefono, claveProvisional);
            contadorLegajos++;
            nuevoEstudiante.Legajo = contadorLegajos;

            // Se agrega nuevoEstudiante a una lista o una base de datos de estudiantes registrados.
            estudiantesRegistrados.Add(nuevoEstudiante);

            // Serializar el nuevo estudiante a JSON y guardarlo en un archivo JSON.
            Serializador.AgregarUltimoAJson(nuevoEstudiante, pathEstudiante);
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
