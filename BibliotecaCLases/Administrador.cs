namespace BibliotecaCLases
{
    public class Administrador : Usuario
    {
 
        public Administrador(string nombre, string apellido, string correo, string dni, string clave)
            : base(nombre, apellido, dni,correo, clave)
        {

        }





        // Método para registrar un nuevo estudiante
        public static Estudiante RegistrarEstudiante(string nombreEstudiante, string apellidoEstudiante, string correoEstudiante, string dniEstudiante, string claveEstudiante, string direccionEstudiante, string telefonoEstudiante, string claveProvisionalEstudiante)
        {
            Estudiante nuevoEstudiante = new(nombreEstudiante, apellidoEstudiante, correoEstudiante, dniEstudiante, claveEstudiante, direccionEstudiante, telefonoEstudiante, claveProvisionalEstudiante);

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
    }
}