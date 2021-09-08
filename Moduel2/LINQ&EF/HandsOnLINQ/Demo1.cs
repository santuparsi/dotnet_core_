using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLINQ
{
    class Demo1
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int k = numbers.First();
            k = numbers.Last();
            k = numbers.First(i => i % 2 == 0);
            k = numbers.Last(i => i % 2 == 0);
        }
    }
}
