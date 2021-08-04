using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethods
{
    class Product
    {
        int pId;
        string pName;
        double price;
        int stock;
        public void SetProduct(int id,string pname,double price,int stock)
        {
            this.pId = id;
            pName = pname;
            this.price = price;
            this.stock = stock;
        }
        public void GetDetails()
        {
            Console.WriteLine("{0} {1} {2} {3}", pId, pName, price, stock);
        }
    }
    class Test_Product
    {
        static void Main()
        {
            Product product = new Product();
            product.SetProduct(100, "Mouse", 300, 10);
            product.GetDetails();
           
        }
    }
}
