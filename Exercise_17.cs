using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_17
    {
        static void Main(String[] args)
        {
            int num1, num2, num3;

            Console.Write("Input the 1st number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 2nd number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");
        }
    }
}
