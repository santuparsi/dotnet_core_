using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingModels.Models;
namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductRepository repository = null;
        public ProductController()
        {
            this.repository = new ProductRepository();
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public IActionResult Get()
        {
            List<Product> products = repository.GetProducts();
            return Ok(products);
        }
        [HttpGet]
        [Route("GetProductById/{id}")]
        public IActionResult Get(int id)
        {
            Product product = repository.GetProduct(id);
            return Ok(product);
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            repository.AddProduct(product);
            return Ok("Record Added");
        }
        [HttpPut]
        [Route("UpdateProduct")]
        public IActionResult EditProduct(Product product)
        {
            repository.UpdateProduct(product);
            return Ok("Record Updated");
        }
        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            repository.DeleteProduct(id);
            return Ok("Deleted Record");
        }

    }
}
