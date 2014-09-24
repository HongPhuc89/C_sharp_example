using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2
{
    class Trigonometric_func
    {
        // Get cos(x) -- x_unit : rad
        public static double cos(double x)
        {
            return Math.Cos(x);
        }
        // Get sin(x) -- x_unit : rad
        public static double sin(double x)
        {
            return Math.Sin(x);
        }
        // Get tan(x) -- x_unit : rad
        public static double tan(double x)
        {
            return Math.Tan(x);
        }
        // Get sec(x) = 1/cos(x)
        public static double sec(double x)
        {
            return (1.0 / Math.Cos(x));
        }
        // Get csc(x) = 1/sin(x)
        public static double csc(double x)
        {
            return (1.0 / Math.Sin(x));
        }
        // Get cot(x) = 1/tan(x)
        public static double cot(double x)
        {
            return (1.0 / Math.Tan(x));
        }
    }
}
