using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    interface IX
    {
        void M1();
    }
    class Class1 : IX
    {
        public void M1()
        {
            throw new NotImplementedException();
        }
    }
    class Class3 : IX
    {
        public void M1()
        {
            throw new NotImplementedException();
        }
    }
    class Demo4
    {
    }
}
