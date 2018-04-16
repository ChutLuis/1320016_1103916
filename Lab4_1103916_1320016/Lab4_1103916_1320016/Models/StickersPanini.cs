using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4_1103916_1320016.Models
{
    public class StickersPanini
    {
        public Pais pais { get; set; }

        //public Pais Rusia { get; set; }
        //public Pais Argentina { get; set; }
        //public Pais Australia { get; set; }
        //public Pais Belgica { get; set; }
        //public Pais Brasil { get; set; }
        //public Pais Colombia { get; set; }
        //public Pais Croacia { get; set; }
        //public Pais Dinamarca { get; set; }
        //public Pais Egipto { get; set; }
        //public Pais Inglaterra { get; set; }
        //public Pais España { get; set; }
        //public Pais Francia { get; set; }
        //public Pais Alemania { get; set; }
        //public Pais Iran { get; set; }
        //public Pais Islandia { get; set; }
        //public Pais Japon { get; set; }
        //public Pais Corea { get; set; }
        //public Pais Arabia { get; set; }
        //public Pais Marruecos { get; set; }
        //public Pais Mexico { get; set; }
        //public Pais Nigeria { get; set; }
        //public Pais Panama { get; set; }
        //public Pais Perú { get; set; }
        //public Pais Portugal { get; set; }
        //public Pais Senegal { get; set; }
        //public Pais Serbia { get; set; }
        //public Pais Suiza { get; set; }
        //public Pais Suecia { get; set; }
        //public Pais Tunez { get; set; }
        //public Pais Uruguay { get; set; }

    }

    public class Pais
    {
        public IList<int> faltantes { get; set; }
        public IList<int> coleccionadas { get; set; }
        public IList<int> cambios { get; set; }
    }
}