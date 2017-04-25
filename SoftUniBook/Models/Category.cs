using SoftUniBook.Models;
using System.Collections.Generic;

namespace SoftUniBook.Models
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