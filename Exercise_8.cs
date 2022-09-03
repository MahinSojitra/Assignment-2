using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_8
    {
        public static void Main()
        {
            int n1, n2;
            bool bothEven;
            Console.Write("Input First number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Second number : ");
            n2 = Convert.ToInt32(Console.ReadLine());

            bothEven = ((n1 % 2 == 0) && (n2 % 2 == 0)) ? true : false;

            Console.WriteLine(bothEven ? "there're numbers Even" : "there's a number odd");
        }
    }
}
