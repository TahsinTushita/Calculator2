using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator2
{
    struct RealNumber
    {
        public double num;

        public RealNumber(double num)
        {
            this.num = num;
        }

        public static RealNumber operator +(RealNumber a, RealNumber b)
        {
            RealNumber number = new RealNumber();
            number.num = a.num + b.num;

            return number;
        }

        public static RealNumber operator -(RealNumber a, RealNumber b)
        {
            RealNumber number = new RealNumber();
            number.num = a.num - b.num;

            return number;
        }

        public static RealNumber operator *(RealNumber a, RealNumber b)
        {
            RealNumber number = new RealNumber();
            number.num = a.num * b.num;

            return number;
        }

        public static RealNumber operator /(RealNumber a, RealNumber b)
        {
            RealNumber number = new RealNumber();
            number.num = a.num / b.num;

            return number;
        }
    }
}
