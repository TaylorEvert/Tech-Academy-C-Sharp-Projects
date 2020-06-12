using System;

namespace DateNumberDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Hello! Please enter a number: ");
            double answer = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(answer));
        }
    }
}
