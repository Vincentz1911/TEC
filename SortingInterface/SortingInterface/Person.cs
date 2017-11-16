using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingInterface
{
    class Person : IComparable
    {
        private string name;
        private int shoes;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Shoes
        {
            set { shoes = value; }
            get { return shoes; }
        }

        public int CompareTo(object obj)
        {
            //Person p = (Person)obj;
            //p = obj as Person;
            //            return this.shoes - p.Shoes;

            int result = shoes - ((Person)obj).shoes;
            if (result != 0) return result;
            else return Name.CompareTo(((Person)obj).Name);
        }

        public string GetInfo()
        {
            return string.Format("Hej {0}. Du bruger nr. {1} i sko. ", Name, Shoes);
        }
        public override string ToString()
        {
            return string.Format("Hej {0,15} du bruger størrelse {1} i sko", Name, Shoes);
        }
    }
}



