using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dag2_Programmering
{
    class Program
    {


        static void Main(string[] args)
        {
            //undervisning();
            //opgave();
            //fintprogram();
            enumsopgaver();
            //enumundervisning();
        }

        static void undervisning()
        {
            int max = int.MaxValue;
            Console.WriteLine(max);
            max = max + 1;
            Console.WriteLine(max);

            int tal1 = 7;
            int tal2 = 7;
            byte b2 = (byte)tal2;

            //NON-STATIC
            if (tal1.Equals(tal2))
                Console.WriteLine(tal1 + " og " + tal2 + " er ens");
            //STATIC
            if (int.Equals(tal1, tal2))
                Console.WriteLine(tal1 + " og " + tal2 + " er ens");

            tal1.ToString(); //
            //--------------------------------------------------------------

            float f = 1234.5f;
            float f2 = 7;

            int tal3 = (int)f;

            int tal4 = (int)Math.Round(f, 0, MidpointRounding.AwayFromZero); // RUNDER OP
            Console.WriteLine(tal4);

            byte b3 = 0b01101001;
            Console.WriteLine(b3);

            //Fra decimal til string af binær, decimal og hex
            Console.WriteLine(Convert.ToString(b3, 16));
            //Fra string af binær, dec, hex til int           
            Console.WriteLine(Convert.ToInt32("011010101001", 2)); // fra binær
            Console.WriteLine(Convert.ToInt32("AB7", 16)); // fra hex
            Console.WriteLine(Convert.ToInt32("1267", 10)); // fra decimal


            Console.WriteLine(Math.Pow(2, 32));
            char ch = 'A';
            char ch2 = char.ToUpper('a');

            Console.ReadLine();


        }

        static void opgave()
        {
            string strtal, htal;
            decimal dtal, dtal100;
            int ital;

            Console.Write("Indtast et decimal tal:");
            strtal = Console.ReadLine();
            dtal = Convert.ToDecimal(strtal);
            ital = (int)Math.Round(dtal, 0, MidpointRounding.AwayFromZero);
            Console.WriteLine(ital);

            dtal = Math.Round(dtal, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine(dtal);

            dtal100 = Math.Round(dtal / 100, 0, MidpointRounding.AwayFromZero) * 100;
            Console.WriteLine(dtal100);

            int e = 100;
            htal = Convert.ToString(e, 10);
            Console.WriteLine(htal);

            Console.WriteLine(Convert.ToInt32("011010101001", 2)); // fra binær
            Console.WriteLine(Convert.ToInt32("AB7", 16)); // fra hex

            Console.ReadLine();

        }


        static void w(string msg, params object[] args)
        {
            Console.Write(msg, args);
        }
        static void CP(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
        static void fintprogram()
        {


            string strtal, htal;
            decimal dtal, dtal100;
            int ital = 0;
            bool tjek = false;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;

            while (!tjek)
            {
                Console.Clear();
                CP(10, 9); w("Omregner (brug b for binær og h for hexadecimal)");
                CP(10, 10); w("Indtast et tal: ");
                strtal = Console.ReadLine();

                char last = strtal[strtal.Length - 1];

                if (strtal == "q" || strtal == "Q")
                { tjek = true; Environment.Exit(0); }

                if (last == 'h') { strtal = strtal.Remove(strtal.Length - 1); ital = Convert.ToInt32(strtal, 16); }
                else if (last == 'd') { strtal = strtal.Remove(strtal.Length - 1); ital = Convert.ToInt32(strtal, 10); }
                else if (last == 'b') { strtal = strtal.Remove(strtal.Length - 1); ital = Convert.ToInt32(strtal, 2); }
                else { Int32.TryParse(strtal, out ital); }

                CP(10, 12); Console.WriteLine(ital + " -decimal");
                CP(10, 13); Console.WriteLine("0b" + Convert.ToString(ital, 2) + " -binær");
                CP(10, 14); Console.WriteLine("0h" + Convert.ToString(ital, 16) + " -hexadecimal");

                CP(10, 16); w("Prøv igen eller tast Q for at kvitte");
                CP(10, 17); Console.ReadLine();
            }
        }

        enum Elever
        { Henrik, Casper, Frederik, Alex, Jim, Peter, Søren }

        static void enumundervisning()
        {
            Elever elev = Elever.Alex;
            int e = (int)Elever.Jim;
            Elever elv2 = (Elever)7;

            Console.WriteLine(elev);
            Console.WriteLine((Elever)e + " har nummer " + e);
            Console.WriteLine((Elever)6 + " har nummer " + 6);

            Array arr = Enum.GetValues(typeof(Elever));
            foreach (Elever ee in arr)
            {
                Console.WriteLine(ee + " har nummer " + (int)ee);
            }

            ConsoleColor[] arrColor = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            foreach (ConsoleColor cc in arrColor)
            {
                Console.BackgroundColor = cc;
                Console.WriteLine(cc + " har nummer " + (int)cc);
            }

            for (int color = 0; color <16; color++)
            {
                Console.BackgroundColor = (ConsoleColor)color;
                Console.ForegroundColor = (ConsoleColor)((color + 1) % 16); //Modulus 16 giver 0 når 16 / 16 (Rest af division)
                Console.Write((ConsoleColor)color + " har nummer " + color + " - ");

            }

            Console.ReadLine();
        }

        static void enumsopgaver()
        {
        
            Random random = new Random();
            int rfColor, rbColor, posX, posY, rElev;
            Array arr = Enum.GetValues(typeof(Elever));

            while (true)
            {
                rfColor = random.Next(0, 15);
                rbColor = random.Next(0, 15);
                posX = random.Next(1, Console.WindowWidth);
                posY = random.Next(1, Console.WindowHeight-1);
                rElev = random.Next(0, arr.Length);

                Console.BackgroundColor = (ConsoleColor)rbColor;
                Console.ForegroundColor = (ConsoleColor)rfColor;

                CP(posX, posY); w(" " + (Elever)rElev);
            }
        }

    }


}
