using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Contrato
    {
        public float NroContrato { get; set; }
        public string CreacionContrato { get; set; }
        public string TerminoContrato { get; set; }
        public string HoraIncio { get; set; }
        public string HoraTermino { get; set; }
        public string DireccionContrato { get; set; }
        public bool EstaVigente { get; set; }
        public Evento Evento { get; set; }
        public string Observaciones { get; set; }

        public Contrato()
        {

        }
    }
}
