using System;
using System.Collections.Generic;
using System.Text;

namespace ClassOverloadDrill
{
    class DrillMethods
    {

        public static int MethodOne(int numberOne )
        {
            int result = (numberOne * 15) + 20;
            return result;
        }

        public static double MethodOne(int numberOne, double decimalOne)
        {
            double decimalTwo = Convert.ToDouble(numberOne);
            double result = (decimalOne + decimalTwo) * 10;
            return result;
        }

        public static double MethodOne(int numberOne, double decimalOne, string stringOne)
        {
            int stringResult = Convert.ToInt32(stringOne);
            double stringDouble = Convert.ToDouble(stringResult);
            double integerDouble = Convert.ToDouble(numberOne);
            double result = (stringDouble + decimalOne + integerDouble) * 100;
            return result;


        }
    }
}
