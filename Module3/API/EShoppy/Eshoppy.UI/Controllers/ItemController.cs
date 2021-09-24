using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshoppy.UI.Services;
using Eshoppy.UI.Models;
namespace Eshoppy.UI.Controllers
{
   
    public class ItemController : Controller
    {
        private readonly IItemService itemService;

        public ItemController(IItemService service)
        {
            this.itemService = service;
        }

      
        public IActionResult Index()
        {
            try
            {
                List<Item> items = itemService.GetItems();
                return View(items);
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }
      
        public IActionResult Details(int id)
        {
            try
            {
                Item item = itemService.GetItem(id);
                return View(item);
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Item item)
        {
            try
            {
               if(ModelState.IsValid)
                {
                    itemService.AddItem(item);
                    return RedirectToAction("Index");
                }
               else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }
        [HttpGet]
      
      
        public IActionResult Edit(int id)
        {
            Item item = itemService.GetItem(id);
            return View(item);
        }
      
      [HttpPost]
      
        public IActionResult Edit(Item item)
        {
            try
            {
               
                    itemService.UpdateItem(item);
                    return RedirectToAction("Index");
               
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }

       
      
        
        public IActionResult Delete(int id)
        {
            try
            {
                itemService.DeleteItem(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View("Error");
            }
        }
    }
}
