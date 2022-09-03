using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_21
    {
        static void Main(String[] args)
        {
            int side_a, side_b, side_c;

            Console.Write("Input side 1 of triangle: ");
            side_a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            side_b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 3 of triangle: ");
            side_c = Convert.ToInt32(Console.ReadLine());

            if (side_a == side_b && side_b == side_c)
            {
                Console.Write("This is an equilateral triangle.\n");
            }
            else if (side_a == side_b || side_a == side_c || side_b == side_c)
            {
                Console.Write("This is an isosceles triangle.\n");
            }
            else
            {
                Console.Write("This is a scalene triangle.\n");
            }
        }
    }
}
