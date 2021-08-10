using System;

namespace HandsOnInheritance
{
    class A //base class
    {
        public int i;
        public int j;
        public void F()
        {
            Console.WriteLine("I am F() of Class A");
        }
    }
    class B : A //B is derive class
    {
        public int k;
        public void Show()
        {
            Console.WriteLine("i:{0} j:{1} k:{2}", i, j, k);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            //obj can access all the public members of Class A
            obj.i = 10;
            obj.j = 20;
            obj.F();
            obj.k = 30;
            obj.Show();
        }
    }
}
