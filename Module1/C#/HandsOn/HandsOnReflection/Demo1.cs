using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace HandsOnReflection
{
    class Sample
    {
        public void M()
        {
            Console.WriteLine("Reflection is working..");
        }
        public void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
    class Demo1
    {
        static void Main()
        {
            //How to invoke methods of given type using Relection
            Sample obj = new Sample();
            Type t = obj.GetType();
            MethodInfo m = t.GetMethod("M");
            m.Invoke(obj,null); //it invokes method M
            m = t.GetMethod("Greet");
            m.Invoke(obj, new object[1] { "Sachin" });
            Console.ReadKey();
        }
    }
}
