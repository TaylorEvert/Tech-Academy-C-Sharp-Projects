using System;

namespace AbsractClassDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee.FirstName = "Sample";
            Employee.LastName = "Student";

            employee.SayName();
        }
    }
}
