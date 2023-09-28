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
        private int contadorLegajos;

        public CrudEstudiante()
        {
            estudiantesRegistrados = new List<Estudiante>();
            contadorLegajos = 1;

            Estudiante estudianteEjemplo = new Estudiante("Estudiante", "Ejemplo", "ejemplo@correo.com", "123456789", "Direccion", "12345", "clave123");
            estudiantesRegistrados.Add(estudianteEjemplo);
            Console.WriteLine(estudiantesRegistrados);
        }

        public Estudiante RegistrarEstudiante(string nombre, string apellido, string correo, string dni, string direccion, string telefono, string claveProvisional)
        {
            if (estudiantesRegistrados.Any(est => est.Correo == correo))
            {
                throw new InvalidOperationException("El correo electrónico ya está registrado.");
            }

            if (estudiantesRegistrados.Any(est => est.Dni == dni))
            {
                throw new InvalidOperationException("El número de identificación (DNI) ya está registrado.");
            }

            Estudiante nuevoEstudiante = new Estudiante(nombre, apellido, correo, dni, direccion, telefono, claveProvisional);

            nuevoEstudiante.Legajo = contadorLegajos;
            contadorLegajos++;

            // Se agrega nuevoEstudiante a una lista o una base de datos de estudiantes registrados.
            estudiantesRegistrados.Add(nuevoEstudiante);

            return nuevoEstudiante;
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