using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_22
    {
        static void Main(String[] args)
        {
            int ang_a, ang_b, ang_c, sum;

            Console.Write("Input angle1 of triangle: ");
            ang_a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input angle 2 of triangle: ");
            ang_b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input angle 3 of triangle: ");
            ang_c = Convert.ToInt32(Console.ReadLine());

            /* Calculate the sum of all angles of triangle */
            sum = ang_a + ang_b + ang_c;

            /* Check whether sum=180 then its a valid triangle otherwise not */
            if (sum == 180)
            {
                Console.Write("The triangle is valid.\n");
            }
            else
            {
                Console.Write("The triangle is not valid.\n");
            }
        }
    }
}
