using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Indtast dit navn: ");
            string navn = Console.ReadLine();
            Console.WriteLine("Hej " + navn);

            int tal1, tal2;
            Console.WriteLine("Indtast 2 tal: ");
            tal1 = int.Parse(Console.ReadLine());

            tal2 = int.Parse(Console.ReadLine());

            int resultat = tal1 + tal2;
            Console.WriteLine("{0} + {1} = {2}", tal1, tal2, resultat);
            */
            float dtal1 = 0, dtal2 = 0, dtal3 = 0;
            string strtal1 = "", strtal2 = "", strtal3 = "";

            bool error = true;
            while (error)
                try
                {
                    Console.Write("Indtast 1 decimaltal: ");
                    strtal1 = Console.ReadLine();
                    dtal1 = float.Parse(strtal1);
                    error = false;
                } catch (Exception) { }

            error = true;
            while(error)
            {
                try
                {
                    Console.Write("Indtast 2 decimaltal: ");
                    strtal2 = Console.ReadLine();
                    dtal2 = float.Parse(strtal2);
                    error = false;
                } catch (Exception) { }
            }
            error = true;
            while (error)
            {
                try
                {
                    Console.Write("Indtast 3 decimaltal: ");
                    strtal3 = Console.ReadLine();
                    dtal3 = float.Parse(strtal3);
                    error = false;
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }

            float gennemsnit = (dtal1 + dtal2 + dtal3) / 3;

            Console.WriteLine("Gennemsnittet af dine 3 tal er {0} + {1} + {2} / 3 = {3}", dtal1, dtal2, dtal3, gennemsnit);
            Console.ReadLine();

            //********************************************************************************************//

            // dtal1, dtal2, dtal3;
            Console.Write("Indtast 3 decimaltal: ");

 
            //            try
            //           { 
            //Console.Write("Indtast tal1: ");
            //strtal1 = Console.ReadLine();
            //           dtal1 = float.Parse(strtal1);

            while (!float.TryParse(strtal1, out dtal1))
            {
                Console.WriteLine("Indtast tal1: ");
                strtal1 = Console.ReadLine();
            }

            //            float dtal1 = float.Parse(strtal1);


            Console.Write("Indtast tal2: ");
            strtal2 = Console.ReadLine();
            dtal2 = float.Parse(strtal2);

            Console.Write("Indtast tal2: ");
            strtal3 = Console.ReadLine();
            dtal3 = float.Parse(strtal3);

            //           }
            //            catch(FormatException e)
            //           {
            //               Console.WriteLine(e.Message);
            //           }

            float gennemsnit = (dtal1 + dtal2 + dtal3) / 3;

            Console.WriteLine("Gennemsnittet af dine 3 tal er {0} + {1} + {2} / 3 = {3}", dtal1, dtal2, dtal3, gennemsnit);
            Console.ReadLine();



            //Console.Write("Indtast dit navn: ");
            //string navn = Console.ReadLine();





            //int tal1 = 7;
            //int tal2 = 8;
            //int resultat = tal1 + tal2;
            //Console.WriteLine(tal1 + " + " + tal2 + " = " + resultat);

            //Console.WriteLine("{0:c2} + {1} = {2}", tal1, tal2, resultat);

            //Console.WriteLine($"{tal1} + {tal2} = {resultat}");

            //Console.Write("Indtast dit navn: ");
            //string navn = Console.ReadLine();


            //Console.Write("Indtast dit skonummer: ");
            //string skonummer = Console.ReadLine();


            ////Struct (indeholder resourcer til bl.a. konverterings)
            //Int16 tal = 0;
            ////Class (refererer til et object)
            //string str = "Henrik";

            //char ch = 'A';
            ////typecaste
            //ushort ch1 = (char)52;
            //char char2= (char)ch1;
            //ch = (char)(ch + 1);

            //byte b = 0;
            //b -= 1;

            //ch = 5;



            //int testresultat;
            //bool test = int.TryParse(skonummer, out testresultat);
            //if (test)
            //{
            //    Console.Write("Indtast dit skonummer: ");
            //    skonummer = Console.ReadLine();
            //}

            //int nummer = int.Parse(skonummer);

            //nummer += 5;

            //Console.WriteLine("Hej " + navn + " du bruger nr " + nummer + " i sko!");

            //Console.ReadLine();



        }
    }
}
