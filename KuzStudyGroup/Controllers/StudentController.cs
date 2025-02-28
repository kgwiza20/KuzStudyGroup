using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KuzStudyGroup.Models;

namespace KuzStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    StudentNo = "23782537",
                    Name = "Kuzivashe",
                    Surname = "Gwiza",
                    Email = "kuzvashegwiza@gmail.com"

                },
                new Student
                {
                    StudentNo = "22942235",
                    Name = "Nigel",
                    Surname = "Jahwi",
                    Email = "nigeljahwi@gmail.com"

                },
                new Student
                {
                    StudentNo = "21345588",
                    Name = "Simphiwe",
                    Surname = "Ngcobo",
                    Email = "simphiwengcobo@gmail.com"

                },
                new Student
                {
                    StudentNo = "24224476",
                    Name = "Atherston",
                    Surname = "Pambeni",
                    Email = "atherstonpambeni@gmail.com"

                },
                new Student
                {
                    StudentNo = "24222472",
                    Name = "Mikitai",
                    Surname = "Junior",
                    Email = "mikitaijunior@gmail.com"
            },
            };
            return View(students);
        }
    }
}