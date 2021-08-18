using System;

namespace HandsOnDelegates
{
    public delegate void Mydelegate(); //declare delegate
    public delegate void Greetdelegate(string name);
    class Program
    {
        public void Print()
        {
            Console.WriteLine("Print something..");
        }
        public void Task()
        {
            Console.WriteLine("Task is Running..");
        }
        public void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
      
        static void Main(string[] args)
        {
            Program p = new Program();
            //instantiate delegate.
            Mydelegate d1 = new Mydelegate(p.Print);//Print is refered by delegate d1
            //invoke delegate
            d1();
            Greetdelegate gd = new Greetdelegate(p.Greet);
            gd("Sachin");
            //multicast delegate
            Mydelegate d2 = p.Print;
            d2 += p.Task;
            d2();
        }
    }
}
