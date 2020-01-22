

namespace Calculator2
{
    public struct RealNumber : ITypes
    {
        public double num { get; private set; }

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
