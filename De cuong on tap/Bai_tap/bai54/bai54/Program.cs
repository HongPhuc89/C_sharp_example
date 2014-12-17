using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai54
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1000, min = -1000;
            int max_value, min_value;
            int m, n; // kich thuoc mang hai chieu
            int i, j; //bien dem
            int[,] ranArray = new int[10,10]; // khai bao mang hai chieu
            Random ran_num = new Random();
            m = 10;
            n = 10;
            // Tao mang hai chieu ngau nhien
            for (i = 0;i<m;i++)
            {
                for (j = 0;j<n;j++)
                {
                    ranArray[i, j] = ran_num.Next(min,max);
                }
            }
            // Tim so lon nhat va nho nhat
            max_value = ranArray[0,0];
            min_value = ranArray[0,0];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (min_value > ranArray[i, j])
                    {
                        min_value = ranArray[i, j];
                    }
                    if (max_value < ranArray[i, j])
                    {
                        max_value = ranArray[i, j];
                    }
                }
            }
            Console.WriteLine("Gia tri lon nhat cua mang la: {0}", max_value);
            Console.WriteLine("Gia tri nho nhat cua mang la: {0}", min_value);
        }
    }
}
