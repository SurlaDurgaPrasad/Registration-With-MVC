using ProjectWith_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectWith_MVC.Controllers
{
    public class ProjectMvcController : Controller
    {
        // GET: ProjectMvc
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(Student obj, string csharp, string java, string php)
        {
            string Course = string.Empty;
            if (csharp == "true")
            {
                Course = Course + "c#" + ",";
            }
            if (java == "true")
            {
                Course = Course + "java" + ",";
            }
            if (php == "true")
            {
                Course = Course + "php" + ",";
            }
                obj.Course = Course;
             Student Emp = new Student();
            Emp.AddDetails(obj);

            return View();
        }
    }
}