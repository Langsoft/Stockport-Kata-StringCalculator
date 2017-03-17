using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorCore
{
    public static class Utilities
    {
        public static bool isPerfectSquare(double x)
        {
            double s = Math.Sqrt(x);
            return (s * s == x);
        }

        // Returns true if n is a Fibinacci Number, else false
        public static bool isFibonacci(double n)
        {
            // n is Fibinacci if one of 5*n*n + 4 or 5*n*n - 4 or both
            // is a perferct square
            //return isPerfectSquare(5 * n * n + 4) ||
            //       isPerfectSquare(5 * n * n - 4);

            double dRes1 = Math.Sqrt((5 * Math.Pow(n, 2)) - 4);
            int nRes1 = (int)dRes1;
            double dDecPoint1 = dRes1 - nRes1;

            double dRes2 = Math.Sqrt((5 * Math.Pow(n, 2)) + 4);
            int nRes2 = (int)dRes2;
            double dDecPoint2 = dRes2 - nRes2;

            if (!Convert.ToBoolean (dDecPoint1) || !Convert.ToBoolean(dDecPoint2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
