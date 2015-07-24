using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class DisplayController : Controller
    {
        //
        // GET: /Display/

        public string Index()
        {
            return "iiiii";
        }
        public string name()
        {
            return "this is from account controller NAME";
        }

        public ActionResult abc()
        {
            Student s = new Student();
            Student s1 = new Student();
            Student s2 = new Student();

            s.name = "ovi";
            s.age = 19;
            s1.name = "ovi1";
            s1.age = 191;
            s2.name = "ovi2";
            s2.age = 192;
            
            List<Student> students = new List<Student>();
            students.Add(s);
            students.Add(s1);
            students.Add(s2);
            return View(students);
        }

    }
}
