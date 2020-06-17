using System;

namespace TryCatchAgeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your age?");
            try
            {
                int personAge = Convert.ToInt32(Console.ReadLine());
                if (personAge <= 0)
                {
                    throw new AgeException();
                }
                var today = DateTime.Today;
                var birthYear = today.AddYears(-personAge);
                Console.WriteLine(birthYear);

            }
            catch(AgeException)
            {
                Console.WriteLine("Please enter a valid age. This cannot be less than or equal to zero. Thank You.");
            }
            catch(Exception)
            {
                Console.WriteLine("An error as occured. Please contact support, thank you.");
            }
        }
    }
}
