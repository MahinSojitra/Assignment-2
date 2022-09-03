using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    class Exercise_3
    {
        static void Main(string[] args)
        {
            int x, y;
            char operation;

            Console.Write("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input operation: ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            else if (operation == '-')
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            else if (operation == '/')
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            else
                Console.WriteLine("Wrong Character");
        }
    }
}
