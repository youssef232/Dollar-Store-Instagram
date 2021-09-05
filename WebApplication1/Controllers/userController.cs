using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class userController : Controller
    {
        // GET: user
        DollarContext db = new DollarContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult signIn()
        {

            return View();
        }
    }
}