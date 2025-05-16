using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Print_string_in_Reverse
{

    /* Instructions
     * Ask user to input a message
     * Print in order
     * Print in reverse
     */

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a string: ");
            string message = Console.ReadLine();

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
            }

            Console.WriteLine("");

            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }


            Console.ReadLine();
        }
    }
}
