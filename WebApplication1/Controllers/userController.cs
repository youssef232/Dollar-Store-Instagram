﻿using System;
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
        public ActionResult register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult register(user newGuy, HttpPostedFileBase img)
        {
            img.SaveAs(Server.MapPath("~/attach/" + img.FileName));
            newGuy.userPhoto = img.FileName;
            
                db.users.Add(newGuy);
                db.SaveChanges();
                return RedirectToAction("signIn");
         
        }
        public ActionResult signIn(user newUser)
        {
            user temp = db.users.Where(n=> n.username == newUser.username && n.password == newUser.password).FirstOrDefault();
            if (temp != null)
            {
                Session.Add("username", temp.username);
                return RedirectToAction("profile");
            }
            
            return View();
        }
        public ActionResult profile()
        {
            if (Session["username"] == null) return RedirectToAction("signIn");
            string username = (string)Session["username"];
            user s = db.users.Where(n => n.username == username).FirstOrDefault();
            return View(s);
        }
        public ActionResult signOut()
        {
            Session["username"] = null;
            return RedirectToAction("signIn");
        }
         public ActionResult edit(string username)
        {
            user tempUser = db.users.Where(n => n.username == username).FirstOrDefault();
            //ViewBag.tempUser = tempUser;
            return View(tempUser);
        }
    }
}