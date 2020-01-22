
using Calculator2.Interfaces;

namespace Calculator2
{
    public struct VectorNumber : ITypes
    {
        public double u { get;private set; }
        public double v { get;private set; }
        public double w { get;private set; }

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

        public static VectorNumber operator *(VectorNumber num1, VectorNumber num2)
        {
            VectorNumber number = new VectorNumber();

            number.u = num1.v*num2.w - num1.w*num2.v;
            number.v = num1.w*num2.u - num1.u*num2.w;
            number.w = num1.u*num2.v - num1.v*num2.u;

            return number;
        }
    }
}
