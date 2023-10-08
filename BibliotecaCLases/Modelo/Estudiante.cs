using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Modelo
{
    /// <summary>
    /// Clase que representa a un estudiante.
    /// </summary>
    public class Estudiante : Usuario
    {
        private string _direccion;
        private string _telefono;
        private bool _debecambiar;
        private List<string> _cursosInscriptos;
        private string _estadoDePago;

        /// <summary>
        /// Constructor de la clase Estudiante.
        /// </summary>
        /// <param name="nombre">Nombre del estudiante.</param>
        /// <param name="apellido">Apellido del estudiante.</param>
        /// <param name="dni">DNI del estudiante.</param>
        /// <param name="correo">Correo electrónico del estudiante.</param>
        /// <param name="direccion">Dirección del estudiante.</param>
        /// <param name="telefono">Teléfono del estudiante.</param>
        /// <param name="claveProvisional">Clave provisional del estudiante.</param>
        /// <param name="debeCambiar">Indica si el estudiante debe cambiar su contraseña.</param>
        public Estudiante(string nombre, string apellido, string dni, string correo, string direccion, string telefono, string claveProvisional, bool debeCambiar)
            : base(nombre, apellido, dni, correo, claveProvisional, 1)
        {
            _debecambiar = debeCambiar;
            _direccion = direccion;
            _telefono = telefono;

            _cursosInscriptos = new List<string>();
            _estadoDePago = "pendiente";
        }

        /// <summary>
        /// Propiedad para obtener o establecer si el estudiante debe cambiar su contraseña.
        /// </summary>
        public bool Debecambiar
        {
            get { return _debecambiar; }
            set { _debecambiar = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer la dirección del estudiante.
        /// </summary>
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer el teléfono del estudiante.
        /// </summary>
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer la lista de cursos en los que está inscrito el estudiante.
        /// </summary>
        public List<string> CursosInscriptos
        {
            get { return _cursosInscriptos; }
            set { _cursosInscriptos = value; }
        }

        /// <summary>
        /// Propiedad para obtener o establecer el estado de pago del estudiante.
        /// </summary>
        public string EstadoDePago
        {
            get { return _estadoDePago; }
            set { _estadoDePago = value; }
        }

    }
}
