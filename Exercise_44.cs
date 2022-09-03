using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_44
    {
        static void Main(String[] args)
        {
            int[] arr1 = new int[10];
            int i, n, p = 0, inval;

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
            inval = Convert.ToInt32(Console.ReadLine());

            Console.Write("The exist array list is : \n ");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", arr1[i]);

            /* Determine the position where the new value will be insert. */
            for (i = 0; i < n; i++)
                if (inval < arr1[i])
                {
                    p = i;
                    break;
                }

            /* move all data at right side of the array */
            for (i = n; i >= p; i--)
                arr1[i] = arr1[i - 1];

            /* insert value at the proper position */
            arr1[p] = inval;

            Console.Write("\n\nAfter Insert the list is : \n ");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", arr1[i]);
            Console.Write("\n");
        }
    }
}
