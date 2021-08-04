using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo7
    {
        static void Main()
        {
            int[][] ja = new int[3][]; //size 3 indicates storing 3 diffrent arrays
            ja[0] = new int[4] { 34, 45, 56, 67 };
            ja[1] = new int[3] { 32, 21, 23 };
            ja[2] = new int[5] { 34, 56, 67, 78, 89 };
            int m = ja[0][0];
            for (int i = 0; i < 3; i++)
            {
                foreach (int k in ja[i])
                {
                    Console.Write(k + "\t");

                    Console.WriteLine();
                }
                int[,][] twodjagged = new int[1, 1][];
                twodjagged[0, 0] = new int[2] { 2, 3 };
                twodjagged[0, 1] = new int[2] { 2, 3 };

            }
        }
    }
}
