using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statements_2nd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("you didnt enter your name!");
            }
            else
            {
                Console.WriteLine("hello " + name);
            }

            Console.ReadKey();
        }
    }
}
