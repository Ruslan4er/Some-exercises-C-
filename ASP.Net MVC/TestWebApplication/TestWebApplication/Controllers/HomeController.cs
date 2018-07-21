using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TestWebApplication.Models;

namespace TestWebApplication.Controllers
{
    public class HomeController : Controller
    {

        BookContext db = new BookContext();

        public ActionResult Index()
        {
            var countries = new[] { "Россия", "Украина", "США" };

            HttpContext.Response.Cookies["id"].Value = "ca-2331w";

            ViewBag.Message = "Частичное представление";
            IEnumerable<Book> books = db.Books.ToList();
            ViewBag.Books = books;
            return View(countries);
        }

        public async Task<ActionResult> BookList()
        {
            IEnumerable<Book> books = await db.Books.ToListAsync();
            ViewBag.Books = books;
            return View("Index");
        }

        public string GetData()
        {
            string id = HttpContext.Request.Cookies["id"].Value;
            return id.ToString();
        }

        [HttpGet]
        public ActionResult GetBook(int id)
        {
            var book = db.Books.Find(id);
            if (book==null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        public string GetContext()
        {
            string browser = HttpContext.Request.Browser.Browser;
            string user_agent = HttpContext.Request.UserAgent;
            string url = HttpContext.Request.RawUrl;
            string ip = HttpContext.Request.UserHostAddress;
            string referrer = HttpContext.Request.UrlReferrer == null ? "" : HttpContext.Request.UrlReferrer.AbsoluteUri;
            return "<p>Browser: " + browser + "</p><p>User-Agent: " + user_agent + "</p><p>Url запроса: " + url +
                   "</p><p>Реферер: " + referrer + "</p><p>IP-адрес: " + ip + "</p>";
        }

        public FileResult GetFile()
        {
            var file_path = Server.MapPath("~/Files/Book.cs");
            var file_type = "application/octet-stream";
            var file_name = "Book.cs";

            return File(file_path, file_type, file_name);
        }

        public ActionResult GetList()
        {
            var states = new[] { "Russia", "USA", "Canada", "France" };
            return PartialView(states);
        }

        public FileResult GetBytes()
        {
            var file_path = Server.MapPath("~/Files/Book.cs");
            byte[] mas = System.IO.File.ReadAllBytes(file_path);
            var file_type = "application/octet-stream";
            var file_name = "Book.cs";

            return File(mas, file_type, file_name);
        }

        public FileResult GetStream()
        {
            var file_path = Server.MapPath("~/Files/Book.cs");
            var fs = new FileStream(file_path, FileMode.Open);
            var file_type = "application/octet-stream";
            var file_name = "Book.cs";

            return File(fs, file_type, file_name);
        }

        [HttpPost]
        public ContentResult PostBook()
        {
            var title = Request.Form["title"];
            var author = Request.Form["author"];
            return Content(title + " " + author);
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            Purchase purchase = new Purchase { BookId = id };

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }


        //public ActionResult Delete(int id)
        //{
        //    try
        //    {
        //        //var book = db.Books.Find(id);
        //        //if (book != null)
        //        //{
        //        //    db.Books.Remove(book);
        //        //}

        //        var book = new Book {Id = id};
        //        db.Entry(book).State = EntityState.Deleted;
        //        db.SaveChanges();

        //        return RedirectToAction("Index");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //}

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var book = db.Books.Find(id);
            if (book == null)
                return HttpNotFound();
            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var book = db.Books.Find(id);
            if (book == null)
                return HttpNotFound();
            db.Books.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return HttpNotFound();
            var book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        [HttpPost]
        public ActionResult Edit(Book book)
        {
            db.Entry(book).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            try
            {
                db.Books.Add(book);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        [HttpGet]
        public ActionResult CreateBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBook(Book book)
        {
            try
            {
                db.Books.Add(book);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}