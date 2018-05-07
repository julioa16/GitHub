using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public class Taschenrechner
    {
        private int Number_1;
        private int Number_2;

        public Taschenrechner(int incomming_1, int incomming_2)
        {
            Number_1 = incomming_1;
            Number_2 = incomming_2;
        }


        public int addidtion()
        {
            return (Number_1 + Number_2);
        }

        public int subtraction()
        {
            //return (Number_1 - Number_2);
            return 0;
        }

        public int multiplication()
        {
            return (Number_1 * Number_2);
        }

        public int division()
        {
            //return (Number_1 - Number_2);
            return 0;
        }
    }
}
