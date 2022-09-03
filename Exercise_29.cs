using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_29
    {
        static void Main(String[] args)
        {
			int month_no;

			Console.Write("Input Month No : ");
			month_no = Convert.ToInt32(Console.ReadLine());

			switch (month_no)
			{
				case 1:
					Console.Write("January\n");
					break;
				case 2:
					Console.Write("February\n");
					break;
				case 3:
					Console.Write("March\n");
					break;
				case 4:
					Console.Write("April\n");
					break;
				case 5:
					Console.Write("May\n");
					break;
				case 6:
					Console.Write("June\n");
					break;
				case 7:
					Console.Write("July\n");
					break;
				case 8:
					Console.Write("August\n");
					break;
				case 9:
					Console.Write("September\n");
					break;
				case 10:
					Console.Write("October\n");
					break;
				case 11:
					Console.Write("November\n");
					break;
				case 12:
					Console.Write("December\n");
					break;
				default:
					Console.Write("invalid Month number. \nPlease try again ....\n");
					break;
			}
		}
    }
}
