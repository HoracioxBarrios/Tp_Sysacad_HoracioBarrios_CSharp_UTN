using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Utilidades
{
    public abstract class Archivo
    {
        public virtual void GuardarAJson<T>(Dictionary<int, T> objetoAGuardar, string path)
        {

        }
        public virtual void ActualizarJson<T>(Dictionary<int, T> diccionario, string path)
        {

        }
        public virtual T LeerJson<T>(string path)
        {
            T resultado = default(T);
            return resultado;
        }
    }
}
