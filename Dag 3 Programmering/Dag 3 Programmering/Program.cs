using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dag_3_Programmering
{
    class Program
    {
        enum Noget : int // default er int
        {
            Noget1, Noget2, Noget3, Nogetandet
        }
        [Flags] // Tildeler en bit til hver af enums
        enum Kombi : byte
        {
            //00000001  00000010  00000100  00001000  00010000  00100000  01000000  10000000
            Dum = 1, Klog = 2, Sød = 4, Smuk = 8, Grim = 16, Høj = 32, Tyk = 64, Dygtig = 128
        }

        static void Main(string[] args)
        {
            // IfSwitch();
            //undervisning();
            //structs();
            //strings();
            ENUMopgaver();
        }


        static void undervisning()
        {
            Noget noget = Noget.Noget3 | Noget.Noget1;

            Kombi kombi = Kombi.Dum | Kombi.Høj;

            Console.WriteLine(noget);

            Console.WriteLine(kombi + " har bitværdi " + (byte)kombi);

            kombi = (Kombi)(((byte)kombi) << 2); //bitshift som rykker placeringen 2 pladser til venstre
            Console.WriteLine(kombi + " har bitværdi " + (byte)kombi);

            kombi = (Kombi)(((byte)kombi) << 2); //bitshift som rykker placeringen 2 pladser til venstre
            Console.WriteLine(kombi + " har bitværdi " + (byte)kombi);

            Console.WriteLine((Kombi)7 + " har bitværdi " + (byte)kombi);

            FileAttributes f = FileAttributes.Hidden | FileAttributes.ReadOnly;
            Console.WriteLine(f + " har bitværdi " + (int)f);

            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine();
            }

            //foreach (int element in F)

            Console.ReadLine();
        }

        enum Pause
        {
            Ni, HalvTi, Ti, TiMinutterOverTi, Prefrokost, Frokost, PostFrokost, Eftermiddagskaffe
        }

        static void IfSwitch()
        {
            Pause pause = Pause.Ti;
            string tekst = "";

            if (pause == Pause.Ni || pause == Pause.Ti) { tekst = "Formiddag"; }
            else if (pause == Pause.HalvTi) { tekst = "Formiddag"; }
            else if (pause == Pause.Prefrokost) { tekst = "Formiddag"; }
            Console.WriteLine(pause + " er " + tekst);

            //Pause pause2 = 

            switch (pause)
            {
                case Pause.Ni:
                case Pause.HalvTi:
                case Pause.Ti:
                case Pause.TiMinutterOverTi:
                    tekst = "Formiddag";
                    break;
                case Pause.Prefrokost:
                case Pause.Frokost:
                case Pause.PostFrokost:
                    tekst = "Middag";
                    break;
                case Pause.Eftermiddagskaffe:
                    tekst = "Eftermiddag";
                    break;
                default:
                    tekst = "Tjaaee....";
                    break;
            }

            Console.WriteLine(pause + " er " + tekst);



            Console.ReadLine();
        }

        struct Person
        {
            public int id;
            public string navn;
            public override string ToString() // Overrider ToString med returneringen
            {
                return navn + " har id " + id;
            }
        }

        static void structs()
        {
            Person p1 = new Person();
            p1.navn = "Frederik";
            p1.id = 6;

            Person p2;
            p2.id = 7;
            p2.navn = "Jim";

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.navn + " har id " + p1.id);
            Console.WriteLine(p1);

            Person p3 = p2;
            Console.WriteLine(p2);
            p3.navn = "Rasmus";
            p3.id = 8;
            Console.WriteLine(p3);

            Console.ReadLine();
        }

        static void strings()
        {
            //string str1 = new string("Hej"); Oprindelig måde at oprette et objekt på

            int len = "Hej Hej".Length;
            string str2 = "Hej med jer!";

            string str3 = new string('A', 5);
            Console.WriteLine(str3);

            char[] arr1 = { 'a', 'b', 'c' };
            string str4 = new string(arr1);
            Console.WriteLine(str4);
            
            string str5 = "Pølsepause holdes senere hvor en pølse nydes med følelse med ketswup".ToString();

            string str6 =str5.ToUpper();
            //str5 = str5.ToUpper();

            string str7 = str5.Substring(30); // Fra character 30 og op
            string str8 = str5.Substring(0, 30); // Fra 0 til 30

            int str9 = str5.IndexOf("de", 15);

            //str5.Where

            Console.WriteLine(str9);

            //*********************************************************************

            StringBuilder strBuilder1 = new StringBuilder();

            StringBuilder strBuilder2 = strBuilder1;

            strBuilder1.Append("Hej med jer");

            Console.WriteLine("\n" + strBuilder1);

            strBuilder1.Append(". Nu er det snart frokost.");
            Console.WriteLine("\n" + strBuilder1);

            strBuilder1.Append("Det er Jim glad for");

            strBuilder2.Replace("Jim", "Søren");

            Console.WriteLine("\n" + strBuilder1);
            Console.WriteLine("\n" + strBuilder2);


            string str10 = @"c:\";
            Console.ReadLine();
        }


        enum Ugedage
        {
            Mandag, Tirsdag, Onsdag, Torsdag, Fredag, Lørdag, Søndag
        }
        static void ENUMopgaver()
        {



        }
        /*
         1. Lav et lignende eksempel, som det ovenstående, hvor brugeren indtastede verdenshjørner, men her med Ugedage, 
         altså en enum der hedder Ugedage. Brug desuden en switch til at udskrive om det er weekend eller ej. 
         Prøv at oversætte en dansk ugedag til en engelsk ugedag vha. den fordefinerede enum DayOfWeek og den oprettede enum Ugedage.

        2. Opret en enum BeerType med værdierne Lager, Pilsner, Münchener, Wiener, Dortmunder, Bock, DobbelBock og Porter. 
        Udskriv alle typer med betegnelse og nummer.

        3. Enum FileAttributes er en eksisterende enum i C#. Den er defineret med attributten FlagsAttribute. 
        Udskriv alle definitionerne og find ud af hvilket bit, der ikke er defineret. Find det tal, der samlet representerer 
        alle filattributter og udskriv disse på en gang.
         */


    }
}
