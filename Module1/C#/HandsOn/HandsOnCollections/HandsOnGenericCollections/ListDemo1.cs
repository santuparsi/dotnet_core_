using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class ListDemo1
    {
        static void Main()
        {
            List<string> flowers = new List<string>()
            {
                "Rose",
                "Lilly",
                "Tulips"
            };
            List<bool> results = new List<bool>() { true, false, true, false, false };
            List<int> list1 = new List<int>() { 12, 23, 34, 45 };
            list1.Add(10);
            list1.Insert(0, 120);
            int k1 = list1[2];
            list1.Sort();
            list1.Remove(12);
            bool b = list1.Contains(23);
            foreach (var k in list1)
                Console.WriteLine(k);
        }
    }
}
