using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Numbers
{
    internal class numbers8
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // it is creating random numbers --> random.Next()
            // int num = random.Next(1, 21) + 100;

            // it is makes a random number between 0 to 1. --> random.NextDouble()
            //double num = random.NextDouble();

            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);


            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.ReadKey();  
        }
    }
}
