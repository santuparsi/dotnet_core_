using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnEFUsingSP
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CTSDBEntities db = new CTSDBEntities())
            {
                //db.AddProduct("bottle", 120, 10);
                Product ob = db.GetProductById(3).SingleOrDefault();
                Console.WriteLine("{0} {1} {2}", ob.Pid, ob.Pname, ob.Stock);
                ob.Price = 400;
                db.UpdateProduct(ob.Pid, ob.Pname, ob.Price, ob.Stock);
                //db.DeleteProduct(5);

            }
        }
    }
}
