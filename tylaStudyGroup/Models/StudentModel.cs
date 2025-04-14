using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tylaStudyGroup.Models
{
    public class StudentModel
    {
        [Display(Name = "First Name")]
        public string studentName { get; set; }

        [Display(Name = "Last Name")]
        public string studentSurname { get; set; }

        [Display(Name = "Student Number")]
        public string studentNumber { get; set; }

        [Display(Name = "Student Email")]
        public string studentEmail { get; set; }

   

    }
}