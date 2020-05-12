using System;

namespace InterfaceDrill
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
