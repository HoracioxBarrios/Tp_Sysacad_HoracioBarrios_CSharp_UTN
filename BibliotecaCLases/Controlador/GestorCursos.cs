using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    public class GestorCursos
    {
        private CrudCurso crudCurso;
        private bool _validado;
        private string _nombre;
        private string _codigo;
        private string _descripcion;
        private string _cuposDisponibles;
        public ValidadorDatosCurso validadorDatosCurso;
        private string _mensajeError;

        public GestorCursos(string nombre, string codigo, string descripcion, string cuposDisponibles)
        {
            validadorDatosCurso = new ValidadorDatosCurso(nombre, codigo, descripcion, cuposDisponibles);

            _validado = validadorDatosCurso.ValidarCurso(out string mensajeError);
            if (_validado)
            {
                crudCurso = new CrudCurso();
                _nombre = nombre;
                _codigo = codigo;
                _descripcion = descripcion;
                _cuposDisponibles = cuposDisponibles;
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
        public bool verificarDatosExistentes()
        {
            int numeroError = crudCurso.VerificarCodigoCurso(_codigo);

            if (numeroError == 1)
            {
                _mensajeError = "Error: El código ya está registrado.";
                return false;
            }

            return true;
        }
        public void AgregarCurso(string nombre, string codigo, string descripcion, string cupoMaximo)
        {
            crudCurso.AgregarCurso(nombre, codigo, descripcion, cupoMaximo);
        }

        public string EditarCurso(string nombre, string codigo, string nombreAtributo, string nuevoValor)
        {
            string resultadoEdicion = crudCurso.EditarCurso(nombre, codigo, nombreAtributo, nuevoValor);
            return resultadoEdicion;
        }


    }
}
