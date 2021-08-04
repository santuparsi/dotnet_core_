using System;

namespace HandsOnNullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int? k = null; //nullable type declaration
            k = 100;
            Nullable<byte> b = null; //nullabel type
            k = i; //implicit //converting normal type to nullble type
            i = (int)k; //converting nullable type to value type.

        }
    }
}
