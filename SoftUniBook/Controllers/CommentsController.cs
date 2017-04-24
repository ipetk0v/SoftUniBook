using Blog.Models;
using Microsoft.AspNet.Identity;
using MVCBlog.Models;
using SoftUniBook.Models.BindingModels;
using System.Net;
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

        [HttpPost]
        public ActionResult Create(AddComentBm bm)
        {
            if (!this.ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var strCurrentUserId = User.Identity.GetUserId();
            Post post = this.db.Posts.Find(bm.Id);
            Comment comment = new Comment
            {
                Content = bm.Content,
                Author = this.db.Users.Find(strCurrentUserId),
                Post = this.db.Posts.Find(bm.Id)
            };
            post.Comments.Add(comment);
            this.db.Comments.Add(comment);
            this.db.SaveChanges();
            return Redirect($"/posts/details/{post.ID}");
        }
    }
}