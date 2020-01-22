using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator2
{
    struct ComplexNumber
    {
        public double realNum, imgNum;

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
