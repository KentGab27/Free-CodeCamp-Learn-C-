﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Fizz_Buzz_Game
{
    internal class Program
    {

        /* Instructions
         * Create a loop from 1 to X (15)
         * 3 and 5 = FizzBuzz
         * 3 = Fizz
         * 5 = Buzz
         * else = number
         * */

        static void Main(string[] args)
        {

            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine("Number");
                }
            }

            Console.ReadLine();
        }
    }
}
