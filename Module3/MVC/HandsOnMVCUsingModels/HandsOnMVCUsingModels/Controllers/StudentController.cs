using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingModels.Models;
namespace HandsOnMVCUsingModels.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository repository = new StudentRepository();
        public IActionResult Index() //display all the student details
        {
            List<Student> students=repository.GetStudents();
            return View(students);
        }
        public IActionResult Details(int id)
        {
            Student student=repository.GetStudent(id);
            return View(student);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Add(Student student)
        {
            repository.AddStudent(student);
            return RedirectToAction("Index"); //redirects to Index action
            //return RedirectToAction("Privacy", "Home"); //redirect to Home Controller Privacy Action
        }
    }
}
