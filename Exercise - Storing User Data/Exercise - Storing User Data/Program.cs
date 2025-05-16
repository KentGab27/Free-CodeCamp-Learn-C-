using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Storing_User_Data
{
    internal class Program
    {

        /* Instructions
         * Define a variable to hold your name
         * Define a variable to hold your phone number
         * Define a variable to hold your age
         * Extra: Define variables using the var keyword
         */

        static void Main(string[] args)
        {
            string name1 = "Kent";
            int phoneNumber1 = 1234567890;
            int age1 = 23;

            Console.WriteLine(name1);   
            Console.WriteLine(phoneNumber1);    
            Console.WriteLine(age1);

            Console.WriteLine("");

            var name = "Kent";
            var phoneNumber = 1234567890;
            var age = 23;

            Console.WriteLine(name);
            Console.WriteLine(phoneNumber); 
            Console.WriteLine(age);
            Console.ReadLine();
        }
    }
}
