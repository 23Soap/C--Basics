using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while loop = repeats some code while some condition remains true
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            while (name == "")
            {
                Console.WriteLine("You have to enter your name");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}
