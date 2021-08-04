using System;

namespace HandsOnImplicitylyTypedVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            a = 12;
            int k = a;
            object o = 10;
            o = 'a';
            o = "Hello";
            o = 12.34;
            double d = (double)o;
            var u="Hello";
           
        }
    }
}
