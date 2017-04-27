using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using SoftUniBook.Models;
using Microsoft.AspNet.Identity;
using SoftUniBook.Models.BindingModels;
using System;
using System.Collections.Generic;

namespace SoftUniBook.Controllers
{
    [Authorize]
    public class PostsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var posts = db.Posts.ToList();

            return View(posts);
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }


        // GET: Posts/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddPostBm bm)
        {
            var strCurrentUserId = User.Identity.GetUserId();

            ApplicationUser user = this.db.Users.Find(strCurrentUserId);
            List<Tag> tags = new List<Tag>();
            foreach (var tag in bm.Tags.Split(new[] { ' ',',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                tags.Add(new Tag() { Title = tag });
            }
            var post = new Post
            {
                Author = user,
                Date = DateTime.Now,
                Tags= tags,
                Body = bm.Body,
                Title = bm.Title
            };
            if (ModelState.IsValid)
            {

                db.Posts.Add(post);

                try
                {
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                }
                return RedirectToAction("Index");
            }

            return View(post);
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( Post model)
        {
            if (ModelState.IsValid)
            {
                var post = db.Posts.Find(model.Id);
                post.Title = model.Title;
                post.Body = model.Body;
                db.SaveChanges();
                return RedirectToAction("Details", new { id = post.Id });
            }
            return View(model);
        }
 
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = db.Posts.Find(id);
            foreach (var item in post.Tags)
            {
                item.Post = null;
            }
            db.Posts.Remove(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }



    }
}
