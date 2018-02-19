using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2_EdgarChian.Models
{
    public class Arbol
    {
        public Pais valor { get; set; }
        public Arbol izquierdo { get; set; }
        public Arbol derecho { get; set; }

        public class Pais
        {
            public string nombre { get; set; }
            public string Grupo { get; set; }
        }
    }
}