using System;
using System.IO;

namespace NumberTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter a number: ");
            string answer = Console.ReadLine();

            File.WriteAllText(@"logdrill1.txt", answer);
            Console.WriteLine("File Says: " + File.ReadAllText(@"logdrill1.txt"));
        }
    }
}
