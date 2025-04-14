using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tylaStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult ListStudent()
        {
            List<Models.StudentModel> student = new List<Models.StudentModel>();

            student.Add(new Models.StudentModel { studentName = "Tyla", studentSurname = "Naidoo", studentNumber = "u23601711", studentEmail = "u23601711@tuks.co.za", myLink = "~/html/Person1.html" });
            student.Add(new Models.StudentModel { studentName = "Nikhil", studentSurname = "Sunker", studentNumber = "u24706672", studentEmail = "u24706672@tuks.co.za", myLink = "~/html/Person2.html" });
            student.Add(new Models.StudentModel { studentName = "Matthew", studentSurname = "Frohlich", studentNumber = "u24894312", studentEmail = "u24894312@tuks.co.za", myLink = "~/html/Person3.html" });
            student.Add(new Models.StudentModel { studentName = "Siyanda", studentSurname = "Twala", studentNumber = "u24765544", studentEmail = "u24765544@tuks.co.za", myLink = "~/html/Person4.html" });
            student.Add(new Models.StudentModel { studentName = "Aman", studentSurname = "Singh", studentNumber = "u23570823", studentEmail = "u23570823@tuks.co.za", myLink = "~/html/Person5.html" });

            return View(student);
        }

        public ActionResult Index()
        {

            return View();

        }
    }
}