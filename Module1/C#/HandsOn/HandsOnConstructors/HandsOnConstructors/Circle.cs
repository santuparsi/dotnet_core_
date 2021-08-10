using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructors
{
    class Circle
    {
        public double r;
        static double PI;
        public Circle(double r)
        {
            this.r = r;
        }
        static Circle()
        {
            Console.WriteLine("I am invoked only once.");
            PI = 3.14;
        }
        public double Area()
        {
            double result;
            result = PI * r * r;
            return result;
        }
    }
    class Circle_Test
    {
        static void Main()
        {
            Circle[] circles = new Circle[4];
            circles[0] = new Circle(12.3);
            circles[1] = new Circle(34.5);
            circles[2] = new Circle(34);
            circles[3] = new Circle(45);
            foreach (var circle in circles)
                Console.WriteLine("Area of Circle with Radius {0} is {1}",circle.r
                    ,circle.Area());
        }
    }
}
