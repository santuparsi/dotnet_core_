using System;

namespace HandsOnClassTypes
{
    static class Convertor
    {
        public static double RTD(double rupees)
        {
            return rupees / 78.5;
        }
        public static double DTR(double dollers)
        {
            return dollers * 78.5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:C}",Convertor.RTD(100000));
            Console.WriteLine(Convertor.DTR(1000));
        }
    }
}
