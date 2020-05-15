using System;

namespace StructNumberDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 15.5M;
            Console.WriteLine(number.Amount);
        }
    }
}
