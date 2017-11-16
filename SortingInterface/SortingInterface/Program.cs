using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Balen", Shoes = 42 };
            Person p2 = new Person() { Name = "Mikkel", Shoes = 44 };

            Person[] personer = new Person[10];
            personer[0] = p1;
            personer[1] = p2;
            personer[2] = new Person() { Name = "Philip", Shoes = 42 };
            personer[3] = new Person() { Name = "Belawel", Shoes = 31 };
            personer[4] = new Person() { Name = "Jesper", Shoes = 55 };
            personer[5] = new Person() { Name = "Kevin", Shoes = 34 };
            personer[6] = new Person() { Name = "Søren", Shoes = 33 };
            personer[7] = new Person() { Name = "Rasmus", Shoes = 22 };
            personer[8] = new Person() { Name = "Alex", Shoes = 55 };
            personer[9] = new Person() { Name = "Frederik", Shoes = 42 };

            //int comp = p1.CompareTo(p2);

            Array.Sort(personer);

            foreach (Person p in personer)
            {
                Console.WriteLine(p);            
            }


            Console.ReadLine();

        }
    }
}
