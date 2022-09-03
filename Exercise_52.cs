using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_52
    {
        static void Main(String[] args)
        {
            int i, j, n;
            int[,] mat_1 = new int[6, 6];
            int[,] mat_2 = new int[6, 6];

            Console.Write("Enter the size of matrix (less than 5) : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n < 5 && n != 0)
            {
                // initialize matrixs of array by user
                Console.Write("\nMatrix : 1\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("Enter Element [{0}, {1}] : ", i, j);
                        mat_1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("\nMatrix : 2\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("Enter Element [{0}, {1}] : ", i, j);
                        mat_2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // display matrixs 
                Console.Write("\nMatrix : 1\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("{0} ", mat_1[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.Write("\nMatrix : 2\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("{0} ", mat_2[i, j]);
                    }
                    Console.WriteLine();
                }

                // Calculate Multiplication Matrix and print it 
                Console.Write("\nMultiplication Matrix :\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("{0} ", (mat_1[i, j] * mat_2[i, j]));
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                if (n == 0)
                    Console.WriteLine("\nSize of the array can't be 0 ! \nIt must be grater than 0 or less than 5.");
                else
                    Console.WriteLine("\nSize of the array is too large ! \nIt must be less than 5.");
            }
        }
    }
}
