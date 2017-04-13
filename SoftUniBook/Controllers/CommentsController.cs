using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class CommentsController : Controller
    {
        ApplicationDbContext db;
        public CommentsController()
        {
            this.db = new ApplicationDbContext();
        }
        // GET: Comments
        [HttpPost]
        public ActionResult Create([Bind(Include = "Comment")] Comment comment)
        {
            this.db.Comments.Add(comment);
            this.db.SaveChanges();
            return this.View();
        }
    }
}