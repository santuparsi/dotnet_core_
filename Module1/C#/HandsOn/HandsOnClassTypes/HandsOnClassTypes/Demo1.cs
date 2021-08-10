using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    //sealed class
    class A
    {
        public void M() { }
    }
    sealed class B:A
    {
        public void M1() { }
    }
    class C
    {

    }
    class Demo1
    {
        static void Main()
        {
            B obj = new B();
            obj.M();
            obj.M1();
        }
    }
}
