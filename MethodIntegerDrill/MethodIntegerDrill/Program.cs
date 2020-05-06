using System;
using System.Collections.Generic;

namespace MethodIntegerDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            // First method to do work with
            Console.WriteLine("Please enter a whole number: ");
            int methodOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Method One Output: " + IntegerMethods.IntegerOne(methodOne));

            // Second method input for math
            Console.WriteLine("Please enter another whole number: ");
            int methodTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Method Two Output: " + IntegerMethods.IntegerTwo(methodTwo));

            // Third method to produce outpute based on user input
            Console.WriteLine("Please enter the final whole number: ");
            int methodThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Method Three Output: " + IntegerMethods.IntegerThree(methodThree));
        }
    }
}
