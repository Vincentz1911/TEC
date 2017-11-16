using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_8_programmering_Metoder
{

    class Program
    {
        public static int GlobalTal = 5;
        static int tal = 20;

        static void Main(string[] args)
        {
            int i = 10;

            while (!int.TryParse("1234", out i))
            {
                Console.WriteLine(i);
            }
            int f = i;
            Console.WriteLine(i);

            MyInPar(tal);

            //int tal = 7;
            MyOutPar(out tal);
            Console.WriteLine(tal);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("Hej fra mig");
            strBuilder.Append(" og hej fra dig");
            MyRefStringBuilder(strBuilder);
            Console.WriteLine(strBuilder);

            string string1 = "Hej";

            stringMetode(ref string1);
            Console.WriteLine(string1);


            Console.ReadLine();
        }

        static void MyInPar(int tal)
        {
            int tallet = tal;  // kun ind
            int Globaltallet = GlobalTal; // kan bruges som in og out

            int DetGlobaleTal = Program.tal;

        }

        static void MyOutPar(out int tal)
        {
            tal = 15; // kun out
            Console.WriteLine("Tal i Out : " + tal);
        }

        static void MyRefPar(ref int tal)
        {
            tal = tal * 1;
            Console.WriteLine("Tal i Ref : " + tal);
        }

        static void MyRefStringBuilder(StringBuilder sb)
        {
            sb.Append(" Vi tilføjer lige lidt mere");

        }

        static void stringMetode(ref string str)
        {
            str = str + "Jhhjsakhf";
        }

    }

}
