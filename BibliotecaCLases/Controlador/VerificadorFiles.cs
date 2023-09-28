using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    public class VerificadorFiles : VerificadorFilesSystem
    {
        public VerificadorFiles(string filePath) : base(filePath) 
        {

        }
        public override bool Exists()
        {
            return File.Exists(path);
        }

    }
}
