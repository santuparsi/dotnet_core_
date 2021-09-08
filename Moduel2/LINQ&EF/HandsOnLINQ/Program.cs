using System;
using System.Linq;
namespace HandsOnLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] no = { 12, 23, 43, 54, 43, 32, 21, 56, 67, 78, 87, 76, 65 }; //Datasource
            //Linq Query
            var result = from int k in no
                         where k % 2 == 0
                         select k;
            foreach (var n in result)
                Console.WriteLine(n);
        }
    }
}
