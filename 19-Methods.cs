using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //method = performs a section of code, whenever its called "invoked"
            //benefit = lets us reuse code w/o writing it multiple times.

            string name = "Yusuf";
            int age = 21;
            singHappyBirthday(name,age);

            Console.ReadKey();
        }
        static void singHappyBirthday(string name,int age) 
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + name);
            Console.WriteLine("You are " + age + "years old");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
    }
}
