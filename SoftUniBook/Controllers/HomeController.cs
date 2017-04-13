using Blog.Models;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using MVCBlog.Models;
using System.Collections.Generic;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db;
        public HomeController()
        {
            this.db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {

            var post = db.Posts.OrderByDescending(p => p.Date).Take(6);
            return View(post.ToList());
        }
        [HttpGet]
        public ActionResult Search(string postName)
        {
            IEnumerable<Post> currentPosts = this.db.Posts.Where(p => p.Title.Contains(postName));
            return this.View(currentPosts);
        }
    }
}