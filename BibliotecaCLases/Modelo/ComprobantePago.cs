using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Modelo
{

    public class ComprobantePago
    {
        public string Fecha { get; set; }
        public string Estudiante { get; set; }
        public List<string> ConceptosDePago { get; set; }
        public decimal MontoTotal { get; set; }
        public string MetodoDePago { get; set; }
    }


}
