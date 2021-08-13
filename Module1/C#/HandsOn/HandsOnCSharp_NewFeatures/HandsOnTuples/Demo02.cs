using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTuples
{
    class Demo02
    {
        //tuple field names
        static void Main() //C# 7.0
        {
            var t =
(1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
11, 12, 13, 14, 15, 16, 17, 18,
19, 20, 21, 22, 23, 24, 25, 26); //You can define tuples with an arbitrary large number of elements
            Console.WriteLine(t.Item26);
            (double, int) t1 = (4.5, 3);
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
            // Output:
            // Tuple with elements 4.5 and 3.

            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
            // Output:
            // Sum of 3 elements is 4.5.

            var t3 = (Sum: 4.5, Count: 3);
            Console.WriteLine($"Sum of {t3.Count} elements is {t3.Sum}.");

            (double Sum, int Count) d = (4.5, 3);
            Console.WriteLine($"Sum of {d.Count} elements is {d.Sum}.");

            var sum = 4.5;
            var count = 3;
            var t5 = (sum, count);
            Console.WriteLine($"Sum of {t5.count} elements is {t5.sum}.");
        }
    }
}
