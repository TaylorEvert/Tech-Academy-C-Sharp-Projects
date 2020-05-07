using System;

namespace OverloadVoidDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidMethod methodOne = new VoidMethod();
            Console.WriteLine("Please enter a whole number: ");
            int answerOne = Convert.ToInt32(Console.ReadLine());
            VoidMethod.NumberMethod(out int resultMain, answerOne);
            Console.WriteLine(resultMain);


        }
    }
}
