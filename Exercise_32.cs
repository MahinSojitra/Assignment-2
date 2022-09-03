using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_32
    {
        static void Main(String[] args)
        {
            int[] arr = new int[10];
            int i;

            Console.Write("Input 10 elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are : ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
        }
    }
}
