using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_40
    {
        static void Main(String[] args)
        {
            int[] arr1 = new int[100];
            int i, mx, mn, n;

            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            mx = arr1[0];
            mn = arr1[0];

            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }

                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }
            Console.Write("Maximum element is : {0}\n", mx);
            Console.Write("Minimum element is : {0}\n\n", mn);
        }
    }
}
