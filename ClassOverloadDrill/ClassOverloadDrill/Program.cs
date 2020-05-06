using System;

namespace ClassOverloadDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOne = DrillMethods.MethodOne(50);
            Console.WriteLine(numberOne);

            double numberTwo = DrillMethods.MethodOne(50, 56.7);
            Console.WriteLine(numberTwo);

            double stringNumber = DrillMethods.MethodOne(50, 56.7, "12");
            Console.WriteLine(stringNumber);
        }
    }
}
