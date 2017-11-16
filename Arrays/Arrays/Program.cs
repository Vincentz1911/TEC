using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Navne = { "Søren", "Anders", "Peter", "Mads", "Hans", "Jørgen", "Tom", "Rene", "Michael", "Jens" };
            foreach (string navn in Navne)
                Console.WriteLine(navn);

            int count = 0;
            foreach (string navn in Navne)
            {
                if (navn[0] == 'J') count++;
            }
            Console.WriteLine("\nDer var {0} navne der startede med J\n", count);

            string[] JNavne = new string[count];

            int count2 = 0;
            for (int i = 0; i < Navne.Length; i++)
            {
                if (Navne[i].Substring(0, 1) == "J")
                {
                    JNavne[count2] = Navne[i];
                    count2++;
                }
            }

            foreach (string jnavn in JNavne)
                Console.WriteLine(jnavn);

            Console.ReadLine();
        }
    }
}
