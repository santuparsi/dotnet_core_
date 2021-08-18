using System;
using System.Collections;
using System.Reflection;
namespace HandsOnReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Type t = list.GetType();
            //Get all the methods name of Arraylist
            MethodInfo[]methods=t.GetMethods();
            foreach(MethodInfo m in methods)
            {
                Console.WriteLine("{1} {0}", m.Name,m.ReturnType.Name);
            }
            Console.Clear();
            //Get All constructors
            ConstructorInfo[] constructors=t.GetConstructors();
            foreach(ConstructorInfo c in constructors)
            {
                Console.WriteLine(c);
            }
            Console.Clear();
            //Get All Properties
            PropertyInfo[]properties=t.GetProperties();
            foreach(PropertyInfo p in properties)
            {
                Console.WriteLine("{1} {0}", p.Name, p.PropertyType.Name);
            }
            Console.ReadKey();
        }
    }
}
