using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySorting 
{
    class Program
    {
        static void Main(string[] args)
        {
            Model[] models = new Model[5];
            models[0] = new Model("Jim", 47);
            models[1] = new Model("Alex", 42);
            models[2] = new Model("Philip", 45);
            models[3] = new Model("Nicolai", 46);
            models[4] = new Model("Henrik", 41);

            foreach (Model m in models)
            { Console.WriteLine(m); }

            Array.Sort(models, new CompareName());
            Console.WriteLine();

            foreach (Model m in models)
            { Console.WriteLine(m); }

            Array.Sort(models, new CompareShoeUp());
            Console.WriteLine();

            foreach (Model m in models)
            { Console.WriteLine(m); }

            Array.Sort(models, new CompareShoeDown());
            Console.WriteLine();

            foreach (Model m in models)
            { Console.WriteLine(m); }


            Console.ReadLine();
        }

    }
    class Model
    {

        public string Navn { get; set; }
        public int Sko { get; set; }

        public Model(string n, int s)
        {
            Navn = n;
            Sko = s;
        }

        public override string ToString()
        {
            return $"Hej {Navn,10} - Nå, så du bruger nummer {Sko} i sko!?";
        }

    }


}
