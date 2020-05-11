using System;

namespace SuperClassDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Employee employee = new Employee();

            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();
        }
    }
}
