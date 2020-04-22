using System;

namespace DailyReportDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string whatPageNumber = Console.ReadLine();
            int pageNumber = Convert.ToInt32(whatPageNumber);

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
            string doesNeedHelp = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(doesNeedHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string howManyHours = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(howManyHours);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
