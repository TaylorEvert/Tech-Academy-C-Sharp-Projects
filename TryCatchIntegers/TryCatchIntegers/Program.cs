using System;
using System.Collections.Generic;

namespace TryCatchIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numberList = new List<int>() { 800, 250, 325, 999, 225 };
                Console.WriteLine("Please enter a number. This number will be used to divide the numbers in the list.");
                int divideNumber = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numberList)
                {
                    int total = number / divideNumber;
                    Console.WriteLine("Output: " + total);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number. ");
            }
            finally
            {
                Console.WriteLine("Program has emerged from the try/catch block. ");
            }
        }
    }
}
