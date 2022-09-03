using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_27
    {
        static void Main(String[] args)
        {
			int day_no;

			Console.Write("Input Day Number : ");
			day_no = Convert.ToInt32(Console.ReadLine());

			switch (day_no)
			{
				case 1:
					Console.Write("Monday \n");
					break;
				case 2:
					Console.Write("Tuesday \n");
					break;
				case 3:
					Console.Write("Wednesday \n");
					break;
				case 4:
					Console.Write("Thursday \n");
					break;
				case 5:
					Console.Write("Friday \n");
					break;
				case 6:
					Console.Write("Saturday \n");
					break;
				case 7:
					Console.Write("Sunday  \n");
					break;
				default:
					Console.Write("Invalid day number. \nPlease try again ....\n");
					break;
			}
		}
	}
}
