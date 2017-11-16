using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag_6_programering
{
    class Program
    {
        static void Main(string[] args)
        {
            //Flow();
            //conditional();
            //lokker();
            //arraylists();
            exceptions();
        }

        static void Flow()
        {
            int tal = 13;
            while (true)
            {
                switch (tal)
                {
                    case 1:
                        Console.WriteLine("Det var 1");
                        return;
                    case 9:
                        Console.WriteLine("Det var 9");
                        goto noget;
                    case 13:
                        Console.WriteLine("Det var 13");
                        continue;
                    default:
                        break;

                }

                if (tal == 5)
                    break;
            }

            Console.WriteLine("Nu er det slut");
            noget:
            Console.ReadLine();
        }

        static void conditional()
        {
            int tal2 = 9;
            bool svar = tal2 == 9 ? true : false;

            //Conditional statement
            string strSvar = tal2 == 9 ? "Det var ni" : "Det var ikke ni";
            //Som ville erstatte dette
            if (tal2 == 9)
            {
                strSvar = "Det var ni";
            }
            else
            {
                strSvar = "Det var ikke ni";
            }

            //Dobbelt if statement i conditional:
            strSvar = tal2 == 9 ? "Det var ni" : tal2 == 8 ? "Det var otte" : "Det var hverken otte eller ni";


            Console.WriteLine(strSvar);

            Console.WriteLine("Svaret er {0}", tal2 == 9 ? "Det var ni" : "Det var ikke ni");

            Console.ReadLine();
        }

        static void lokker()
        {
            // do ... while .... kører først en enkelt gang inden 

            string str2 = "Hansen";
            for (int i = 0; ; i++)
            {
                Console.WriteLine(str2[i]);
                if (str2[i] == 's')
                    break;
                if (str2.Substring(i, 1) == "n")
                    break;
            }

            Console.ReadLine();

        }


        static void arraylists()
        {
            ArrayList list = new ArrayList();
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add("Hej");
            list.Add('A');
            list.Add(true);

            foreach (object tallet in list)
            {
                Console.WriteLine(tallet);
            }

            foreach (var tallet in list)
            {
                Console.WriteLine(tallet);
            }

            List<int> l = new List<int>();
            l.Add(4);
            l.Add(5);

            Tuple<int, string> noget = new Tuple<int, string>(7, "Hej");

            Console.ReadLine();
        }

        static void exceptions()
        {

            int[] array = new int[5];
            try
            {

                int tal = int.Parse("123A");
                Console.WriteLine("Tallet var {0}", tal);
                Console.WriteLine("Der kom ikke en exception");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Det var ikke et lovligt tal");
            }

            catch (Exception e) //catch(FormatException e)
            {
                Console.WriteLine("Der kom en exception: " + e.Message);
                Console.WriteLine("Der kom en exception: " + e);
            }
            finally
            {

            }


            string Navn = "Philip";
            try
            {
                if(Navn=="Philip")
                {
                    throw new Exception("Dit navn skal ikke længere være Philiph, du skal nu hedde Christophpher");
                }
            }
            catch (Exception erre)
            {
                Console.WriteLine(erre.Message);
            }

            Console.WriteLine("Programmet fortsætter trods exception");

            Console.ReadLine();
        }

    }
}
