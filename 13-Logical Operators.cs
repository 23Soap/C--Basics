using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LOGICAL OPERATORS = can be used to check if more than 1 condition is true/false

            // && (and)
            // || (or)

            Console.WriteLine("What is the temperature outside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("it is warm outside");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("do not go outside");

            }

            Console.ReadKey();
        }
    }
}
