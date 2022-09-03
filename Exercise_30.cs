using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_30
    {
        static void Main(String[] args)
        {
			int month_no;

			Console.Write("Input Month No : ");
			month_no = Convert.ToInt32(Console.ReadLine());

			switch (month_no)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					Console.Write("Month  have 31 days. \n");
					break;
				case 2:
					Console.Write("The 2nd month is a February and have 28 days. \n");
					Console.Write("in leap year The February month  Have 29 days.\n");
					break;
				case 4:
				case 6:
				case 9:
				case 11:
					Console.Write("Month have 30 days. \n");
					break;
				default:
					Console.Write("invalid Month number.\nPlease try again ....\n");
					break;
			}
		}
    }
}
