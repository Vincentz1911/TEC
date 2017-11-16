using System;

namespace Opgave_klasse_Beer
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer[] beer = new Beer[3];
            beer[0] = new Beer { Navn = "Tuborg", Slags = Slags.Pilsner, Procent = 4.6f, Volumen = 33 };
            beer[1] = new Beer { Navn = "Mumme", Slags = Slags.Pilsner, Procent = 5.7f, Volumen = 33 };
            beer[2] = new Beer { Navn = "Hoegarden", Slags = Slags.Wiener, Procent = 8.7f, Volumen = 50 };

            Array.Sort(beer);
            foreach (Beer b in beer)
                Console.WriteLine(b.Navn + " " + b.Procent);

            Console.ReadLine();
        }
    }

    public enum Slags
    {
        Lager, Pilsner, Münchener, Wiener, Dortmunder, Bock, DobbelBock, Porter
    }

    class Beer : IComparable
    {
        private string _Navn;
        Slags _Slags;
        private float _Procent;
        private int _Volumen;

        public string Navn
        {
            set { _Navn = value; }
            get { return _Navn; }
        }
        public Slags Slags
        {
            set { _Slags = value; }

            get { return _Slags; }
        }
        public float Procent
        {
            set { _Procent = value; }
            get { return _Procent; }
        }
        public int Volumen
        {
            set { _Volumen = value; }
            get { return _Volumen; }
        }

        public Beer()
        { }

        public Beer(string navn, Slags slags, float procent, int volumen)
        {
            Navn = navn;
            Slags = slags;
            Procent = procent;
            Volumen = volumen;
        }

        public override string ToString()
        {
            string str = $"{Navn}{Slags}{Volumen}{Procent}";
            return base.ToString();
        }

        public float GetUnits(int volumen, float procent)
        {
            // Antal genstande = (vol * 10 * procent/100) /15 = vol * pro / 150
            float genstande = (volumen * procent) / 150;
            return genstande;
        }

        public int CompareTo(object obj)
        {
            Beer castedP = obj as Beer;
            int resultat = (int)(GetUnits(_Volumen, _Procent) - castedP.GetUnits(castedP._Volumen, castedP._Procent));
            return resultat;
        }
    }
}


