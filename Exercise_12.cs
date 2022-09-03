using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_12
    {
        static void Main(String[] args)
        {
            int num;

            Console.Write("Input an integer : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
                Console.WriteLine("{0} is a Positive Number.\n", num);
            else
                Console.WriteLine("{0} is a Negative Number. \n", num);
        }
    }
}
