using Blog.Models;
using MVCBlog.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
namespace Blog.Controllers
{
    public class UsersController : Controller
    {
        private ApplicationDbContext db;
        public UsersController()
        {
            this.db = new ApplicationDbContext();
        }

        public ActionResult Profile()
        {
            var strCurrentUserId = User.Identity.GetUserId();
            IEnumerable<Post> posts = this.db.Posts.Where(p => p.Author.Id == strCurrentUserId);
            return View(posts);
        }
    }
}