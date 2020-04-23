using System;

namespace PackageExpressDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. ");

            // Package Weight
            Console.WriteLine("What is the weight of the package?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Environment.Exit(-1);
            }

            // Package Width
            Console.WriteLine("What is the width of your package?");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            // Package Height
            Console.WriteLine("What is the height of you package?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            // Package Length
            Console.WriteLine("What is the length of your package?");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            if ((packageWidth + packageLength + packageHeight) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Environment.Exit(-1);
            }

            int totalDimension = packageHeight * packageLength * packageWidth;
            double totalResult = (totalDimension * packageWeight) / 100;

            Console.WriteLine("Your estimated total for shipping this package is: $" + totalResult + ".00");
            Console.WriteLine("Thank You.");

        }
    }
}
