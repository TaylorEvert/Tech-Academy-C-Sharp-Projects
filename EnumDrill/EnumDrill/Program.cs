using System;
using System.Collections.Generic;
using System.Text;

namespace EnumDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week: ");
                string dayAnswer = Console.ReadLine();

                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayAnswer);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }
}
