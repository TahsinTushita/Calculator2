

namespace Calculator2
{
    public struct ComplexNumber : ITypes
    {
        public double realNum { get; private set; }
        public double imgNum { get; private set; }

        public ComplexNumber(double realNum,double imgNum)
        {
            this.realNum = realNum;
            this.imgNum = imgNum;
        }

        public static ComplexNumber operator +(ComplexNumber a,ComplexNumber b)
        {
            ComplexNumber num = new ComplexNumber();
            num.realNum = a.realNum + b.realNum;
            num.imgNum = a.imgNum + b.imgNum;

            return num;
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber num = new ComplexNumber();
            num.realNum = a.realNum - b.realNum;
            num.imgNum = a.imgNum - b.imgNum;

            return num;
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber num = new ComplexNumber();
            num.realNum = a.realNum * b.realNum;
            num.imgNum = a.imgNum * b.imgNum;

            return num;
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber num = new ComplexNumber();
            num.realNum = a.realNum / b.realNum;
            num.imgNum = a.imgNum / b.imgNum;

            return num;
        }
    }
}
