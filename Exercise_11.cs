using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_11
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");
            i = Convert.ToInt32(Console.ReadLine());

            if (i % 2 == 0)
                Console.Write("Entered Number is an Even Number");
            else
                Console.Write("Entered Number is an Odd Number");
        }
    }
}
