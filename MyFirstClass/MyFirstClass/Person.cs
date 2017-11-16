using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass
{
    class Person
    {

        public string _Efternavn, Job;
        public int Løn, Vægt;
        string _Navn;

        //Property
        public string Navn
        {
            set { _Navn = value; }
            get { return _Navn; }
        }

        public string Efternavn
        {
            set { _Efternavn = value; }
            get { return _Efternavn; }
        }


        public void setFullNavn(string navn, string efternavn)
        { Navn = navn + " " + efternavn; }

        public string getFullNavn()
        { return Navn+ " " +Efternavn; }

            //public void setNavn(string navn)
        //{ Navn = navn; }
        //public string getNavn()
        //{ return Navn; }

        //public void setEfternavn(string efternavn)
        //{ Efternavn = efternavn; }
        //public string getEfterNavn()
        //{ return Efternavn; }

        public void setJob(string job)
        { Job = job; }
        public string getJob()
        { return Efternavn; }

        public void setLøn(int løn)
        { Løn = løn; }
        public int getLøn()
        { return Løn; }

        public void setVægt(int vægt)
        { Vægt = vægt; }
        public int getVægt()
        { return Vægt; }



        public override string ToString()
        {
            // overrider ToString med et RETURN
            return "Hej " + Navn + " " + Efternavn + ". Du vejer " + Vægt + " kg, og tjener " + Løn + " som " + Job;
        }

    }
}
