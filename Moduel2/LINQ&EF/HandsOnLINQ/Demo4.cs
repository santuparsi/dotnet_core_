using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLINQ
{
    class Demo4
    {
        static void Main()
        {
            int[] no = { 12, 23, 43, 54, 43, 32, 21, 56, 67, 78, 87, 76, 65 }; //Datasource
            //Linq Query
            //Immediate execution
            List<int> result = (from int k in no
                         where k % 2 == 0
                         select k).ToList();
            no[1] = 24;
            foreach (var n in result)
                Console.WriteLine(n);
        }
    }
}
