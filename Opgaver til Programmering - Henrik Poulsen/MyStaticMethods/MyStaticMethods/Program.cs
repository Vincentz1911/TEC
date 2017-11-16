using System;

namespace MyStaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //****************** OPGAVE 2 ********************
            Console.WriteLine("\nopgave 2\n");
            int tal = 20;
            Console.WriteLine("Halvdelen af {0} er : {1}", tal, Methods.GetHalf(tal));
            Console.WriteLine("Det dobbelte af {0} er : {1}", tal, Methods.GetDouble(tal));

            //****************** OPGAVE 3 ********************
            Console.WriteLine("\nopgave 3\n");
            tal = 7;
            string str3 = "";
            if (Methods.IsEven(tal))
                str3 = "lige";
            else
                str3 = "ulige";
            Console.WriteLine("Tallet " + tal + " er " + str3);

            tal = 8;
            if (Methods.IsEven(tal))
                str3 = "lige";
            else
                str3 = "ulige";
            Console.WriteLine("Tallet " + tal + " er " + str3);

            //****************** OPGAVE 4 ********************
            Console.WriteLine("\nopgave 4\n");
            string str = "We are some talented programmers!Vi er nogle dygtige programmører!";
            string first = StringMethods.GetFirstHalf(str);
            string last = StringMethods.GetLastHalf(str);

            Console.WriteLine("First half: " + first);
            Console.WriteLine("Last half: " + last);

            //****************** OPGAVE 5 ********************
            Console.WriteLine("\nopgave 5\n");
            string ens = "";
            bool enscifre = false;
            int tal3 = 45;
            int tal4 = 35;
            enscifre = Methods.CommonDigit(tal3, tal4);
            if (!enscifre) ens = "ingen ";
            else ens = "";
            Console.WriteLine("{0} og {1} har {2}ens cifre", tal3, tal4, ens);

            tal3 = 99;
            tal4 = 177;
            enscifre = Methods.CommonDigit(tal3, tal4);
            if (!enscifre) ens = "ingen ";
            else ens = "";
            Console.WriteLine("{0} og {1} har {2}ens cifre", tal3, tal4, ens);

            Console.ReadLine();
        }
    }

    class StringMethods
    {
        public static string GetFirstHalf(string str)
        {
            string svar = str.Substring(0, str.Length / 2);
            return svar;
        }
        public static string GetLastHalf(string str)
        {
            string svar = str.Substring(str.Length / 2);
            return svar;
        }

    }
    class Methods
    {
        public static int GetHalf(int tal)
        {
            int svar = tal / 2;
            return svar;
        }
        public static int GetDouble(int tal)
        {
            int svar = tal * 2;
            return svar;
        }
        public static bool IsEven(int tal)
        {
            bool svar = (tal % 2 == 0);
            return svar;
        }

        //Opgave 5
        public static bool CommonDigit(int tal1, int tal2)
        {
            bool svar = false;

            string stal1 = tal1.ToString();
            string stal2 = tal2.ToString();
            for (int i = 0; i < stal2.Length; i++)
            {
                if (stal1.Contains(stal2.Substring(i, 1)))
                {
                    svar = true;
                    break;
                }
            }
            return svar;
        }
    }

}
