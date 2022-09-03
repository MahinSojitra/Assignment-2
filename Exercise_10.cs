using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_10
    {
        static void Main(String[] args)
        {
            int int1, int2;

            Console.Write("Input 1st number: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            if (int1 == int2)
                Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
            else
                Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);
        }
    }
}
