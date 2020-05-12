using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDrill
{
    public abstract class Person
    {
        public static string FirstName { get; set; }
        public static string LastName { get; set; }

        public abstract void SayName();
    }
}
