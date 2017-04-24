using MVCBlog.Models;
using System.Collections.Generic;

namespace Blog.Models
{
    public class Category
    {
        public Category()
        {
            this.Posts = new HashSet<Post>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}