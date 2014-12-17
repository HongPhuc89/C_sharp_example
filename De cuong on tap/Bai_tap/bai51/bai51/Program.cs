using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai51
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 0;
            int Max = 20;

            // this declares an integer array with 5 elements
            // and initializes all of them to their default value
            // which is zero
            int[] test2 = new int[5];

            Random randNum = new Random();
            for (int i = 0; i < test2.Length; i++)
            {
                test2[i] = randNum.Next(Min, Max);
            }
        }
    }
}
