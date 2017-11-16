using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            InfoClass info1 = new InfoClass();
            info1.Name = "Jesper";
            info1.Shoes = 47;

            IFirstInterface if1 = info1;

            Console.WriteLine(info1.GetInfo());
            Console.WriteLine(if1.GetInfo());

            InfoClass info2 = new InfoClass();

            info2.Name = "Peter";
            info2.Shoes = 42;

            Object o1 = info2;


            if (o1 is IFirstInterface)
            {
                IFirstInterface ic =  (IFirstInterface)o1;
                Console.WriteLine(ic.GetInfo() + o1);
            }
            Console.ReadLine();
        }
    }
}
