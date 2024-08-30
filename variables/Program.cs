using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; //Declaration
            x = 123; //Initialization

            int y = 321;// declaration and initialization

            int z = x + y;

            int age = 21; // whole integer
            double height = 300.5; // decimal number
            bool alive = false; //True or False
            char symbol = '@';
            string name = "Yusuf";

            Console.WriteLine("Hello " + name);
            Console.WriteLine("your age is: " + age);
            Console.WriteLine("your height is: " + height + " cm");
            Console.WriteLine("are you alive? " + alive);
            Console.WriteLine("your symbol is: " + symbol);

            string username = symbol + name;

            Console.WriteLine("your username is: " + username); 
            

            Console.ReadKey();
        }
    }
}
