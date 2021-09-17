using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIUsingModels.Models
{
    public class ProductRepository
    {
        public static List<Product> products = new List<Product>()
        {
            new Product(){Pid=1,Pname="Mouse",Price=300,Stock=10},
              new Product(){Pid=2,Pname="Keyboard",Price=300,Stock=10},
        };
        public List<Product> GetProducts()
        {
            return products;
        }
        public Product GetProduct(int id)
        {
            return products.SingleOrDefault(p => p.Pid == id);
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void UpdateProduct(Product update_product)
        {
           for(int i=0;i<products.Count;i++)
            {
                if(products[i].Pid==update_product.Pid)
                {
                    products[i].Price = update_product.Price;
                    products[i].Stock = update_product.Stock;
                }
            }
        }
        public void DeleteProduct(int id)
        {
            Product product = products.SingleOrDefault(p => p.Pid == id);
            products.Remove(product);
        }
    }
}
