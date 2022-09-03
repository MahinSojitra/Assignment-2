using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_14
    {
        static void Main(String[] args)
        {
            int age;

            Console.Write("Input the age of the candidate : ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.Write("Sorry, You are not eligible to caste your vote.\n");
                Console.Write("You would be able to caste your vote after {0} year.\n\n", 18 - age);
            }
            else
                Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
        }
    }
}
