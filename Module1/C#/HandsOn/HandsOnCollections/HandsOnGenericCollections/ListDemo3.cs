using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Price { get; set; }

    }

    class ListDemo3
    {
        static void Main()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Pid=1,Pname="Mouse",Price=1000},
                 new Product(){Pid=2,Pname="P1",Price=1000},
                  new Product(){Pid=3,Pname="P2",Price=1000},
                   new Product(){Pid=4,Pname="P3",Price=1000},
                    new Product(){Pid=5,Pname="P4",Price=1000},
            };
            Product p = products[0];
            foreach(var item in products)
            {
                Console.WriteLine("{0} {1} {2}", item.Pid, item.Pname, item.Price);
            }
        }
    }
}
