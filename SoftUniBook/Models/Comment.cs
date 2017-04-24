using MVCBlog.Models;

namespace Blog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public virtual ApplicationUser Author { get; set; }
        public virtual Post Post { get; set; }
    }
}