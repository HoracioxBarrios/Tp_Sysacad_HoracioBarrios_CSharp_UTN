using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;

namespace BibliotecaCLases.Controlador
{
    public class GestorRegistroEstudiantes
    {
        private CrudEstudiante crudEstudiante;
        private bool _validado;
        private string _nombre;
        private string _apellido;
        private string _correo;
        private string _dni;
        private string _direccion;
        private string _telefono;
        private string _claveProvisional;
        public ValidadorDatosRegistro validadorDatosRegistro;
        private string _mensajeError;
        //private string _mensajeErrorDatosExistente;

        public GestorRegistroEstudiantes(string nombre ,string apellido ,string dni, string correo, string direccion,string telefono , string claveProvisional)
        {
            // aca tener todos los datos mientras vemos si son correctos 
             validadorDatosRegistro =  new ValidadorDatosRegistro(nombre, apellido,dni, correo, direccion, telefono, claveProvisional);

            _validado = validadorDatosRegistro.Validar(out string mensajeError);
         
            if (this.Validado)
            {
                crudEstudiante = new CrudEstudiante();
                _nombre = nombre;
                _apellido = apellido;
                _dni = dni;
                _correo = correo;
                _direccion = direccion;
                _telefono = telefono;
                _claveProvisional = claveProvisional;
            }
            else
            {
                _mensajeError = mensajeError;
            }

        }
        public bool Validado
        {
            get { return _validado; }
        }

        public string MensajeError
        {
            get { return _mensajeError; }
        }

        public bool verificardatosExistentes()
        {
            int numeroError = crudEstudiante.VerificarDatosEstudiante(_correo, _dni);

            if (numeroError == 1)
            {
                _mensajeError = "Error: El correo electrónico ya está registrado.";
                return false;
            }
            else if (numeroError == 2)
            {
                _mensajeError = "Error: El número de identificación (DNI) ya está registrado.";
                return false;
            }

            return true ;
            }
        public void RegistrarEstudiante(string nombre, string apellido,  string dni, string correo, string direccion, string telefono, string claveProvisional, bool debeCambiar)
        {
            
            crudEstudiante.RegistrarEstudiante(nombre, apellido, dni, correo, direccion, telefono, claveProvisional, debeCambiar);
        }

        public List<Estudiante> ObtenerEstudiantesRegistrados()
        {
            return crudEstudiante.ObtenerEstudiantesRegistrados();
        }

        public void ModificarEstudiante(Estudiante estudiante)
        {
            crudEstudiante.ModificarEstudiante(estudiante);
        }

        public void EliminarEstudiante(Estudiante estudiante)
        {
            crudEstudiante.EliminarEstudiante(estudiante);
        }
    }
}
