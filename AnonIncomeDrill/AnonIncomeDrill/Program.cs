using System;

namespace AnonIncomeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1, please enter information for the following categories: ");
            Console.WriteLine("Hourly Rate: ");
            int ratePerson1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            int weekPerson1 = Convert.ToInt32(Console.ReadLine());
            int weeklyPayPerson1 = ratePerson1 * weekPerson1;
            int monthlyPayPerson1 = weeklyPayPerson1 * 4;
            int annualPayPerson1 = monthlyPayPerson1 * 12;

            Console.WriteLine("Person 2, please enter information for the following categories: ");
            Console.WriteLine("Hourly Rate: ");
            int ratePerson2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            int weekPerson2 = Convert.ToInt32(Console.ReadLine());
            int weeklyPayPerson2 = ratePerson2 * weekPerson2;
            int monthlyPayPerson2 = weeklyPayPerson2 * 4;
            int annualPayPerson2 = monthlyPayPerson2 * 12;

            Console.WriteLine("Annual Salary of Person 1: " + annualPayPerson1);
            Console.WriteLine("Annual Salary of Person 2: " + annualPayPerson2);

            bool moreMoney = annualPayPerson1 > annualPayPerson2;
            Console.WriteLine("Does Person 1 make more money than Person 2: " + moreMoney);
        }
    }
}
