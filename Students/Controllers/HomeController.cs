using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Students.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           
            Dal dal=new Dal();
            StudentsModel students=new StudentsModel();
            students.studentsList = dal.GetStudents();

            return View();
        }
        public JsonResult getStudents()
        {
            Dal dal = new Dal();
            StudentsModel students = new StudentsModel();
            students.studentsList = dal.GetStudents();
            return Json(students.studentsList, JsonRequestBehavior.AllowGet);


        }
    }
}