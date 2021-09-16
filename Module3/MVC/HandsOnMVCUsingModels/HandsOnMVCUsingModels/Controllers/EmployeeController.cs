using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingModels.Models;
using HandsOnMVCUsingModels.ViewModels;
namespace HandsOnMVCUsingModels.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Project project = new Project() { ProjectCode = "P0001", ProjectName = "ShoppingCart" };
            Employee employee = new Employee() { EmployeeId = 1233, ProjectCode = "P0001", Designation = "Developer", EmployeeName = "Rajesh" };
            EmployeeProject employeeProject = new EmployeeProject()
            {
                Project = project,
                Employee = employee
            };
            return View(employeeProject);
        }
        public IActionResult Index1()
        {
            Project project = new Project() { ProjectCode = "P0001", ProjectName = "ShoppingCart" };
            Employee employee = new Employee() { EmployeeId = 1233, ProjectCode = "P0001", Designation = "Developer", EmployeeName = "Rajesh" };
            ProjectEmployee projectEmployee = new ProjectEmployee()
            {
                ProjectName = project.ProjectName,
                EmployeeName = employee.EmployeeName,
                Designation = employee.Designation
            };
            return View(projectEmployee);
        }
    }
}
