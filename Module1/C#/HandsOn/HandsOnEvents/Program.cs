using System;

namespace HandsOnEvents
{
    public delegate void myDelegate();
    class Subscriber
    {
        public void Callme()
        {
            Console.WriteLine("Hey Guys,Good Morning");
        }
    }
    class Program
    {
        //even delcaration
        public event myDelegate myevent;
      
        static void Main(string[] args)
        {
            //initiate event
            Subscriber sub = new Subscriber();
            Program obj = new Program();
            //iniate methods to events
            obj.myevent += sub.Callme;
            obj.myevent(); //event firing
        }
    }
}
