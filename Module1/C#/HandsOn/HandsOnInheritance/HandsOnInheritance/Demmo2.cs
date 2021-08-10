using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;
namespace HandsOnInheritance
{
    class Demmo2
    {
        static void Main()
        {
            XX obj = new XX();
            obj.j = 20;
          
        }
    }
    class Class1:XX
    {
        public void F()
        {
            j = 30;
            m = 34; //prtected-internal
           
        }
    }
}
