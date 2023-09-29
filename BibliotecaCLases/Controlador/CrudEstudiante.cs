using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCLases.Modelo;

namespace BibliotecaCLases.Controlador
{
    public class CrudEstudiante
    {
        //private readonly List<Usuario> usuarios;
        private readonly List<Estudiante> estudiantesRegistrados;
        private static int contadorLegajos = 1;

        public CrudEstudiante()
        {
            estudiantesRegistrados = new List<Estudiante>();


        }
        public string VerificarDatosEstudiantes(string nombre, string apellido, string correo, string dni, string direccion, string telefono, string claveProvisional)
        {
            if (estudiantesRegistrados.Any(est => est.Correo == correo))
            {
                return "El correo electrónico ya está registrado.";
            }

            if (estudiantesRegistrados.Any(est => est.Dni == dni))
            {
                return "El número de identificación (DNI) ya está registrado.";
            }
            return "Datos son Validos";
        }

        public string RegistrarEstudiante(string nombre, string apellido, string correo, string dni, string direccion, string telefono, string claveProvisional)
        {


            Estudiante nuevoEstudiante = new Estudiante(nombre, apellido, correo, dni, direccion, telefono, claveProvisional);

            nuevoEstudiante.Legajo = contadorLegajos;
            contadorLegajos++;

            // Se agrega nuevoEstudiante a una lista o una base de datos de estudiantes registrados.
            estudiantesRegistrados.Add(nuevoEstudiante);
            // hay que serializar la lista a json ---- no necesariamente en este metodo
            return "Se creo";
          
        }

        public static void ModificarEstudiante(Estudiante estudiante)
        {
            if (estudiante is null)
            {
                throw new ArgumentNullException(nameof(estudiante));
            }
            // Realiza aquí las operaciones de modificación del estudiante.
        }
        public static void EliminarEstudiante()
        {
            // eliminar
        }

    }
}