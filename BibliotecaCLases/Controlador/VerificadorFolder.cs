using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Controlador
{
    public class VerificadorFolder : VerificadorFilesSystem
    {

        public VerificadorFolder(string path) : base(path)
        {

        }

        public override bool Exists()
        {
            return Directory.Exists(path);
        }
    }
 
}
