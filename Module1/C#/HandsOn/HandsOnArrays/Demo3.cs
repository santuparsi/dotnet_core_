using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo3
    {
        static void Main()
        {
            int[] numbers = { 12, 23, 34, 32, 21, 
                11, 56, 67, 87, 65, 54 };
            Console.WriteLine("Count: " +
                numbers.Length);
            //sort array elements
            // Array.Sort(numbers);
            Array.Reverse(numbers);
            //foreach (int n in numbers)
            //    Console.WriteLine(n);
            int[] b = new int[4];
            //copy value from numbers arrray to array b[]
            Array.Copy(numbers, b, 4);
            foreach (int n in b)
                Console.WriteLine(n);

        }
    }
}
