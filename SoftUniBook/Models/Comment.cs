using MVCBlog.Models;

namespace Blog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public ApplicationUser Author { get; set; }
        public Post Post { get; set; }
    }
}