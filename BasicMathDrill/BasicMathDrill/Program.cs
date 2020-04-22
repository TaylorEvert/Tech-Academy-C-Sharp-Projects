using System;

namespace BasicMathDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take input and multiplies it by 50 then prints results
            Console.WriteLine("Please enter a number to be multiplied: ");
            string multiplyNumber = Console.ReadLine();
            int chosenMulNumber = Convert.ToInt32(multiplyNumber);
            int mulResult = chosenMulNumber * 50;
            Console.WriteLine("Results: " + mulResult);

            // Take input and adds 25 to it then prints results
            Console.WriteLine("Please enter a number to be added: ");
            string addNumber = Console.ReadLine();
            int chosenAddNumber = Convert.ToInt32(addNumber);
            int addResult = chosenAddNumber + 25;
            Console.WriteLine("Results: " + addResult);

            // Take input and divide by 12.5 then print results
            Console.WriteLine("Please enter a number to be divided: ");
            string divNumber = Console.ReadLine();
            double chosenDivNumber = Convert.ToInt32(divNumber);
            double divResult = chosenDivNumber / 12.5;
            Console.WriteLine("Results: " + divResult);

            // Take input and check if greater than 50 then print true/false
            Console.WriteLine("Please enter a number to be checked: ");
            string checkNumber = Console.ReadLine();
            int toNumber = Convert.ToInt32(checkNumber);
            bool isNumber = toNumber > 50;
            Console.WriteLine("Results: " + isNumber);

            // Take input and divide it by 7 then print the remainder
            Console.WriteLine("Please enter a number to be divided: ");
            string modNumber = Console.ReadLine();
            double chosenModNumber = Convert.ToInt32(modNumber);
            double modResult = chosenModNumber % 7;
            Console.WriteLine("Results: " + modResult);

            Console.Read();

        }
    }
}
