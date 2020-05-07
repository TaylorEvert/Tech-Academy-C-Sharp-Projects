using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalMethodDrill
{
    class Methods
    {
        public static int OptionalMethod(int numberOne, int numberTwo = 0)
        {
            int mathOne = (numberOne * 10) / 5;
            int mathTwo = (numberTwo * 5) / 2;
            int result = (mathOne + mathTwo);
            return result;
        }
    }
}
