using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.API.Entities;
using EShoppy.API.Repositories;
namespace EShoppy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository repository = null;
        public ItemController(IItemRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        [Route("GetAllItems")]
        public IActionResult GetItems()
        {
            try
            {
                List<Item> Items = repository.GetItems();
                return Ok(Items);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetItem/{id}")]
        public IActionResult GetItem(int id)
        {
            try
            {
                Item item = repository.GetItem(id);
                return Ok(item);
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteItem/{id}")]
        public IActionResult DeleteItem(int id)
        {
            try
            {
                repository.DeleteItem(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("AddItem")]
        public IActionResult AddItem(Item item)
        {
            try
            {
                repository.AddItem(item);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateItem")]
        public IActionResult UpdateItem(Item item)
        {
            try
            {
                repository.UpdateItem(item);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
