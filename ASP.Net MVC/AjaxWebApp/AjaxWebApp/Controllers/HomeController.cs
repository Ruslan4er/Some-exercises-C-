using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxWebApp.Models;

namespace AjaxWebApp.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            ViewBag.Authors = db.Books.Select(s=>s.Author).Distinct();
            return View();
        }

        public JsonResult JsonSearch(string name)
        {
            var jsonData = db.Books.Where(a => a.Author.Contains(name)).ToList();
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        //[HttpPost]
        public ActionResult BookSearch(string name)
        {
            var books = db.Books.Where(p => p.Author.Contains(name)).ToList();
            return PartialView(books);
        }

        public ActionResult BestBook()
        {
            var book = db.Books.First();
            return PartialView(book);
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
    }
}