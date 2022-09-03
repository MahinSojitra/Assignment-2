using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_20
    {
        static void Main(String[] args)
        {
            int tmp;

            Console.Write("Input days temperature : ");
            tmp = Convert.ToInt32(Console.ReadLine());

            if (tmp < 0)
                Console.Write("Freezing weather.\n");
            else if (tmp < 10)
                Console.Write("Very cold weather.\n");
            else if (tmp < 20)
                Console.Write("Cold weather.\n");
            else if (tmp < 30)
                Console.Write("Normal in temp.\n");
            else if (tmp < 40)
                Console.Write("Its Hot.\n");
            else
                Console.Write("Its very hot.\n");
        }
    }
}
