using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIService.Services;

namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles="User")]
    public class UserController : ControllerBase
    {
        UserService userService = new UserService();
        
        //[HttpGet]
        //[Route("GetUsers")]
        //[Authorize(Roles = "Admin")]
        //public IActionResult GetUsers()
        //{
        //    return Ok(userService.GetUsers()) ;
        //}
       
        [HttpGet]
        [Route("GetUserById/{Uid}")]
      
        public IActionResult GetUserById(string Uid)
        {
            return Ok(userService.GetUser(Uid));
        }
    }
}
