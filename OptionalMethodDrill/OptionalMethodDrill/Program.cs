using System;

namespace OptionalMethodDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number: ");
            int answerOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another whole number. This is optional: ");
            int results;
            string answerTwo = Console.ReadLine();
            if (answerTwo == "")
            {
                results = Methods.OptionalMethod(answerOne);
            }
            else 
            {
                int answerThree = Convert.ToInt32(answerTwo);
                results = Methods.OptionalMethod(answerOne, answerThree);
            }


            Console.WriteLine("Results: " + results);
        }
    }
}
