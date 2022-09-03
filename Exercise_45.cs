using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_45
    {
        static void Main(String[] args)
        {
            int[] arr1 = new int[10];
            int i, n, p, x;

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            /* Stored values into the array */
            Console.Write("Input {0} elements in the array in ascending order : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input the value to be inserted : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Position, where the value to be inserted : ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("The current list of the array : \n");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", arr1[i]);

            /* Move all data at right side of the array */
            for (i = n; i >= p; i--)
                arr1[i] = arr1[i - 1];

            /* insert value at given position */
            arr1[p - 1] = x;

            Console.Write("\n\nAfter Insert the element the new list is : \n");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", arr1[i]);
            Console.Write("\n\n");
        }
    }
}
