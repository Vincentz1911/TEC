using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testtest
{
    class StringMethods
    {
        //3.Opret en metode af navnet ChangeSpace() i klasssen StringMethods, der modtager en string som
        //input og returnerer en string hvor alle mellemrum i input-strengen er udskiftet med underscore ”_”
        //Afprøv: Udskriv strengen der benyttes i kaldet og strengen der returneres fra metoden.
        public static string ChangeSpace(string str)
        {
            string strNy = str.Replace(" ", "_");
            return strNy;
        }

        //4. Opret en metode af navnet RemoveWord() i klassen StringMethods, der modtager en string og
        //returnerer en string. Metoden skal, når den modtager en string med flere ord i, adskilt af
        //mellemrum, returneren en string indeholdene det første og det sidste ord.
        //Afprøv: Udskriv strengen der benyttes i kaldet og strengen der returneres fra metoden.
        public static string RemoveWord(string str)
        {
            string[] strArray = str.Split(' ');
            string strNy = strArray[0] + " " + strArray[strArray.Length - 1];
            return strNy;
        }

        //5. Opret en metode af navnet LetterCount() i klassen StringMethods.Metoden skal modtage en string
        //og en char som parametre, og returne et heltal, der angiver hvor mange gange den angivne char
        //findes i den angivne string.
        //Metoden benyttes som følger:
        //string str2 = "Jeg er havren, jeg har bjælder på";
        //int number = StringMethods.LetterCount(str2, 'e');
        //Udskriv resultatet sådan:
        //Strengen: "Jeg er havren, jeg har bjælder på", indeholder karakteren 'e' 5 steder
        public static int LetterCount(string str, char cha)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (cha == char.Parse(str.Substring(i, 1))) count++;
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //opgave1();
            //opgave2();
            //opgave3();
            string str = "Der var en gang en konge";
            char cha = 'e';
            //Console.WriteLine(StringMethods.ChangeSpace(str));//Opgave 4
            //Console.WriteLine(StringMethods.RemoveWord(str));//Opgave 5
            int number = StringMethods.LetterCount(str, cha);
            Console.WriteLine("Strengen: {0}, indeholder karakteren '{1}' {2} steder.", str, cha, number);

            Console.WriteLine("\nEr tilbage i Main...");
            Console.ReadLine();
        }

        private static void opgave2()
        {
            //2.Spørg brugeren om at indtaste et heltal, der angiver hvor mange tal han ønsker at indtaste.
            //Opret et array af denne størrelse.
            //Bed brugeren indtaste disse tal, som et heltal ad gangen, og læg hver af disse tal ind i arrayet.
            //Udskriv alle tal fra arrayet, samt det største tal, det mindste tal og gennemsnittet af tallene.        

            Console.Write("Indtast et heltal :");
            int heltal = int.Parse(Console.ReadLine());
            int[] talarray = new int[heltal];

            for (int i = 0; i < talarray.Length; i++)
            {
                Console.Write("\nIndtast tal nr " + (i + 1) + ": ");
                talarray[i] = int.Parse(Console.ReadLine());
            }
            foreach (int t in talarray)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine("\nDet største: {0}, Det mindste: {1} og gennemsnittet: {2}",
                talarray.Max(), talarray.Min(), (talarray.Sum() / talarray.Length));
        }

        private static void opgave1()
        {
            //1.Opret et array med 7 navne i. Udskriv navnene i en løkke.Hvis arrayet indeholder navnet ”Jan”, skal
            //udskrivningen stoppe, når dette navn er udskrevet
            string[] Navne = { "Peter", "Søren", "Hans", "Casper", "Henrik", "Jan" };
            foreach (string navn in Navne)
            {
                Console.WriteLine(navn);
                if (navn == "Jan") return;
            }
        }
    }
}
