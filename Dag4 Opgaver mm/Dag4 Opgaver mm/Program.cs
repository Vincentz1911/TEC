﻿using System;

namespace Dag4_Opgaver_mm
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayUndervisning();
            //ArrayOpgaver();
            TipsArray();
        }

        static void ArrayUndervisning()
        {
            int tal; // Udefineret

            //            Console.WriteLine(tal);
            int[] tallene = new int[10]; //10 pladser med 0 i hver

            tallene[0] = 13;
            Console.WriteLine(tallene[0]);

            int[] tallene2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int taeller = 0;
            foreach (int tal2 in tallene2)
            {
                Console.WriteLine(tal2 + " er nummer " + taeller);
                taeller++;
            }

            int t = tallene[5];

            int ff = 0;
            while (ff < tallene2.Length)
            {
                Console.WriteLine(ff + " " + tallene[ff]);
                ff++;
            }

            Console.WriteLine();

            for (int i = 0; i < tallene2.Length; i++)
            {
                Console.WriteLine(i + " er pladsen for " + tallene2[i]);
            }


            tallene2 = new int[] { 10, 22, 34, 46, 58, 64, 72, 88, 95, 104 };
            int[] tallene3 = { 10, 22, 34, 46, 58, 64, 72, 88, 95, 104 };

            Array.Sort(tallene2);
            Array.Reverse(tallene2);
            Array.Resize(ref tallene2, tallene2.Length + 1);

            string[] Elever = { "Patrick", "Jason", "Nicolai", "Simon" };

            //------------------------------------------------------------

            //int[,] toDim = new int[5, 3];
            int[,] toDim = new int[,] { { 1, 2 }, { 1, 3 }, { 4, 5 } };

            for (int x = 0; x < toDim.GetLength(0); x++)
            {
                for (int y = 0; y < toDim.GetLength(1); y++)
                {
                    Console.Write("{0,5}", toDim[x, y]);
                }
                Console.WriteLine();
            }


            string str = "Hej med jer";

            string[] strsplit = str.Split();
            //str.Split(new char[] { ' ', '-', '_' });
            Console.WriteLine(str);
            foreach (string name in strsplit)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

        static void ArrayOpgaver()
        {
            string str = "Der var en gang en lille mand som boede i en lille spand";
            string[] strsplit = str.Split();
            foreach (string str2 in strsplit)
            { Console.WriteLine(str2); }

            //------------------------------------------
            Random r = new Random();
            int[] talarray = new int[7];
            int tt = 0;
            for (int i = 0; i < talarray.Length; i++)
            {
                talarray[i] = r.Next(0, 100);
            }
            foreach (int t in talarray)
            {
                Console.Write(t + " ");
                tt += t;
            }
            Array.Sort(talarray);
            Console.WriteLine("Det mindste/største: " + talarray[talarray[0]] + "/" + talarray[6]);
            Console.WriteLine("Ialt {0} og gennemsnit {1}, Ialt i array {2}", tt, tt / talarray.Length, talarray.Length);       

            Console.ReadLine();
        }

        static void TipsArray()
        {
            string[,] t = new string[13, 3];
            string l = new string('-', 16);
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WindowWidth = 16; Console.WindowHeight = 17;
            Console.WriteLine(l + "\n| Kamp | 1 x 2 |\n"+ l);
            for (int i = 0; i < t.GetLength(0); i++)
            {
                t[i, rnd.Next(0, 3)] = "x";
                Console.BackgroundColor = (ConsoleColor)(i % 2)+10;
                Console.WriteLine("|  {0,2}  | {1}  {2}  {3} |", i+1, t[i, 0], t[i, 1], t[i, 2]);
            }
            Console.Write(l);
            Console.ReadLine();
        }
    }
}
/*Opgaver.
3. Opret et 2-dimensionelt array som en række på en tipskupon, dvs. 13x3 felter, 
hvor hver af de 13 kampe får udfyldt ’X’ på en tilfældig af de tre pladser. 
Udskriv derefter arrayet på en pæn måde så det ligner en tipskupon.
*/