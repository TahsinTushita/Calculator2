using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator2
{
    struct VectorNumber
    {
        public double u, v, w;

        public VectorNumber(double u,double v,double w)
        {
            this.u = u;
            this.v = v;
            this.w = w;
        }

        public static VectorNumber operator +(VectorNumber num1, VectorNumber num2)
        {
            VectorNumber number = new VectorNumber();

            number.u = num1.u + num2.u;
            number.v = num1.v + num2.v;
            number.w = num1.w + num2.w;

            return number;
        }

        public static VectorNumber operator -(VectorNumber num1, VectorNumber num2)
        {
            VectorNumber number = new VectorNumber();

            number.u = num1.u - num2.u;
            number.v = num1.v - num2.v;
            number.w = num1.w - num2.w;

            return number;
        }
    }
}
