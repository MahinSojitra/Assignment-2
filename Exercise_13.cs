using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_13
    {
        static void Main(String[] args)
        {
            int year;

            Console.Write("Input an Year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", year);
            else if ((year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", year);
            else if ((year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", year);
            else
                Console.WriteLine("{0} is not a leap year.\n", year);
        }
    }
}
