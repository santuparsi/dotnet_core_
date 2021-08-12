using System;

namespace HandsOnGenericCollections
{
    //Generic class
    class Sample<T>//generic class
    {
        public T a;
        public T b;
        public void M(T i,T j)
        {
            Console.WriteLine("i={0} j={1}", i, j);
        }
        public T M1(T k)
        {
            return k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample<int> s1 = new Sample<int>();
            s1.a = 10;
            s1.b = 20;
            s1.M(1, 3);
            s1.M1(23);
            Sample<char> s2 = new Sample<char>();
            s2.a = 'a';
            s2.b = 'c';
            Sample<string> s3 = new Sample<string>();
            s3.a = "Ram";
            s3.b = "Raghu"
;        }
    }
}
