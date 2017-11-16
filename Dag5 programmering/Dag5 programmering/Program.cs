using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag5_programmering
{
    class Program
    {
        static void Main(string[] args)
        {
            structs();
        }

        struct Person
        {
            public int id;
            public string navn;
            public override string ToString() // Overrider ToString med returneringen
            {
                return navn + " har id " + id;
            }
        }

        static void structs()
        {
            Person p1 = new Person();
            p1.navn = "Frederik";
            p1.id = 6;

            Person p2;
            p2.id = 7;
            p2.navn = "Jim";

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.navn + " har id " + p1.id);
            Console.WriteLine(p1);

            Person p3 = p2;
            Console.WriteLine(p2);
            p3.navn = "Rasmus";
            p3.id = 8;
            Console.WriteLine(p3);

            Console.ReadLine();
        }

    }
}
