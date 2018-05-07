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
            int Number_1;
            int Number_2;
            string Operator;
            string Result;

            Console.WriteLine("Zahl 1:");
            Number_1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Zahl 2:");
            Number_2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Operator:");
            Operator = (Console.ReadLine());

            Taschenrechner Taschenrechner= new Taschenrechner(Number_1, Number_2);

            if (Operator == "+")
            {
                Result = (Taschenrechner.addidtion()).ToString();
            }
            else if (Operator == "-")
            {
                // ToDo: Subtraction
                Result = "0";
            }
            else if (Operator == "*")
            {
                Result = (Taschenrechner.multiplication()).ToString();
            }
            else if (Operator == "/")
            {
                // ToDo: Division
                Result = "0";
            }
            else
            {
                Result = "Es wurde kein Operator eingegeben";
            }

            Console.WriteLine("Ergenis:");
            Console.WriteLine(Result);
            Console.ReadLine();
        }
    }
}
