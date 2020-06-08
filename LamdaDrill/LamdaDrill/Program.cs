using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LamdaDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> employees = new List<Person>();

            Person employee1 = new Person();
            employee1.FirstName = "Joe";
            employee1.LastName = "Smith";
            employee1.Id = 0;
            employees.Add(employee1);

            Person employee2 = new Person();
            employee2.FirstName = "Jacob";
            employee2.LastName = "Hall";
            employee2.Id = 1;
            employees.Add(employee2);

            Person employee3 = new Person();
            employee3.FirstName = "Ashley";
            employee3.LastName = "Riek";
            employee3.Id = 2;
            employees.Add(employee3);

            Person employee4 = new Person();
            employee4.FirstName = "Nathan";
            employee4.LastName = "Riek";
            employee4.Id = 3;
            employees.Add(employee4);

            Person employee5 = new Person();
            employee5.FirstName = "Tre";
            employee5.LastName = "Hines";
            employee5.Id = 4;
            employees.Add(employee5);

            Person employee6 = new Person();
            employee6.FirstName = "Will";
            employee6.LastName = "Escobar";
            employee6.Id = 5;
            employees.Add(employee6);

            Person employee7 = new Person();
            employee7.FirstName = "Evan";
            employee7.LastName = "Cameron";
            employee7.Id = 6;
            employees.Add(employee7);

            Person employee8 = new Person();
            employee8.FirstName = "Hailey";
            employee8.LastName = "Everson";
            employee8.Id = 7;
            employees.Add(employee8);

            Person employee9 = new Person();
            employee9.FirstName = "Justin";
            employee9.LastName = "Hage";
            employee9.Id = 8;
            employees.Add(employee9);

            Person employee10 = new Person();
            employee10.FirstName = "Joe";
            employee10.LastName = "Swanson";
            employee10.Id = 9;
            employees.Add(employee10);

            List<Person> employees1 = new List<Person>();
            foreach (Person employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    employees1.Add(employee);
                    Console.WriteLine(employee.FirstName + employee.LastName + employee.Id);
                }
            }

            List<Person> employees2 = new List<Person>();
            var joeLambda = employees.Where(p => p.FirstName == "Joe");
            foreach (Person employee in joeLambda)
            {
                employees2.Add(employee);
                Console.WriteLine(employee.FirstName + employee.LastName + employee.Id);
            }

            List<Person> employees3 = new List<Person>();
            var fiveLambda = employees.Where(e => e.Id > 5);
            foreach (Person employee in fiveLambda)
            {
                employees3.Add(employee);
                Console.WriteLine(employee.FirstName + employee.LastName + employee.Id);
            }
        }
    }
}
