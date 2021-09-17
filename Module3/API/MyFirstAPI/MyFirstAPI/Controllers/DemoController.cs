using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        //api/Demo/Hello
        [HttpGet]
        [Route("Hello")]
        public IActionResult Get()
        {
            return Ok("Hello World..");
        }
        //api/Demo/Greet
        [HttpGet]
        [Route("Greet")]
        public IActionResult Greet()
        {
            return Ok("hello users..");
        }
        [HttpGet]
       [Route("GetFlowers")]
        public IActionResult GetFlowers()
        {
            List<string> flowers = new List<string>() { "Rose", "Lilly", "Jasmine" };
            return Ok(flowers);
        }
        [HttpGet]
        [Route("Greet/{name}")]
        public IActionResult Greet(string name)
        {
            return Ok("Hello " + name);
        }
        [HttpGet]
        [Route("Sum/{a}/{b}")]
        public IActionResult Add(int a,int b)
        {
            int c = a + b;
            return Ok("Sum= " + c);
        }
    }
}
