using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Evento
    {
        public int IdEvento { get; set; }
        public string NombreEvento { get; set; }
        public int ValorBase { get; set; }
        public int RecargoPersonal { get; set; }
        public int RecargoAsistentes { get; set; }

        public Evento()
        {

        }
    }
}
