using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int seed = 0;
            int[] XPOS = new int[20];
            int gScale = 1000;
            seed = rnd.Next(100000000, 999999999);

            for (int i = 0; i < XPOS.Length; i++)
            {
                 XPOS[i] = ((seed)%100000); //* gScale
                Console.WriteLine(XPOS[i]);
            }

            Console.ReadLine();
        }
    }
}
