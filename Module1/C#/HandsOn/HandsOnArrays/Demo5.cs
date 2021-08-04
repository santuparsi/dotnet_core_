using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Demo5
    {
        static void Main()
        {
            //2-dimensional array
            int[,] twod = new int[3, 2];
            //assign values to array
            //1st row
            twod[0, 0] = 10;
            twod[0, 1] = 23;
            //2nd row
            twod[1, 0] = 34;
            twod[1, 1] = 35;
            //3rd row
            twod[2, 0] = 89;
            twod[2, 1] = 56;

            //access value
            int k = twod[1, 0]; //34
            foreach (int i in twod)
                Console.WriteLine(i);
            Console.WriteLine();
            //display elements in Matrix format
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write(twod[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
