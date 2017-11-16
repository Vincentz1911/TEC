using System;

namespace MyCompute
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Indtast ønsket regneart (+, -, * eller /): ");
                string strtest = Console.ReadLine();
                while (strtest.Length > 1 || (strtest.IndexOfAny("+-*/".ToCharArray()) != 0))
                {
                    Console.Write("Kan ikke genkende tegn, prøv igen: ");
                    strtest = Console.ReadLine();
                }
                char regnechar = strtest[0];

                Console.Write("Indtast det første tal: ");
                string strtal1 = Console.ReadLine();
                double dtal1 = 0;
                while (!double.TryParse(strtal1, out dtal1))
                {
                    Console.Write("Kan ikke genkende tal, prøv igen: ");
                    strtal1 = Console.ReadLine();
                }

                Console.Write("Indtast det andet tal: ");
                string strtal2 = Console.ReadLine();
                double dtal2 = 0;
                while ((!double.TryParse(strtal2, out dtal2) || ((strtal2 =="0") && regnechar=='/')))
                {
                    Console.Write("Kan ikke genkende tal, prøv igen: ");
                    strtal2 = Console.ReadLine();
                }

                double resultat = 0;
                switch (regnechar)
                {
                    case '+':
                        resultat = dtal1 + dtal2;
                        break;
                    case '-':
                        resultat = dtal1 - dtal2;
                        break;
                    case '*':
                        resultat = dtal1 * dtal2;
                        break;
                    case '/':
                        resultat = dtal1 / dtal2;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nResultatet af {0} {1} {2} er lig med {3} ( {0} {1} {2} = {3} )", dtal1, regnechar, dtal2, resultat);
                Console.Write("\nPrøv igen eller skriv Q for at Quitte: ");

            } while ((Console.ReadLine()) != "Q");
        }
    }
}
