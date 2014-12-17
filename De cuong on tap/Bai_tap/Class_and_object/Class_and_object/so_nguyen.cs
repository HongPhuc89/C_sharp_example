using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_and_object
{
    class so_nguyen
    {
        private int myNumber_val;
        public int myNumber
        {
            get
            {
                return this.myNumber_val / 100;
            }
            set
            {
                this.myNumber_val = value * 100;
            }
        }
    }
}
