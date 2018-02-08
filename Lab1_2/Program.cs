using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    public delegate bool DelegateComparision(Libro libro);
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Libro> Lista = new LinkedList<Libro>();
            Lista.AddLast(new Libro() { ID = 1, Nombre = "El Quijote", Edicion = "Primera" });
            Lista.AddLast(new Libro() { ID = 2, Nombre = "Baldor", Edicion = "Tercera" });
            Lista.AddLast(new Libro() { ID = 3, Nombre = "Sr. Presidente", Edicion = "Segunda" });
            DelegateComparision delegado = new DelegateComparision(EsPrimeraEdicion);
            Console.WriteLine(delegado(Lista.ElementAt(2)));
            Console.WriteLine(delegado(Lista.First()));
            Console.WriteLine(delegado(Lista.Last()));

            Console.ReadKey();
        }
        static bool EsPrimeraEdicion(Libro libro)
        {
            if (libro.Edicion == "Primera")
            {
                return true;
            }
            else
                return false;
        }
    }
    public class Libro
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Edicion { get; set; }


    }
}
