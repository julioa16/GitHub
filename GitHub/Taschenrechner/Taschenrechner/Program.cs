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
            string wert1;
            string wert2;
            string wert;
            string ergebnis = "";
            double zahl1;
            double zahl2;
            do_something dos = new do_something();

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
            {
                ergebnis = dos.addition(zahl1, zahl2);
            }
            else if (wert == "-")
            {
                // ergebnis = dos.subtraktion(zahl1, zahl2);
            }
            else if (wert == "*")
            {
                ergebnis = dos.multiplikation(zahl1, zahl2);
            }
            else if (wert == "/")
            {
                //ergebnis = dos.division(zahl1, zahl2);
            }

            Console.WriteLine(ergebnis);
            Console.ReadLine();
        }
    }
}
