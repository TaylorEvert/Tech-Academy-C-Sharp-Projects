using System;

namespace OperatorOverloadDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quittable = new Employee();
            quittable.Quit();
        }
    }
}
