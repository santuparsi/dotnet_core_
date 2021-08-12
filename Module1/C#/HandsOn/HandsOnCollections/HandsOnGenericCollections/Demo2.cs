using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
   
    class A<T> //generic class
    {
        public T a;
    }
    class B:A<int>
    {

    }
    interface ICalculate<T> //generic interface
    {
        T Add(T a, T b);
        T Sum(T a, T b);
    }
    class Calculate : ICalculate<int>
    {
        public int Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Sum(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
    class Demo2
    {
        static void Main()
        {
            B obj = new B();
            obj.a = 100;
        }
    }
}
