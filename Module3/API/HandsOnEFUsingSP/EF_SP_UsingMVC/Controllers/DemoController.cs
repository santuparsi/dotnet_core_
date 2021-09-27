using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF_SP_UsingMVC.Models;
namespace EF_SP_UsingMVC.Controllers
{
    public class DemoController : Controller
    {
        CTSDBEntities db = new CTSDBEntities();
        // GET: Demo
        [ActionName("GetAll")]
        public ActionResult Index()
        {
            return View(db.GetEmpInfo());
        }
    }
}