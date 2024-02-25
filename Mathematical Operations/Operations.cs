using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Operations
{
    public class Operations
    {
        public int Sum(int x , int y) // As this method is public, everyone has access to it.
        {
            return x + y;
        }
        protected int Subtract (int m , int n) // As this is protected, only derived classes have access.
        {
            return m - n;
        }

        internal int Multiplication (int e, int f) // As this method is internal, only classes contained in the same assembly have access.
        {
            return e * f;
        }

        private double Divison (int c, int d) // As this method is private, only the class that defines it has access to it.
        {
            if (d != 0) // An if is used in case you cannot divide by zero.
                return c / d;
            else
            {
                Console.WriteLine("In case it is 0, it cannot be divided.");
                return double.NaN; // NaN is used if the result of an operation is not defined.
            }
        }
    }
}
