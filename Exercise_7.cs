using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_7
    {
        static void Main(String[] args)
        {
            char symbol;

            Console.Write("Input a Symbol : ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                    (symbol == 'o') || (symbol == 'u'))
                Console.WriteLine("It's a lowercase vowel.");
            else if ((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another symbol.");
        }
    }
}
