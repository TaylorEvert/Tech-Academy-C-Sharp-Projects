using System;

namespace LoopComparisonDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 10");
            int numberChosen = Convert.ToInt32(Console.ReadLine());
            bool isOver = false;

            while (numberChosen <= 10)
            {
                Console.WriteLine(numberChosen);
                numberChosen += 1;
                if (numberChosen > 10)
                {
                    isOver = true;
                }
            }

            do
            {
                Console.WriteLine(numberChosen);
                numberChosen--;
                if (numberChosen < 1)
                {
                    isOver = false;
                    Console.WriteLine("Done counting!");
                }
            } while (isOver);
        }
    }
}
