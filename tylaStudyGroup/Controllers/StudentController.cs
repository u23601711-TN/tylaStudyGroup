using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tylaStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        private static List<Models.StudentModel> students = new List<Models.StudentModel>();
        public ActionResult ListStudent()
        {
            students.Add(new Models.StudentModel { studentName = "Tyla", studentSurname = "Naidoo", studentNumber = "u23601711", studentEmail = "tn@gmail.com" });
            students.Add(new Models.StudentModel { studentName = "Nikhil", studentSurname = "Sunker", studentNumber = "u24706672", studentEmail = "ns@gmail.com" });
            students.Add(new Models.StudentModel { studentName = "Matthew", studentSurname = "Frohlich", studentNumber = "u24894312", studentEmail = "mf@gmail.com" });
            students.Add(new Models.StudentModel { studentName = "Siyanda", studentSurname = "Twala", studentNumber = "u24765544", studentEmail = "st@gmail.com" });
            students.Add(new Models.StudentModel { studentName = "Aman", studentSurname = "Singh", studentNumber = "u23570823", studentEmail = "as@gmail.com" });

            return View(students);
        }

        public ActionResult Index()
        {

            return View();

        }
       
        [HttpGet]
        public ActionResult addPersonModel()
        {
            return View("addPerson");
        }
        public ActionResult addPersonModel(Models.StudentModel pm)
        {
            students.Add(new Models.StudentModel { studentName = pm.studentName, studentSurname = pm.studentSurname, studentNumber = pm.studentNumber, studentEmail = pm.studentEmail });

            return View("ListStudent",students);   //?????
        }

        [HttpPost]
        public ActionResult SearchStudent(string searchQuery)
        {
            // Find matching students based on the search query
            var matchingStudents = students.Where(s => s.studentName.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||s.studentEmail.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            // Save matching students to ViewBag for highlighting
            ViewBag.MatchingStudents = matchingStudents;

            // Return the updated list with matches highlighted
            return View("ListStudent", students); 
        }
    }
}