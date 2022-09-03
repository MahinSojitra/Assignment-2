using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    class Exercise_2
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the desired width : ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                width--;
            }
        }
    }
}
