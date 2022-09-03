using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_6
    {
        static void Main(String[] args)
        {
            float r;
            float PI = 3.1415926535f;

            Console.Write("Radius : ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(4 * PI * (r * r));

            Console.WriteLine(4f / 3f * PI * (r * r * r));
        }
    }
}
