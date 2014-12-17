using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai52
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = -20;
            int Max =  20;

            // this declares an integer array with 5 elements
            // and initializes all of them to their default value
            // which is zero
            int[] randArray = new int[10];
            int[] negArray  = new int[10];
            int[] posArray  = new int[10];
            int neg_size, pos_size;

            Random randNum = new Random();
            neg_size = 0; pos_size = 0;
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = randNum.Next(Min, Max);
                // Tach mang am duong
                if (randArray[i] < 0)
                {
                    negArray[neg_size] = randArray[i];
                    neg_size += 1;
                }
                else
                {
                    posArray[pos_size] = randArray[i];
                    pos_size += 1;
                }
            }
            //Sap xep tang dan mang am
            Array.Sort(negArray); 
            //Sap xep giam dan mang duong
            Array.Sort(posArray,
                new Comparison<int>(
                        (i1, i2) => i2.CompareTo(i1)
                ));
            //Ghep hai mang
            //Ghep mang am
            for (int i = 0; i < negArray.Length; i++)
            {
                randArray[i] = negArray[i];
            }
            //Ghep mang duong
            for (int i = neg_size; i < randArray.Length; i++)
            {
                randArray[i] = posArray[i - neg_size];
            }
            //In mang ra man hinh
            for (int i = 0; i < randArray.Length; i++)
            {
                Console.Write(randArray[i]);
                Console.Write(' ');
            }

            Console.ReadLine();
        }
    }
}
