using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Opgaver2
{
    class Program
    {
        static void Main(string[] args)
        {
            //opgaverENUM(Ugedage.Torsdag);
            //opgaverENUM();
            FA();
            //Structopgaver();
        }

        enum Ugedage { mandag = 1, tirsdag, onsdag, torsdag, fredag, lørdag, søndag }

        enum BeerType { Lager, Pilsner, Münchener, Wiener, Dortmunder, Bock, DobbelBock, Porter }
        private static void opgaverENUM()
        {
            //DateTime Dato = DateTime.Now;
            //Console.WriteLine("I dag er det {0} den {1}. dag i ugen", Dato.DayOfWeek.ToString(), (int)Dato.DayOfWeek);
            //// Konverterer Ugedage enum til et object og tilbage til en ugedag.
            //Object o = Ugedage.Lørdag;
            //Ugedage d = (Ugedage)o;

            //Object o3 = "sda";
            //object o2 = "7";
            //int i2 = (int)o2;

            //Type t = typeof(Ugedage);
            //Type t2 = i2.GetType();

            //***********************************************************
            Console.Write("Indtast en ugedag :");
            string dagStr = Console.ReadLine().ToLower();
            Ugedage dag = (Ugedage)Enum.Parse(typeof(Ugedage), dagStr);

            DayOfWeek day = (DayOfWeek)(((int)dag) % 7); //7=>0
            if (dag == Ugedage.søndag) { day = DayOfWeek.Sunday; }
            day = (DayOfWeek)((((int)dag) == 7) ? 0 : (int)dag);

            //if sætning
            string s = "Jan";
            string svar = (s == "Jan") ? "Ja" : "Nej";

            Console.WriteLine("Du har valgt {0} som har nummer {1}. På engelsk {2}", dag, (int)dag, day);

            switch (dag)
            {
                case Ugedage.mandag:
                case Ugedage.tirsdag:
                case Ugedage.onsdag:
                case Ugedage.torsdag:
                    Console.WriteLine("Det er arbejdsdag");
                    break;

                case Ugedage.fredag:
                case Ugedage.lørdag:
                case Ugedage.søndag:
                    Console.WriteLine("Det er weekend");
                    break;
                default:
                    break;
            }

            foreach (BeerType beer in Enum.GetValues(typeof(BeerType))) Console.WriteLine(beer + " er nummer " + (int)beer);

            FileAttributes f = FileAttributes.System | FileAttributes.Hidden;
            Console.WriteLine(f);

            foreach (string name in Enum.GetNames(typeof(FileAttributes)))
            { Console.WriteLine(name + " er nummer "); } //+ Enum.Parse(FileAttributes, name

            Console.ReadLine();
        }

        static void FA()
        {
            FileAttributes f = FileAttributes.System | FileAttributes.Hidden;
            //Console.WriteLine(f);
            int all = 0;

            foreach (FileAttributes fa in Enum.GetValues(typeof(FileAttributes)))
            {
                string bstr = Convert.ToString((int)fa, 2);
                string nulstr = new string('0', 32 - bstr.Length);
                bstr = nulstr + bstr;

                Console.WriteLine("{0, -20} er nummer {1,10} {2,20}", fa, (int)fa, bstr);
                all += (int)fa;

            }
            Console.WriteLine((FileAttributes)all);

            ////FileAttributes fa = Enum.GetValues(typeof(FileAttributes));
            //for (int i; i < 256000; i = i * 2)
            //{
            //    FileAttributes fai = (FileAttributes)i;
            //    if (fai == (FileAttributes)fai)
            //    { Console.WriteLine("Denne bit mangler"); }
            //}




            Console.ReadLine();
        }
        struct Account
        {
            string Navn;
            int CPRnr;
            float Saldo;
        }

        static void Structopgaver()
        {


        }



    }
}
