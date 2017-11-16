using System;

namespace Interfaces
{
    class InfoClass : IFirstInterface
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

        public string GetInfo()
        {
            return string.Format("Hej {0}. Du bruger nr. {1} i sko. ", Name, Shoes);
        }
        public string BlaInfo()
        {
            return string.Format("Hej {0}. Du bruger nr. {1} i sko. ", Name, Shoes);
        }


    }
}
