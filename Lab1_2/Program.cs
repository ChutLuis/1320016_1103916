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
            Lista.AddLast(new Libro() { ID = 1, Nombre = "El Quijote", Edicion = "Primera", Año=1994  });
            Lista.AddLast(new Libro() { ID = 2, Nombre = "Baldor", Edicion = "Tercera", Año=2010 });
            Lista.AddLast(new Libro() { ID = 3, Nombre = "Sr. Presidente", Edicion = "Segunda", Año=2015});
            //Instancia del delegado 
            DelegateComparision delegado = new DelegateComparision(EsPrimeraEdicion);
            DelegateComparision delegado2 = x => x.Edicion == "Primera";
            DelegateComparision delegado3 = x => 
            {
                if (x.Edicion == "Primera")
                    return true;
                else
                    return false;
            };
            Console.WriteLine(delegado(Lista.ElementAt(2)));
            Console.WriteLine(delegado(Lista.First()));
            Console.WriteLine(delegado(Lista.Last()));
            //buscar el libro baldor
            var result = Lista.Where(libro => libro.Nombre == "Baldor").ToList();
            var datos = Lista.Where(x => x.ID == 1).ToList();
            var bisiestos = Lista.Where(x => 
            {
                if (x.Año % 100 == 0)
                    if (x.Año % 4 == 0)
                        if (x.Año % 5 > 1)
                            return true;
                        else
                            return false;
            });
            Libro paraEliminar = Lista.Where(variable => variable.ID == 1).First();
            Lista.Remove(paraEliminar);
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
        static Libro EsBaldor(Libro libro)
        {
            if (libro.Nombre == "Baldor")
                return libro;
            else
                return null;
        }
    }
    public class Libro
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Edicion { get; set; }
        public int Año { get; set; }

    }
}
