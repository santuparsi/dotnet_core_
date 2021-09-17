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
    public class SampleController : ControllerBase
    {
        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult GetAll()
        {
            return Ok("Employees are returnd");
        }
        [HttpGet]
        [Route("GetEmployeeById/{id}")]
        public IActionResult Get(int id)
        {
            return Ok("Employee Returns by Id");
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult Post(object employee)
        {
            return Ok("Employee Added");
        }
        [HttpPut]
        [Route("UpdateEmployee")]
        public IActionResult Put(object employee)
        {
            return Ok("Employee Updated");
        }
        [HttpDelete]
        [Route("DeleteEmployee/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Employee Deleted");
        }
    }
}
