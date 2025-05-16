using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Odd_and_Even_Checker
{

    /* Instructions
     * Create & initialise two ints
     * Make a variable to work out the remainder
     * Output a remainder to the screen
     * Change the first in variable to another number
     * and recalcualate the remainder
     * output new remainder to the screen 
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 31,
                b = 3;

            int c = 10,
                d = 2;

            Console.WriteLine(a % b);
            Console.WriteLine(c % d);

            Console.ReadLine();
        }
    }
}
