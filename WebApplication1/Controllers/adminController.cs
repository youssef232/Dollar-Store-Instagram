using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{  
    public class adminController : Controller
    {
        DollarContext db = new DollarContext();
        
        public ActionResult dashboard()
        {
            if ((string)Session["username"] != "admin") return RedirectToAction("signIn", "user");
            ViewBag.numberOfUsers = db.users.Count();
            ViewBag.numberOfPosts = db.posts.Count();
            return View(db.categories.ToList());
        }
        public ActionResult usersBrief()
        {
            if ((string)Session["username"] != "admin") return RedirectToAction("signIn","user");
            return View(db.users.ToList());
        }
    }
}