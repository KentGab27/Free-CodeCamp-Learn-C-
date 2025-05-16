using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Times_Table
{
    internal class Program
    {

        /* Instructions
         * Ask the user for a number for the table
         * Write a for loop to print X times table
         * */

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number for the times table: ");
            int table = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter how many times will it multiply: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            for (int i = 0; i <= limit; i++) 
            {
                Console.WriteLine("{0} x {1} = {2}", i, table, i * table);
            }
            Console.ReadLine();
        }
    }
}
