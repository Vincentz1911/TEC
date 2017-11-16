using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass
{
    class Elev
    {
        //Fields (Attributter)
        private string _Navn;
        private int _Alder;
        private string _Hårfarve;

        //Property
        public string Hårfarve
        {
            set { _Hårfarve = value; }
            get { return _Hårfarve; }            
        }


        //Metoder
        public void setNavn(string navn)
        {
            _Navn = navn;
        }
        public string getNavn()
        {
            return _Navn;
        }

        public void setAlder(int alder)
        {
            _Alder = alder;
        }
        public int getAlder()
        {
            return _Alder;
        }
        public override string ToString()
        {
            // overrider ToString med et RETURN
            return "Hej " + _Navn + ". Du er " + _Alder + " gammel" ;
        }


        //Constructors
        public Elev()
        { }

        public Elev(string navn, int alder)
        { setNavn(navn);
            setAlder(alder);
        }

        public Elev(string navn, int alder, string hårfarve) : this(navn, alder) // tager navn og alder fra ovenstående constructor
        {
            //setNavn(navn);
            //setAlder(alder);
            Hårfarve = _Hårfarve;
        }

        //Destructor (finalizer)
        ~Elev()
        {
            Console.WriteLine("Sletter indholdet af objecterne i Elev ");
        }

        static public void test(int i = 0, string s = "")
        {
            Console.WriteLine(i + s);
        }

 
    }
}
