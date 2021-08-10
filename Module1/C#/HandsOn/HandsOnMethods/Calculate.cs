using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Calculate
    {
        public int Add(int a,int b)
        {
            int result = a + b;
            return result;
        }
        public double Sqaure(double a)
        {
            double result = a * a;
            return result;
        }
        public static string Greet(string name)
        {
            string message = "Hello " + name;
            return message;
        }
        public int Sum(int[]a)
        {
            int sum = 0;
            foreach(var i in a)
            {
                sum = sum + i;
            }
            return sum;
        }
        public static bool IsEven(int no)
        {
            return no % 2 == 0 ? true : false;
        }
        public void Print(string name,int count=5) //default parameter value
        {
            for(int i=1;i<=count;i++)
            {
                Console.WriteLine("Hello " + name);
            }
        }
    }
    class Test_Calculate
    {
        static void Main()
        {
            Calculate obj = new Calculate();
            //int result = obj.Add(3, 5);
            //Console.WriteLine("Addition: " + result);
            //result = obj.Sum(new int[3] { 23, 34, 45 });
            //Console.WriteLine("Sum of array no's " + result);
            //Console.WriteLine(obj.Sqaure(23));
            //Console.WriteLine(Calculate.Greet("Sachin"));
            //if (Calculate.IsEven(2))
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //    Console.WriteLine("Odd");
            obj.Print("Sachin"); //count=5;
            obj.Print("Rahul", 10);
            obj.Print(name: "Kohili", count: 20); //named parametes
            obj.Print(count: 4, name: "Dhoni");
            Console.ReadKey();
        }
    }
}
