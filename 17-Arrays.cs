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
            // arrays = a variable that can store multiple values. fixed size

            // string[] cars = { "BMW","Ferrari","McLaren" };

            String[] cars = new string[3];

            cars[0] = "Mercedes";
            cars[1] = "Ferrari";
            cars[2] = "McLaren";

            for (int i =0; i < cars.Length;i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.ReadKey();
        }
    }
}
