using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    internal class Exercise_5
    {
        static void Main(String[] args)
        {
            double distance, time, speed;
            Console.Write("Enter Distance [in Kilometer(s)] : ");
            distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Time [in hour(s)] : ");
            time = Convert.ToDouble(Console.ReadLine());

            speed = distance / time;
            Console.WriteLine("Speed is : {0}KM/h", speed);
        }
    }
}
