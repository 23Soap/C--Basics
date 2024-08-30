using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type casting = Converting a value to a different data type
            //                useful when we accept user input ( string )
            //                different data types can do different things.

            double a = 3.14;
            int b = Convert.ToInt32(a);

            Console.WriteLine(b.GetType());

            int c = 123;
            double d = Convert.ToDouble(c);

            Console.WriteLine(d.GetType());

            int e = 321;
            string f = Convert.ToString(e);
            Console.WriteLine(f.GetType());

            string g = "$";
            char h = Convert.ToChar(g);

            Console.WriteLine(h.GetType());

            string i = "true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(j.GetType());

            Console.ReadKey();
        }
    }
}
