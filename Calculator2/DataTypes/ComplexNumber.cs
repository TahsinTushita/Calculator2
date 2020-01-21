using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator2
{
    struct ComplexNumber
    {
        public double num1, num2;

        public ComplexNumber(double num1,double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public static ComplexNumber operator +(ComplexNumber a,ComplexNumber b)
        {
            ComplexNumber num = new ComplexNumber();
            num.num1 = a.num1 + b.num1;
            num.num2 = a.num2 + b.num2;

            return num;
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber num = new ComplexNumber();
            num.num1 = a.num1 - b.num1;
            num.num2 = a.num2 - b.num2;

            return num;
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber num = new ComplexNumber();
            num.num1 = a.num1 * b.num1;
            num.num2 = a.num2 * b.num2;

            return num;
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            ComplexNumber num = new ComplexNumber();
            num.num1 = a.num1 / b.num1;
            num.num2 = a.num2 / b.num2;

            return num;
        }
    }
}
