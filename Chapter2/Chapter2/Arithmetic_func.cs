using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2
{
    class Arithmetic_func
    {
        public const double E   = 2.718281828;
        public const double PI  = 3.141592653;
        //The min method
        public static double Min(double x, double y)
        {
            if (x < y)                      // x is min
            {
                return x;
            }
            else                            // y is min
            {
                return y;
            }
        }
        //The max method
        public static double Max(double x, double y)
        {
            if (x > y)                      // x is max
            {
                return x;
            }
            else                            // y is min
            {
                return y;
            }
        }
        //The power method <x to the power y>
        public static double Pow(double x, double y)
        {
            return Math.Pow(x,y);
        }
        //The exponential method
        public static double Exp(double x)
        {
            return Math.Pow(E,x);  
        }
        //The logarit method
        public static double Log(double x)
        {
            return Math.Log(x);
        }
        //The logarit 10 method
        public static double Log10(double x)
        {
            return Math.Log10(x);
        }
    }
}
