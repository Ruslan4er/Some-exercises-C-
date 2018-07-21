using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AuthWebApp.Models;

namespace AuthWebApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {

            using (var db = new CarServiceDBEntities())
            {
                var a = db.Users.First();
                var ab = db.Users.Include(u => u.UserProfile).First();
                var b = a.UserProfile;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user;


                //using (var db = new UserContext())
                //{
                    
                //    user = db.Users.FirstOrDefault(u => u.Email == model.Name);
                //}
                //if (user == null)
                //{
                //    using (var db = new UserContext())
                //    {
                //        db.Users.Add(new User
                //        {
                //            Email = model.Name,
                //            Password = model.Password,
                //            Age = model.Age
                //        });
                //        db.SaveChanges();

                //        user = db.Users
                //            .FirstOrDefault(u => u.Email == model.Name && u.Password == model.Password && u.Age == model.Age);
                //    }
                //    if (user != null)
                //    {
                //        FormsAuthentication.SetAuthCookie(model.Name, true);
                //        return RedirectToAction("Index", "Home");
                //    }
                //}
                //else
                //{
                //    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
                //}
            }
            return View(model);
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                //User user;
                //using (var db = new UserContext())
                //    user = db.Users
                //            .FirstOrDefault(u => u.Email == model.Name && u.Password == model.Password);
                //if (user != null)
                //{
                //    FormsAuthentication.SetAuthCookie(model.Name, true);
                //    return RedirectToAction("Index", "Home");
                //}
                //else
                //{
                //    ModelState.AddModelError("", "Неверный логин или пароль");
                //}
            }
            return View(model);
        }
    }
}