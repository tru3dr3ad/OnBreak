using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Cliente
    {
        public string RutCliente { get; set; }
        public string RazonSocial { get; set; }
        public string NombreCliente { get; set; }
        public string MailCliente { get; set; }
        public string DireccionCliente { get; set; }
        public int Telefono { get; set; }
        public string ActividadEmpresa { get; set; }
        public string TipoEmpresa { get; set; }

        public Cliente()
        {

        }
    }
}
