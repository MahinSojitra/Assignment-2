using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_54
    {
        static void Main(String[] args)
        {
            int i, j, n;
            int[,] arr1 = new int[10, 10];
            int[] rsum = new int[10];
            int[] csum = new int[10];

            Console.Write("Input the size of the square matrix (less than 5) : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n < 5 && n != 0)
            {
                Console.Write("Input elements in the matrix : \n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("The matrix is : \n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                        Console.Write("{0}  ", arr1[i, j]);
                    Console.Write("\n");
                }

                /* Sum of rows */
                for (i = 0; i < n; i++)
                {
                    rsum[i] = 0;
                    for (j = 0; j < n; j++)
                        rsum[i] = rsum[i] + arr1[i, j];
                }

                /* Sum of Column */
                for (i = 0; i < n; i++)
                {
                    csum[i] = 0;
                    for (j = 0; j < n; j++)
                        csum[i] = csum[i] + arr1[j, i];
                }

                Console.Write("The sum of row and column of the matrix : \n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                        Console.Write("{0}    ", arr1[i, j]);
                    Console.Write("{0}    ", rsum[i]);
                    Console.Write("\n");
                }

                Console.Write("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0}   ", csum[j]);
                }
                Console.Write("\n\n");
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
