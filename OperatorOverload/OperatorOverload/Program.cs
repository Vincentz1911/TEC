using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dyr[] dArr = new Dyr[10] { { "Jumbo", 15 },   };
            Dyr elefant = new Dyr() { Art = DyreArt.Elefant, Navn = "Baby John", Vægt = 1000 };
            Dyr mus = new Dyr() { Art = DyreArt.Mus, Navn = "Fede Hans", Vægt = 0.17913 };

            Console.WriteLine(elefant);
            Console.WriteLine(mus);

            Dyr fabeldyr = elefant + mus;

            Console.WriteLine(fabeldyr);
            Console.ReadLine();
        }
    }

    public enum DyreArt { Fabeldyr, Elefant, Mus, Giraf, Ko, Gris, Løve, Leopard, Gazelle, Kat, Hund };

    class Dyr
    {
        public DyreArt Art { set; get; }
        public string Navn { set; get; }
        public double Vægt { set; get; }

        public override string ToString()
        {
            return $"Dyret {Art} hedder {Navn} og vejer {Vægt} kg. ";
        }

        public static Dyr operator +(Dyr dyr1, Dyr dyr2)
        {
            Dyr fabeldyr = new Dyr();
            fabeldyr.Art = DyreArt.Fabeldyr;
            fabeldyr.Navn = dyr1.Navn + " " + dyr2.Navn;
            fabeldyr.Vægt = dyr1.Vægt + dyr2.Vægt;

            return fabeldyr;
        }

    }
}
