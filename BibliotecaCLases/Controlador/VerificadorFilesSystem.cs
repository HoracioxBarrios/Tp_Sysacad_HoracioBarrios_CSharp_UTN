using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    public class VerificadorFilesSystem
    {
        protected string path;
        public VerificadorFilesSystem(string path)
        {
            this.path = path;   
        }
        public virtual bool Exists()
        {
            return Directory.Exists(path);
        }

    }
}
