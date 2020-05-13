using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //IQuittable quittable = new Employee();
            //quittable.Quit();

            ////Employee X = new Employee();
            ////Employee Y = new Employee();

            //X.Id = 06;
            //Y.Id = 07;
            //Console.WriteLine(X.Id == Y.Id);

            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "This", "is", "a list", "of different", "strings to", "put together in a loop."};

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            foreach (string item in employee.Things)
            {
                Console.WriteLine(item);
            }

            foreach (int item in employee2.Things)
            {
                Console.WriteLine(item);
            }
        }
    }
}
