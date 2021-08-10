using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    interface IMobiel
    {
        void Discount();
    }
    interface ILaptop
    {
        void Discount();
    }
    class ECommerce : IMobiel, ILaptop
    {
        //explicit implement
        void IMobiel.Discount()
        {

        }
        void ILaptop.Discount()
        {
        }
    }
    class Demo5
    {
    }
}
