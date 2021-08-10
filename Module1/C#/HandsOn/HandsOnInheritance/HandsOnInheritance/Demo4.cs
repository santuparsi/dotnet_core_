using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class XXX
    {
       protected int i;
        protected int j;

        public XXX(int i, int j)
        {
            this.i = i;
            this.j = j;
        }
    }
    class YYY:XXX
    {
        int k;
        public YYY():base(2,3)
        {
            k = 10;
        }
        public YYY(int i,int j,int k):base(i,j)
        {
            this.k = k;
        }
        public void Show()
        {
            Console.WriteLine("{0} {1} {2}", i, j, k);
        }
    }

    class Demo4
    {
        static void Main()
        {
            YYY obj = new YYY(12, 23, 45);
            obj.Show();
            YYY ob1 = new YYY();
            ob1.Show();

        }
    }
}
