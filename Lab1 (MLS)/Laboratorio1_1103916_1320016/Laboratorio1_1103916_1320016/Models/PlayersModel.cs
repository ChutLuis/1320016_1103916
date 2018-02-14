using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_1103916_1320016.Models
{
    public class PlayersModel
    {
        public string Equipo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Posición { get; set; }
        public double SalarioBase { get; set; }
        public double Compensación { get; set; }
    }
}