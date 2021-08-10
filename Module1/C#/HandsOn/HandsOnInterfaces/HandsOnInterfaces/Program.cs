using System;

namespace HandsOnInterfaces
{
    interface IShape
    {
        void Area(); //abstract method
    }
    class Circle : IShape
    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public void Area()
        {
            Console.WriteLine("Area of Circle: " + Math.PI * r * r);
        }
    }
    class Rectangle : IShape
    {
        int l;
        int w;

        public Rectangle(int l, int w)
        {
            this.l = l;
            this.w = w;
        }

        public void Area()
        {
            Console.WriteLine("Area of Rectangle: " + (l * w));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(12.3);
            circle.Area();
            IShape rectangle = new Rectangle(12, 34);
            rectangle.Area();
            Circle circle1 = new Circle(34.5);
            circle.Area();
        }
    }
}
