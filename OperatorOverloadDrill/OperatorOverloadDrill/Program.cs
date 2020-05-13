using System;

namespace OperatorOverloadDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quittable = new Employee();
            quittable.Quit();

            Employee X = new Employee();
            Employee Y = new Employee();

            X.Id = 06;
            Y.Id = 07;
            Console.WriteLine(X.Id == Y.Id);
        }
    }
}
