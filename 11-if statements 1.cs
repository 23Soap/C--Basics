using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if statement = a basic form of decision making
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age > 100)
            {
                Console.WriteLine("You are too old");
            }else if(age < 0)
            {
                Console.WriteLine("You have not been born yet");
            }else if (age >= 18)
            {
                Console.WriteLine("You can get the Driver Licance");
            }
            else
            {
                Console.WriteLine("You Can not get the Driver Licance ");
            }

            Console.ReadKey();
        }
    }
}
