using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2
{
    class Rounding_func
    {
        // The Ceiling Method
        public static Int64 ceil(double x)
        {
            return (Int64)Math.Ceiling(x);
        }
        // The Floor Method
        public static Int64 floor(double x)
        {
            return (Int64)Math.Floor(x);
        }
        // The Truncation Method
        public static Int64 trunc(double x)
        {
            if (x>0)
            {
                return (Int64)Math.Floor(x);
            }
            else
            {
                return (Int64)Math.Ceiling(x);
            }
        }
    }
}
