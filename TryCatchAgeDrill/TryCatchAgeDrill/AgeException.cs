using System;
using System.Collections.Generic;
using System.Text;

namespace TryCatchAgeDrill
{
    public class AgeException : Exception
    {
        public AgeException()
            : base() { }

        public AgeException(string message)
            : base(message) { }
    }
}
