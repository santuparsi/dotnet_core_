using System;

namespace MyLibrary
{
    public class Calculate
    {
        public int Add(int a,int b)
        {
            int result = a + b;
            return result;
        }
        public int Sub(int a,int b)
        {
            int result = a - b;
            return result;
        }
        public double Mul(double a,double b)
        {
            return a * b;
        }
        public double Div(double a,double b)
        {
            if (b == 0)
                return 0.0;
            else
                return a / b;
        }

    }
}
