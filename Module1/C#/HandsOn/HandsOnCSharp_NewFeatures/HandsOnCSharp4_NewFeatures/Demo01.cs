using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp4_NewFeatures
{
    //Dynamic Types
    //A dynamic type escapes type checking at compile-time; instead, it resolves type at run time.
    class Demo01
    {
        static void Main(string[] args)
        {
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            object o = "Hello";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());
            string s = MyDynamicVar;
            s = o.ToString();

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            var i = 100;
            Console.WriteLine("Value: {0}, Type: {1}", i, i.GetType());
            //i = "Hello";
        }
    }
}
