using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo4
    {
        static void Main()
        {
            int[] n = new int[3];
            //Read array values from input
            for (int i = 0; i < n.Length;i++)
            {
                Console.Write("Enter n[{0}] value:", i);
                n[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            foreach (int k in n)
                Console.Write(k+"\t");
        }
    }
}
