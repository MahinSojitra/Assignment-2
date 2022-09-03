using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_23
    {
        static void Main(String[] args)
        {
            char ch;

            Console.Write("Input an Alphabet (A-Z or a-z) : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.Write("You entered a number, Please enter an alpahbet.");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is not a vowel");
                        break;
                }
            }
        }
    }
}
