using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Navn = "Bjarke";

            Person p2 = new Person()
            {
                Navn = "Rasmus",
                _Id = 1000,
                vægt = 120                
            };


            var personA = new
            {
                Navn = p2.Navn,
                Vægt = p2.vægt
            };

            Person p3 = new Person()
            {
                Navn = personA.Navn,
                _Id = 1000,
                vægt = 120
            };

            //Anonymous type
            var bil1 = new
            {
                Fabrikat = "Folkevogn",
                Kubik = 1600.45
            };
            var bil2 = new
            {
                Fabrikat = "Folkevogsadsn",
                Kubik = 1600.450043,
                HU = "jhjd"
            };

            Console.WriteLine(bil1.Fabrikat + " " + bil1.Kubik + " " + bil1.GetType());

            Console.WriteLine(" " + bil2.GetType());

            Console.ReadLine();

        }
    }

    class Person
    {
        //Field
        private string _Navn;
        public int _Id;

        //Property
        public string Navn
        {
            set { _Navn = value; }
            get { return _Navn; }
        }

        //automatisk property som selv laver underliggende fields
        public int vægt { set; get; } //set og get kan sættes private




        //Method (abstract)
        //abstract public int MyMethod();
    }

}
