using System;
using MyLibrary;
namespace Console_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate obj = new Calculate();
            Console.WriteLine(obj.Add(12, 23));
            Console.WriteLine(obj.Mul(2, 4));
            Console.WriteLine("{0:F2}",obj.Div(10, 3));
            Currency ob = new Currency();
            Console.WriteLine(Currency.DTR(1000));
            Console.WriteLine(Currency.RTD(100000));
            //string s = "123";
            //int k = int.Parse(s);
            //int j = Convert.ToInt32(s);
            //short s1 = Convert.ToInt16(s);
            //long l = Convert.ToInt64(s);
            //double d = 12.34;
            //int m = (int)d;
            //int n = Convert.ToInt32(m);
        }
    }
}
