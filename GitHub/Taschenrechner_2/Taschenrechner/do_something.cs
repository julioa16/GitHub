using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class do_something
    {
        public string addition(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 + zahl2;
            return ergebnis.ToString();
        }

        public string multiplikation(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 * zahl2;
            return ergebnis.ToString();
        }
    }
}
