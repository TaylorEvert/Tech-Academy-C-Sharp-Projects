using System;

namespace OptionalMethodDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number: ");
            int answerOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another whole number. This is optional, please enter '0' if you wish to not answer: ");
            int answerTwo = Convert.ToInt32(Console.ReadLine());

            int results = Methods.OptionalMethod(answerOne, answerTwo);
            Console.WriteLine("Results: " + results);
        }
    }
}
