using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManyToMany.Models;

namespace ManyToMany.Controllers
{
    public class NavigationController : Controller
    {
        MobileContext db =new MobileContext();

        // GET: Navigation
        public ActionResult Index(int page=1)
        {
            int pageSize = 3;
            IEnumerable<Phone> phonesPerPages = db.Phones
                .OrderBy(m => m.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize).ToList();

            PageInfo pageInfo = new PageInfo{PageNumber = page,PageSize = pageSize,TotalItems = db.Phones.Count()};
            IndexViewModel ivm = new IndexViewModel{PageInfo = pageInfo,Phones =phonesPerPages};
            return View("Phones",ivm);
        }
    }
}