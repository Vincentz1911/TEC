using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Simon_Opgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            
                        //            Opgave 1)
                        //Erklær en int med variable navnet ”tal1” med værdien 15, erklær en int med variable navnet ”tal2” med
                        //værdien 42, Adder de to tal og læg resultatet ind i ”result”. Udskriv ”result” i console.

                        int tal1 = 15, tal2 = 42;
                        int result = tal1 + tal2;
                        Console.WriteLine(result);

                        //            Opgave 2)
                        //Bed brugeren om at indtaste et decimaltal og et heltal, Adder de to tal og læg resultatet ind i ”int resultat”
                        //og udskriv det i console.
                        Console.Write("Indtast et decimaltal: ");
                        double dtal = double.Parse(Console.ReadLine());
                        Console.Write("Indtast et heltal: ");
                        int ital = int.Parse(Console.ReadLine());
                        int resultat = (int)dtal + ital;
                        Console.WriteLine(resultat);

                        //            Opgave 3)
                        //Erklær tre strings, en med variable navnet ”str”, en med variable navnet ”temp”, og en med variable navnet
                        //”kartoffel”. ”str” skal have værdien ”Karl - Johan”, ”temp” skal have værdien ”er en”, ”kartoffel” skal have
                        //værdien ”parmesanost”. Sæt de tre strings sammen i en ny string så det ser rigtigt ud når du printer det i
                        //consolen(du skal selv bestemme variable navnet på den nye string).
                        //Lav en kommentar hvor du skriver hvad ”str”,”temp”,”kartoffel” burde hedde(brug beskrivende ord)
                        string str = "Karl - Johan";
                        string temp = "er en";
                        string kartoffel = "parmesanost";

                        string nystring = str + " " + temp + " " + kartoffel;
                        Console.WriteLine(nystring);

                        //            Opgave 4)
                        //Bed brugeren om at indtaste sit navn og sin alder, gem disse i deres respektive variabler.Læg 5 til alderen
                        //og skift alle ”a” ud med ”u” og alle ”i” ud med ”o”. Udskriv deres nye navn og deres nye alder.

                        Console.Write("Indtast navn: ");
                        string navn = Console.ReadLine();
                        Console.Write("Indtast alder: ");
                        int alder = int.Parse(Console.ReadLine());
                        alder += 5;
                        navn = navn.Replace("a", "u");
                        navn = navn.Replace("i", "o");
                        Console.WriteLine("Hej {0}, du er da ikke {1} år gammel, er du?", navn, alder);
                        
            //            Opgave 1)
            //Opret 2 for-løkker, hvor den ene er inde i den anden.Begge løkker skal gennemløbes 10 gange og udskriv
            //produktet(produktet er når man ganger) af de to tællere. (fortsættes i opgave 2)
            //(hint: Første linje ”1 2 3 4 5 6 7 8 9 10”)
            //(hint2: Sidste linje ”10 20 30 40 50 60 70 80 90 100”)

            int antalTalDerSlutterPåNul = 0;

            for (int i = 1; i <= 10; i++)
            {
                for (int o = 1; o <= 10; o++)
                {
                    Console.Write(i * o + " ");
                    if ((i * o) % 10 == 0) antalTalDerSlutterPåNul++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Antal tal der ender på nul: " + antalTalDerSlutterPåNul);
            //            Opgave 2)
            //Opret en ”int antalTalDerSlutterPåNul”
            //Indsæt nu en If-statement i for-løkkerne(find selv ud af hvor i for-løkkerne) som gør at hver gang tallet
            //ender på 0 så stiger ”antalTalDerSlutterPåNul” med en. Udskriv hvor mange tal der slutter på 0.

            //            Opgave 3)
            //Lad brugeren indtaste et tal mellem 1 og 5.
            //Brug en Switch -case.
            //Hvis tallet er 1, skal den udskrive det der blev indtastet samt ”er det laveste tal”.
            //Hvis tallet er 2 eller 3, skal der lægges 5 til tallet og så udskrives.
            //Hvis tallet er 4, skal der ikke gøres noget.
            //Hvis tallet er 5, skal der udskrives ”Det er Fredag, nu er der ikke langt til Weekend”.

            Console.Write("Indtast et tal mellem 1 og 5: ");
            int tal5 = int.Parse(Console.ReadLine());
            string str5 = "";
            switch (tal5)
            {
                case 1:
                    str5 = tal5 + " er det laveste tal";
                    break;
                case 2:
                case 3:
                    tal5 += 5;
                    break;
                case 4:
                    break;
                case 5:
                    str5 = "Det er Fredag, nu er der ikke langt til Weekend";
                    break;
                default:
                    break;
            }

            //            Opgave 4)
            //Opret en ”do -while” løkke som kører indtil brugeren indtaster ”Jeg bruger en Do-While løkke” (den skal
            // være case sensitive).

            string stri="",str6 = "Jeg bruger en Do-While løkke";
            do {Console.Write("Input (Do-While): "); stri = Console.ReadLine();} while (!(str6 == stri));

            //            Enum:
            //            Opgave 1)
            //Opret en enum der hedder ”Måneder” (Husk Januar er den første måned). Brug en ”foreach” løkke til at
            //udskrive alle månederne samt deres nummer. (denne enum bliver også brugt i opgave 2)

            //Måneder t = new Enum.GetValues(typeof(Måneder));

            foreach (Måneder m in Enum.GetValues(typeof(Måneder)))
            {
                Console.WriteLine(m + " " + (int)m);
            }

            //            Opgave 2)
            //(Brug samme enum som du oprettede i Opgave 1.)
            //Men denne gang skal du bruge en ”for” løkke til at udskrive alle numrene samt deres respektive månednavn.
            for (int i = 0; i < Enum.GetNames(typeof(Måneder)).Length; i++)
            {
                //string strE1 = Enum.GetName(typeof(Måneder),i);
                string strE2 = ((Måneder)i).ToString();
                Console.WriteLine(i + " " + strE2);
            }

            //            Opgave 3)
            //Brug enum typen ”FileAttributes” og udskriv tal værdierne for følgende Attributes.
            //(eks.på udskrift) ”Værdien for ReadOnly, Directory er: 17”
            //3.1)
            //System, Offline.
            //3.2)
            //Hidden, Normal, Encrypted.
            //3.3)
            //Temporary, Compressed, SparseFile, Device.
            //3.4)
            //Offline, ReadOnly, Hidden, Directory, IntegrityStream.

            int o31 = (int)FileAttributes.System + (int)FileAttributes.Offline;
            int o32 = (int)FileAttributes.Hidden + (int)FileAttributes.Normal + (int)FileAttributes.Encrypted;
            int o33 = (int)FileAttributes.ReadOnly + (int)FileAttributes.Hidden + (int)FileAttributes.Directory + (int)FileAttributes.IntegrityStream;
            Console.WriteLine("Opg 3.1: " + o31 +" - Opg 3.2: " + o32 + " - Opg 3.3: " + o33);
            Console.WriteLine();
            //            Struct:
            //            Opgave 1)
            //Opret en struct ”Person” som indeholder Navn, Efternavn og Fødselsdag.Opret et par variabler af Persontypen,
            //giv dem værdier og udskriv dem. (fortsættes i opgave 2)
            //Opgave 2)
            //Opret en struct ”Account” som indeholder Person og Saldo.Opret et par variabler af Account-type, giv dem
            //værdier og udskriv dem. (Personerne skal også have værdier samt udskrives)

            Person[] p = new Person[3];
            Account[] a = new Account[3];

            p[0].Navn = "George";
            p[0].Efternavn = "Looney";
            p[0].Fødselsdag = DateTime.Parse("1961/05/06");
            p[1].Navn = "Tom";
            p[1].Efternavn = "Juice";
            p[1].Fødselsdag = DateTime.Parse("1962/07/03");
            p[2].Navn = "Jessica";
            p[2].Efternavn = "Apple";
            p[2].Fødselsdag = DateTime.Parse("1981/04/28");

            foreach (Person pers in p)
                Console.WriteLine("Navn: {0} {1}, Født: {2}", pers.Navn, pers.Efternavn, pers.Fødselsdag);

            a[0].person = p[0];
            a[1].person = p[1];
            a[2].person = p[2];
            a[0].Saldo = -300;
            a[1].Saldo = 50;
            a[2].Saldo = 200000000;

            foreach (Account acc in a)
                Console.WriteLine("Navn: {0} {1}, Saldo: {2}", acc.person.Navn, acc.person.Efternavn, acc.Saldo);

            //            Metoder:
            //            (Alle metode opgaver skal laves i sammen program)
            //Opgave 1)
            //1,1)
            //Opret en metode som tager to tal(int), lægger dem sammen og returnere resultatet.
            //1,2)
            //Opret en metode som tager to tal(int), ganger dem med hinanden og returnere resultatet.
            //1,3)
            //Opret en metode som tager to tal(int), dividere dem med hinanden og returnere resultatet.
            //Opgave 2)
            //Opret en metode som tager tre tal(int) ind og bruger de metoder som du har lavet i opgave 1.

            //Det første tal og det tredje tal skal lægges sammen.
            //Derefter skal det andet tal og det tredje tal ganges med hinanden.
            //De to nye tal skal så lægges sammen.
            //Det tal vi får efter de er to nye tal er lagt sammen skal nu divideres med det første tal vi tog ind.
            //Alle tal og resultater skal udskrives.
            udregn(10, 20, 30);

            del3("Tredje Bogstav");

            strings3("Der var en gang en lille mand", "lille", "stor");

            Console.ReadLine();

        }
        //Opgave 4)
        //Opret en metode som tager tre strings ind.
        //Den første string skal indeholde en tekst.
        //Den anden string skal indeholde hvad vi leder efter i den tekst.
        //Den tredje string skal indeholde hvad vi ønsker at skifte hvad vi leder efter ud med.
        //eks.string1 ”Hej med dig mit navn er kaj, hvordan går det med dig ?”, string2 ”dig”, string3 ”Lotte”
        //resultat: ”Hej med Lotte mit navn er kaj, Hvordan går det med Lotte ?”
        static void strings3(string str1, string str2, string str3)
        {
            str1 = str1.Replace(str2, str3);
            Console.WriteLine(str1);
        }

        //Opgave 3)
        //Opret en metode som tager en string ind og fjerne det tredje bogstav og udskriver den nye string.
        static void del3(string str)
        {
            str = str.Remove(2, 1);
            Console.WriteLine(str);
        }


        static int udregn(int tal1, int tal2, int tal3)
        {
            int svar1 = plusse(tal1, tal3);
            int svar2 = gange(tal2, tal3);
            int svar3 = plusse(svar1, svar2);
            int svar4 = dividere(svar3, tal1);
            Console.WriteLine("S1: {0} S2: {1} S3: {2} S4: {3}", svar1, svar2, svar3, svar4);
            return svar4;
        }

        static int plusse(int tal1, int tal2)
        {
            int svar = tal1 + tal2;
            return svar;
        }

        static int gange(int tal1, int tal2)
        {
            int svar = tal1 * tal2;
            return svar;
        }

        static int dividere(int tal1, int tal2)
        {
            int svar = tal1 / tal2;
            return svar;
        }

        struct Person { public string Navn; public string Efternavn; public DateTime Fødselsdag; }
        struct Account { public Person person; public int Saldo; }
        enum Måneder { Januar, Februar, Marts, April, Maj, Juni, Juli, August, September, Oktober, November, December }
    }
}
