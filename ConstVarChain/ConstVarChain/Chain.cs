using System;
using System.Collections.Generic;
using System.Text;

namespace ConstVarChain
{
    public class Chain
    {
        public Chain(string namedPerson) : this(namedPerson, namedLocation: "Earth") { }
        public Chain(string namedPerson, string namedLocation)
        {
            string name = namedPerson;
            string location = namedLocation;
            Console.WriteLine("Thank you {0}, from {1} for using my program! Have a great day!", name, location);
        }

    }
}
