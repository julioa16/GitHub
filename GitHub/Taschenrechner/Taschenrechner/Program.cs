using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            string wert1, wert2, wert;
            double zahl1, zahl2;

            Console.WriteLine("Zahl1");
            wert1 = Console.ReadLine();

            Console.WriteLine("Zeichen");
            wert = Console.ReadLine();

            Console.WriteLine("Zahl2");
            wert2 = Console.ReadLine();

            zahl1 = Double.Parse(wert1);
            zahl2 = Double.Parse(wert2);

            Console.WriteLine("Ergebnis");
            if (wert == "+")
                Console.WriteLine(zahl1 + zahl2);
            else if (wert == "-")
                Console.WriteLine(zahl1 - zahl2);
            else if (wert == "*")
                Console.WriteLine(zahl1 * zahl2);
            else if (wert == "/")
                Console.WriteLine(zahl1 / zahl2);

            Console.ReadLine();
        }
    }
}
