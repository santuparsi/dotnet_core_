using System;

namespace HandsOnDynamicKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic a = 10;
            Console.WriteLine(a);
            a = 12.23;
            Console.WriteLine(a);
            a = "Hello";
            Console.WriteLine(a);
            string s = a;
            Console.WriteLine(s);
        }
    }
}
