using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_49
    {
        static void Main(String[] args)
        {
            int i, j;
            int[,] arr1 = new int[3, 3];

            /* Stored values into the array */
            Console.Write("Input elements in the matrix : \n");

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe Matrix is : \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}   ", arr1[i, j]);
            }
            Console.Write("\n\n");
        }
    }
}
