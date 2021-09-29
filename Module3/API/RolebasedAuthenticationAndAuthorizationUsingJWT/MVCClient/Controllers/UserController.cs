using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCClient.Services;
namespace MVCClient.Controllers
{
    public class UserController : Controller
    {
        UserService userService = new UserService();
        public IActionResult Index(string Uid)
        {
            return View(userService.GetUserById(Uid));
        }
    }
}
