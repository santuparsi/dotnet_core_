using System;
using System.Threading;
namespace HandsOnMultiThreading
{
    class Program
    {
        public static void Task1()
        {
            for(int i=1;i<=100;i++)
            {
                Console.Write(i+" ");
                Thread.Sleep(500); //execution haleted 500 millisec
            }
        }
        public static void Task2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(Convert.ToChar(i));
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Task1);
            Thread t2 = new Thread(Task2);
            t1.Start();
            t2.Start();
          
        }
    }
}
