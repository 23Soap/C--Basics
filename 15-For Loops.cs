using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loop = repeats some code a finite amount of times
            /*
            for(int i = 0; i < 10;i++)
            {
                Console.WriteLine(i);
            }
            */

            for (int i = 10; i >0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Happy new year!!");

            Console.ReadKey();  
        }
    }
}
