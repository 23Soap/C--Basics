using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("You are " + age + " years old.");

            Console.ReadLine();
        }
    }
}
