using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCClient.Services;
using MVCClient.Models;
namespace MVCClient.Controllers
{
    public class AdminController : Controller
    {
        UserService userService = new UserService();
        public IActionResult Index()
        {
            List<User> users = userService.GetUsers();
            return View(users);
        }
    }
}
