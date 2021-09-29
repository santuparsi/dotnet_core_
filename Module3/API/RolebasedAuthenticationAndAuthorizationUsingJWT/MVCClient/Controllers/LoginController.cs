using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCClient.Services;
using MVCClient.Models;
namespace MVCClient.Controllers
{
    public class LoginController : Controller
    {
        UserService userService = new UserService();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("Validate")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [Route("Validate")]
        public IActionResult Login(string Uname,string Pwd)
        {
            UserModel userModel = userService.Validate(Uname, Pwd);
            if(userModel.Token!="")
            {
                Common.Token = userModel.Token;
               // HttpContext.Session.SetString("token", userModel.Token);
               if(userModel.Role=="User")
                {
                    return RedirectToAction("Index","User", new { Uid = userModel.UId });
                }
               else
                {
                    return RedirectToAction("Index", "Admin");
                }
            }
            else
            {
                ViewData["errMsg"] = "Invalid Credentials";
                return View();
            }
        }
    }
}
