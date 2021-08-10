using System;

namespace HandsOnStructures
{
    struct Box
    {
        public int l;
        public int w;
        //public Box() //stucute does not support default constructor.
        //{
        //    l = 10;
        //    w = 20;
        //}
        public Box(int l,int w)
        {
            this.l = l;
            this.w = w;
        }
        public void Details()
        {
            Console.WriteLine("length:{0} width:{1}", l, w);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(2,3);
            box.Details();
            Box box1;
            box1.l = 10;
            box1.w = 20;
            box1.Details();
            
        }
    }
}
