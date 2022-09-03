using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_33
    {
        static void Main(String[] args)
        {
            int i, n;
            int[] a = new int[100];

            Console.Write("Input the number of elements to store in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} number of elements in the array : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values store into the array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            Console.Write("\n\nThe values store into the array in reverse are : \n");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("\n\n");
        }
    }
}
