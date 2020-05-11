using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadVoidDrill
{
    class VoidMethod
    {
        public static void NumberMethod(out int resultOne, int numberOne)
        {
            resultOne = numberOne / 2;
            
        }
        public static void NumberMethod(out int resultOne, int numberOne, int numberTwo = 0)
        {
            resultOne = (numberOne / 2) * numberTwo;
        }
    }
}
