using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Demo3
    {
        //public static void M(int i)
        //{
        //    i = i + 2;
        //    Console.WriteLine(i);
        //}
        public static void M(ref int i)
        {
            i = i + 2;
            Console.WriteLine(i);
        }
        public static void Add(int a,int b,out int c)
        {
            c = a + b;
        }
        public static int Sum(params int []a)
        {
            int result = 0;
            foreach (var k in a)
                result = result + k;
            return result;
        }
        static void Main()
        {
            int k;
           // Console.WriteLine(k); //C# doesnot allow unassigned local variables
            int i=10;
            Console.WriteLine("i={0}", i);
            M(ref i);
            Console.WriteLine("i={0}", i);
            int a= 10, b = 20, c;
            Add(a, b, out c);
            Console.WriteLine("c={0}", c);
            Sum(new int[3] { 12, 23, 34 });
            Sum(12, 23, 34, 45); //params allows to pass differnt value to paramente a at runtime
            Sum(12, 23);
            Sum(23, 34, 45, 56, 67, 78);
            string s = "Hello GoodMornig Students";
            string[] str = s.Split(' ', ',');
        }
    }
}
