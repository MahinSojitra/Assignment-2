using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_46
    {
        static void Main(String[] args)
        {
            int i, pos, n;
            int[] arr1 = new int[50];

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            /* Stored values into the array */
            Console.Write("Input {0} elements in the array in ascending order : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nInput the position where to delete : ");
            pos = Convert.ToInt32(Console.ReadLine());

            /* ------- locate the position of i in the array ------- */
            i = 0;
            while (i != pos - 1)
                i++;

            /* 
             * the position of i in the array will be replaced by the 
             * value of its right 
            */
            while (i < n)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            n--;
            Console.Write("\nThe new list is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", arr1[i]);
            }
            Console.Write("\n\n");

        }
    }
}
