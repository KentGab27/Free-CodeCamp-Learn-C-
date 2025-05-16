using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercise___Array_of_Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            int length = 9;
            int[] result = new int[length];
            int counter = 0;
            
            for (int i = 1; i <= result.Length; i++, counter++)
            {
                result[counter] = num * i;
            }

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            
            Console.ReadLine();

        }
    }
}
