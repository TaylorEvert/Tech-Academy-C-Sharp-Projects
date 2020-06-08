using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LamdaDrill
{
    public class Employee<T> : Person, IQuittable
    {

        public List<T> Things { get; set; }

        public void Quit()
        {
            Console.WriteLine("This line was generated from a method that was inherited from an interface. ");
        }

        //public static bool operator ==(Employee X, Employee Y)
        //{
        //    bool status = false;
        //    if (X.Id == Y.Id)
        //    {
        //        status = true;
        //    }
        //    return status;
        //}

        //public static bool operator !=(Employee X, Employee Y)
        //{
        //    bool status = true;
        //    if (X.Id != Y.Id)
        //    {
        //        status = false;
        //    }
        //    return status;
        //}
    }
}
