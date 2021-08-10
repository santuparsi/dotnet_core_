using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    partial class Sample
    {
        public void M1() { }
    }
    partial class Sample
    {
        public void M2() { }
        public void M3() { }
    }
    partial class Sample

    {
        public void M4() { }
        public void M5() { }
    }
    class Demo3
    {
        static void Main()
        {
            Sample obj = new Sample();
            obj.M1();
            obj.M3();
            obj.M5();
        }
    }
}
