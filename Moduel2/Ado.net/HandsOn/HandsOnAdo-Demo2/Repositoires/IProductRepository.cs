using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnAdo_Demo2.Entities;
namespace HandsOnAdo_Demo2.Repositoires
{
    interface IProductRepository
    {
        void AddProduct(Product product);
        Product GetProduct(int pid);
        List<Product> GetProducts();
        void DeleteProduct(int pid);
        void UpdateProduct(Product product);
    }
}
