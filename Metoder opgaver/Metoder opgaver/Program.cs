using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_opgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 6
            int a = 5;
            int b = 10;
            Tools.Swap(ref a, ref b);
            Console.WriteLine("opgave 6 :" + a + " og " + b);
            Console.ReadLine();
           
            //Opgave 2
            int i = Tools.Greatest(5,10);
            Console.WriteLine(i);
            double d = Tools.Greatest(5.5, 10.1);
            Console.WriteLine(d);
            string s = Tools.Greatest("5", "10");
            Console.WriteLine(s);

            //Opgave 3
            string str = Tools.GetFromUser("Indtast et eller andet: ", 5, 8);
            Console.WriteLine(str);
            Console.ReadLine();

            //Opgave 4
            int i2 = Tools.GetIntFromUser("Indtast et tal: ", 10, 10);
            Console.WriteLine(i2);
            Console.ReadLine();



        }



    }
}
