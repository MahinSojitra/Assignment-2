using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_4
    {
        static void Main(String[] args)
        {
            double r, per_cir, PI = 3.14;
            Console.Write("Enter Radius Of a Circle : ");
            r = Convert.ToDouble(Console.ReadLine());

            per_cir = 2 * PI * r;
            Console.WriteLine("Perimeter of Circle is : {0}", per_cir);
        }
    }
}
