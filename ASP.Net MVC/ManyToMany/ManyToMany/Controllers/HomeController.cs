using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManyToMany.Models;

namespace ManyToMany.Controllers
{
    public class HomeController : Controller
    {
        private StudentContext db = new StudentContext();

        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        public ActionResult DataDetails()
        {
            var student = db.Students.FirstOrDefault();
            return View(student);
        }

        public ActionResult Edit1()
        {
            LogModel logModel = new LogModel{Login = "asda",Password = "asdasd"};
            return View(logModel);
        }

        public ActionResult Details(int id = 0)
        {
            var student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            var student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            ViewBag.Courses = db.Courses.ToList();
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student, int[] selectedCourses)
        {
            var newStudent = db.Students.Find(student.Id);
            newStudent.Name = student.Name;
            newStudent.SurName = student.SurName;

            newStudent.Courses.Clear();
            if (selectedCourses != null)
            {
                foreach (var c in db.Courses.Where(co => selectedCourses.Contains(co.Id)))
                {
                    newStudent.Courses.Add(c);
                }
            }
            db.Entry(newStudent).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Courses = db.Courses.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student, int[] selectedCourses)
        {
            if (selectedCourses != null)
            {
                foreach (var c in db.Courses.Where(co => selectedCourses.Contains(co.Id)))
                {
                    student.Courses.Add(c);
                }
            }
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Array()
        {
            return View();
        }

        [HttpPost]
        public string Array(List<string> names)
        {
            string fin = "";
            foreach (string t in names)
            {
                fin += t + "; ";
            }
            return fin;
        }

        //[HttpGet]
        //public ActionResult EditBook()
        //{
        //    var books = new List<Book>
        //    {
        //        new Book {Name = "Книга 1", Author = "Автор 1", Price = 2221},
        //        new Book {Name = "Книга 2", Author = "Автор 2", Price = 3121},
        //        new Book {Name = "Книга 3", Author = "Автор 3", Price = 1124}
        //    };
        //    return View(books);
        //}

        //[HttpPost]
        //public string EditBook(List<Book> books)
        //{
        //    return books.Count.ToString();
        //}

        [HttpGet]
        public ActionResult GetAuthor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetAuthor(Author author)
        {
            return View();
        }
    }
}