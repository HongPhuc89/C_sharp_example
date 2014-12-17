using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_and_object
{
    class Program
    {
        static void Main(string[] args)
        {
            duongtron duongtron1 = new duongtron();
            duongtron1.ban_kinh  = 1;
            Console.WriteLine(duongtron1.chu_vi());
            Console.WriteLine(duongtron1.dien_tich());
            so_nguyen so_nguyen1 = new so_nguyen();
            so_nguyen1.myNumber = 110;
            Console.WriteLine(so_nguyen1.myNumber);
            Console.ReadLine();
        }
    }
}
