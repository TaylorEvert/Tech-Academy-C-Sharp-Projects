using System;

namespace InsuranceDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insurance Approval Program");

            Console.WriteLine("What is  your age?");
            int personAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer 'true' or 'false'.");
            bool personDui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int personTicket = Convert.ToInt32(Console.ReadLine());
            bool doesQualify = ((personAge > 15) && (personDui == false) && (personTicket < 3));
            Console.WriteLine("Qualified?");
            Console.WriteLine(doesQualify);
        }
    }
}
