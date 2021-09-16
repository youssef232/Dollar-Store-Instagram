using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        DollarContext db = new DollarContext();
        public ActionResult addPost()
        {
            if (Session["username"] == null) return RedirectToAction("signIn", "user");
            SelectList categoryList = new SelectList(db.categories.ToList(), "categoryName", "categoryName");
            ViewBag.categoryList = categoryList;
            return View();
        }
        [HttpPost]
        public ActionResult addPost(post temp, HttpPostedFileBase img)
        {
            img.SaveAs(Server.MapPath($"~/attach/postsPhoto/{img.FileName}"));
            temp.photo = $"/attach/postsPhoto/{img.FileName}";

            temp.writerUsername = (string)Session["username"];
            temp.date = DateTime.Now;
            db.posts.Add(temp);
            db.SaveChanges();
            return RedirectToAction("myPosts");
        }
        public ActionResult myPosts()
        {
            if (Session["username"] == null) return RedirectToAction("signIn", "User");
            string username = (string)Session["username"];
            List<post> posts = db.posts.Where(n=>n.writerUsername == username).ToList();
            return View(posts);
        }
        public ActionResult allPosts()
        {
            return View(db.posts.ToList());
        }
        public ActionResult details(int postId)
        {
            
            post allDetailsOfThePost = db.posts.Where(n => n.postID == postId).FirstOrDefault();
            return View(allDetailsOfThePost);
        }
        public ActionResult delete(int postId)
        {
            
            post postIdInTheDataBase = db.posts.Where(n=>n.postID == postId).FirstOrDefault();  
            db.posts.Remove(postIdInTheDataBase);
            db.SaveChanges();
            return RedirectToAction("myPosts");
        }
        public ActionResult categories()
        {
            return View(db.categories.ToList());
        }
        public ActionResult specificCategory(string categoryName)
        {
               ViewBag.categoryName = categoryName;
            return View(db.posts.ToList());
        }
        public ActionResult edit(int postId)
        {
            if (Session["username"] == null) return RedirectToAction("signIn", "user");
            SelectList categoryList = new SelectList(db.categories.ToList(), "categoryName", "categoryName");
            ViewBag.categoryList = categoryList;
            post temp = db.posts.Where(n=>n.postID == postId).FirstOrDefault();
            return View(temp);
        }
        [HttpPost]
        public ActionResult edit(post temp, HttpPostedFileBase img)
        {
            img.SaveAs(Server.MapPath($"~/attach/postsPhoto/{img.FileName}"));
            temp.photo = $"/attach/postsPhoto/{img.FileName}";

            temp.writerUsername = (string)Session["username"];
            temp.date = DateTime.Now;
            db.Entry(temp).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("myPosts");
        }
    }
}