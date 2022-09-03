using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_53
    {
        static void Main(String[] args)
        {
            int i, j, n, sum = 0;

            Console.Write("Enter the size of matrix (less than 5) : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n < 5 && n != 0)
            {
                // declare array of given size
                int[,] mat_1 = new int[n, n];

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

                // Calculate sum of left Diagonal of Matrix and print it
                for (i = 0; i < n; i++)
                {
                    sum += mat_1[i, (n - 1) - i];
                }

                Console.WriteLine("Sum of Left Diagonal of a Matrix is : {0}", sum);
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
