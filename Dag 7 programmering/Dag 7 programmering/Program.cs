using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_7_programmering
{

    class Program
    {
        //public static MyTools t;


        void WriteNonStatic()
        { Console.WriteLine("Hej med jer"); }

        static void Write()
        { Console.WriteLine("Hej med jer igen"); }

        static void Write2(string str)
        {
            Console.WriteLine(str);
        }
        static void Write2(int str)
        {
            Console.WriteLine(str);
        }
        static void Write2(double str)
        {
            Console.WriteLine(str);
        }
        //static void Write2(double str)
        //{
        //    Console.WriteLine(str);
        //}

        static string getFullName()
        {
            Console.WriteLine("Indtast fornavn: ");
            string fName = Console.ReadLine();
            Console.WriteLine("Indtast efternavn: ");
            string eName = Console.ReadLine();
            return fName + " " + eName;
        }

        static int opløftetTal(int tal, int opløft)
        {
            int svend = 1;
            for (int i = 0; i < opløft; i++)
            {svend *= tal; }
            return svend;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(MyTools.Add(5, 10));


            int resultat = opløftetTal(2, 20);
            Console.WriteLine(resultat);

            Program p = new Program(); // opretter et object fra klassen Program så Write ikke behøver at være static
            p.WriteNonStatic();

            Write();

            Write2("Hej med allesammen og nogen");

            Write2('5');

            Write2(5.5f);


            float f = 5;

            string Name = getFullName(); // Hvis flere ting skal returneres kan man evt. lave et struct eller array eller list.
            Console.WriteLine("Hej med dig " + Name);

            Console.ReadLine();
        }

    }
}
