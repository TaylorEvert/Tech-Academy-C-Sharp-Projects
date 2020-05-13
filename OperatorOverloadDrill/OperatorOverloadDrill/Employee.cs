using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloadDrill
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("This line was generated from a method that was inherited from an interface. ");
        }

        public static bool operator ==(Employee X, Employee Y)
        {
            bool status = false;
            if (X.Id == Y.Id)
            {
                status = true;
            }
            return status;
        }

        public static bool operator !=(Employee X, Employee Y)
        {
            bool status = true;
            if (X.Id != Y.Id)
            {
                status = false;
            }
            return status;
        }
    }
}
