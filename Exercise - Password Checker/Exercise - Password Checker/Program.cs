using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Password_Checker
{
    /* Instructions
     * Ask user to enter password and store
     * Ask user to enter password again and store
     * Check if they both are containing something
        * If so check if they are the same
            * If they are, print "Passwords match"
            * If they are not, print "Passwords do not match"
        *If they are empty, print "Please enter a password"
        */
           
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Enter the password again: ");
            string password2 = Console.ReadLine();

            if (string.IsNullOrEmpty(password))
            {

                Console.WriteLine("Please enter a password");
            }

            else if (password.Equals(password2))
            {
                Console.WriteLine("Passwords match");
            }

            else 
            {
                Console.WriteLine("Passwords do not match");
            }


            Console.ReadLine();
        }
    }
}
