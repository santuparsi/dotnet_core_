using System;

namespace HandsOnDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 10;
            int b = 20;
            int max = a == b ? a : b;
            Console.WriteLine(max);
            Console.WriteLine("In {0} and {1},{2} is Max", a, b, max);
            int n = 12;
            string result = n % 2 == 0 ? "Even" :"Odd";
            Console.WriteLine("{0} is {1}", n, result);
        }
    }
}
