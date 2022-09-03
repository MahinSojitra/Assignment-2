using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_9
    {
        static void Main(String[] args)
        {
            string answer;
            string result;

            Console.Write("Input a Number : ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                // for binary conversation base is 2
                int remainder = num % 2;  
                result = Convert.ToString(remainder) + result;

                // for binary conversation base is 2
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary : {0}", result);
        }
    }
}
