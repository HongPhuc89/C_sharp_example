using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai55
{
    class Program
    {
        public static void print_array(int[,] arr)
        { 
            int i,j;
            int height = arr.GetLength(0);
            int width = arr.GetLength(1);
            for (i = 0; i < height; i++)
            {
                for (j = 0; j < width; j++)
                {
                    Console.Write("{0,5}",arr[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int max = 1000, min = -1000;
            int m, n; // kich thuoc mang hai chieu
            int i, j; //bien dem
            int[,] a = new int[20, 10]; // khai bao mang hai chieu
            int[,] b = new int[20, 10]; // khai bao mang hai chieu
            int[,] c = new int[20, 10]; // khai bao mang hai chieu
            Random ran_num = new Random();
            m = a.GetLength(0);
            n = a.GetLength(1);
            // Tao mang hai chieu ngau nhien
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = ran_num.Next(min, max);
                    b[i, j] = ran_num.Next(min, max);
                    //Tong la mang c
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            Console.WriteLine("Mang a: ");
            print_array(a);
            Console.WriteLine("Mang b: ");
            print_array(b);
            Console.WriteLine("Tong mang a va b: ");
            print_array(c);
            Console.ReadLine();
        }
    }
}
