using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    abstract class Shape
    {
        public abstract void Area();
        public void Type()
        {
            Console.WriteLine("It is a 2D type object");
        }
    }
    class Circle:Shape
    {
        double r;

        public Circle(double r)
        {
            this.r = r;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Cicle " + Math.PI * r * r);
        }
    }
    class Recangle:Shape
    {
        int l;
        int w;

        public Recangle(int l, int w)
        {
            this.l = l;
            this.w = w;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Rectangle " + (l * w));
        }
    }
    class Demo2
    {
        static void Main()
        {
            Shape[] shapes = new Shape[2];
            shapes[0] = new Circle(12.3);
            shapes[1] = new Recangle(34, 45);
            foreach (var item in shapes)
                item.Area();
        }
    }
}
