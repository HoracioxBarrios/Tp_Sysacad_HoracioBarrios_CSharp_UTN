using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases
{
    public class Validacion
    {
        public bool ValidarString(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
            /*hora hora*/
        }
        public bool ValidarDigit(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
