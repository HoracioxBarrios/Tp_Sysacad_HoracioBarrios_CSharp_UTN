using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases
{
    public class ScrumEstudiante
    {
        private readonly List<Usuario> usuarios;


        public ScrumEstudiante()
        {

            /*
            usuarios = new List<Usuario>
            {
             new Administrador("Alexis", "Aranda", "alexisaranda", "111", "111"),
             new Administrador("Hora", "Barrios",  "horabarrios","222", "222")

             // Agregar más administradores según sea necesario
            };*/

        }

        // Método para registrar un nuevo estudiante
        public static Estudiante RegistrarEstudiante(string nombre, string apellido, string correo, string dni, string direccion, string telefono, string claveProvisional)
        {
             Estudiante nuevoEstudiante = new Estudiante(nombre, apellido, correo, dni, direccion, telefono, claveProvisional);

            // Aquí deberías agregar nuevoEstudiante a una lista o una base de datos de estudiantes registrados.
            // Ejemplo: estudiantesRegistrados.Add(nuevoEstudiante);

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