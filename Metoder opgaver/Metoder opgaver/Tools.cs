using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_opgaver
{
    class Tools
    {

        public static int Greatest(int tal1, int tal2)
        {
            int largest = Math.Max(tal1, tal2);
            return largest;
        }

        public static double Greatest(double tal1, double tal2)
        {
            double largest = Math.Max(tal1, tal2);
            return largest;
        }


        //Comparable CompareTo()
        public static string Greatest(string tal1, string tal2)
        {
            int largest = Math.Max(int.Parse(tal1), int.Parse(tal2));
            return largest.ToString();
        }



        public static string GetFromUser(string s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
            string str = Console.ReadLine();
            return str;
        }

        public static int GetIntFromUser(string s, int x, int y)
        {
            string str = ""; int tal = 0;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write(s);
                str = Console.ReadLine();
            }
            while (!int.TryParse(str, out tal));

            return tal;
        }


        public static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;

        }

    }
}
