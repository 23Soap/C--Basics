using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Yusuf OZCAN";
            string phoneNumber = "123-456-7890";

            //ToUpper() --> this is make it all the chars UPPERCASE
            //fullName = fullName.ToUpper();

            //ToLower() --> this is make it all the chars lowercase
            //fullName = fullName.ToLower();
            //Console.WriteLine(fullName);

            //Replace() --> it is allow us to replace characters(  Replace("remove","add");  )
            //phoneNumber = phoneNumber.Replace("-","/");
            //Console.WriteLine(phoneNumber);

            //string userName = fullName.Insert(0, "Mr.");
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length);

            String firstName = fullName.Substring(0,5);
            String lastName = fullName.Substring(5,6);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            

            Console.ReadKey();
        }
    }
}
