using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCUsingControllersAndViews.Controllers
{
    public class DemoController : Controller
    {
        //Action Methods
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Greet(string name)
        {
            string un = name;
            //set value in viewData
            ViewData["uname"] = un;
            return View();
        }
        public IActionResult Sum(int a,int b)
        {
            int result = a + b;
            ViewBag.Result = result; //set value to ViewBag
            return View();
        }
    }
}
