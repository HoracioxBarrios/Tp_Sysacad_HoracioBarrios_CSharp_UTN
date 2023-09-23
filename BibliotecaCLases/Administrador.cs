namespace BibliotecaCLases
{
    public class Administrador
    {
        private string _nombre;
        private string _apellido;
        private string _correo;
        private string _dni;
        private string _clave;
        private string _nome;


        public Administrador(string nombre, string apellido, string correo, string dni, string clave)
        {
            _nombre = nombre;
            _apellido = apellido;
            _correo = correo;
            _dni = dni;
            _clave = clave;
        }


        public Estudiante RegistrarEstudiante(string nombreEstudiante, string apellidoEstudiante, string correoEstudiante, string dniEstudiante, string claveEstudiante, string direccionEstudiante, string telefonoEstudiante, string claveProvisionalEstudiante)
        {
            Estudiante nuevoEstudiante = new Estudiante(nombreEstudiante, apellidoEstudiante, correoEstudiante, dniEstudiante, claveEstudiante, direccionEstudiante, telefonoEstudiante, claveProvisionalEstudiante);

            return nuevoEstudiante;


        }

        public void ModificarEstudiante()
        {
            // hacer algo
        }
    }
}