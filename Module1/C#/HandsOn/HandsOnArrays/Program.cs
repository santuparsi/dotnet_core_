using System;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declration of the array
            int[] n = new int[5];
            //assign values to the array
            n[0] = 89;
            n[1] = 78;
            n[2] = 56;
            n[3] = 45;
            n[4] = 44;
            // n[5] = 99; exception or runtime error
            //access value from array
            int k = n[2];
            // Console.WriteLine(n[1]);
            //access all the values using for loop
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(n[i]);
            //}
            foreach(int i in n)
            {
                Console.WriteLine();
            }
           
        }
    }
}
