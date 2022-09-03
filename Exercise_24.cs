using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_24
    {
        static void Main(String[] args)
        {
            int cprice, sprice, plamt;

            Console.Write("Input Cost Price: ");
            cprice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Selling Price: ");
            sprice = Convert.ToInt32(Console.ReadLine());

            if (sprice > cprice)
            {
                plamt = sprice - cprice;
                Console.Write("\nYou can booked your profit amount : {0}\n", plamt);
            }
            else if (cprice > sprice)
            {
                plamt = cprice - sprice;
                Console.Write("\nYou got a loss of amount : {0}\n", plamt);
            }
            else
            {
                Console.Write("\nYou are running in no profit no loss condition.\n");
            }
        }
    }
}
