using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo2
    {
        static void Main()
        {
            int[] n = new int[4] { 12, 23, 45, 56 };
            char[] ch = new char[3] { 'a', 'b', 'c' };
            object[] mix = new object[4] { 12, 12.23, 'c', true };
            double[] prices = new double[4]
            {
                12.34,
                34.45,
                56.67,
                78.86
            };
            int[] numbers = { 12, 23, 34, 456, 6 };//dynamic arrays
            string[] flowers = new string[3]
            {
                "Rose",
                "Lilly",
                "Tulips"
            };
            foreach(string s in flowers)
            {
               if(s.Length>4)
                Console.Write(s+"\t");
            }
            Console.WriteLine("ENter size of the pool");
            int size=int.Parse(Console.ReadLine());
            int[] n1 = new int[size];
        }
    }
}
