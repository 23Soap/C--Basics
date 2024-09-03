using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // foreach loop = a simpler way to iterate over an array, but its LESS fixeible

            String[] cars = new string[3];

            cars[0] = "Mercedes";
            cars[1] = "Ferrari";
            cars[2] = "McLaren";


            foreach(string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
