using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLINQ
{
    class Demo3
    {
        static void Main()
        {
            int[] no = { 12, 23, 43, 54, 43, 32, 21, 56, 67, 78, 87, 76, 65 };
            List<int> result = (from k in no
                                let m = k * k
                                select m).ToList();
            foreach (var a in result)
                Console.WriteLine(a);
        }
    }
}
