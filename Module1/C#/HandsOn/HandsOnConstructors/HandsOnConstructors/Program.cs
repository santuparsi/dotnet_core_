using System;

namespace HandsOnConstructors
{
    class Sample
    {
        int a;
        int b;
        public Sample() //default constructor
        {
            a = 10;
            b = 20;
        }
        public Sample(int a,int b) //parameterized constructor
        {
            this.a = a;
            this.b = b;
        }
        public Sample(Sample sample) //copy constructor
        {
            this.a = sample.a;
            this.b = sample.b;
        }
        public void Show()
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample s1 = new Sample();
            s1.Show();
            Sample s2 = new Sample(12,45);
            s2.Show();
            Sample s3 = new Sample(s2); //copy s2 to s3
            s3.Show();
            Sample s4 = new Sample(s1);
            s4.Show();
        }

    }
}
