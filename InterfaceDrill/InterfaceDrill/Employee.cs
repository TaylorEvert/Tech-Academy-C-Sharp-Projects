using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDrill
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("This line was generated from a method that was inherited from an interface. ");
        }
    }
}
