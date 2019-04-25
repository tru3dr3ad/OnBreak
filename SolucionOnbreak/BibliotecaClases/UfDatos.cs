﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class UfDatos
    {
        public string version { get; set; }
        public string autor { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public List<Serie> serie { get; set; }
        public UfDatos()
        {

        }
    }
    public class Serie
    {
        public string fecha { get; set; }
        public string valor { get; set; }
        public Serie()
        {
                
        }
    }
}
