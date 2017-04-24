using MVCBlog.Models;
using System.ComponentModel.DataAnnotations;
namespace Blog.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public Post Post { get; set; }
    }
}