using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCLases.Modelo;
using BibliotecaCLases.Utilidades;

namespace BibliotecaCLases.Controlador
{
    public class GestorEstudiantes
    {
        private readonly CrudEstudiante crudEstudiante;
        private readonly string pathJson;
        private string nombre;
        private string apellido;
        private string correo;
        private string dni;
        private string direccion;
        private string telefono;
        private string claveProvisional;

        public GestorEstudiantes(string pathJson)
        {
            crudEstudiante = new CrudEstudiante(nombre, apellido,correo, dni, direccion, telefono, claveProvisional);
            this.pathJson = pathJson;
        }

        public string VerificarDatosEstudiante(string correo, string dni)
        {
            return crudEstudiante.VerificarDatosEstudiante(correo, dni);
        }

        public void RegistrarEstudiante(string nombre, string apellido, string correo, string dni, string direccion, string telefono, string claveProvisional)
        {
            crudEstudiante.RegistrarEstudiante(nombre, apellido, correo, dni, direccion, telefono, claveProvisional, pathJson);
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
