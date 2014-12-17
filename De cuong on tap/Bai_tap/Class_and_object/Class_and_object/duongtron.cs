using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_and_object
{
    public class duongtron
    {
        public double ban_kinh, x, y;
        public double BanKinh;
        public double chu_vi()
        {
            return Math.PI * ban_kinh * 2;
        }
        public double dien_tich()
        {
            return Math.PI * ban_kinh * ban_kinh;
        }
    }
}
